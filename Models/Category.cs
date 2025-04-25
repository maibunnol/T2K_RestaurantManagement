namespace T2K_RestaurantManagement.Models
{
    public class Category
    {
        public int Id { get; set; }

        public required string Title { get; set; }

        public string? Description { get; set; }

        public string? ImagePath { get; set; }
    }
}
