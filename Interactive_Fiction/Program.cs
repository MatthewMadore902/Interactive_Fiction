using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interactive_Fiction
{
	class Program
	{
		static string[] story = new string[11];
		
		static void Main(string[] args)
		{
			Pages();
			Console.WriteLine(story[1]);
			Console.ReadKey();
		}

		static void GameLoop()
		{
			
		}

		static void Pages()
		{
			string userInput = Console.ReadLine();

			story[0] = "Title Screen";
			story[1] = "Page 1, You wake up in the middle of no where unsure how or why you're here,as you start to regan you ability to stand you begin to analysis your suroundings all old dead tree's and a few boulders,you find an old hatchet beside you";
			//string[] page = story[1].Split(' ');
			story[2] = "Page 2";
			story[3] = "Page 3";
			story[4] = "Page 4";
			story[5] = "Page 5";
			story[6] = "Page 6";
			story[7] = "Page 7";
			story[8] = "Page 8";
			story[9] = "Page 9";
			story[10] = "Page 10";


		}


		



		static void Choice()
		{
			
		}
	}

}
