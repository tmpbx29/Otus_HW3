using System;

namespace SOLID
{
    internal class Program
    {
        static void Main()
        {
            var gameSettings = new GameSettings(1, 100, 10);
            var generatorNumber = new RandomGenerator();
            var gameController = new GameController(gameSettings, generatorNumber);

            while (true)
            {
                Console.Write("Ведите угадываемое число: ");
                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Вы ввелм не число. Ведите угадываемое число: ");
                }
                else
                {
                    var isEqual = gameController.CompareNumbers(number, out string message);
                    Console.WriteLine(message);
                    if (isEqual)
                    {
                        break;
                    }
                }
            }
        }
    }
}
