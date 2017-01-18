using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pets.Areas.Api.Controllers
{
    public class TitlesController : Controller
    {
        // GET: Api/Titles
        public JsonResult Index()
        {
            var titles = new[]
            {
                new { id = 1, titleCode = "Code 1", title = "Pet 1" },
                new { id = 1, titleCode = "Code 2", title = "Pet 2" },
                new { id = 1, titleCode = "Code 3", title = "Pet 3" }
            };
            return Json(titles, JsonRequestBehavior.AllowGet);
        }
    }
}