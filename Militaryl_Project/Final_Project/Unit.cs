using System;
namespace Final_Project
{
    public class Unit
    {
        public static bool isUnitsEnd;
        public static int unitsCount;
        private static int unitsNumber;
        private static Random rnd = new Random();

        public Unit(int unitsnumber)
        {
            unitsNumber = unitsnumber;
        }
        
        public static void Walk(Character character)
        {
            var randomUnits = rnd.Next(1,7);
            switch (randomUnits)
            {
                case 1:
                    unitsCount += 1;
                    Console.WriteLine("You walk 1 Unit!");
                    break;
                case 2:
                    unitsCount += 2;
                    Console.WriteLine("You walk 2 Units!");
                    break;
                case 3:
                    unitsCount += 3;
                    Console.WriteLine("You walk 3 Units!");
                    break;
                case 4:
                    unitsCount += 4;
                    Console.WriteLine("You walk 4 Units!");
                    break;
                case 5:
                    unitsCount += 5;
                    Console.WriteLine("You walk 5 Units!");
                    break;
                case 6:
                    unitsCount += 6;
                    Console.WriteLine("You walk 6 Units!");
                    break;
            }
            Console.WriteLine($"The unit You walked is {unitsCount} / {unitsNumber}");
            if (unitsCount >= unitsNumber)
            {
                isUnitsEnd = true;
            }
        } 
    }
}