using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace DoAnCNTT.Models
{
    public class Invoice : BaseModel
    {
        public decimal Deposit { get; set; }
        public DateTime RecieveOn { get; set; }
        public DateTime ReturnOn { get; set; }
        public string? PostId { get; set; }
        [ValidateNever]
        public Post Post { get; set; } = null!;
        public string? PromotionId { get; set; }
        [ValidateNever]
        public Promotion Promotion { get; set; } = null!;
        public string? PaymentId { get; set; }
        [ValidateNever]
        public Payment Payment { get; set; } = null!;
        public string? UserId { get; set; }
        [ValidateNever]
        public ApplicationUser User { get; set; } = null!;
    }
}
