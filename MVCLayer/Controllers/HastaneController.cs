using BusinessLayer.Abstract;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;

namespace MVCLayer.Controllers
{
    public class HastaneController : Controller
    {
        private readonly IHastaneService hastaneService;
        public HastaneController(IHastaneService hastaneService)
        {
            this.hastaneService = hastaneService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = hastaneService.HastaneListele();
            return View(result);
        }

        [HttpPost]
        public IActionResult Add(Hastane hastane)
        {
            hastaneService.HastaneEkle(hastane);
            return RedirectToAction("GetAll"); 
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Delete(Hastane hastane)
        {
            hastaneService.HastaneSil(hastane);
            return RedirectToAction("GetAll");
        }
        [HttpGet]
        public IActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update(Hastane hastane)
        {
            var result = hastaneService.HastaneGuncelle(hastane);
            return RedirectToAction("GetAll");
        }
        public IActionResult Update()
        {
            return View();
        }

        public IActionResult Index()
        {
            return RedirectToAction("GetAll");
        }
    }
}
