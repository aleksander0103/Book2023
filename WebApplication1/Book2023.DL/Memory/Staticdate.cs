using Book2023.models.Models;

namespace Book2023.DL.Memory
{
    public static class Staticdate
    {
        public static List<Book> Books = new List<Book>()
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

        public static List<Author> Authors = new List<Author>()
        {
            new Author()
            {
                Id = 1,
                Title = "Author 1"
            },


            new Author()
            {
                Id = 2,
                Title = "Author 2"
            },
        {
                new Author()
                {
                    Id = 3,
                    Title = "Author 3"
                }
            }



        };
        internal static object author;

        public static object Author { get; internal set; }

        internal static object Add(Author author)
        {
            throw new NotImplementedException();
        }

        internal static object Add(object author)
        {
            throw new NotImplementedException();
        }
    }
}