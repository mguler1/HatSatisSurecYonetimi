using AutoMapper;
using Business.Interface;
using Dto;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class HatController : Controller
    {
        private readonly IElasticsearchService _elasticsearchService;
        private readonly IHatService _hatService;
        private readonly IMapper _mapper;

        public HatController(IElasticsearchService elasticsearchService, IHatService hatService,IMapper mapper)
        {
            _elasticsearchService = elasticsearchService;
            _hatService = hatService;
            _mapper = mapper;
        }
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
        public IActionResult HatSil(int HatId)
        {
            _hatService.Sil(new Hat { HatId = HatId });
            return Json(null);
        }
    }
}

