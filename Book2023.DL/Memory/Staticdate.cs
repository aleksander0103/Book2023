

using Book2023.models;

namespace Book2023.DL.Memory
{
    public static class Staticdate
    {
        public static List<Book> books = new List<Book>()
        {
            new Book()
            {
                Id = 1,
                Title = "Book 1"
            },


            new Book()
            {
                Id = 2,
                Title = "Book 2"
            },
        {
                new Book()
                {
                    Id = 3,
                    Title = "Book 3"
                }
            }



        };

        public static List<Book> Books { get => books; set => books = value; }
        public static object Book { get; internal set; }

        internal static object Add(Book book)
        {
            throw new NotImplementedException();
        }
    }
}