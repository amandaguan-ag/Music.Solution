// using Microsoft.VisualStudio.TestTools.UnitTesting;
// using Music.Models;
// using System.Collections.Generic;

// namespace Music.Tests
// {
//     [TestClass]
//     public class RecordTests
//     {
// [TestMethod]
//         public void RecordConstructor_CreatesInstanceOfRecord_Record()
//         {
//             Record newRecord = new Record("Test title", "Test artist");
//             Assert.AreEqual(typeof(Record), newRecord.GetType());
//         }

//         [TestMethod]
//         public void GetTitle_ReturnsTitle_String()
//         {
//             //Arrange
//             string title = "Test title";
//             Record newRecord = new Record(title, "Test artist");

//             //Act
//             string result = newRecord.Title;

//             //Assert
//             Assert.AreEqual(title, result);
//         }

//         [TestMethod]
//         public void GetAll_ReturnsAllRecordObjects_RecordList()
//         {
//             // Arrange
//             Record.ClearAll();
//             string title1 = "Test Record 1";
//             string title2 = "Test Record 2";
//             string artistName = "Test Artist";
//             Record newRecord1 = new Record(title1, artistName);
//             Record newRecord2 = new Record(title2, artistName);
//             List<Record> newList = new List<Record> { newRecord1, newRecord2 };

//             // Act
//             List<Record> result = Record.GetAll();

//             // Assert
//             CollectionAssert.AreEqual(newList, result);
//         }

//         [TestMethod]
//         public void Find_ReturnsCorrectRecord_Record()
//         {
//             // Arrange
//             Record.ClearAll();
//             string title1 = "Test Record 1";
//             string title2 = "Test Record 2";
//             string artistName = "Test Artist";
//             Record newRecord1 = new Record(title1, artistName);
//             Record newRecord2 = new Record(title2, artistName);

//             // Act
//             Record result = Record.Find(2);

//             // Assert
//             Assert.AreEqual(newRecord2, result);
//         }
//     }
// }
