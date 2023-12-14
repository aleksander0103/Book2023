using Book2023.models;

namespace Book2023.DL.interfaces
{
    public interface IBookRepository
    {
        public void AddBook(Book book);

        public void DeleteBook(int id);

        public void UpdateBook(Book book);

        public Book GetBook(int id);

        public List<Book> getAllBooks ();   

     
    }
}
