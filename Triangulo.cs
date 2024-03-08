using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucao02
{
    class Triangulo
    {
        //FORMA MAIS PRIMITIVA:
        //private string bas;
        //public string alt;
        //public void setBas(string _bas) { bas = _bas; }
        //public void setAlt(string _alt) { alt = _alt; }

        //public string getBas() { return bas; }
        //public string getAlt() { return alt; }


        public string Bas { get; set; }
        public string Alt { get; set; }

        public string getArea()
        {
            return (float.Parse(Bas) * float.Parse(Alt) / 2).ToString();
        }
    }
}
