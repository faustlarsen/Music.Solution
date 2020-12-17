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
  }
}