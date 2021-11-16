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
		static string userInput = Console.ReadLine();
		
		static void Main(string[] args)
		{
			Pages();
			//Console.WriteLine(story[1]);
			Console.ReadKey();
			Console.ReadLine();
			Pages();

		}

		static void GameLoop()
		{
			string userInput = Console.ReadLine();

			while (gameOver == false)
			{

			}
			/*if (userInput == Choice(story[]))
			{ }*/
		}

		static void Pages()
		{
		

			story[0] = "Title Screen";
			story[1] = "Page 1,You wake up in the middle of no where unsure how or why you're here, as you start to regan you ability to stand;you begin to analysis your suroundings all old dead tree's and a few boulders.;2;3";
			//string[] page = story[1].Split(splits);
			story[2] = "Page 2";
			story[3] = "Page 3";
			story[4] = "Page 4";
			story[5] = "Page 5";
			story[6] = "Page 6";
			story[7] = "Page 7";
			story[8] = "Page 8";
			story[9] = "Page 9";
			story[10] = "Page 10";

			Console.WriteLine(story[1]);
		}


		



		static void Choice(string[] story)
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
		}
	}

}
