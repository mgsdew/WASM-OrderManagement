using AutoMapper;
using OrderManagement.BLL.Models;
using OrderManagement.DAL.Data;
using OrderManagement.DAL.Entities;

namespace OrderManagement.BLL.Services
{
    public class StateService : IStateService
    {
        private readonly IRepository<StateDto> _stateRepository;
        private IMapper _mapper;

        public StateService(IRepository<StateDto> stateRepository, IMapper mapper)
        {
            _stateRepository = stateRepository;
            _mapper = mapper;
        }

        public async Task<State> GetStateById(int id)
        {
            var response = new State();

            var data = await _stateRepository.GetByIdAsync(id);
            response = _mapper.Map<StateDto, State>(data);

            return response;
        }

        public async Task<IEnumerable<State>> GetStates()
        {
            var data = await _stateRepository.GetAllAsync();
            IEnumerable<State> response = _mapper.Map<IEnumerable<StateDto>, IEnumerable<State>>(data);

            return response;
        }

        public async Task<StateUpdateResponse> Create(State model)
        {
            var response = new StateUpdateResponse();
            var savedModel = new StateDto();

            StateDto dto = _mapper.Map<State, StateDto>(model);

            if (dto != null)
            {
                savedModel = await _stateRepository.CreateAsync(dto);

                //Save Dto
                if (savedModel == null)
                {
                    response.ErrorMessage = "State failed to create.";
                }
            }
            else
            {
                response.ErrorMessage = "Error mapping State to data object";
            }

            //return State, if create is successful.
            if (response.ErrorMessage == null)
            {
                response.Result = _mapper.Map<StateDto, State>(savedModel); ;
            }
            return response;
        }

        public async Task<bool> Update(int id, State model)
        {
            var data = await _stateRepository.GetByIdAsync(id);
            if (data != null)
            {
                data.Name = model.Name;
                await _stateRepository.UpdateAsync(data);
                return true;
            }
            else
                return false;
        }
    }
}
