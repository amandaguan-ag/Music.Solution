// using Microsoft.VisualStudio.TestTools.UnitTesting;
// using Music.Models;
// using System.Collections.Generic;

// namespace Music.Tests
// {
//     [TestClass]
//     public class ArtistTests
//     {
//         [TestMethod]
//         public void ArtistConstructor_CreatesInstanceOfArtist_Artist()
//         {
//             Artist newArtist = new Artist("test artist");
//             Assert.AreEqual(typeof(Artist), newArtist.GetType());
//         }

//         [TestMethod]
//         public void GetName_ReturnsName_String()
//         {
//             string name = "Test Artist";
//             Artist newArtist = new Artist(name);
//             string result = newArtist.Name;
//             Assert.AreEqual(name, result);
//         }

//         [TestMethod]
//         public void GetId_ReturnsArtistId_Int()
//         {
//             // Arrange
//             Artist.ClearAll(); // cleanup before test
//             string name = "Test artist";
//             Artist newArtist = new Artist(name);

//             // Act
//             int result = newArtist.Id;

//             // Assert
//             Assert.AreEqual(1, result);
//         }

//         [TestMethod]
//         public void GetAll_ReturnsAllArtistObjects_ArtistList()
//         {
//             // Arrange
//             Artist.ClearAll(); // cleanup before test
//             string name01 = "Test artist 1";
//             string name02 = "Test artist 2";
//             Artist newArtist1 = new Artist(name01);
//             Artist newArtist2 = new Artist(name02);
//             List<Artist> newList = new List<Artist> { newArtist1, newArtist2 };

//             // Act
//             List<Artist> result = Artist.GetAll();

//             // Assert
//             CollectionAssert.AreEqual(newList, result);
//         }

//         [TestMethod]
//         public void Find_ReturnsCorrectArtist_Artist()
//         {
//             // Arrange
//             Artist.ClearAll();
//             string name1 = "Test artist 1";
//             string name2 = "Test artist 2";
//             Artist newArtist1 = new Artist(name1);
//             Artist newArtist2 = new Artist(name2);

//             // Act
//             Artist result = Artist.Find(2);

//             // Assert
//             Assert.AreEqual(newArtist2, result);
//         }

//         [TestMethod]
//         public void AddRecord_AssociatesRecordWithArtist_RecordList()
//         {
//             string artistName = "Test Artist";
//             Artist newArtist = new Artist(artistName);
//             string title = "Test Record";
//             Record newRecord = new Record(title, artistName);
//             List<Record> newList = new List<Record> { newRecord };
//             newArtist.AddRecord(newRecord);
//             List<Record> result = newArtist.Records;
//             CollectionAssert.AreEqual(newList, result);
//         }
//     }
// }
