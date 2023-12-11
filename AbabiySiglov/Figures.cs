using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbabiySiglov
{
    internal class Figures
    {
        public string name;
        
        public int side1, side2, side3;
        public Figures() { }
        public Figures(string name, int side1, int side2)
        { 
            this.name = name;
            this.side1 = side1;
            this.side2 = side2;
            
        }
        public override string ToString() { return $"name-{name}\t side1-{side1}\t side2-{side2}\t side3-{side3}"; }
       
        public void PS()
        {
            int perimetre = (side1 + side2) * 2;
            
            int square = side1 * side2;
            Console.WriteLine($"per={perimetre}, sq={square}");
        }
        public void PS1()
        {
            int perimetre = side1 + side2 + side3;
            double p = perimetre / 2;
            double square = Math.Sqrt(p*(p-side1)*(p-side2)*(p-side3));
            Console.WriteLine($"per={perimetre}, sq={square}");
        }
        public Figures(string name, int side1, int side2, int side3) : this(name, side1, side2)
        {
            this.side3 = side3;
        }
    }
}
