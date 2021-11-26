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
		static string[] story = new string[12];
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

		static void Story()
		{
			// this is what the contents number changes to 
			//                               ↓  ↓
			story[0] = "start?;A) yes ;B) no;1;11";
			story[1] = "You wake up in the middle of no where unable to recall how you got there and who YOU are!!, all around you are trees \nand bushes, you see a path what do you do?;A) Take the path;B) I don't trust the path I'll take an alternate rout;2;10";
			story[2] = "You decide to take the path, why you don't know it feels like the right decision,Right?,After walking the path for \nsometime you see a shack;A) Go inside the shack;B) Keep walking the path;3;4";
			story[3] = "The shack was enpty except for a book you get a odd headache while reading so you decide to set it down now \nyou don't know what to do while your here;A) Keep looking around the shack;B) Leave and follow the path once again;5;4";
			story[4] = "After walking for some time you begine to feel weak from all the walking you've ben doing;A) Take a rest? ;B) Push onwards;6;7";
			story[5] = "After looking around the shack for a while you find a stash hidden in the floor boards, full of food and water \nplus a note, writen on the note is a name, a familiar name but nothing comes to mind;A) take the food and water and leave;B) Hunker down and rest;7;6";
			story[6] = "After a while of resting, a shiver down your spine jolts you awake, a man standing inches away from your face, \njust standing, just staring, he says nothing, backs away and continues his journey without a word from either of you;A) Follow him;B) wait a bit before heading out again;7;8";
			story[7] = "After a extremely long time of walking you have a thought that higher ground would help you to see if you \nreconize the area or any surrounding locations;A) Follow your gut and get higher ground;B) Continue on the path;10;9";
			story[8] = "After waiting for the creepy man to get a good distance ahead not wanting to run into him again you decide \nto continue on your journey ;A) Follow the path you oringinally were following;B) take a alternate rout through the forest;9;10";
			story[9] = "After following the path for what feels like a eternity you, a man comes out of the bushs and shanks you, \nyou immediately bleed out Ending in your death;A) Restart?;B) Quit?;0;11";
			story[10] = "After hiking up the steep hill of a mix of rocks and moss you reach the top, you see a village in the \ndistance thinking about finally getting some answers you start to run, \nforgetting your on a steep hill, you fall and substain serious injuries, unable to talk or move you perish;A) Restart?;B) Quit ;0;11";
			story[11] = "Quit Coming soon!!!!;More story and detail coming later!!!!!;Hit enter again;0;0";
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
			//Console.WriteLine(choice2);

			//everytime the user inputs a or b the number changes depenin f on what number a and b are (contents [1] < this number
			Parse1 = int.Parse(contents[3]);
			Parse2 = int.Parse(contents[4]);
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

		static void Title()
		{
			Console.WriteLine("UNKNOWN");
			Console.WriteLine("");
		}

		static void GameLoop()
		{
			Title();
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
