using System;
using System.Diagnostics.Contracts;
using _07_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentTests
    {
        [TestMethod]
        public void SetTitle_ShouldSetCorrectString() //-- What you are testing - What your expected outcome is
        {
            StreamingContent content = new StreamingContent();  //-- 'ctrl + .' to add reference
            content.Title = "Toy Story";

            //--creating two variables that we are going to use in Assert statement to test that the title functionality is working as it should
            string expected = "Toy Story";
            string actual = content.Title;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SetStarRating_ShouldSetCorrectInt() //-- What you are testing - What your expected outcome is
        {
            StreamingContent content = new StreamingContent();  //-- 'ctrl + .' to add reference
            content.StarRating = 5;

            //--creating two variables that we are going to use in Assert statement to test that the title functionality is working as it should
            int expected = 5;
            int actual = content.StarRating;

            Assert.AreEqual(expected, actual);
        }

        //-- How to run multiple tests with multiple data points
        [DataTestMethod]
        [DataRow(GenreType.Thriller)]
        [DataRow(GenreType.Romance)]
        [DataRow(GenreType.Comedy)]
        public void SetTypeOfGenre_ShouldSetCorrectGenreType(GenreType typeOfGenre)
        {
            //--Arrange (set the stage)
            StreamingContent content = new StreamingContent();
            //--Act (call the functionality
            content.TypeOfGenre = typeOfGenre;
            //--Assert (did this work out the way I expected?)
            Assert.AreEqual(typeOfGenre, content.TypeOfGenre);
        }
    }
}
