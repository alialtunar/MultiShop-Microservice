﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Cargo.BusinessLayer.Abstract;
using MultiShop.Cargo.DtoLayer.Dtos.CargoOperationDtos;
using MultiShop.Cargo.EntityLayer.Concrete;

namespace MultiShop.Cargo.WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CargoOperationsController : ControllerBase
    {
        private readonly ICargoOperationService _CargoOperationService;

        public CargoOperationsController(ICargoOperationService CargoOperationService)
        {
            _CargoOperationService = CargoOperationService;
        }

        [HttpGet]
        public IActionResult CargoOperationList()
        {
            var values = _CargoOperationService.TGetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateCargoOperation(CreateCargoOperationDto createCargoOperationDto)
        {
            CargoOperation CargoOperation = new CargoOperation()
            {
                Barcode = createCargoOperationDto.Barcode,
                Description = createCargoOperationDto.Description,
                OperationDate = createCargoOperationDto.OperationDate,
            };
            _CargoOperationService.TInsert(CargoOperation);
            return Ok("Kargo İşlemi başarıyla oluşturuldu");
        }

        [HttpDelete]
        public IActionResult DeleteCargoOperation(int id)
        {

            _CargoOperationService.TDelete(id);
            return Ok("Kargo işlemi başarıyla silindi");

        }

        [HttpGet("{id}")]
        public IActionResult GetCargoOperationById(int id)
        {
            var values = _CargoOperationService.TGetById(id);
            return Ok(values);
        }

        [HttpPut]
        public IActionResult UpdateCargoOperation(UpdateCargoOperationDto updateCargoOperationDto)
        {
            CargoOperation CargoOperation = new CargoOperation()
            {
                Barcode = updateCargoOperationDto.Barcode,
                OperationDate = updateCargoOperationDto.OperationDate,
                Description = updateCargoOperationDto.Description,
                CargoOperationId = updateCargoOperationDto.CargoOperationId
            };
            _CargoOperationService.TUpdate(CargoOperation);
            return Ok("Kargo işlemi başarıyla güncellendi");
        }
    }
}
