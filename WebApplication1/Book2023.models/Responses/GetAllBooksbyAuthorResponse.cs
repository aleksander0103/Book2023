using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book2023.models.Models;


namespace BookStoreModels.Responses
{
    public class GetAllBooksByAuthorResponse
    {
        public Author Author { get; set; }

        public List<Book> Books { get; set; }
    }
}
