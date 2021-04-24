using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GenshinMVC.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [ActionName("not-found")]
        public ActionResult NotFound()
        {
            Response.StatusCode = 404;
            return View("NotFound");
        }

        [HttpGet]
        [ActionName("internal-error")]
        public ActionResult InternalError()
        {
            Response.StatusCode = 500;
            return View("InternalError");
        }

        [HttpGet]
        [ActionName("bad-request")]
        public ActionResult BadRequest()
        {
            Response.StatusCode = 400;
            return View("BadRequest");
        }
    }
}