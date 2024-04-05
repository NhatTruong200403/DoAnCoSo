using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DoAnCNTT.Controllers
{
    public class FooterController : Controller
    {
        
       
        public IActionResult LienHe()
        {
            return View();
        }
    }
}
