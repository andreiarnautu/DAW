using Microsoft.AspNetCore.Mvc;
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
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorManager manager;

        public AuthorController(IAuthorManager manager)
        {
            this.manager = manager;
        }


        [HttpGet]
        public async Task<IActionResult> GetAuthors()
        {
            var addresses = manager.GetAuthors().ToList();
            return Ok(addresses);
        }

        [HttpPost]
        public async Task<IActionResult> AddAuthors(AuthorModel author)
        {
            manager.Create(author);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAddress(int id)
        {
            manager.Delete(id);
            return Ok();
        }

        [HttpPut("")]
        public async Task<IActionResult> PutAuthor(AuthorModel author)
        {
            manager.Update(author);
            return Ok();
        }
    }
}
