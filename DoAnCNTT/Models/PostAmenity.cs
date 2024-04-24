using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace DoAnCNTT.Models
{
    public class PostAmenity : BaseModel
    {
        public string? PostId { get; set; }
        [ValidateNever]
        public Post Post { get; set; } = null!;
        public string? AmenityId { get; set; }
        [ValidateNever]
        public Amenity Amenity { get; set; } = null!;


    }
}
