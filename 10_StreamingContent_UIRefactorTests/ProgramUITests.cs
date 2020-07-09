using System;
using System.Collections.Generic;
using _09_StreamingContent_Console.UI;
using _10_StreamingContent_UIRefactorTests.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _10_StreamingContent_UIRefactorTests
{
    [TestClass]
    public class ProgramUITests
    {
        [TestMethod]
        public void GetList_OutputShouldContainList()
        {
            // Arrange
            List<string> commandList = new List<string> { "1", "5" };
            MockConsole console = new MockConsole(commandList);
            ProgramUI program = new ProgramUI(console);

            // Act
            program.Run();
            Console.WriteLine(console.Output);

            // Assert
            Assert.IsTrue(console.Output.Contains("Ferris Bueller's Day Off"));
        }

        [TestMethod]
        public void AddToList_ShouldSeeItemInList()
        {
            // Arrange
            var customDesc = "This is my customer description";
            var commandList = new List<string> { "3", "Title", customDesc, "4", "1", "8", "1", "5", };
            var console = new MockConsole(commandList);
            var ui = new ProgramUI(console);

            // Act
            ui.Run();
            Console.WriteLine(console.Output);

            // Assert
            Assert.IsTrue(console.Output.Contains(customDesc));

        }

        [TestMethod]
        public void RemoveFromList_ShouldSeeRemovedMessage()
        {
            // Arrange
            var commandList = new List<string> { "4", "2", "1", "5" };
            var console = new MockConsole(commandList);
            var ui = new ProgramUI(console);

            // Act
            ui.Run();
            Console.WriteLine(console.Output);

            // Assert
            Assert.IsFalse(console.Output.Contains("Dog plays basketball"));
        }

        [TestMethod]
        public void GetByTitle_ShouldGetCorrectTitle()
        {
            // Arrange
            // need to know the command list - in what order to i need to go to get by title
            var fakeUserInput = new List<string> { "2", "Ferris Bueller's Day Off", "5" };
            // set up console
            var console = new MockConsole(fakeUserInput);
            // set up ui
            var ui = new ProgramUI(console);

            // Act
            // Running the program
            ui.Run();

            // Assert
            // what in my output is going to be unique that can be tested that would work
            Assert.IsTrue(console.Output.Contains("Cool guy ditches school for a fun day on the town"));
        }
    }
}
