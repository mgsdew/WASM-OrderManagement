using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderManagement.DAL.Entities
{
    [Table("Window")]
    public class WindowDto
    {
        public WindowDto()
        {
            Elements = new HashSet<ElementDto>();
        }

        [Key]
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string Name { get; set; }
        public int QuantityOfWindows { get; set; }
        public int TotalSubElements { get; set; }
        public virtual ICollection<ElementDto> Elements { get; set; }
        public virtual OrderDto Order  { get; set; }
    }
}
