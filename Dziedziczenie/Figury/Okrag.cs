using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// zmiana z poziomu github'a
namespace Dziedziczenie.Figury
{
    class Okrag
    {
        private double srednica;

        public double ObliczPole()
        {
            return Math.PI * Math.Pow(0.5 * srednica, 2);
             //  return  3.14159 * (0.5 * srednica) * (srednica);
        }
    }
}
