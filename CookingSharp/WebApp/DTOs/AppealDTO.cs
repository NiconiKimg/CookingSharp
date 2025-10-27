namespace WebApp.DTOs
{
    public class AppealResponseDTO
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public int ApplicantId { get; set; }
        public string ApplicantName { get; set; }
    }

    public class AppealCreateDTO
    {
        public string Description { get; set; }
    }
}