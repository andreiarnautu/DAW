using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
    public class BookController : ControllerBase
    {
        private IBookManager manager;

        public BookController(IBookManager manager)
        {
            this.manager = manager;
        }

        [HttpGet]
        public async Task<IActionResult> GetBooks()
        {
            var books = manager.GetBooks().ToList();
            return Ok(books);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBook([FromRoute] int id)
        {
            var book = manager.GetBookById(id);
            return Ok(book);
        }

        [HttpPost]
        public async Task<IActionResult> AddBooks(BookModel book)
        {
            manager.Create(book);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            manager.Delete(id);
            return Ok();
        }
        
        [HttpPut]
        public async Task<IActionResult> PutBook(BookModel book)
        {
            manager.Update(book);
            return Ok();
        }


    }
}
