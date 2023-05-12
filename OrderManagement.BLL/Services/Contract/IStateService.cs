using OrderManagement.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.BLL.Services
{
    public interface IStateService
    {
        Task<IEnumerable<State>> GetStates();
        Task<State> GetStateById(int id);
        Task<StateUpdateResponse> Create(State model);
        Task<bool> Update(int id, State model);
    }
}
