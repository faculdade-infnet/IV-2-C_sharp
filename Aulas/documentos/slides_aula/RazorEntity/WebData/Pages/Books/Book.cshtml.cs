using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebData.Models;

namespace WebData.Pages.Books
{
    public class BookModel : PageModel
    {
        private readonly LibraryContext _context;
        public List<Book>? Books { get; set; }

        public BookModel(LibraryContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            Books = await _context.Books.ToListAsync();
        }
    }
}
