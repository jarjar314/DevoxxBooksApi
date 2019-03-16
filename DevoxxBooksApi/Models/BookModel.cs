using System;

namespace DevoxxBooksApi.Models
{
    public class BookModel
    {
        public int BookId { get; set; }

        public string BookTitle { get; set; }

        public string BookType { get; set; }

        public int BookPublication { get; set; }

        public string AutorName { get; set; }
    }
}