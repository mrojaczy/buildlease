﻿namespace Contracts.DTOs
{
    public class ProductInfo
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string ImageLink { get; set; }
        public int TotalCount { get; set; }
        public decimal? Price { get; set; }
        public ProductAttributeInfo[] Attributes { get; set; }
        public ProductDescriptionInfo[] Descriptions { get; set; }
    }
}
