﻿using System;

namespace Domain.Models
{
    public class HistoryOfOrderStatus
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public OrderStatus NewStatus { get; set; }

        public Order Order { get; set; }
    }
}
