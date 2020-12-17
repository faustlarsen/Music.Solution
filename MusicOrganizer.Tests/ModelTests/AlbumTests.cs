using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicOrganizer.Models;
using System;
using System.Collections.Generic; 

namespace MusicOrganizer.Tests
{
    [TestClass]
    public class AlbumTest : IDisposable
    {
    public void Dispose()
    {
      Album.ClearAll();
    }

    [TestMethod]
    public void AlbumConstructor_CreateInstanceOfAlbum_Album()
    {
    Album newAlbum = new Album("test", "test", "test");
    Assert.AreEqual(typeof(Album), newAlbum.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsNameString_String()
    {
      string albumName = "Vacancy";
      string artist = "Four Seconds Ago";
      string genre = "Lo-Fi";

      Album newAlbum = new Album(albumName, artist, genre);
      string result1 = newAlbum.AlbumName;
      string result2 = newAlbum.Artist;
      string result3 = newAlbum.Genre;
    
      Assert.AreEqual(albumName, result1);
      Assert.AreEqual(artist, result2);
      Assert.AreEqual(genre, result3);
    }
  }
}