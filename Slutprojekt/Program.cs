using System;

namespace Slutprojekt
{
    class Program
    {
        static void Main(string[] args)
        {


            System.Console.WriteLine("Survival");
            System.Console.WriteLine("How long will you survive?");

            System.Console.WriteLine("\n--------------------------------------------------------------------------------------------------------------------\n");

            System.Console.WriteLine("\nI was always scared of planes. The way they sound, bumps and espacially all the people aboard. \nI don't like people. Unpredictable in movements, actions and emotions. \nThe woman next to me looks:");

            string lady = Console.ReadLine();

            System.Console.WriteLine("Yeah she deffinitly looks " + lady + ".");

            System.Console.WriteLine("\n--------------------------------------------------------------------------------------------------------------------\n");

            System.Console.WriteLine("Suddenly, the plane starts to shake. Through the speakers i hear \n-Hello passengers. We are experiencing some turbulence but it should soon be over, Thank you for your patioence.- \nPhew I think to mysielf, I hate turbulence.");
            System.Console.WriteLine("\nBOOM! The cabin goes quiet. I can hear my breath shaking. \nThe " + lady + " lady looks at me and asks \n-What was that?- \nWithout controlling it I barely say \n-I don't know- \nwhen the seatbelt icon lights up.");
            System.Console.WriteLine("\nWhen people start to realise whats about to happen I feel my stomache drop. \nOh no. \nThe plane drops in alltitude and the flightattendants shouts \n-Brace for impact everyone!- \nNow, people realise what's about to happen. \nI hear screams, shouts, cries for help. \nThe lady next to me has passed out.");

            System.Console.WriteLine("\n--------------------------------------------------------------------------------------------------------------------\n");

            System.Console.WriteLine("\nI look out the window. We are close now. I let out a lonely tear. Hopefully i will survive.");
            System.Console.WriteLine("\n\nShould i brace for impact? y/n");

            string answer1 = Console.ReadLine().ToLower();

            if (answer1 == "y")
            {



            }

            else
            {
                System.Console.WriteLine("\nI wipe the tear away. I knew this... BOOM!");
                System.Console.WriteLine("\n\nYou Died.");
            }








            Console.ReadLine();
        }
    }
}
