using Microsoft.AspNetCore.Mvc;
using RoomManager.Domain.Services.People;
using RoomManager.Domain.TransferObjects;
using System.Collections.Generic;

namespace RoomManager.Web.Controllers
{
    public class PersonController : Controller
    {
        private readonly IPersonService _service;

        public PersonController(IPersonService service)
        {
            _service = service;
        }

        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [ProducesResponseType(415)]
        [ProducesResponseType(500)]
        public IActionResult Create([FromBody] PersonModel model)
        {
            _service.Create(model);
            return Ok();
        }

        [HttpGet]
        [ProducesResponseType(typeof(IList<PersonModel>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [ProducesResponseType(415)]
        [ProducesResponseType(500)]
        public IList<PersonModel> GetAll()
        {
            return _service.GetAll();
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(PersonModel), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [ProducesResponseType(415)]
        [ProducesResponseType(500)]
        public PersonModel GetById([FromRoute] long id)
        {
            return _service.GetById(id);
        }
    }
}
