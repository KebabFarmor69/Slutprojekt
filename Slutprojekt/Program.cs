using System;
using System.Collections.Generic;

namespace Slutprojekt
{
    class Program
    {

        //lista array för playeritems
        static List<string> playerItems = new List<string>();

        static void Main(string[] args)
        {


            //loop för att lätt kunna starta om spelet.
            //bool är en variabel som endast kan vara sann eller falsk, datatyp är bool
            bool restart = true;
            while (restart)
            {
                Console.Clear();

                System.Console.WriteLine("Survival");
                System.Console.WriteLine("How long will you survive?");

                System.Console.WriteLine("\n--------------------------------------------------------------------------------------------------------------------\n");

                //anropar IntroText metoden
                string introData = IntroText();

                System.Console.WriteLine("\n--------------------------------------------------------------------------------------------------------------------\n");

                System.Console.WriteLine("\nI look out the window. We are close now. I let out a lonely tear. Hopefully i will survive.");
                System.Console.WriteLine("\n\nShould i brace for impact? y/n");

                //variabel för svar, ToLower för att göra så svaret inte är uppercase
                string answer = Console.ReadLine().ToLower();

                if (answer == "y" || answer == "ye" || answer == "yes")
                {

                    //ropar in metod
                    SurvivedIntro(introData);

                }

                else
                {
                    System.Console.WriteLine("\nI wipe the tear away. Fuck it, I've always wanted to die anyways. I knew this... BOOM!");
                    System.Console.WriteLine("\n\nYou Died.");
                }






                System.Console.WriteLine("Press ENTER to play again.\n\nPress ESC to quit.");

                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    restart = false;
                }

            }
        }
        //organisering - att lägga koden här, (story-texten) gör så att det ser finare ut.
        #region txt functions 
        static string IntroText() //metod
        {

            System.Console.WriteLine("\nI was always scared of planes. The way they sound, bumps and especially all the people aboard. \nI don't like people. Unpredictable in movements, actions and emotions. \nThe woman next to me looks:");

            string lady = Console.ReadLine();

            System.Console.WriteLine("Yeah she definitely looks " + lady + ".");

            System.Console.WriteLine("\n--------------------------------------------------------------------------------------------------------------------\n");

            System.Console.WriteLine("Suddenly, the plane starts to shake. Through the speakers i hear \n-Hello passengers. We are experiencing some turbulence but it should soon be over, Thank you for your patience.- \nPhew I think to myself, I hate turbulence.");
            System.Console.WriteLine("\nBOOM! The cabin goes quiet. I can hear my breath shaking. \nThe " + lady + " lady looks at me and asks \n-What was that?- \nWithout controlling it I barely say \n-I don't know- \nwhen the seatbelt icon lights up.");
            System.Console.WriteLine("\nWhen people start to realise whats about to happen I feel my stomache drop. \nOh no. \nThe plane drops in altitude and the flightattendants shouts \n-Brace for impact everyone!- \nNow, people realise what's about to happen. \nI hear screams, shouts, cries for help. \nThe lady next to me has passed out.");

            return lady;
        }

        //string ladyParsed är en parameter
        static void SurvivedIntro(string ladyParsed) //metod
        {
            System.Console.WriteLine("\n--------------------------------------------------------------------------------------------------------------------\n");
            System.Console.WriteLine("The sun blinds me as I open my eyes. I hear the wind blow through the trees and the birds chirp. I look around.\nI try to stand up but my left foot hurts like hell.");
            System.Console.WriteLine("Damn, I realise what had happened when i see the plane shattered about 10 metres away. \nHow did I survive that? Beside me lies the " + ladyParsed + " lady.");
            System.Console.WriteLine("I think she's dead. In the grass I see an axe. Should I pick it up? y/n");
            System.Console.WriteLine("\n--------------------------------------------------------------------------------------------------------------------\n");

            string answer = Console.ReadLine();

            if (answer == "y" || answer == "ye" || answer == "yes")
            {
                System.Console.WriteLine("I pick up the axe.");
                //lägger till axe i listan
                playerItems.Add("Axe");

                System.Console.WriteLine("I go down from the plane i find some rocks. I pick them up.");
                //lägger till rocks i listan
                playerItems.Add("Rocks");

                System.Console.WriteLine("\n--------------------------------------------------Player--Items-----------------------------------------------------");

                //tar varje element i listan och skriver det
                foreach (var item in playerItems)
                {
                    System.Console.WriteLine(item + " ");
                }

                System.Console.WriteLine("--------------------------------------------------------------------------------------------------------------------\n");

            }

        }
        #endregion
    }
}

