using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Order.Application.Feautures.CQRS.Commands.AddressCommands;
using MultiShop.Order.Application.Feautures.CQRS.Handlers.AdressHandlers;
using MultiShop.Order.Application.Feautures.CQRS.Queries.AdressQueries;

namespace MultiShop.Order.WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AdressesController : ControllerBase
    {
        private readonly GetAddressQueryHandler _getAddressQueryHandler;
        private readonly GetAdressByIdQueryHandler _getAdressByIdQueryHandler;
        private readonly CreateAddressCommandHandler _createAddressCommandHandler;
        private readonly UpdateAddressCommandHandler _updateAddressCommandHandler;
        private readonly RemoveAddressCommandHandler _removeAddressCommandHandler;

        public AdressesController(GetAddressQueryHandler getAddressQueryHandler, GetAdressByIdQueryHandler getAdressByIdQueryHandler, RemoveAddressCommandHandler removeAddressCommandHandler, UpdateAddressCommandHandler updateAddressCommandHandler, CreateAddressCommandHandler createAddressCommandHandler)
        {
            _getAddressQueryHandler = getAddressQueryHandler;
            _getAdressByIdQueryHandler = getAdressByIdQueryHandler;
            _removeAddressCommandHandler = removeAddressCommandHandler;
            _updateAddressCommandHandler = updateAddressCommandHandler;
            _createAddressCommandHandler = createAddressCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> AddressList()
        {
            var values = await _getAddressQueryHandler.Handle();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAdressById(int id)
        {
            var values = await _getAdressByIdQueryHandler.Handle(new GetAdressByIdQuery(id));
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAddress(CreateAddressCommand command)
        {
            await _createAddressCommandHandler.Handle(command);
            return Ok("Adres bilgisi başarıyla eklendi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAddress(UpdateAdressCommand command)
        {
            await _updateAddressCommandHandler.Handle(command);
            return Ok("Adres bilgisi başarıyla güncellendi");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveAddress(int id)
        {
            await _removeAddressCommandHandler.Handle(new RemoveAddressCommand(id));
            return Ok("Adres başarıyla temizlendi");  
        }
    }
}
