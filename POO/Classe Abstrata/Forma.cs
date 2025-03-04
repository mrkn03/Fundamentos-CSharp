using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Abstrata
{
    public abstract class Forma
    {
        public string Cor { get; set; }
        public double Area { get; set; }
        public double Perimetro { get; set; }

        //Metodos abstratos
        public abstract void CalcularArea();
        public abstract void CalcularPerimetro();

        //Metodo comum
        public string Descricao()
        {
            return "Sou a classe abstrat6a Forma";
        }
    }
}
