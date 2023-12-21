using Book2023.DL.interfaces;
using Book2023.DL.Memory;
using Book2023.models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book2023.DL.Repository
{
    internal class AuthorRepository : IAuthorRepository
    {
        private Author author;
        private object existingAuthor;

        object StaticData { get; }
        int id { get; }

        public void AddAuthor(Author Author)
        {
            Staticdate.Add(author);
        }

        public void DeleteAuthor(int id)
        {
            

        }
        public void UpdateAuthor(Author author)
        {
            var existingBook =
                Staticdate.Authors
                .FirstOrDefault(b => b.Id == id);
            if (existingAuthor == null) return;
            existingBook.Title = author.Title;
        }
        public Author? GetAuthor(int id)
        {
            return
                Staticdate.Authors
                .FirstOrDefault(b => b.Id == id);

        }
        public List<Author> GetAllAuthors()
        {
            throw new NotImplementedException();
        }

        public void UpdateAuthor(IAuthorRepository author)
        {
            throw new NotImplementedException();
        }

        Author IAuthorRepository.GetAuthor(int id)
        {
            throw new NotImplementedException();
        }

        public List<Author> getAllAuthor()
        {
            throw new NotImplementedException();
        }

        public Author GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public List<Author> getAllAuthors()
        {
            throw new NotImplementedException();
        }
    }
}
