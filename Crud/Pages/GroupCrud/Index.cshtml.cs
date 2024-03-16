using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Crud.Data.Model;
using Crud.Data;

namespace Crud.Pages.GroupCrud
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public IList<Group> Group { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Groups != null)
            {
                Group = await _context.Groups.ToListAsync();
            }
        }
    }
}
