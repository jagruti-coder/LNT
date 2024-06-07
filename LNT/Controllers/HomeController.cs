using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using LNT.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Routing;

namespace LNT.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUrlHelperFactory _urlHelperFactory;

        public HomeController(IUrlHelperFactory urlHelperFactory)
        {
            _urlHelperFactory = urlHelperFactory;
        }

        public ActionResult Index()
        {
            var urlHelper = _urlHelperFactory.GetUrlHelper(ControllerContext);
            var images = new List<ImageModel>
            {

                // Use direct paths if images are in wwwroot/images folder
                new ImageModel { ImageUrl = Url.Content("~/images/0_ovb9xbmk0at1kot-.jpg")},
                new ImageModel { ImageUrl = Url.Content("~/images/image2.2.jpg")},
                new ImageModel { ImageUrl = Url.Content("~/images/image3.3.jpg")}
           };

            return View(images);
        }

        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Request()
        {
            return View();
        }
    }
}