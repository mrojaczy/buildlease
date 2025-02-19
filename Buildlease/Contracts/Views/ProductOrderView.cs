﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contracts.Views
{
    public class ProductOrderView
    {
        public int ProductOrderId { get; set; }
        public int? ProductId { get; set; }
        public string Name { get; set; }
        public ProductAttributeView[] Attributes { get; set; }
        public string ImagePath { get; set; }
        public int Count { get; set; }
        public decimal? Price { get; set; }
        public CategoryView[] CategoryPath { get; set; }
    }
}
