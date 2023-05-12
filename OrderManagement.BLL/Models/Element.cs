﻿namespace OrderManagement.BLL.Models
{
    public class Element
    {
        public int Id { get; set; }
        public int WindowId { get; set; }
        public int ElementTypeId { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public ElementType ElementType { get; set; }
        public Window Window { get; set; }
    }
}
