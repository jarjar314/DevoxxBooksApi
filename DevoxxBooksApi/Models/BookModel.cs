using System;
using System.ComponentModel.DataAnnotations;

namespace DevoxxBooksApi.Models
{
    public class BookModel
    {
        [Key]
        public int BookId { get; set; }

        public string BookTitle { get; set; }

        public string BookType { get; set; }

        public int BookPublication { get; set; }

        public string AutorName { get; set; }
    }
}