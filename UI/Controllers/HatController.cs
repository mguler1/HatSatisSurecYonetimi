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
        private readonly IHatService _heatService;
        private readonly IMapper _mapper;

        public HatController(IElasticsearchService elasticsearchService, IHatService heatService,IMapper mapper)
        {
            _elasticsearchService = elasticsearchService;
            _heatService = heatService;
            _mapper = mapper;
        }

        //public async Task <IActionResult> Index()
        //{
        //    var hats = await _elasticsearchService.GetAllHatsFromElasticsearchAsync();
        //    var hatListeDtos = _mapper.Map<List<HatListeDto>>(hats);
        //    return View(hatListeDtos);
        //}

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

    }
}

