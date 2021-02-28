using Microsoft.AspNetCore.Mvc;
using RoomManager.Domain.Services.CoffeeSpaces;
using RoomManager.Domain.TransferObjects;
using System.Collections.Generic;

namespace RoomManager.Web.Controllers
{
    public class CoffeeSpaceController : Controller
    {
        private readonly ICoffeeSpaceService _service;

        public CoffeeSpaceController(ICoffeeSpaceService service) 
        {
            _service = service;
        }

        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [ProducesResponseType(415)]
        [ProducesResponseType(500)]
        public IActionResult Create([FromBody] CoffeeSpaceModel model)
        {
            _service.Create(model);
            return Ok();
        }

        [HttpGet]
        [ProducesResponseType(typeof(IList<CoffeeSpaceModel>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [ProducesResponseType(415)]
        [ProducesResponseType(500)]
        public IList<CoffeeSpaceModel> GetAll()
        {
            return _service.GetAll();
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(CoffeeSpaceModel), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [ProducesResponseType(415)]
        [ProducesResponseType(500)]
        public CoffeeSpaceModel GetById([FromRoute] long id)
        {
            return _service.GetById(id);
        }
    }
}
