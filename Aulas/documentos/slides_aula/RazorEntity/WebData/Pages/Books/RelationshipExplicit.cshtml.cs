using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebData.Models;

namespace WebData.Pages.Books
{
    public class RelationshipExplicitModel : PageModel
    {
        private readonly LibraryContext _context;
        public List<BookAuthor>? Books { get; set; }
        public RelationshipExplicitModel(LibraryContext context)
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
                    //_context.Entry(book).Reference(p => p.Author).Load();

                    BookAuthor listElement = new BookAuthor(book.Title,
                                                            book.Author.FirstName,
                                                            book.Author.LastName);
                    Books.Add(listElement);
                }
            }
        }
    }
}
