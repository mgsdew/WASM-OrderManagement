using System.ComponentModel.DataAnnotations;

namespace OrderManagement.BLL.Models
{
    public class ElementType
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}