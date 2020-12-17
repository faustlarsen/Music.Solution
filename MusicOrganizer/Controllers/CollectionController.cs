using Microsoft.AspNetCore.Mvc;
using MusicOrganizer.Models;
using System.Collections.Generic;

namespace MusicOrganizer.Controllers
{

    public class CollectionController : Controller
    {
        [HttpGet("/collection")]
        public ActionResult Index()
        {
            List<Collection> allCollection = Collection.GetAll();
            return View(allCollection);
        }

        [HttpGet("/collection/new")]
        public ActionResult New()
        {
            return View();
        }
        
        [HttpPost("/collection")]
        public ActionResult Create(string collectionName)
        {
            Collection newCollection = new Collection(collectionName);
            return RedirectToAction("Index");
        }

        [HttpGet("/collection/{id}")]
        public ActionResult Show(int id)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Collection selectedCollection = Collection.Find(id);
            List<Album> collectionAlbums = selectedCollection.Album;
            model.Add("collection", collectionAlbums);
            model.Add("album", collectionAlbums);
            return View(model);
        }

        [HttpPost("/collection/{collectionId}/album")]
        public ActionResult Create(int collectionId, string albumName, string artist, string genre)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Collection foundCollection = Collection.Find(collectionId);
            Album newAlbum = new Album(albumName, artist, genre);
            foundCollection.AddAlbum(newAlbum);
            List<Album> collectionAlbums = foundCollection.Album;
            model.Add("album", collectionAlbums);
            model.Add("collection", foundCollection);
            return View("Show", model);
        }
    }
}