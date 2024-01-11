using Book2023.BL.Interfaces;
using Book2023.DL.interfaces;
using Book2023.models.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1;

namespace Book2023.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookservice _bookservice;
        public BookController(IBookservice bookservice)
        {
            _bookservice = bookservice;
        }
        [HttpGet("GetAll")]
        public Book Get(int id)
        {
            return _bookservice.GetBook(id);

        }
        [HttpGet("GetById")]
        public Book GetById(int id)
        {
            return _bookservice.GetById(id);
        }
        [HttpDelete("Add")]
        public void Add([FromBody] Book book) { _bookservice.AddBook(book);
        }
        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _bookservice.Remove(id);
        }

        

    }
}
