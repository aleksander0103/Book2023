using Book2023.BL.Interfaces;
using Book2023.DL.interfaces;
using Book2023.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Book2023.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AuthorController : ControllerBase
    {
        private readonly IAuthorRepository _authorRepository;
        public AuthorController(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }
        [HttpGet("GetAll")]
        public Author Get(int id)
        {
            return _authorRepository.GetAuthor(id);

        }
        [HttpGet("GetById")]
        public Author GetById(int id)
        {
            return _authorRepository.GetById(id);
        }
        [HttpDelete("Add")]
        public void Add([FromBody] Author author)
        {
            _authorRepository.AddAuthor(author);
        }
        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _authorRepository.Remove(id);
        }

        public void AddAuthor(Author author)
        {
            throw new NotImplementedException();
        }

        public void DeleteAuthor(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateAuthor(IAuthorRepository author)
        {
            throw new NotImplementedException();
        }

        public Author GetAuthor(int id)
        {
            throw new NotImplementedException();
        }

        public List<Author> getAllAuthor()
        {
            throw new NotImplementedException();
        }
    }
}
