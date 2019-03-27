using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DevoxxBooksApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BooksController : Controller
    {
        //Si vous voulez être en asynchrone la signature de votre méthode doit être 
        //public async Task<Ienumerable<Model>> GetAll() où Model est le type de votre classe model
        //sinon remplacer object par le type de votre model
        [HttpGet]
        public  IEnumerable<object> GetAll()
        {
            //à l'intérieur de celui appelez soit simplement seulement votre DbSet de votre context 
            //soit en plus vous utilisez la méthode ToListAsync
            using (var context = new BookDataContext()){
                
            }
            return null;
        }

        [HttpGet]
        //en asynchrone public async  Task<Model> Get(int bookId) où Model est le type de votre model
        public object Get(int bookId)
        {
            //vous devez parmi votre collection trouvez celui qui a le bon id 
            //soit par un foreach 
            //soit par firstordefault de linq
            using (var context = new BookDataContext()){
               
            }
            return null;
        }

        [HttpPost]
        //en asynchrone public async  Task<BookModel> Create(Model book) où Model est le type de votre model
        public string Create(object book)
        {
            try{
                //vous devez utilisez dans le using la méthode add de votre context et savechanges 
                //si vous êtes en asynchrone utilisez addasync et savechangesasync
                using(var context = new BookDataContext()){
                  
                  
                }
                return "OK";
            }
            catch(Exception ex){
                return string.Format("erreur {0}", ex.Message);   
            }
        }

        [HttpDelete]
        // en asynchrone public async Task<string> Delete(int bookId)
        public string Delete(int bookId)
        {
            try{
                //vous devez utilisez la même méthode que dans le get pour trouver le livre à supprimer
                //utilisez ensuite la méthode Remove de votre contexte
                //utilisez savechanges si vous êtes en synchrone et savechangesasync en asynchrone
                using(var context = new BookDataContext()){
                    
                }
                return "OK";
            }
            catch(Exception ex){
                return string.Format("erreur {0}", ex.Message);   
            }
        }
    }
}