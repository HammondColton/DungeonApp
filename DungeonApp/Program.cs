using DungeonLibrary;
namespace DungeonApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Title/Introduction
            Console.WriteLine("Hello and Welcome to the MASTER DUNGEON!!");
            #endregion

            //todo Create a player

            //Game loop:
            bool exit = false;
            do
            {
                //todo generate a room
                //todo generate a monster in the room

                //Encounter loop:
                bool reload = false;//reload = true to "reload" a room and a monster
                do
                {
                    #region Menu
                    //prompt the user:
                    Console.Write("\nPlease choose an action:\n" +
                                  "A) Attack\n" +
                                  "R) Run away\n" +
                                  "P) Player Info\n" +
                                  "M) Monster Info\n" +
                                  "X) Exit\n");
                    //Capture user's menu selection
                    string menuSelection = Console.ReadKey(true).Key.ToString();//Executes upon input without hitting enter
                    //Clear the console AFTER user input
                    Console.Clear();

                    //using branching logic to act upon the user's menu selection
                    switch (menuSelection)
                    {
                        case "A":
                            Console.WriteLine("Combat!");
                            //put combat functionality here
                            break;

                        case "R":
                            Console.WriteLine("Run Away!");
                            //put free monster attack here
                            //get a new monster and a new room:
                            reload = true;
                            break;

                        case "P":
                            Console.WriteLine("Player Info");
                            //print player info here
                            break;

                        case "M":
                            Console.WriteLine("Monster Info");
                            //print monster info here
                            break;

                        case "X":                            
                        case "E":
                            Console.WriteLine("No one likes a quitter...");
                            //exit both loops
                            exit = true;
                            break;
                        default:
                            //invalid input.
                            break;
                    }
                    #endregion
                } while (!reload && !exit);
                //if exit = true, both loops will terminate.
                //If reload = true, only the inner loop will terminate.
            } while (!exit); //exit == false
            //handle exit messages and stuff
        }
    }
}