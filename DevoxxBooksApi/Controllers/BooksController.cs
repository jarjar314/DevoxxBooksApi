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
             List<BookModel> books = new List<BookModel>();
            using (var context = new BookDataContext()){
                foreach(var book in context.Books){
                    books.Add(book);
                }
            }
            return books;
        }

        [HttpGet]
        public  BookModel Get(int bookId)
        {
            BookModel book = new BookModel();
            using (var context = new BookDataContext()){
                book = context.Books.FirstOrDefault(o => o.BookId == bookId);
            }
            return book;
        }

        [HttpPost]
        public string Create(BookModel book)
        {
            try{

                using(var context = new BookDataContext()){
                   context.Books.Add(book);
                   context.SaveChanges();
                  
                }
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
                using(var context = new BookDataContext()){
                    BookModel book = context.Books.FirstOrDefault(o => o.BookId == bookId);
                    context.Books.Remove(book);
                    context.SaveChanges();
                }
                return "OK";
            }
            catch(Exception ex){
                return string.Format("erreur {0}", ex.Message);   
            }
        }
    }
}