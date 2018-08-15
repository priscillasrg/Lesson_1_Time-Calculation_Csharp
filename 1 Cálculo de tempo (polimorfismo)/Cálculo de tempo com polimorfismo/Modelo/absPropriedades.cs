using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cálculo_de_tempo_com_polimorfismo.Modelo
{
    public abstract class absPropriedades
    {
        public String mensagem;
        protected String resultado;      
        public String distancia;
        public String velocidade;
        public Double numdistancia;
        public Double numvelocidade;

        //Método para classe Validação e Controle
        public absPropriedades(String distancia, String velocidade)
        {
            this.distancia = distancia;
            this.velocidade = velocidade;
        }

        //Método para classe Cálculos
        public absPropriedades(Double numdistancia, Double numvelocidade)
        {
            this.numdistancia = numdistancia;
            this.numvelocidade = numvelocidade;
        }
          
        public virtual void Executar ()
        {
        }

        public override string ToString()
        {
            return this.resultado;
        }
    }
}
