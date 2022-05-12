using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.ComponentModel;

namespace ProblematicProblem
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            bool cont;

            List<string> activities = new List<string>() { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };


            Console.Write("Hello, welcome to the random activity generator! \nWould you like to generate a random activity? yes/no: ");
            string answer = Console.ReadLine();
            //var result = TrueOrFalse(answer);
            if (answer.ToLower() == "yes")
            {
                cont = true;
            }
            else
            {
                return;
            }

            Console.WriteLine();

            Console.Write("We are going to need your information first! What is your name? ");
            string userName = Console.ReadLine();
            Console.WriteLine();

            Console.Write("What is your age? ");
            int userAge = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Would you like to see the current list of activities? Sure/No thanks: ");

            bool seeList = Console.ReadLine().ToLower() == "sure" ? true : false;

            if (seeList)
            {
                foreach (string activity in activities)
                {
                    Console.Write($"{activity} ");
                    Thread.Sleep(50);
                }
            }
            Console.WriteLine();

            Console.Write("Would you like to add any activities before we generate one? yes/no: ");
            bool addToList = Console.ReadLine().ToLower() == "yes" ? true : false;

            Console.WriteLine();

            do
            {
                if (addToList == true)
                {
                    Console.Write("What would you like to add? ");
                    string userAddition = Console.ReadLine();
                    activities.Add(userAddition);
                    foreach (string activity in activities)
                    {
                        Console.Write($"{activity} ");
                        Thread.Sleep(50);
                    }
                }
                else
                {
                    break;
                }
                Console.WriteLine();
                Console.WriteLine("Would you like to add more? yes/no: ");
                addToList = Console.ReadLine().ToLower() == "yes" ? true : false;

            }
            while (addToList);

            Console.WriteLine();

            while (cont)
            {
                Console.Write("Connecting to the database");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(50);
                }
                Console.WriteLine();

                Console.Write("Choosing your random activity");
                for (int i = 0; i < 9; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(100);
                }
                Console.WriteLine();

                int randomNumber = rng.Next(activities.Count);
                string randomActivity = activities[randomNumber];
                if (userAge < 21 && randomActivity == "Wine Tasting")
                {
                    Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
                    Console.WriteLine("Pick something else!");
                    activities.Remove(randomActivity);
                    randomNumber = rng.Next(activities.Count);
                    randomActivity = activities[randomNumber];
                }

                Console.Write($"Ah got it! {userName}, your random activity is: {randomActivity}! Is this ok or do you want to grab another activity? Keep/Redo: ");
                Console.WriteLine();
                cont = Console.ReadLine().ToLower() == "keep" ? false : true;
            }
            #region
            //do
            //{
            //    switch (cont2)
            //    {
            //        case "redo":
            //            randomNumber = rng.Next(activities.Count);
            //            randomActivity = activities[randomNumber];
            //            if (userAge > 21 && randomActivity == "Wine Tasting")
            //            {
            //                Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
            //                Console.WriteLine("Pick something else!");
            //                activities.Remove(randomActivity);
            //                randomNumber = rng.Next(activities.Count);
            //                randomActivity = activities[randomNumber];
            //            }
            //            Console.Write($"Ah got it! {userName}, your random activity is: {randomActivity}! Is this ok or do you want to grab another activity? Keep/Redo: ");
            //            Console.WriteLine();
            //            cont2 = Console.ReadLine().ToLower();
            //            if (cont2 == "Redo")
            //            {
            //                continue;
            //            }
            //            else
            //            {
            //                Console.WriteLine($"{randomActivity} is a great choice and will be lots of fun! ");
            //            }
            //            break;
            //        case "keep":
            //            Console.WriteLine($"{randomActivity} is a great choice and will be lots of fun!! ");
            //            break;
            //        default:
            //            Console.WriteLine("I don't recognize your entry, please try again - Keep/Redo: ");
            //            cont2 = Console.ReadLine().ToLower();
            //            if (cont2 == "redo")
            //            {
            //                randomNumber = rng.Next(activities.Count);
            //                randomActivity = activities[randomNumber];
            //                if (userAge > 21 && randomActivity == "Wine Tasting")
            //                {
            //                    Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
            //                    Console.WriteLine("Pick something else!");
            //                    activities.Remove(randomActivity);
            //                    randomNumber = rng.Next(activities.Count);
            //                    randomActivity = activities[randomNumber];
            //                }
            //                Console.Write($"Ah got it! {userName}, your random activity is: {randomActivity}! Is this ok or do you want to grab another activity? Keep/Redo: ");
            //                Console.WriteLine();
            //                cont2 = Console.ReadLine().ToLower();
            //            }
            //            else if (cont2 == "keep")
            //            {
            //                Console.WriteLine($"{randomActivity} is a great choice and will be lots of fun!! ");
            //            }
            //            else
            //            {
            //                Console.WriteLine("I still don't understand your entry, goodbye! ");
            //            }
            //            break;
            //    }
            //}
            //while (cont2 == "redo");
            #endregion
        }

        public static bool TrueOrFalse(string answer)
        {
            if (answer.ToLower() == "yes")
            {
                return true;
            }
            return false;


        }
    }
}