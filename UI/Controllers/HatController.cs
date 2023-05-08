using AutoMapper;
using Business.Interface;
using Dto;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace UI.Controllers
{
    public class HatController : Controller
    {
        private readonly IElasticsearchService _elasticsearchService;
        private readonly IHatService _hatService;
        private readonly IHatKullanimService _hatKullanimService;
        private readonly IMapper _mapper;

        public HatController(IElasticsearchService elasticsearchService, IHatService hatService,IMapper mapper, IHatKullanimService hatKullanimService)
        {
            _elasticsearchService = elasticsearchService;
            _hatService = hatService;
            _mapper = mapper;
            _hatKullanimService = hatKullanimService;
        }
        [Authorize(Roles = "Admin,Editor")]
        public async Task<IActionResult> Index()
        {
           var hats = await _elasticsearchService.GetAllHatsFromElasticsearchAsync();
            var hatListeDtos = new List<HatListeDto>();

            foreach (var hat in hats)
            {
                var hatListeDto = new HatListeDto
                {
                    HatId = hat.HatId,
                    TelefonNo = hat.TelefonNo,
                    SatisDurumu = hat.SatisDurumu,
                    Ad = hat.Ad,
                    Soyad = hat.Soyad,
                    HatAcilisTarihi = hat.HatAcilisTarihi
                };

                hatListeDtos.Add(hatListeDto);
            }
            return View(hatListeDtos);
        }
        [Authorize(Roles = "Admin")]
        public IActionResult HatSil(int HatId)
        {
            _hatService.Sil(new Hat { HatId = HatId });
            return Json(null);
        }
        [Authorize(Roles = "Admin,Editor")]
        public IActionResult HatKullanimDetay(int HatId)
        {
            return View(_mapper.Map<List<HatKullanimListeDto>>(_hatKullanimService.KullanimDetayListe(HatId)));

        }
    }
}

