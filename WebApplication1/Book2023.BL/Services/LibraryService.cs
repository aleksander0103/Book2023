using Book2023.BL.Interfaces;
using Book2023.BL.Services;
using BookStoreBL.Interfaces;
using BookStoreModels.Requests;
using BookStoreModels.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreBL.Services
{
    public class LibraryService : ILibraryService
    {
        private readonly IAuthorService _authorService;
        private readonly IBookservice _bookService;
        public LibraryService(IAuthorService authorService, BookService bookService)
        {
            _bookService = bookService;
            _authorService = authorService;
        }
        public GetAllBooksByAuthorResponse GetGetAllBooksByAuthorAfterReleaseDate(GetAllBooksByAuthorRequest request)
        {
            return new GetAllBooksByAuthorResponse
            {
                Author = _authorService.GetByID(request.AuthorID),
                Books = _bookService.GetAllByAuthorAfterReleaseDate(request.AuthorID, request.DateAfter)
            };
        }
    }
}
