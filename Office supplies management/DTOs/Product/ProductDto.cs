﻿namespace Office_supplies_management.DTOs.Product
{
    public class ProductRequestDto
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string UnitCurrency { get; set; }
        public string UnitPrice { get; set; }
    }
}
