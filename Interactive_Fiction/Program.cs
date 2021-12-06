using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Interactive_Fiction
{
	class Program
	{
		static char[] splits = { ';' };
		static string[] story = new string[13];
		static string[] contents;
		static bool gameOver = false;
		static int currentpage;
		static string plot;
		static string option1;
		static string option2;
		static string choice1;
		static string choice2;
		static int Parse1;
		static int Parse2;
		static string playerInput;
		static string StoryFile = "Story.txt";

		static void Main(string[] args)
		{
			GameLoop();
		}

		static void Story()
		{
			story = File.ReadAllLines(StoryFile);
		}

		static void PageSplit()
		{
			contents = story[currentpage].Split(';');

			plot = contents[0];
			option1 = contents[1];
			option2 = contents[2];
			choice1 = contents[3];
			choice2 = contents[4];
			Console.WriteLine(plot);
			Console.WriteLine(option1);
			Console.WriteLine(option2);
			//Console.WriteLine(choice1);

			//everytime the user inputs a or b the number changes depening on what number a and b are (contents [1] < this number
		}

		static void PlayerInput()
		{
			Parse1 = int.Parse(contents[3]);
			Parse2 = int.Parse(contents[4]);
			
			//Parse is turning a string into a number so a = 1 b = 9 or 4, etc.
			//parse uses user input to determine the number like a or b will change into one of the two numbers specified 
			//switch case is used for a if/else statment when you want to test and there are 3 or more options
			//switch statment needs to match, so playerInput is a which will mean current page = whatever a is 
			playerInput = Console.ReadLine();
			switch (playerInput)
			{
				case "a":
					currentpage = Parse1;
					break;

				case "b":
					currentpage = Parse2;
					break;
			}

		}



		static void GameLoop()
		{
			while (gameOver == false)
			{
				Story();
				PageSplit();
				PlayerInput();
				Console.Clear();
				if (currentpage == 11)
				{
					gameOver = true;
				}
				if (gameOver == true)
				{
					break;
				}
			}
			/*if (userInput == Choice(story[]))
			{ }*/
		}

	}

}
