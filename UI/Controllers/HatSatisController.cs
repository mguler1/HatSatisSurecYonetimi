using AutoMapper;
using Business.Interface;
using Dto;
using Entity.Concrete;
using Hangfire;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Data;

namespace UI.Controllers
{
    public class HatSatisController : Controller
    {
        //[Authorize(Roles = "Admin")]
        private readonly IHatSatisService _hatSatisService;
        private readonly IHatService _hatService;
        private readonly IMapper _mapper;
        private readonly UserManager<AppUser> _userManager;
        private readonly IHostEnvironment _hostEnvironment;
        private readonly IEmailService _emailService;

        public HatSatisController(IHatSatisService hatSatisService, IHatService hatService,IMapper mapper , UserManager<AppUser> userManager, IHostEnvironment hostEnvironment, IEmailService emailService)
        {
            _hatSatisService = hatSatisService;
            _hatService = hatService;
            _mapper = mapper;
            _userManager = userManager;
            _hostEnvironment = hostEnvironment;
            _emailService=emailService;
        }

        [Authorize(Roles = "Admin,Editor")]
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult IlceGetir(int ilId)
        {
            var ilceler = _hatSatisService.IlceListesi(ilId);
            return Json(ilceler);
        }
        [Authorize(Roles = "Admin,Editor")]
        public async Task<IActionResult> HatSatisEkle()
        {
            ViewBag.Il= new SelectList(_hatSatisService.IlListesi(), "IlId", "IlAdi");
            ViewBag.Hat= new SelectList(_hatService.HatListesi(), "HatId", "TelefonNo");
            return View(new HatSatisEkleDto());
        }
        [HttpPost]
        [Authorize(Roles = "Admin,Editor")]
        public async Task<IActionResult> HatSatisEkle(HatSatisEkleDto model)
        {
          
            var kullanici = await _userManager.FindByNameAsync(User.Identity!.Name);
            var kullaniciRol =await _userManager.GetRolesAsync(kullanici);
            if (ModelState .IsValid)
            {
                if (kullaniciRol.Contains("Admin")) {
                    model.HatAcilisTarihi=DateTime.Now;
                    model.HatOnayDurumu = 1;
                }
                else {
                    model.HatAcilisTarihi = null;
                    model.HatOnayDurumu = 0;
                }
                _hatSatisService.Kayit(new HatSatis()
                {
                    Ad=model.Ad,
                    Soyad=model.Soyad,
                    EPosta=model.EPosta,
                    HatId=model.HatId,
                    Il=model.Il,
                    Ilce=model.Ilce,
                    Adres=model.Adres,
                    HatOnayDurumu=model.HatOnayDurumu,
                    HatAcilisTarihi=model.HatAcilisTarihi
                });
                //var filePath = Path.Combine(_hostEnvironment.ContentRootPath, "data.txt");
                //_hatSatisService.MailGonder($"Merhaba {model.Ad} {model.Soyad} hattınız aktif edilmiştir.", filePath);
                if (kullaniciRol.Contains("Admin"))
                {
                    BackgroundJob.Enqueue(() => _emailService.MailGonder(model.EPosta));
                }
               
               // await _emailService.MailGonder(model.EPosta);
                return RedirectToAction("Index");
            }
            ViewBag.Il = new SelectList(_hatSatisService.IlListesi(), "IlId", "IlAdi");
            ViewBag.Hat = new SelectList(_hatService.HatListesi(), "HatId", "TelefonNo");
            return View(model);
        }
        [Authorize(Roles = "Admin")]
        public IActionResult OnayBekleyenHatListesi()
        {
            return View(_mapper.Map<List<HatSatisOnayListeDto>>(_hatSatisService.OnayBekleyenHatListesi()));
        }
        [Authorize(Roles = "Admin")]
        public IActionResult HatSatisOnayla(int HatSatisId)
        {
            _hatSatisService.HatSatisOnayla(HatSatisId);
            return RedirectToAction("Index");
        }
    }
}
