
namespace OrderManagement.BLL.Models
{
    public class OrderUpdateResponse
    {
        public string ErrorMessage { get; set; }
        public Order Result { get; set; }
    }

    public class StateUpdateResponse
    {
        public string ErrorMessage { get; set; }
        public State Result { get; set; }
    }


    public class WindowUpdateResponse
    {
        public string ErrorMessage { get; set; }
        public Window Result { get; set; }
    }

    public class ElementUpdateResponse
    {
        public string ErrorMessage { get; set; }
        public Element Result { get; set; }
    }

    public class ElementTypeUpdateResponse
    {
        public string ErrorMessage { get; set; }
        public ElementType Result { get; set; }
    }
}
