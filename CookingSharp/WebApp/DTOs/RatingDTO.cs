namespace WebApp.DTOs
{
    public class RatingCreateUpdateDTO
    {
        public int Stars { get; set; }
    }

    public class AverageRatingResponseDTO
    {
        public double AverageRating { get; set; }
    }
}