using Microsoft.AspNetCore.Mvc;
using MusicOrganizer.Models;
using System.Collections.Generic;

namespace MusicOrganizer.Controllers
{

    public class AlbumController : Controller
    {
        [HttpGet("/album")]
        public ActionResult Index()
        {
            List<Album> allAlbums = Album.GetAll();
            return View(allAlbums);
        }

        [HttpGet("/album/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/album")]
        public ActionResult Create(string albumName, string artist, string genre)
        {
            Album newAlbum = new Album(albumName, artist, genre);
            return RedirectToAction("Index");
        }

        [HttpPost("/album/delete")]
        public ActionResult DeleteAll()
        {
            Album.ClearAll();
            return View();
        }

    }
}