using Book2023.models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreBL.Interfaces
{
    public interface IAuthorService
    {
        public void Add(Author author);

        public void Delete(int id);

        public void Update(Author author);

        public Author? GetByID(int id);

        public List<Author> GetAll();
    }
}