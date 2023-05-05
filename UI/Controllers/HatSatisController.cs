using Business.Interface;
using Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data;

namespace UI.Controllers
{
    public class HatSatisController : Controller
    {
        //[Authorize(Roles = "Admin")]
        private readonly IHatSatisService _hatSatisService;
        private readonly IHatService _hatService;

        public HatSatisController(IHatSatisService hatSatisService, IHatService hatService)
        {
            _hatSatisService = hatSatisService;
            _hatService = hatService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public JsonResult IlceGetir(int ilId)
        {
            var ilceler = _hatSatisService.IlceListesi(ilId);
            return Json(ilceler);
        }
        public async Task<IActionResult> HatSatisEkle()
        {
            ViewBag.Il= new SelectList(_hatSatisService.IlListesi(), "IlId", "IlAdi");
            ViewBag.Hat= new SelectList(_hatService.HatListesi(), "HatId", "TelefonNo");
            return View(new HatSatisEkleDto());
        }
        [HttpPost]
        public async Task<IActionResult> HatSatisEkle(HatSatisEkleDto model)
        {
            return View();
        }
    }
}
