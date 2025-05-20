using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebData.Models;

namespace WebData.Pages.Books
{
    public class RelationshipEagerModel : PageModel
    {
        private readonly LibraryContext _context;
        public List<BookAuthor>? BookAuthors { get; set; }
        public RelationshipEagerModel(LibraryContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            List<Book> books = _context.Books
                               .Include(a => a.Author)
                               .ToList();

            if (books.Any() == true)
            {
                BookAuthors = new();

                foreach (Book book in books)
                {
                    BookAuthor listElement = new BookAuthor(book.Title,
                                                            book.Author.FirstName,
                                                            book.Author.LastName);
                    BookAuthors.Add(listElement);
                }
            }
        }
    }
}
