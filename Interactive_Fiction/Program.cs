using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interactive_Fiction
{
	class Program
	{
		static char[] splits = {';'};
		static string[] story = new string[11];
		static bool gameOver = false;
		static int currentpage;
		static string plot;
		static string option;
		static string choice1;
		static string choice2;
		static int Parse1;
		static int Parse2;
		static string playerInput;
		
		static void Main(string[] args)
		{
			GameLoop();
		}

		static void GameLoop()
		{
			while (gameOver == false)
			{
				Story();
				PageSplit();
				PlayerInput();
				Story();
				PageSplit();
				PlayerInput();
			}
			/*if (userInput == Choice(story[]))
			{ }*/
		}

		static void Story()
		{
			// this is what the contents number changes to 
			//                        ↓
			story[0] = "Title;Options;0;10";
			story[1] = "Test1;option;1;9";
			story[2] = "Test2;option;2;8";
			story[3] = "Test3;option;3;7";
			story[4] = "Test4;option;4;6";
			story[5] = "Test5;option;5;5";
			story[6] = "Test6;option;6;4";
			story[7] = "Test7;option;7;3";
			story[8] = "Test8;option;8;2";
			story[9] = "Test9;option;9;1";
			story[10] = "Test10;option;10;0";
		}

		static void PageSplit()
		{
			string[] contents = story[currentpage].Split(';');

			plot = contents[0];
			option = contents[1];
			choice1 = contents[2];
			choice2 = contents[3];
			Console.WriteLine(plot);
			Console.WriteLine(option);
			Console.WriteLine(choice1);
			Console.WriteLine(choice2);

			//everytime the user inputs a or b the number changes depenin f on what number a and b are (contents [1] < this number
			Parse1 = int.Parse(contents[2]);
			Parse2 = int.Parse(contents[3]);
		}

		static void PlayerInput()
		{
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

	}

}
