﻿using _07_RepositoryPattern_Repository;
using _08_StreamingContent_Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _09_StreamingContent_Console.UI
{
    public class ProgramUI

    {
        private readonly IConsole _console;
        private readonly StreamingRepository _streamingRepo = new StreamingRepository();

        public ProgramUI(IConsole console)
        {
            _console = console;
        }
        public void Run()
        {
            SeedContentList();
            RunMenu();
        }

        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {

                //-- \n = new line
                _console.Clear();
                _console.WriteLine(
                    "Enter the number of the option you'd like to select: \n" +
                    "1. Show all streaming content \n" +
                    "2. Find streaming content by title \n" +
                    "3. Add new streaming content \n" +
                    "4. Remove streaming content \n" +
                    "5. Exit"
                    );
                string userInput = _console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        // Show all
                        ShowAllContent();
                        break;
                    case "2":
                        // Find by title
                        ShowContentByTitle();
                        break;
                    case "3":
                        // Add new
                        CreateNewContent();
                        break;
                    case "4":
                        RemoveContentFromList();
                        // Remove
                        break;
                    case "5":
                        // Exit
                        continueToRun = false;
                        break;
                    default:
                        _console.WriteLine("Please enter a valid number between 1 and 5. \n" +
                            "Press any key to continue...");
                        _console.ReadKey();
                        break;
                }
            }
        }

        private void CreateNewContent()
        {
            _console.Clear();
            StreamingContent content = new StreamingContent();
            // title
            _console.WriteLine("Please enter the title of the content: ");
            content.Title = _console.ReadLine();

            // description
            _console.WriteLine("Please enter the description: ");
            content.Description = _console.ReadLine();

            // MaturityRating
            _console.WriteLine("Select a Maturity Rating: \n" +
                "1) G\n" +
                "2) PG \n" +
                "3) PG-13 \n" +
                "4) R \n" +
                "5) NC-17 \n" +
                "6) TV-MA"
                );
            string maturityString = _console.ReadLine();
            switch (maturityString)
            {
                case "1":
                    content.MaturityRating = MaturityRating.G;
                    break;
                case "2":
                    content.MaturityRating = MaturityRating.PG;
                    break;
                case "3":
                    content.MaturityRating = MaturityRating.PG_13;
                    break;
                case "4":
                    content.MaturityRating = MaturityRating.R;
                    break;
                case "5":
                    content.MaturityRating = MaturityRating.NC_17;
                    break;
                case "6":
                    content.MaturityRating = MaturityRating.TV_MA;
                    break;
            }
            // StarRating
            _console.WriteLine("Please enter the star-rating (1-5): ");
            content.StarRating = int.Parse(_console.ReadLine());             // int.Parse converts a string to an integer
            // type of genre
            _console.WriteLine("Select a Genre: \n" +
                "1) Horror \n" +
                "2) SciFi \n" +
                "3) Drama \n" +
                "4) Action \n" +
                "5) Comedy \n" +
                "6) Anime \n" +
                "7) Documentary \n" +
                "8) Thriller \n" +
                "9) Romance"
                );
            string genreInput = _console.ReadLine();
            int genreID = int.Parse(genreInput);
            content.TypeOfGenre = (GenreType)genreID;  // casting : what you want to be is inside the parantheses and what you are starting with is to the right
            _streamingRepo.AddContentToDirectory(content);

        }

        private void ShowAllContent()
        {
            _console.Clear();
            List<StreamingContent> listOfContent = _streamingRepo.GetContents();

            foreach(StreamingContent contentVariable in listOfContent)
            {
                DisplayContent(contentVariable);
            }
            _console.WriteLine("Press any key to continue...");
            _console.ReadKey();
        }

        private void ShowContentByTitle()
        {
            _console.Clear();
            _console.WriteLine("Enter a title");
            string title = _console.ReadLine();
            StreamingContent foundTitle = _streamingRepo.GetContentByTitle(title);

            if(foundTitle != null)
            {
                DisplayContent(foundTitle);
            }
            else
            {
                _console.WriteLine("Invalid title. Could not find any results.");
            }
            _console.WriteLine("Press any key to continue");
            _console.ReadKey();
        }

        private void RemoveContentFromList()
        {
            _console.WriteLine("Which item would you like to remove?");
            List<StreamingContent> contentList = _streamingRepo.GetContents();

            int count = 0;

            foreach(StreamingContent content in contentList)
            {
                count++;
                _console.WriteLine($"{count}. {content.Title}");
            }

            int targetContentID = int.Parse(_console.ReadLine());
            int targetIndex = targetContentID - 1;

            if(targetIndex >= 0 && targetIndex < contentList.Count)
            {
                StreamingContent desiredContent = contentList[targetIndex];
                if (_streamingRepo.DeleteExistingContent(desiredContent))
                {
                    _console.WriteLine($"{desiredContent.Title} successfully removed.");
                }
                else
                {
                    _console.WriteLine("I'm sorry. I'm afraid I can't do that.");
                }
            }
            else
            {
                _console.WriteLine("No content has that ID");
            }
            _console.WriteLine("Press any key to continue...");
            _console.ReadKey();
        }

        private void DisplayContent(StreamingContent content)
        {
            _console.WriteLine($"Title: {content.Title} \n" +
                $"Description: {content.Description} \n" +
                $"Genre: {content.TypeOfGenre} \n" +
                $"StarRating: {content.StarRating} \n" +
                $"Family Friendly: {content.IsFamilyFriendly} \n" +
                $"MaturityRating: {content.MaturityRating} \n");
        }

        private void SeedContentList()
        {
            StreamingContent movieOne = new StreamingContent("Ferris Bueller's Day Off", "Cool guy ditches school for a fun day on the town", MaturityRating.PG_13, 5, GenreType.Comedy);
            StreamingContent movieTwo = new StreamingContent("Airbud", "Dog plays basketball", MaturityRating.G, 3, GenreType.Thriller);

            _streamingRepo.AddContentToDirectory(movieOne);
            _streamingRepo.AddContentToDirectory(movieTwo);
        }
    }
}
