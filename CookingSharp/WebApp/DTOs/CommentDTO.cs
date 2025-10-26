namespace WebApp.DTOs
{
    public class CommentResponseDTO
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class CommentCreateDTO
    {
        public string Text { get; set; }
    }
}