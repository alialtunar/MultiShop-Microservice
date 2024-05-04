﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Feautures.Mediator.Commands.OrderingCommands
{
    public class CreateOrderingCommand:IRequest
    {

        public string UserId { get; set; }

        public decimal TotalPrice { get; set; }

        public DateTime OrderDate { get; set; }
    }
}
