using Crud.Data.Model;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Crud.Data
{
    public static class Functions
    {
        static readonly AppDbContext _context;


        public static List<SelectListItem> getCategories()
        {
            List<SelectListItem> CategoryList = new List<SelectListItem>();

            List<Category> data = _context.Categories.ToList();
            foreach (var item in data)
            {
                CategoryList.Add(new SelectListItem
                {
                    Text = item.Name,
                    Value = item.Id.ToString(),
                });
            }
            return CategoryList;

        }

    }
}
