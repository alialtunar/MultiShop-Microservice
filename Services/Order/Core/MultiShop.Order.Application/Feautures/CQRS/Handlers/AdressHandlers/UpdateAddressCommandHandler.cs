using MultiShop.Order.Application.Feautures.CQRS.Commands.AddressCommands;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Feautures.CQRS.Handlers.AdressHandlers
{
    public class UpdateAddressCommandHandler
    {
        private readonly IRepository<Address> _repsitory;

        public UpdateAddressCommandHandler(IRepository<Address> repsitory)
        {
            _repsitory = repsitory;
        }

        public async Task Handle(UpdateAdressCommand command)
        {
          var values =  await _repsitory.GetByIdAsync(command.AddressId);
          values.Detail = command.Detail;
          values.District = command.District;
            values.Detail = command.Detail;
            values.City = command.City;
            await _repsitory.UpdateAsync(values);
        }
    }
}
