using AutoMapper;
using OrderManagement.BLL.Models;
using OrderManagement.DAL.Data;
using OrderManagement.DAL.Entities;

namespace OrderManagement.BLL.Services
{
    public class ElementTypeService : IElementTypeService
    {
        private readonly IRepository<ElementTypeDto> _eTypeRepository;
        private IMapper _mapper;

        public ElementTypeService(IRepository<ElementTypeDto> eTypeRepository, IMapper mapper)
        {
            _eTypeRepository = eTypeRepository;
            _mapper = mapper;
        }

        public async Task<ElementType> GetElementTypeById(int id)
        {
            ElementType response = default;

            var data = await _eTypeRepository.GetByIdAsync(id);
            response = _mapper.Map<ElementTypeDto, ElementType>(data);

            return response;
        }

        public async Task<IEnumerable<ElementType>> GetElementTypes()
        {
            var data = await _eTypeRepository.GetAllAsync();
            IEnumerable<ElementType> response = _mapper.Map<IEnumerable<ElementTypeDto>, IEnumerable<ElementType>>(data);

            return response;
        }

        public async Task<ElementTypeUpdateResponse> Create(ElementType model)
        {
            var response = new ElementTypeUpdateResponse();
            var savedModel = new ElementTypeDto();

            ElementTypeDto dto = _mapper.Map<ElementType, ElementTypeDto>(model);

            if (dto != null)
            {
                savedModel = await _eTypeRepository.CreateAsync(dto);

                //Save Dto
                if (savedModel == null)
                {
                    response.ErrorMessage = "ElementType failed to create.";
                }
            }
            else
            {
                response.ErrorMessage = "Error mapping ElementType to data object";
            }

            //return ElementType, if create is successful.
            if (response.ErrorMessage == null)
            {
                response.Result = _mapper.Map<ElementTypeDto, ElementType>(savedModel); ;
            }
            return response;
        }

        public async Task<bool> Update(int id, ElementType model)
        {
            var data = await _eTypeRepository.GetByIdAsync(id);
            if (data != null)
            {
                data.Name = model.Name;
                await _eTypeRepository.UpdateAsync(data);
                return true;
            }
            else
                return false;
        }
    }
}
