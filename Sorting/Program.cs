using System;

namespace Sorting
{
    class Program
    {
        private static void Main(string[] args)
        {
            int count = 10;
            Random random = new Random();
            int minValue = 1;
            int maxValue = 20;

            int[] bubbleSort = new int[count];            

            Console.WriteLine($"имеется несортированный массив длиной {count}, заполненный числами от {minValue} до {maxValue}:");

            for (int i = 0; i < count; i++)
            {
                bubbleSort[i] = random.Next(minValue, maxValue + 1);
            }

            Console.WriteLine($"{String.Join(", ", bubbleSort)}");

            Console.WriteLine($"\n\nСОРТИРОВКА ПУЗЫРЬКОМ");            

            bool isRaplaced = true;
            int step = 1;

            while (isRaplaced)
            {
                isRaplaced = false;
                count = bubbleSort.Length - step;

                for (int i = 0; i < count; i++)
                {
                    if (bubbleSort[i] > bubbleSort[i + 1])
                    {
                        int temporary = bubbleSort[i];
                        bubbleSort[i] = bubbleSort[i + 1];
                        bubbleSort[i + 1] = temporary;

                        isRaplaced = true;
                    }
                }
                step++;
            }

            Console.WriteLine($"результат сортировки: {String.Join(", ", bubbleSort)}");
        }
    }
}
