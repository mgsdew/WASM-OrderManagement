using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderManagement.DAL.Entities
{
    [Table("State")]
    public class StateDto
    {
        public StateDto()
        {
            Orders = new HashSet<OrderDto>();
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<OrderDto> Orders { get; set; }
    }
}
