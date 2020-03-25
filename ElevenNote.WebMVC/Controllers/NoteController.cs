using ElevenNote.Models;
using ElevenNote.WebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElevenNote.WebMVC.Controllers
{
    [Authorize]
    public class NoteController : Controller
    {
        // NOTE: GET
        public ActionResult Index()
        {
            //initializing a new instance of the NoteListItem as an IEnumerable with the [0] syntax. //
            var model = new NoteListItem[0];
            return View(model);
        }

        // CREATE NOTE: GET
        public ActionResult Create()
        {
            return View();
        }

        // CREATE NOTE: POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NoteCreate model)
        {
            if (ModelState.IsValid)
            {

            }
            return View(model);
        }
    }
}