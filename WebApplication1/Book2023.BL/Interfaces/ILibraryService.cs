using BookStoreModels.Requests;
using BookStoreModels.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreBL.Interfaces
{
    public interface ILibraryService
    {
        public GetAllBooksByAuthorResponse GetGetAllBooksByAuthorAfterReleaseDate(GetAllBooksByAuthorRequest request);
    }
}