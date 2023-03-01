using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пр10
{
    internal class Cake
    {
        private string[] name;
        private string[] testo;
        private string[] krem;
        private double[] ves;
        private double[] kal;
        private double[] cena;       
        public void set_kol(int x)
        {
            name = new string[x];
            testo = new string[x];
            krem = new string[x];
            ves = new double[x];
            kal = new double[x];
            cena = new double[x];
        }
        public void set_name(int i,string x)
        {
            name[i] = x;
        }
        public void set_testo(int i, string x)
        {
            testo[i] = x;
        }
        public void set_krem(int i, string x)
        {
            krem[i] = x;
        }
        public void set_ves(int i, double x)
        {
            ves[i] = x;
        }
        public void set_kal(int i, double x)
        {
            kal[i] = x;
        }
        public void set_cena(int i, double x)
        {
            cena[i] = x;
        }
        public void get_info(int y)
        {
            Console.WriteLine($"Название - {name[y - 1]}");
            Console.WriteLine($"Тесто - {testo[y - 1]}");
            Console.WriteLine($"Крем - {krem[y - 1]}");
            Console.WriteLine($"Вес - {ves[y - 1]}");
            Console.WriteLine($"Каллорийность - {kal[y-1]}");
            Console.WriteLine($"Цена - {cena[y-1]}");
        }
        
    }
}
