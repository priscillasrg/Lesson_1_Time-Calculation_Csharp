using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cálculo_de_tempo_com_polimorfismo.Modelo
{
   public class Controle: absPropriedades, intMetodos
    {
        public Controle (String distancia, String velocidade) : base(distancia, velocidade)
        {
            Executar();
        }

        public override void Executar ()
        {
            this.mensagem = "";
            absPropriedades validacao = new Validacao(this.distancia, this.velocidade);

            if (validacao.mensagem.Equals(""))
            {
                absPropriedades calculos = new Calculos(validacao.numdistancia, validacao.numvelocidade);
                this.resultado = calculos.ToString();               
            }
            else
            {
                this.mensagem = validacao.mensagem; 
            }
            
        }
    }
}
