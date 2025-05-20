using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebData.Models;

namespace WebData.Pages.Books
{
    public class RelationshipLazyModel : PageModel
    {
        private readonly LibraryContext _context;
        public List<BookAuthor>? Books { get; set; }
        public RelationshipLazyModel(LibraryContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            List<Book> books = _context.Books.ToList();

            if (books.Any() == true)
            {
                Books = new();

                foreach (Book book in books)
                {
                    BookAuthor listElement = new BookAuthor(book.Title,
                                                            book.Author.FirstName,
                                                            book.Author.LastName);
                    Books.Add(listElement);
                }
            }
        }
    }
}
