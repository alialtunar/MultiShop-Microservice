﻿using MultiShop.Order.Application.Feautures.CQRS.Results.OrderDetailResults;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Feautures.CQRS.Handlers.OrderDetailHandlers
{
    public class GetOrderDetailQueryHandler
    {
        private readonly IRepository<OrderDetail> _repository;

        public GetOrderDetailQueryHandler(IRepository<OrderDetail> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetOrderDetailQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetOrderDetailQueryResult
            {
                OrderDetailId = x.OrderDetailId,
                OrderingId = x.OrderingId,
                PoructPrice = x.PoructPrice,
                ProductAmount = x.ProductAmount,
                ProductName = x.ProductName,
                ProductTotalPrice = x.ProductTotalPrice,
                ProductId = x.ProductId,
            }).ToList();
        }
    }
}
