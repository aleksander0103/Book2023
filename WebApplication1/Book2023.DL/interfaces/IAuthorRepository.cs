using Book2023.models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book2023.DL.interfaces
{
    public interface IAuthorRepository
    {
        public void AddAuthor(Author author);

        public void DeleteAuthor(int id);

        public void UpdateAuthor(Author author);

        public Author GetAuthor(int id);

        public List<Author> getAllAuthors();
        void Remove(int id);
        Author GetById(int id);
    }
}
