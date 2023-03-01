using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пр10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Cake cake = new Cake();
                Console.WriteLine("Сколько видов пирожных вы хотите записать?");
                int x = int.Parse(Console.ReadLine());
                while (x < 1)
                {
                    Console.WriteLine("Сколько видов пирожных вы хотите записать?");
                    x = int.Parse(Console.ReadLine());
                }
                cake.set_kol(x);
                for (int i = 0; i < x; i++)
                {
                    Console.WriteLine($"Введите название {i + 1} пирожного");
                    string st = Console.ReadLine();
                    while (st == "")
                    {
                        Console.WriteLine($"Введите название {i + 1} пирожного");
                        st = Console.ReadLine();
                    }
                    cake.set_name(i, st);
                }
                for (int i = 0; i < x; i++)
                {
                    Console.WriteLine($"Введите тесто {i + 1} пирожного");
                    string st = Console.ReadLine();
                    while (st == "")
                    {
                        Console.WriteLine($"Введите тесто {i + 1} пирожного");
                        st = Console.ReadLine();
                    }
                    cake.set_testo(i, st);
                }
                for (int i = 0; i < x; i++)
                {
                    Console.WriteLine($"Введите крем {i + 1} пирожного");
                    string st = Console.ReadLine();
                    while (st == "")
                    {
                        Console.WriteLine($"Введите крем {i + 1} пирожного");
                        st = Console.ReadLine();
                    }
                    cake.set_krem(i, st);
                }
                for (int i = 0; i < x; i++)
                {
                    Console.WriteLine($"Введите вес {i + 1} пирожного");
                    double st = Convert.ToDouble(Console.ReadLine());
                    while (st < 0.1)
                    {
                        Console.WriteLine($"Введите вес {i + 1} пирожного");
                        st = Convert.ToDouble(Console.ReadLine());
                    }
                    cake.set_ves(i, st);
                }
                for (int i = 0; i < x; i++)
                {
                    Console.WriteLine($"Введите каллорийность {i + 1} пирожного");
                    double st = Convert.ToDouble(Console.ReadLine());
                    while (st < 0.1)
                    {
                        Console.WriteLine($"Введите каллорийность {i + 1} пирожного");
                        st = Convert.ToDouble(Console.ReadLine());
                    }
                    cake.set_kal(i, st);
                }
                for (int i = 0; i < x; i++)
                {
                    Console.WriteLine($"Введите цену {i + 1} пирожного");
                    double st = Convert.ToDouble(Console.ReadLine());
                    while (st < 0.1)
                    {
                        Console.WriteLine($"Введите цену {i + 1} пирожного");
                        st = Convert.ToDouble(Console.ReadLine());
                    }
                    cake.set_cena(i, st);
                }
                Console.WriteLine("Информацию о каком пирожном вы хотите узнать?");
                int y = int.Parse(Console.ReadLine());
                while (y < 1)
                {
                    Console.WriteLine("Информацию о каком пирожном вы хотите узнать?");
                    y = int.Parse(Console.ReadLine());
                }
                cake.get_info(y);
            }
            catch { Console.WriteLine("Неверный ввод"); }


            Console.ReadKey();
        }
    }
}
