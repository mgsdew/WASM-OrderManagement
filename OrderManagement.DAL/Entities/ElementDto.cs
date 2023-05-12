using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderManagement.DAL.Entities
{
    [Table("Element")]
    public class ElementDto
    {
        [Key]
        public int Id { get; set; }
        public int WindowId { get; set; }
        public int ElementTypeId { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public virtual ElementTypeDto ElementType { get; set; }
        public virtual WindowDto Window { get; set; }
    }
}
