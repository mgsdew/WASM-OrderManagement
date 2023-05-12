using OrderManagement.BLL.Models;

namespace OrderManagement.BLL.Services
{
    public interface IElementTypeService
    {
        Task<IEnumerable<ElementType>> GetElementTypes();
        Task <ElementType> GetElementTypeById(int id);
        Task <ElementTypeUpdateResponse> Create(ElementType model);
        Task<bool> Update(int id, ElementType model);
    }
}
