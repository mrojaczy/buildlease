﻿using System;
using System.Collections.Generic;
using Domain.Models;

namespace Domain.EntitiesExample
{
    public static class OrderStatusHistoryEntities
    {
        public static List<HistoryOfOrderStatus> Get()
        {
            return new List<HistoryOfOrderStatus>()
            {
                new HistoryOfOrderStatus()
                {
                    Id = -1,
                    OrderId = -4,
                    Date = new DateTime(2020, 9, 20, 18, 22, 15),
                    NewStatus = OrderStatus.WaitingForApproval
                },
                new HistoryOfOrderStatus()
                {
                    Id = -2,
                    OrderId = -4,
                    Date = new DateTime(2020, 9, 25, 14, 14, 16),
                    NewStatus = OrderStatus.Approved
                },
                new HistoryOfOrderStatus()
                {
                    Id = -3,
                    OrderId = -4,
                    Date = new DateTime(2020, 10, 11, 12, 30, 17),
                    NewStatus = OrderStatus.DocumentPending
                },
                new HistoryOfOrderStatus()
                {
                    Id = -4,
                    OrderId = -4,
                    Date = new DateTime(2020, 10, 12, 13, 0, 18),
                    NewStatus = OrderStatus.InProcess
                },
                new HistoryOfOrderStatus()
                {
                    Id = -5,
                    OrderId = -4,
                    Date = new DateTime(2020, 10, 25, 19, 12, 0),
                    NewStatus = OrderStatus.Finished
                },

                new HistoryOfOrderStatus()
                {
                    Id = -6,
                    OrderId = -1,
                    Date = DateTime.UtcNow,
                    NewStatus = OrderStatus.WaitingForApproval,
                },
                new HistoryOfOrderStatus()
                {
                    Id = -7,
                    OrderId = -2,
                    Date = DateTime.UtcNow,
                    NewStatus = OrderStatus.InProcess,
                },
                new HistoryOfOrderStatus()
                {
                    Id = -8,
                    OrderId = -3,
                    Date = DateTime.UtcNow,
                    NewStatus = OrderStatus.DocumentPending,
                },
                new HistoryOfOrderStatus()
                {
                    Id = -9,
                    OrderId = -5,
                    Date = DateTime.UtcNow,
                    NewStatus = OrderStatus.Approved,
                },
                new HistoryOfOrderStatus()
                {
                    Id = -10,
                    OrderId = -7,
                    Date = DateTime.UtcNow,
                    NewStatus = OrderStatus.Finished,
                },
            };
        }
    }
}