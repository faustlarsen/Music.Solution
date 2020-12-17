using Microsoft.AspNetCore.Mvc;
using MusicOrganizer.Models;
using System.Collections.Generic;

namespace MusicOrganizer.Controllers
{

    public class AlbumController : Controller
    {
        [HttpPost("/album/delete")]
        public ActionResult DeleteAll()
        {
            Album.ClearAll();
            return View();
        }
    }

}