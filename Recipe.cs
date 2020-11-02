using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe_Projects
{
    public class Recipe
    {
        public double Ahmet { get; set; }
        public double Cihat { get; set; }
        public double Muhammed { get; set; }
        public double Mucahit { get; set; }
        public double Yusuf { get; set; }
        public double Total { get; set; }

        public Recipe(double p1,double p2, double p3, double p4, double p5)
        {
            Ahmet = p1;
            Cihat = p2;
            Muhammed=p3;
            Mucahit= p4;
            Yusuf = p5;
        }

        public void Calculate()
        {
            Total = Ahmet + Yusuf + Cihat + Muhammed + Mucahit;
            Ahmet = Ahmet - (Total / 5);
            Yusuf = Yusuf - (Total / 5);
            Cihat = Cihat- (Total / 5);
            Mucahit = Mucahit - (Total / 5);
            Muhammed = Muhammed- (Total / 5);

        }
    }
}
