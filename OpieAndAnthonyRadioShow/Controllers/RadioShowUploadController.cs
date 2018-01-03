using Microsoft.AspNetCore.Mvc;
using OpieAndAnthonyRadioShow.Models;

namespace OpieAndAnthonyRadioShow.Controllers
{
    public class RadioShowUploadController : Controller
    {
        public IActionResult Upload()
        {
            var model = new UploadRadioShowModel();

            return View(model);
        }
    }
}