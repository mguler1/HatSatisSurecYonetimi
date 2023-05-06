using Business.Interface;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class HatController : Controller
    {
        private readonly IElasticsearchService _elasticsearchService;
        private readonly IHatService _heatService;

        public HatController(IElasticsearchService elasticsearchService, IHatService heatService)
        {
            _elasticsearchService = elasticsearchService;
            _heatService = heatService;
        }

        public async Task <IActionResult> Index()
        {
         var a= await _elasticsearchService.GetAllHatsFromElasticsearchAsync();
            return View(a);
        }

        //public async Task<IActionResult<List<Hat>>> GetAllHatsFromElasticsearch()
        //{
        //    var hats = await _elasticsearchService.GetAllHatsFromElasticsearchAsync();
        //    return View(hats);
        //}
    }
}

