

using Book2023.DL.Memory;
using Book2023.models;
using System.Linq;

namespace Book2023.DL.Repository
{
    internal interface BookRepository : interfaces.IBookRepository
    {
        object StaticData { get; }
        int id { get; }

        public void AddBook(Book book)
        {
            object value = Staticdate.Add(book);
        }

        public void DeleteBook(int id)
        {
            var book =
                Staticdate.Books
                .FirstOrDefault(b => b.Id == id);
            if (book == null) return;
            Staticdate.books.Remove(book);

        }
        public void UpdateBook(Book book)
        {
            var existingBook =
                Staticdate.books
                .FirstOrDefault(b => b.Id == id);
            if (existingBook == null) return;
            existingBook.Title = book.Title;
        }
        public Book? GetBook(int id)
        {
            return
                Staticdate.Books
                .FirstOrDefault(b => b.Id == id);

        }
        public List<Book> GetAllBooks()
        {
            throw new NotImplementedException();

        }
}
}
