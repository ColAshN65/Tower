using System;

namespace Tower
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите Число - ");

                int Element;

                if (!int.TryParse(Console.ReadLine(), out Element)) continue;

                Tower tower = new Tower(Element);

                Console.WriteLine($"Этаж - {tower.GetPosition()}, Позиция - {tower.GetFloor()}");
            }
        }
    }
}
