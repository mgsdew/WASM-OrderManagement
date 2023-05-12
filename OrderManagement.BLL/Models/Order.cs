using System.ComponentModel.DataAnnotations;

namespace OrderManagement.BLL.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public int StateId { get; set; }
        public string StateName { get; set; }
    }
}
