﻿namespace Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public int TotalCount { get; set; }
        public decimal? Price { get; set; }

        public Category Category { get; set; }
        public ProductAttribute ProductAttribute { get; set; }
    }
}
