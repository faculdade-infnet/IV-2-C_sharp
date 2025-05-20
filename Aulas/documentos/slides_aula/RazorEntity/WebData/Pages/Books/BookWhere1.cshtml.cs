using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebData.Models;

namespace WebData.Pages.Books
{
    public class BookWhere1Model : PageModel
    {
        private readonly LibraryContext _context;
        public List<Book>? Books { get; set; }

        public BookWhere1Model(LibraryContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            Books = await _context
                          .Books
                          .AsNoTracking()
                          .Where(b => b.Title == "Drácula 1a. Edição")
                          .ToListAsync();
        }
    }
}
