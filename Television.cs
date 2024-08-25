using System;

namespace lab_work_1
{
    class Television
    {
        public string Brand;
        public string Model;
        public int ScreenSize;
        public string Resolution;
        public bool IsSmartTV;
        public int SoundPower;
        public bool IsOn;

        public void TurnOn()
        {
            IsOn = true;
            Console.WriteLine("Телевізор увімкнено.");
        }

        public void TurnOff()
        {
            IsOn = false;
            Console.WriteLine("Телевізор вимкнено.");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Бренд: {Brand}");
            Console.WriteLine($"Модель: {Model}");
            Console.WriteLine($"Діагональ екрану: {ScreenSize}\"");
            Console.WriteLine($"Роздільна здатність: {Resolution}");
            Console.WriteLine($"Smart TV: {(IsSmartTV ? "Так" : "Ні")}");
            Console.WriteLine($"Потужність звуку: {SoundPower} Вт");
            Console.WriteLine($"Стан: {(IsOn ? "Увімкнено" : "Вимкнено")}");
        }
    }
}
