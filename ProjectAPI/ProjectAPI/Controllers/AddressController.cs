using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectAPI.Entities;
using ProjectAPI.Managers;
using ProjectAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressManager manager;

        public AddressController(IAddressManager manager)
        {
            this.manager = manager;
        }


        [HttpGet]
        public async Task<IActionResult> GetAddresses()
        {
            var addresses = manager.GetAddresses().ToList();
            return Ok(addresses);
        }

        [HttpPost]
        public async Task<IActionResult> AddBooks(AddressModel address)
        {
            manager.Create(address);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAddress(int id)
        {
            manager.Delete(id);
            return Ok();
        }

        [HttpPut("")]
        public async Task<IActionResult> PutAddress(AddressModel address)
        {
            manager.Update(address);
            return Ok();
        }


    }
}
