using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevoxxBooksApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DevoxxBooksApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BooksController : Controller
    {
        [HttpGet]
        public async Task<IEnumerable<BookModel>> GetAll()
        {
            List<BookModel> books = new List<BookModel>();
            using (var context = new BookDataContext()){
                books = await context.Books.ToListAsync();
            }
            return books;
        }

        [HttpGet]
        public async  Task<BookModel> Get(int bookId)
        {
            BookModel book = new BookModel();
            using (var context = new BookDataContext()){
                book = await context.Books.FirstOrDefaultAsync(o => o.BookId == bookId);
            }
            return book;
        }

        [HttpPost]
        public async Task<string> Create(BookModel book)
        {
            try{

                using(var context = new BookDataContext()){
                   await context.Books.AddAsync(book);
                   await context.SaveChangesAsync();
                  
                }
                return "OK";
            }
            catch(Exception ex){
                return string.Format("erreur {0}", ex.Message);   
            }
        }

        [HttpDelete]
        public async Task<string> Delete(int bookId)
        {
            try{
                using(var context = new BookDataContext()){
                    BookModel book = await context.Books.FirstOrDefaultAsync(o => o.BookId == bookId);
                    context.Books.Remove(book);
                    await context.SaveChangesAsync();
                }
                return "OK";
            }
            catch(Exception ex){
                return string.Format("erreur {0}", ex.Message);   
            }
        }
    }
}