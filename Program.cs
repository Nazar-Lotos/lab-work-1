using System;

namespace lab_work_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Television tv = new Television();

            Console.Write("Введіть бренд телевізора: ");
            tv.Brand = Console.ReadLine();

            Console.Write("Введіть модель телевізора: ");
            tv.Model = Console.ReadLine();

            Console.Write("Введіть діагональ екрану телевізора (в дюймах): ");
            tv.ScreenSize = int.Parse(Console.ReadLine());

            Console.Write("Введіть роздільну здатність телевізора: ");
            tv.Resolution = Console.ReadLine();

            Console.Write("Це Smart TV (введіть true або false): ");
            tv.IsSmartTV = bool.Parse(Console.ReadLine());

            Console.Write("Введіть потужність звуку телевізора (у ватах): ");
            tv.SoundPower = int.Parse(Console.ReadLine());

            tv.TurnOn();

            tv.DisplayInfo();

            tv.TurnOff();
            Console.ReadKey();
        }
    }
}
