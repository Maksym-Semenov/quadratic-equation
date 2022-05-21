using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Квадратное_уравнение
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();

                Console.WriteLine("Эта программа решает квадратные уравнения вида ax2+bx+c=0");
                Console.Write("Введите первый коэффициент A ");
                double a = int.Parse(Console.ReadLine());
                Console.Write("Введите второй коэффициент B ");
                double b = int.Parse(Console.ReadLine());
                Console.Write("Введите третий коэффициент C ");
                double c = int.Parse(Console.ReadLine());


                double diskriminant = Math.Pow(b, 2) - (4 * a * c);
                double Sqrt = Math.Sqrt(diskriminant);

                double x1 = (((-1) * b) + Sqrt) / (2 * a);

                double x2 = (((-1) * b) - Sqrt) / (2 * a);

                double x12 = (b / (2 * a) * (-1));

                if (diskriminant < 0)
                {
                    Console.WriteLine("Дискриминант меньше 0, поэтому уравнение не имеет рациональных корней");
                }
                else if (diskriminant == 0)
                {
                    Console.Write("Дискриминант равен 0, решение уравнения имеет два равных корня x = " + x12);
                }
                else if (diskriminant > 0)
                {
                    Console.WriteLine("Дискриминант больше 0, поэтому есть два решения ");
                    Console.WriteLine("Первый корень уравнения x1 = " + x1);
                    Console.WriteLine("Второй корень уравнения x2 = " + x2);
                }

                Console.ReadLine();
                Random rnd = new Random();  
            }
            


        }
    }
}
