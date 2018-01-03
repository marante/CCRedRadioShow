using Microsoft.AspNetCore.Mvc;
using OpieAndAnthonyRadioShow.Data;
using OpieAndAnthonyRadioShow.Models;
using System.Linq;

namespace OpieAndAnthonyRadioShow.Controllers
{
    public class RadioShowController : Controller
    {
        private readonly IRadioShow _radioShowService;

        public RadioShowController(IRadioShow radioShowService)
        {
            _radioShowService = radioShowService;
        }

        public IActionResult Index()
        {
            var radioShowList = _radioShowService.GetAll();

            var radioViewModel = new RadioShowViewModel()
            {
                RadioShows = radioShowList,
                SearchQuery = ""
            };
            return View(radioViewModel);
        }

        public IActionResult Details(int id)
        {
            var radioShow = _radioShowService.GetById(id);

            var radioShowDetailModel = new RadioShowDetailModel()
            {
                Id = radioShow.Id,
                Title = radioShow.Title,
                Created = radioShow.AirTime,
                Url = radioShow.URL,
                Tags = radioShow.Tags.Select(t => t.Description).ToList()
            };

            return View(radioShowDetailModel);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}