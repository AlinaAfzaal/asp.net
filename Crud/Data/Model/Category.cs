using System.ComponentModel.DataAnnotations;

namespace Crud.Data.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Group { get; set; }

    }
}
