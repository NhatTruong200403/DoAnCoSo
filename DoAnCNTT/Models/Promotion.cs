namespace DoAnCNTT.Models
{
    public class Promotion : BaseModel
    {
        public string? Content { get; set; }
        public string? DiscountValue { get; set; }
        public DateTime ExpiredDate { get; set; }
        public ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();
    }
}
