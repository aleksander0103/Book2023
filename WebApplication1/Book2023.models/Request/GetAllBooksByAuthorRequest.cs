using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreModels.Requests
{
    public class GetAllBooksByAuthorRequest
    {
        public int AuthorID { get; set; }

        public DateTime DateAfter { get; set; }
    }
}