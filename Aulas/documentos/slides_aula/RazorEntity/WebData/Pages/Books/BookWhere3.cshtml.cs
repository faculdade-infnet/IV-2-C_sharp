using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebData.Models;

namespace WebData.Pages.Books
{
    public class BookWhere3Model : PageModel
    {
        private readonly LibraryContext _context;
        public List<Book>? Books { get; set; }

        public BookWhere3Model(LibraryContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            Books = await _context
                          .Books
                          .OrderBy(o => o.ReleaseDate.Year)
                          .Select(s => new Book() { BookId = s.BookId, Title = $"{s.Title} // {s.Publisher}" })
                          .ToListAsync();
        }
    }
}
