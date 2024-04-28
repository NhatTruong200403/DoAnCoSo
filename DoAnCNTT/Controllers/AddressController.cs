using DoAnCNTT.Data;
using Microsoft.AspNetCore.Mvc;

namespace DoAnCNTT.Controllers
{
    public class AddressController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AddressController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        //[HttpGet]
        //public IActionResult GetProvinces()
        //{
        //    var provinces = _context.Tinh.Select(p => p.Name).ToList();
        //    return Json(provinces);
        //}

        //[HttpGet]
        //public IActionResult GetDistricts(string provinceName)
        //{
        //    var districts = _context.Huyen
        //        .Where(d => d.Province.Name == provinceName)
        //        .Select(d => d.Name)
        //        .ToList();
        //    return Json(districts);
        //}

        //[HttpGet]
        //public IActionResult GetWards(string districtName)
        //{
        //    var wards = _context.Xa
        //        .Where(w => w.District.Name == districtName)
        //        .Select(w => w.Name)
        //        .ToList();
        //    return Json(wards);
        //}
    }
}
