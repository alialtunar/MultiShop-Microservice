using MultiShop.Order.Application.Feautures.CQRS.Results.AdressResults;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Feautures.CQRS.Handlers.AdressHandlers
{
    public class GetAddressQueryHandler
    {
        private readonly IRepository<Address> _repsitory;

        public GetAddressQueryHandler(IRepository<Address> repsitory)
        {
            _repsitory = repsitory;
        }

        public async Task<List<GetAdressQueryResult>> Handle()
        {
            var values = await _repsitory.GetAllAsync();
            return values.Select(x => new GetAdressQueryResult
            {
                AddressId = x.AddressId,
                City = x.City,
                Detail = x.Detail,
                District = x.District,
                UserId = x.UserId,
            }).ToList(); 
        }
    }
}
