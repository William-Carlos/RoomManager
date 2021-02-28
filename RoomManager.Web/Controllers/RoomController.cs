using Microsoft.AspNetCore.Mvc;
using RoomManager.Domain.Services.Rooms;
using RoomManager.Domain.TransferObjects;
using System.Collections.Generic;

namespace RoomManager.Web.Controllers
{
    public class RoomController : Controller
    {
        private readonly IRoomService _service;

        public RoomController(IRoomService service)
        {
            _service = service;
        }

        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [ProducesResponseType(415)]
        [ProducesResponseType(500)]
        public IActionResult Create([FromBody] RoomModel model)
        {
            _service.Create(model);
            return Ok();
        }

        [HttpGet]
        [ProducesResponseType(typeof(IList<RoomModel>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [ProducesResponseType(415)]
        [ProducesResponseType(500)]
        public IList<RoomModel> GetAll()
        {
            return _service.GetAll();
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(RoomModel), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [ProducesResponseType(415)]
        [ProducesResponseType(500)]
        public RoomModel GetById([FromRoute] long id)
        {
            return _service.GetById(id);
        }
    }
}
