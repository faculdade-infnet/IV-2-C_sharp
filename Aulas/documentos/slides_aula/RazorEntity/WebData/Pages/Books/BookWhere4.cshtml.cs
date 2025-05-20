using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebData.Models;

namespace WebData.Pages.Books
{
    public class BookWhere4Model : PageModel
    {
        private readonly LibraryContext _context;
        public List<Book>? Books { get; set; }

        public BookWhere4Model(LibraryContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {

            Books = await _context
                          .Books
                          .Where(b => EF.Functions.Like(b.Title, "%sand%")
                                 && b.ReleaseDate.Year == 2008)
                          .ToListAsync();
        }
    }
}
