using Microsoft.EntityFrameworkCore;

namespace DoAnCNTT.Models
{
    public class AddressModel : BaseModel
    {
        public string Tinh { get; set; } 
        public string Huyen { get; set; } 
        public string Xa { get; set; } 
    }
}
