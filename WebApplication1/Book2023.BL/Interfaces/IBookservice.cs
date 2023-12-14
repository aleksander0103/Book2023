using Book2023.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book2023.BL.Interfaces
{
    public interface IBookservice
    {
        public void AddBook(Book book);

        public void DeleteBook(int id);

        public void UpdateBook(Book book);

        public Book GetBook(int id);

        public List<Book> GetAllBooks();
        Book GetById(int id);
        void Remove(int id);
    }
}

    
 
