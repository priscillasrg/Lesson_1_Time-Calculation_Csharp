using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cálculo_de_tempo_com_polimorfismo.Modelo
{
    public class Validacao: absPropriedades, intMetodos
    {
        public Validacao (String distancia, String velocidade): base (distancia, velocidade)
        {
            Executar();
        }

        public override void Executar()
        {
            this.mensagem = "";

            try
            {
                this.numdistancia = Convert.ToDouble(this.distancia);
            }
            catch (FormatException e)
            {
                this.mensagem += "Erro: número inválido campo 1 \n";
            }
            try
            {
                this.numvelocidade = Convert.ToDouble(this.velocidade);
            }
            catch (FormatException e)
            {
                this.mensagem += "Erro: número inválido campo 2 \n";
            }

        }
    }
}
