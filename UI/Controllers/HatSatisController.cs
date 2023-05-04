using Dto;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class HatSatisController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> HatSatisEkle()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> HatSatisEkle(HatSatisEkleDto model)
        {
            return View();
        }
    }
}
