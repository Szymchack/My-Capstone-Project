using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCapstoneProject
{
    class Program
    {
        static void Main(string[] args)

        // **************************************************
        //
        // Title: My Capstone Project
        // Description: Class, keeping track of horses in stables
        // Application Type: Console
        // Author: (CathyAnn Szymchack)
        // Dated Created: December 1, 2018
        // Last Modified: December 9,2018
        //
        // **************************************************
        {
            DisplayOpeningScreen();
            DisplayMenu();
            DisplayClosingScreen();
        }


        /// <summary>
        /// display opening screen
        /// </summary>
        static void DisplayOpeningScreen()
        {
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("\t\tWelcome to CathyAnn's Stables: Where there is no horsing around");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        static StableHorse InitializeStableHorsePosha(string name)
        {
            StableHorse Posha = new StableHorse("Posha");
            Posha.Weight = 2.5;
            Posha.canUseSideSaddle = true;
            Posha.CurrentEmotionalState = StableHorse.EmotionalState.Happy;
            Posha.HomeStable = "The European, stall 2";

            return Posha;
        }

        static StableHorse InitializeStableHorseEinstein(string name)
        {
            StableHorse Einstein = new StableHorse("Einstein");
            Einstein.Weight = 1.2;
            Einstein.canUseSideSaddle = true;
            Einstein.CurrentEmotionalState = StableHorse.EmotionalState.Nervous;
            Einstein.HomeStable = "The BrainTrust, stall 15";

            return Einstein;
        }

        static void DisplayStableHorseInfo(List<StableHorse> stableHorses)
        {
            string StableHorseName;
            StableHorseName = Console.ReadLine();
            DisplayHeader("Display All Horse Info");

            //
            //display list of stable horses
            //

            foreach (StableHorse StableHorse in stableHorses)
            {
                Console.WriteLine(StableHorse.Name);
            }

            Console.WriteLine();
            Console.Write("Enter the Name of the New Horse:");
            StableHorseName = Console.ReadLine();

            DisplayContinuePrompt();

            //
            // Get Stable Horse from list
            //

            bool horseFound = false;

            foreach (StableHorse StableHorse in stableHorses)
            {
                if (StableHorse.Name == StableHorseName)
                {
                    Console.WriteLine(StableHorse.Name);
                    Console.WriteLine(StableHorse.Weight);
                    Console.WriteLine(StableHorse.canUseSideSaddle);
                    Console.WriteLine(StableHorse.CurrentEmotionalState);
                    Console.WriteLine(StableHorse.HomeStable);
                    horseFound = true;
                    break;
                }
                //
                // Feedback - horse not found
                //
                if (!horseFound)
                {
                    Console.WriteLine("Unable to Locate Your Horse");
                }


                DisplayContinuePrompt();

            }

        }

        static void DisplayDeleteStableHorseInfo(List<StableHorse> stableHorses)
        {
            StableHorse userStableHorse = new StableHorse();
            string StableHorseName;

            DisplayHeader("Delete Sea Monsters Info");

            //
            //display list of stable horses names
            //

            foreach (StableHorse stableHorse in stableHorses)
            {
                Console.WriteLine(stableHorse.Name);
            }

            Console.WriteLine();
            Console.Write("Enter Name:");
            StableHorseName = Console.ReadLine();

            DisplayContinuePrompt();

            //
            // Get Seamonster from list
            //

            bool horseFound = false;

            foreach (StableHorse StableHorse in stableHorses)
            {
                if (StableHorse.Name == StableHorse.Name)
                {
                    stableHorses.Remove(StableHorse);
                    horseFound = true;
                    break;
                }
                
            }
            if (!horseFound)
            {
                Console.WriteLine("Unable to Locate Your Horse");
            }
            DisplayContinuePrompt();
        }


        static void DisplayAllStableHorses(List<StableHorse> stableHorses)
        {
            DisplayHeader("List of Stable Horses");

            foreach (StableHorse stableHorse in stableHorses)
            {
                Console.WriteLine(stableHorse.Name);
            }

            DisplayContinuePrompt();
        }

        static void DisplayGetUserStableHorse(List<StableHorse> stableHorse)
        {
            //
            // create (instantieate) a new Stable Horse 
            //

            StableHorse newstableHorse = new StableHorse();

            DisplayHeader("Add a Stable Horse");
            //

            Console.Write("Enter Name:");
            newstableHorse.Name = Console.ReadLine();
            Console.Write("Enter Weight:");
            double.TryParse(Console.ReadLine(), out double weight);
            newstableHorse.Weight = weight;
            Console.Write("Can Use A SideSaddle:");
            if (Console.ReadLine().ToUpper() == "YES")
            {
                newstableHorse.canUseSideSaddle = true;
            }
            else
            {
                newstableHorse.canUseSideSaddle = false;
            }

            Console.Write("Enter Horses Mind State at new home.");
            Enum.TryParse(Console.ReadLine(), out StableHorse.EmotionalState emotionalState);
            newstableHorse.CurrentEmotionalState = emotionalState;
            Console.Write("Enter Home Stable");
            newstableHorse.HomeStable = Console.ReadLine();

            //
            // add new stable horse to list
            //
            stableHorse.Add(newstableHorse);

            DisplayContinuePrompt();

            
        }

        static void DisplayMenu()
        {
            //
            // instantiate stable horses
            //

            StableHorse Posha = new StableHorse();
            Posha = InitializeStableHorsePosha("Posha");
            StableHorse Einstein = new StableHorse();
            Einstein = InitializeStableHorseEinstein("Einstein");
        
           

            //
            // add horse to stable list
            //

            List<StableHorse> StableHorse = new List<StableHorse>();
            StableHorse.Add(Einstein);
            StableHorse.Add(Posha);

            

            string menuChoice;
            bool exiting = false;

            while (!exiting)
            {
                DisplayHeader("Main Menu");

                Console.WriteLine("\tA) Display All Stable Horses");
                Console.WriteLine("\tB) Add a new horse to the stable");
                Console.WriteLine("\tC) Stable Horse Info");
                Console.WriteLine("\tE) Delete a Stable Horse ");
                Console.WriteLine("\tF) Exit");

                Console.Write("Enter Choice:");
                menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "A":
                    case "a":
                        DisplayAllStableHorses(StableHorse);

                        break;

                    case "B":
                    case "b":
                        DisplayGetUserStableHorse(StableHorse);

                        break;

                    case "C":
                    case "c":
                        DisplayStableHorseInfo(StableHorse);
                        break;

                    case "D":
                    case "d":
                        DisplayDeleteStableHorseInfo(StableHorse);
                        break;

                    case "E":
                    case "e":

                        break;

                    case "F":
                    case "f":
                        exiting = true;
                        break;

                    default:
                        break;
                }
            }
        }

       

        /// <summary>
        /// display closing screen
        /// </summary>
        static void DisplayClosingScreen()
        {
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("\t\tThanks for visiting Skylark Horse Farms.");
            Console.WriteLine();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        /// <summary>
        /// display continue prompt
        /// </summary>
        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        /// <summary>
        /// display header
        /// </summary>
        static void DisplayHeader(string headerTitle)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t" + headerTitle);
            Console.WriteLine();
        }
    }
}