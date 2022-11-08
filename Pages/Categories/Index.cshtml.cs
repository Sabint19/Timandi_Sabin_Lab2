using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Timandi_Sabin_Lab2.Data;
using Timandi_Sabin_Lab2.Models;

namespace Timandi_Sabin_Lab2.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Timandi_Sabin_Lab2.Data.Timandi_Sabin_Lab2Context _context;

        public IndexModel(Timandi_Sabin_Lab2.Data.Timandi_Sabin_Lab2Context context)
        {
            _context = context;
        }

        public IList<BookCategory> BookCategory { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.BookCategory != null)
            {
                BookCategory = await _context.BookCategory
                .Include(b => b.Book)
                .Include(b => b.Category).ToListAsync();
            }
        }
    }
}
