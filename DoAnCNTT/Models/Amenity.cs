namespace DoAnCNTT.Models
{
    public class Amenity : BaseModel
    {
        public string? Name;
        public string? IconImage;
        public ICollection<PostAmenity> PostAmenities { get; set; } = new List<PostAmenity>();
    }
}
