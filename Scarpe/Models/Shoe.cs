namespace Scarpe.Models
{
    public class Shoe
    {
        public int ShoeId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public string? Image { get; set; } = null;
        public string? Image1 { get; set; } = null;
        public string? Image2 { get; set; } = null;
        public DateTime? DeletedAt { get; set; } = null;

    }
}
