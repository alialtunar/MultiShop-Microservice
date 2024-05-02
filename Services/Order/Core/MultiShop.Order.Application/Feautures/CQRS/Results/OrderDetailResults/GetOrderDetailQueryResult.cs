﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Feautures.CQRS.Results.OrderDetailResults
{
    public class GetOrderDetailQueryResult
    {
        public int OrderDetailId { get; set; }

        public string ProductId { get; set; }

        public string ProductName { get; set; }

        public decimal PoructPrice { get; set; }
        public int ProductAmount { get; set; }
        public decimal ProductTotalPrice { get; set; }

        public int OrderingId { get; set; }
    }
}
