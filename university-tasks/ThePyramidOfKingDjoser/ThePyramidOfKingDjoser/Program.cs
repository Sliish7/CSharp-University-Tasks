using System;

namespace ThePyramidOfKingDjoser
{
    internal class Program
    {
        static void Main()
        {
            int baseValue = int.Parse(Console.ReadLine());
            double increment = double.Parse(Console.ReadLine());
            double stoneTotal = 0;
            double marble = 0;
            double lapis = 0;
            double gold = 0;
            int levelCounter = 0;
            int currBaseValue = baseValue;

            for (int i = 1; i <= baseValue; i+= 2)
            {
                //Count each level
                levelCounter++;

                int blocks = currBaseValue * currBaseValue;
                int stones = (currBaseValue - 2) * (currBaseValue - 2);

                if (currBaseValue < 2 || currBaseValue == 2 && blocks == 4)
                {
                    gold = blocks;
                }
                else if (levelCounter % 5 == 0)
                {
                    lapis += (blocks - stones) * increment;
                    stoneTotal += stones * increment;
                }
                else
                {
                    marble += (blocks - stones) * increment;
                    stoneTotal += stones * increment;
                }
                //Jumping on new level
                currBaseValue -= 2;
            }
            Console.WriteLine($"Stone required: {Math.Round(stoneTotal)}");
            Console.WriteLine($"Marble required: {Math.Round(marble)}");
            Console.WriteLine($"Lapis Lazuli required: {Math.Round(lapis)}");
            Console.WriteLine($"Gold required: {gold}");
            Console.WriteLine($"Final pyramid hight: {Math.Round(levelCounter * increment)}");
        }
    }
}
