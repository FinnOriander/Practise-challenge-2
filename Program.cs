using System;

namespace PracticChallenge2
{
    class Program
    {
        static void Main(string[] args)
        {
        {
            string[] menuItem = new string[6];
            menuItem[0] = "1. Create New Deck";
            menuItem[1] = "2. Shuffle Deck";
            menuItem[2] = "3. Deal New Hand";
            menuItem[3] = "4. Display Hand Total Points";
            menuItem[4] = "5. Exit";
            Console.WriteLine("Please select an option:");
            Console.WriteLine("------------------------");
            Console.WriteLine(menuItem[0]);
            Console.WriteLine(menuItem[1]);
            Console.WriteLine(menuItem[2]);
            Console.WriteLine(menuItem[3]);
            Console.WriteLine(menuItem[4]);

            string Selection = Console.ReadLine();
            
            if(Selection == "1"){
                CreateNDeck();
            }

            if(Selection == "2"){
                SDeck();
            }

             if(Selection == "3"){
                DealNHand();
            }

             if(Selection == "4"){
                HandPoints();
            }

             if(Selection == "5"){
                Exit();
            }
        }
    }
}
