﻿namespace CW_13.Entityes
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int? SupplierId { get; set; }
        public Supplier Supplier{ get; set; }
        public int? CategoryId { get; set; }
        public Category category { get; set; }
        public string? QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? UnitsInStock { get; set; }
        public int? UnitOnOrder { get; set; }
        public int? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
        public List<Order_Detail> order_Details { get; set; }





    }
}
