using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicio_11.Pages
{
    public class FilesContentModel : PageModel
    {
        public string? FileName { get; set; }
        public string? FileContent { get; set; }

        public IActionResult OnGet(string filename)
        {
            if (string.IsNullOrEmpty(filename))
                return RedirectToPage("/ReadFiles");

            string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "files");
            string fullPath = Path.Combine(folderPath, filename);

            if (!System.IO.File.Exists(fullPath))
                return NotFound();

            FileName = filename;
            FileContent = System.IO.File.ReadAllText(fullPath);

            return Page();
        }
    }
}