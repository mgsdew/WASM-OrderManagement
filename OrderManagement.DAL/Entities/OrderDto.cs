using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderManagement.DAL.Entities
{
    [Table("Order")]
    public class OrderDto
    {
        public OrderDto()
        {
            Windows = new HashSet<WindowDto>();
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int StateId { get; set; }
        public virtual StateDto State { get; set; }
        public virtual ICollection<WindowDto> Windows { get; set; }
    }
}
