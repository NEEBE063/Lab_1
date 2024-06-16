using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public class Bicycle
    {
        public string Model;
        public string Frame;
        public int Broadcast;
        public string Fork;
        public string Headset;
        public string Handlebars;
        public bool Ring;

        public int Cost()
        {
            return Broadcast * 1 / 2 * 100;
        }

        public int Value
        {
            get { return Cost(); }
            set { }
        }
        public class Program
        {
            static void Main(string[] args)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("Введіть модель");
                string sModel = Console.ReadLine();
                Console.WriteLine("Введіть раму");
                string sFrame = Console.ReadLine();
                Console.WriteLine("Введіть передачі");
                int sBroadcast = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введіть вилку");
                string sFork = Console.ReadLine();
                Console.WriteLine("Введіть рульову колонку");
                string sHeadset = Console.ReadLine();
                Console.WriteLine("Введіть руль");
                string sHandlebars = Console.ReadLine();
                Console.WriteLine("Чи є дзвінок(y - yes, or n - no)");
                ConsoleKeyInfo keyHasRing = Console.ReadKey();
                Bicycle bc = new Bicycle
                {
                    Model = sModel,
                    Frame = sFrame,
                    Broadcast = sBroadcast,
                    Headset = sHeadset,
                    Handlebars = sHandlebars,
                    Fork = sFork,
                    Ring = keyHasRing.Key == ConsoleKey.Y ? true : false
                };
                Console.WriteLine($"Деталі про велосипед:");
                Console.WriteLine("-------------");
                Console.WriteLine($"Модель: {bc.Model}");
                Console.WriteLine($"Рама: {bc.Frame}");
                Console.WriteLine($"Передачі: {bc.Broadcast}");
                Console.WriteLine($"Рульова колонка: {bc.Headset}");
                Console.WriteLine($"Руль {bc.Handlebars}");
                Console.WriteLine($"Вилка: {bc.Fork}");
                Console.WriteLine($"Дзвінок: {(bc.Ring ? "Є дзвінок" : "Немає дзвінка")}");
                Console.WriteLine($"Ціна = {bc.Cost()}грн");
                Console.ReadKey();
            }
        }
    }
}
