using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using crudASPNET.Models;
using crudAspNet.Data;

namespace crudAspNet.Pages_Premiums
{
    public class IndexModel : PageModel
    {
        private readonly crudAspNet.Data.ApplicationDbContext _context;

        public IndexModel(crudAspNet.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Premium> Premium { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Premiums != null)
            {
                Premium = await _context.Premiums
                .Include(p => p.Student).ToListAsync();
            }
        }
    }
}
