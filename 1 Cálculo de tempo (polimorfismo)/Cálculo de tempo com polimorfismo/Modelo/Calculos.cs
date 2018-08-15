using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cálculo_de_tempo_com_polimorfismo.Modelo
{
   public class Calculos: absPropriedades, intMetodos
    {
        public Calculos (Double numdistancia, Double numvelocidade) : base(numdistancia, numvelocidade)
        {
            Executar();
        }

        public override void Executar()
        {
            this.resultado = "Distancia percorrida em horas: \n" + (numdistancia / numvelocidade).ToString("0.##") + "\n" +
                "\n Distancia percorrida em minutos: \n" + ((numdistancia / numvelocidade)*60).ToString("0.##");
        }

    }
}
