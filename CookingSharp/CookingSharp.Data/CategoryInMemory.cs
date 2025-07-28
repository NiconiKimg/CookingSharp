using CookingSharp.Domain.Model;

namespace CookingSharp.Data
{
    public class CategoryInMemory
    {
        public static List<Category> Categories { get; set; } = new List<Category>
        {
            new Category(1, "Desserts", "Sweet dishes served at the end of a meal"),
            new Category(2, "Main Courses", "The primary dish in a meal"),
            new Category(3, "Appetizers", "Small dishes served before the main course"),
            new Category(4, "Salads", "Cold dishes typically made with vegetables"),
            new Category(5, "Soups", "Liquid dishes often served warm")
        };
    }
}
