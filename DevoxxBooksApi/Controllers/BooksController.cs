using System;
using System.Collections.Generic;
using System.Linq;
using DevoxxBooksApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevoxxBooksApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BooksController : Controller
    {


        [HttpGet]
        public IEnumerable<BookModel> GetAll()
        {
            return BookDataContext.Books;
        }

        [HttpGet]
        public  BookModel Get(int bookId)
        {
            return BookDataContext.Books.FirstOrDefault(o => o.BookId == bookId);
        }

        [HttpPost]
        public string Create(BookModel book)
        {
            try{
                BookDataContext.Books.Add(book);
                return "OK";
            }
            catch(Exception ex){
                return string.Format("erreur {0}", ex.Message);   
            }
        }

        [HttpDelete]
        public string Delete(int bookId)
        {
            try{
                BookDataContext.Books.RemoveAll(o => o.BookId == bookId);
                return "OK";
            }
            catch(Exception ex){
                return string.Format("erreur {0}", ex.Message);   
            }
        }
    }
}