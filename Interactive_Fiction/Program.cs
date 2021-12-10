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
		static string saveGame;
		static string quit;
		static int Parse1;
		static int Parse2;
		static int Parse3;
		static int Parse4;
		static ConsoleKey playerInput;
		static string StoryFile = "Story.txt";
		static int Save = 1;
		static string saveData;
		static int savedPage = 0;

		static void Main(string[] args)
		{
			StartingMenu();
			RunGame();
		}

		static void Story()
		{
			story = File.ReadAllLines(StoryFile);
			PageSplit();
		}

		static void PageSplit()
		{
			contents = story[currentpage].Split(';');

			plot = contents[0];
			choice1 = contents[1];
			choice2 = contents[2];
			saveGame = contents[3];
			quit = contents[4];
/*			choice1 = contents[5];
			choice2 = contents[6];*/
			Console.WriteLine(plot);
			//Console.WriteLine(option1);
			//Console.WriteLine(option2);
			//Console.WriteLine(choice1);

			//everytime the user inputs a or b the number changes depening on what number a and b are (contents [1] < this number
		}

		static void ReadPlayerInput()
		{

			//Parse is turning a string into a number so a = 1 b = 9 or 4, etc.
			//parse uses user input to determine the number like a or b will change into one of the two numbers specified 
			//switch case is used for a if/else statment when you want to test and there are 3 or more options
			//switch statment needs to match, so playerInput is a which will mean current page = whatever a is 
			//playerInput = Console.ReadKey();
			if (playerInput == ConsoleKey.A)
			{
				Parse1 = int.Parse(contents[1]);
			}
			if (playerInput == ConsoleKey.B)
			{
				Parse2 = int.Parse(contents[2]);
			}
			if (playerInput == ConsoleKey.C)
			{
				Parse3 = int.Parse(contents[3]);
			}
			if (playerInput == ConsoleKey.D)
			{
				Parse4 = int.Parse(contents[4]);
			}

			
/*			switch (playerInput)
			{
				case "a":
					currentpage = Parse1;
					break;

				case "b":
					currentpage = Parse2;
					break;
				case "c":
					CheckIfSaved();
					SaveFile();
					currentpage = Parse3;
					break;
			}*/


		}
		static void CheckIfSaved()
		{
			if (Save == 0 && currentpage != 0 && currentpage != 1)
			{
				Console.WriteLine("There still is a active save file");
			}
			if (File.Exists("SaveFile.txt") && Save >= 1 && currentpage != 0 && currentpage != 1)
			{
				SaveFile();
			}
			if (currentpage == 1 || currentpage == 0)
			{
				Console.WriteLine("You can't Save ");
			}

		}
		static void StartingMenu()
		{
			Console.WriteLine("                                                                        ");
			Console.WriteLine("  ║   ║ ╔╗      ║  ║   ║  ╔╗      ║  ╔═══╗   ║           ║   ╔╗      ║  ");
			Console.WriteLine("  ║   ║ ║ ║     ║  ║  ║   ║ ║     ║  ║   ║   ║           ║   ║ ║     ║  ");
			Console.WriteLine("  ║   ║ ║  ║    ║  ║ ║    ║  ║    ║  ║   ║    ║    ║    ║    ║  ║    ║  ");
			Console.WriteLine("  ║   ║ ║   ║   ║  ╠╣     ║   ║   ║  ║   ║    ║   ║ ║   ║    ║   ║   ║  ");
			Console.WriteLine("  ║   ║ ║    ║  ║  ║ ║    ║    ║  ║  ║   ║     ║ ║   ║ ║     ║    ║  ║  ");
			Console.WriteLine("  ║   ║ ║     ║ ║  ║  ║   ║     ║ ║  ║   ║     ║ ║   ║ ║     ║     ║ ║  ");
			Console.WriteLine("  ╚═══╝ ║       ╝  ║   ║  ║      ╝   ╚═══╝      ║     ║      ║       ╝  ");
			Console.WriteLine("                                                                        ");

			Console.WriteLine("A) START NEW GAME?");
			Console.WriteLine("A) Load");
			Console.WriteLine("C) Options");
			Console.WriteLine("D) QUIT");
			if (playerInput == ConsoleKey.A)
			{
				Parse1 = int.Parse(contents[1]);
			}
			if (playerInput == ConsoleKey.B)
			{
				Parse2 = int.Parse(contents[2]);
			}
			if (playerInput == ConsoleKey.C)
			{
				Parse3 = int.Parse(contents[3]);
			}
			if (playerInput == ConsoleKey.D)
			{
				Parse4 = int.Parse(contents[4]);
			}
			gameOver = false;
		}

		static void CheckDeath()
		{
			if (story[currentpage].Contains("Died") || story[currentpage].Contains("Passed"))
			{
				gameOver = true;
				GameOver();
				Console.ReadKey();
				Console.Clear();
			}
		}
		static void SaveFile()
		{
			using (StreamWriter sd = new StreamWriter("SaveFile.txt"))
			{
				Save = currentpage;
				sd.WriteLine(currentpage.ToString());
				sd.WriteLine(Save.ToString());
				sd.WriteLine(File.GetLastWriteTime("SaveFile.txt"));
				Console.WriteLine("You Hvae Saved The Game!!!!");
			}
		}
		static void Load()
		{
			using (StreamReader rf = new StreamReader("SaveFile.txt"))
			{
				saveData = rf.ReadLine();
				int.TryParse(saveData, out currentpage);
				//saveData = int.TryParse(Save, out currentpage);
				if (currentpage == 0)
				{
					Console.WriteLine("");
					Console.WriteLine("No Save Data Found");
					Console.WriteLine("");
				}
			}
		}
		static void GameOver()
		{
			Console.WriteLine("  _____         /█       |█        /|    ________        _______                     _________      _______ ");
			Console.WriteLine(" /             /  █      | █      / |   /               /       █    █              /              /       █ ");
			Console.WriteLine("|             /    █     |  █    /  |   |              |         |    █          /  |             |        █ ");
			Console.WriteLine("|      __    /      █    |   █  /   |   |              |         |     █        /   |             |________/ ");
			Console.WriteLine("|       |   /________█   |    █/    |   |========      |         |      █      /    |=========    |    █    "); 
			Console.WriteLine("╚______/   /          █  |              |              |         |       █    /     |             |     █   ");
			Console.WriteLine("                                        ╚_________     |         |        █  /      ╚_________    |      █  ");
			Console.WriteLine("                                                       ╚_________/         █/                     |       █  ");
			gameOver = true;
		}
		static void RunGame()
		{
			while (gameOver == false)
			{
				StartingMenu();
				Story();
				ReadPlayerInput();
				Console.Clear();
				CheckDeath();
				if (gameOver == true)
				{
					Console.ReadKey();
					StartingMenu();
				}
			}
			/*if (userInput == Choice(story[]))
			{ }*/
		}

	}

}
