namespace DoAnCNTT.Models
{
    public class BaseModel
    {
        public string? Id { get; set; }
        public string? CreatedById { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? ModifiedById { get; set; }
        public DateTime ModifiedOn { get; set;}
        public bool IsDeleted { get; set; }
    }
}
