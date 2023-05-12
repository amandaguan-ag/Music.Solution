using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
// using Music.Models;
using System;

namespace Music.Tests
{
    [TestClass]
    public class ArtistTests
    {
        [TestMethod]
        public void ArtistConstructor_CreatesInstanceOfArtist_Artist()
        {
            Artist newArtist = new Artist();
            Assert.AreEqual(typeof(Artist), newArtist.GetType());
        }

        [TestMethod]
        public void GetArtistId_ReturnArtistId_Int()
        {
            //Arrange
            int id = 1;
            Artist newArtist = new Artist() { ArtistId = id };

            //Act
            int result = newArtist.ArtistId;

            //Assert
            Assert.AreEqual(id, result);
        }

        [TestMethod]
        public void GetName_ReturnArtistName_String()
        {
            //Arrange
            string name = "JS Bach";
            Artist newArtist = new Artist() { Name = name };

            //Act
            string result = newArtist.Name;

            //Assert
            Assert.AreEqual(name, result);
        }

        [TestMethod]
        public void GetRecords_ReturnArtistRecords_RecordsCollection()
        {
            //Arrange
            Artist newArtist = new Artist();
            List<Record> records = new List<Record>();

            //Act
            ICollection<Record> result = newArtist.Records;

            //Assert
            CollectionAssert.AreEqual(records, (System.Collections.ICollection)result);
        }
    }
}