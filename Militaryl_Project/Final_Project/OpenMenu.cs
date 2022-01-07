using System;

namespace Final_Project
{
    public class OpenMenu
    {
        private static string lastCheck;
        
        public static void IsOpenMenu()
        {
            Console.Clear();
            new UI().OpenMenu();
            lastCheck = Console.ReadLine();
            switch (lastCheck)
            {
                case "r":
                case "R":
                    return;
                case "Q":
                case "q":
                    Console.Clear();
                    Console.WriteLine($"Are you sure you want to leave {Mode.playerName} alone.....");
                    Console.Write("Yes,i'm sure.[Y] || No way![N]  :  ");
                    var finallycheck = Console.ReadLine();
                    switch (finallycheck)
                    {
                        case "y":
                        case "Y":
                            Environment.Exit(0);
                            break;
                        case "N":
                        case "n":
                            return;
                    }
                    Environment.Exit(0);
                    break;
            }
        }
    }
}