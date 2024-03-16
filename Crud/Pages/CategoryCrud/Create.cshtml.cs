using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Crud.Data.Model;
using Crud.Data;

namespace Crud.Pages.CategoryCrud
{
    public class CreateModel : PageModel
    {
        private readonly AppDbContext _context;
        public List<SelectListItem> GroupList = new List<SelectListItem>();


        public CreateModel(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            var data = _context.Groups.ToList();
            foreach (var item in data)
            {
                GroupList.Add(new SelectListItem
                {
                    Text = item.Name,
                    Value = item.Id.ToString(),
                });
            }
            return Page();
        }

        [BindProperty]
        public Category Category { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Categories == null || Category == null)
            {
                return Page();
            }

            _context.Categories.Add(Category);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
