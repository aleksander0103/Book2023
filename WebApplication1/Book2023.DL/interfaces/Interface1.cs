using Book2023.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book2023.DL.interfaces
{
    internal interface IBookRepository
    {
        public void AddBook(Book book);

        public void DeleteBook(int id);

        public void UpdateBook(Book book);

        public Book GetBook(int id);

        public List<Book> getAllBooks ();   

     
    }
}
