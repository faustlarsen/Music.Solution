using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicOrganizer.Models;
using System;
using System.Collections.Generic; 

namespace MusicOrganizer.Tests
{
  [TestClass]
    public class CollectionTest : IDisposable
    {
      public void Dispose()
      {
        Collection.ClearAll();
      }

      [TestMethod]
      public void CollectionConstructor_CreatesInstance_Collection()
      {
        Collection newCollection = new Collection("test");
        Assert.AreEqual(typeof(Collection), newCollection.GetType());
      }

      [TestMethod]
      public void GetName_ReturnsCollectionsName_String()
      {
        string collectionName = "Electronic";
        Collection newCollection = new Collection(collectionName);
        string result = newCollection.CollectionName;
      
        Assert.AreEqual(result, collectionName);
      }
    }
    
}