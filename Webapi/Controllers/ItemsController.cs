using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using Webapi.Entities;
using Webapi.Repositories;

namespace Webapi.Controllers
{
    [ApiController]
    [Route("items")]
    public class  ItemsController : ControllerBase
    {
        private readonly IInMemItemsRepository repo;

        public ItemsController(IInMemItemsRepository _repo)
        {
            repo = _repo;
        }

        [HttpGet]
        public IEnumerable<Item> GetItem()
        {
            return repo.GetItems();
        }
        [HttpGet("{id}")]
        public ActionResult<Item> GetItem(Guid id)
        {
             Item  item = repo.GetItem(id);
            if (item == null) return NotFound();
                return repo.GetItem(id);
        }
    }
}
