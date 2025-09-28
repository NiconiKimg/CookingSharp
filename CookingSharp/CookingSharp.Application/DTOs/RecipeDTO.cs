namespace CookingSharp.Application.DTOs
{
    public class ResponseRecipeDTO
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string AuthorName { get; set; }
        public List<CategoryDTO> Categories { get; set; }
    }
   
    public class CreateRecipeDTO
    {
        public string Description { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }
        public List<int> CategoryIds { get; set; } = new List<int>();
    }


    public class UpdateRecipeDTO
    {
       public string? Status { get; set; }
       public string? Description { get; set; }
       public string? Content { get; set; }
       public List<CategoryDTO>? Categories { get; set; }
    }
}