using MultiShop.Order.Application.Feautures.CQRS.Commands.AddressCommands;
using MultiShop.Order.Application.Feautures.CQRS.Commands.OrderDetailCommands;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Feautures.CQRS.Handlers.OrderDetailHandlers
{
    public class UpdateOrderDetailCommandHandler
    {
        private readonly IRepository<OrderDetail> _repsitory;

        public UpdateOrderDetailCommandHandler(IRepository<OrderDetail> repsitory)
        {
            _repsitory = repsitory;
        }

        public async Task Handle(UpdateOrderDetailCommand command)
        {
            var values = await _repsitory.GetByIdAsync(command.OrderDetailId);

            values.OrderDetailId = command.OrderDetailId;
            values.OrderingId = command.OrderingId;
            values.ProductId  = command.ProductId;
            values.ProductName = command.ProductName;
            values.ProductPrice = command.ProductPrice;
            values.ProductTotalPrice = command.ProductTotalPrice;
            values.ProductAmount = command.ProductAmount;

            await _repsitory.UpdateAsync(values);

        }
    }
}
