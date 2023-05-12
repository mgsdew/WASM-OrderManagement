namespace OrderManagement.BLL.Models
{
    public class Window
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string Name { get; set; }
        public int QuantityOfWindows { get; set; }
        public int TotalSubElements { get; set; }
        public Order Order { get; set; }
        public List<Element> Elements { get; set; }
    }
}