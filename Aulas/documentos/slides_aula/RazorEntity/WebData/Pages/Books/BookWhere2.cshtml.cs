using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebData.Models;

namespace WebData.Pages.Books
{
    public class BookWhere2Model : PageModel
    {
        private readonly LibraryContext _context;
        public List<Book>? Books { get; set; }

        public BookWhere2Model(LibraryContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            Books = _context
                    .Books
                    .Where(b => b.ReleaseDate >= EF.Functions.DateFromParts(2007, 05, 1)
                           && b.ReleaseDate <= EF.Functions.DateFromParts(2026, 12, 31))
                    .ToList();
        }
    }
}
