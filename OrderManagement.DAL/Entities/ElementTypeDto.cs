using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderManagement.DAL.Entities
{
    [Table("ElementType")]
    public class ElementTypeDto
    {
        public ElementTypeDto()
        {
            Elements = new HashSet<ElementDto>();
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ElementDto> Elements { get; set; }
    }
}
