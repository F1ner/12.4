using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbabiySiglov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figures figure1 = new Figures();
            figure1.name = "kvadr";
            figure1.side1 = 1;
            figure1.side2 = 2;
            Console.WriteLine(figure1.ToString());
            figure1.PS();
            Figures figure2 = new Figures("kv",12,10);
            Console.WriteLine(figure2.ToString());
            figure2.PS();
            Console.WriteLine("Введите название фигуры");
            string name=Console.ReadLine();
            Console.WriteLine("Введите сторону 1");
            int s1=int.Parse(Console.ReadLine());
            
            Console.WriteLine("Введите сторону 2");
            int s2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону 3");
            int s3 = int.Parse(Console.ReadLine());
            Figures figures3= new Figures(name,s1,s2,s3);
            Console.WriteLine(figures3.ToString());
            figures3.PS1();


            Console.ReadKey();
        }
    }
}
