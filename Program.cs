using System;
using LabaCSharp.Generators;

namespace LabaCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RandomGenerator");
            Console.WriteLine("Введите N:");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите название генератора:");
            string name = Console.ReadLine();

            RandomGenerator randomGenerator = new RandomGenerator(name, N);

            Console.WriteLine("Введите кол-во необходимых генерируемых чисел:");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Сгенерированная последовательность:");
            for (int i = 0; i < k; i++)
            {
                Console.Write($"{randomGenerator.Generate()} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Сред. арифмет. - {randomGenerator.Average()}");

            Console.WriteLine("GeneratorWithStep");
            Console.WriteLine("Введите N:");
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите название генератора:");
            name = Console.ReadLine();
            Console.WriteLine("Введите начальное число:");
            double first = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите начальный шаг:");
            double step = Convert.ToDouble(Console.ReadLine());

            BaseGenerator generatorWithStep = new GeneratorWithStep(name, N, first, step);

            Console.WriteLine("Введите кол-во необходимых генерируемых чисел:");
            k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Сгенерированная последовательность:");
            for (int i = 0; i < k; i++)
            {
                Console.Write($"{generatorWithStep.Generate()} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Сред. арифмет. - {generatorWithStep.Average()}");
        }
    }
}
