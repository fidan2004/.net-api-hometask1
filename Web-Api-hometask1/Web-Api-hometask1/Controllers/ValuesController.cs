using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Web_Api_hometask1.Model;

namespace Web_Api_hometask1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public static List<Book> _books = new List<Book>();

        [HttpGet("book/get")]
        public List<Book> GetAll()
        {

            return _books;
        }

        [HttpGet("book/get{id}")]
        public IActionResult Get(int id)
        {
            Book book = _books.FirstOrDefault(m => m.Id == id);
            if (book != null)
                return Ok(book);
            else
                return NotFound();
        }

        [HttpPost("book/create")]
        public IActionResult Create(Book book)
        {
            if (book.Id != null)
            {
                _books.Add(book);
                return Ok(book);
            }
            else
                return NotFound();
        }

        [HttpPut]
        public IActionResult Update(int id, string bookName, decimal price, string category, string author)
        {
            var updated = _books.FirstOrDefault(x => x.Id == id);
            if (updated.Id != null)
            {
                _books.Remove(updated);
                updated.BookName = bookName;
                updated.Price = price;
                updated.Category = category;
                updated.Author = author;

                _books.Add(updated);
                return Ok(updated);
            }
            else
                return NotFound();

        }
        [HttpDelete]
        public void Remove(int id)
        {
            Book book = _books.FirstOrDefault(x => x.Id == id);
            _books.Remove(book);    
            
        }

  }
}
