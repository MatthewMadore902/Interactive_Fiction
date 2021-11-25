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
			story[0] = "Title;Options;2;3";
			story[1] = "Test1;option;4;3";
			//string[] page = story[1].Split(splits);
			story[2] = "Test2;option;2;3";
			story[3] = "Test3;option;2;3";
			story[4] = "Test4;option;3;3";
			story[5] = "Test5;option;2;3";
			story[6] = "Test6; option; 2; 3";
			story[7] = "Test7;option;2;3";
			story[8] = "Test8;option;2;3";
			story[9] = "Test9;option;2;3";
			story[10] = "Test10;option;2;3";

			//Console.WriteLine(story[1]);
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

			Parse1 = int.Parse(contents[2]);
			Parse2 = int.Parse(contents[3]);
		}

		/*static void Choice(string[] story)
		  {
			  if (story[1] == userInput)
			  {
				  if (userInput == "A")
				  {
					  Console.WriteLine(story[2]);
					  Console.ReadKey();
				  }
				  if (userInput == "B")
				  {

				  }
			  }
		  }*/

		static void PlayerInput()
		{
		
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
