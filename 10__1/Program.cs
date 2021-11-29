using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10__1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите градусы?: ");
                uint a = Convert.ToUInt32(Console.ReadLine());
                Console.Write("\nВведите минуты?: ");
                uint b = Convert.ToUInt32(Console.ReadLine());
                Console.Write("\nВведите секунды?: ");
                uint c = Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine();
                Corner corner = new Corner(a, b, c);
                corner.ToRadians();
            }
            catch
            {
                Console.Write("Ошибка!");
            }
            Console.ReadKey();
        }
    }
    class Corner
    {
        public uint gradus;
        public uint min;
        public uint sec;

        public Corner(uint gradus, uint min, uint sec)
        {
            this.gradus = gradus;
            this.min = min;
            this.sec = sec;
        }


        public void ToRadians()
        {
            double fullgradus = gradus + (double)min / 60 + (double)sec / 3600;
            if (fullgradus <= 360)
            {
                double radians = (fullgradus * Math.PI) / 180;
                Console.WriteLine("Перевод градусов в радианы: " + Math.Round(radians, 6));
            }
            else
            {
                Console.WriteLine("Ошибка!");
            }
        }
    }
}
