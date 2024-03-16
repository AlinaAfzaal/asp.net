using Crud.Data.Model;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Crud.Data
{
    public static class Functions
    {


        public static List<SelectListItem> getCategories(AppDbContext context)
        {
            List<SelectListItem> CategoryList = new List<SelectListItem>();

            List<Category> data = context.Categories.ToList();
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
