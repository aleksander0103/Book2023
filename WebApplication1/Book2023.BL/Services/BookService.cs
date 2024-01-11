using Book2023.BL.Interfaces;
using Book2023.DL.interfaces;
using Book2023.models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book2023.BL.Services
{
    public class BookService : IBookservice
    {
        private readonly IBookRepository bookRepository1;
        public void AddBook(Book book)
        {
            throw new NotImplementedException();
        }

        public void DeleteBook(int id)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAllBooks()
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAllByAuthorAfterReleaseDate(int authorID, DateTime dateAfter)
        {
            throw new NotImplementedException();
        }

        public Book GetBook(int id)
        {
            throw new NotImplementedException();
        }

        public Book GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateBook(Book book)
        {
            throw new NotImplementedException();
        }
    }

    internal record struct NewStruct(IBookRepository bookRepository, object Item2)
    {
        public static implicit operator (IBookRepository bookRepository, object)(NewStruct value)
        {
            return (value.bookRepository, value.Item2);
        }

        public static implicit operator NewStruct((IBookRepository bookRepository, object) value)
        {
            return new NewStruct(value.bookRepository, value.Item2);
        }
    }
}
