using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDataGridEInterfacesVisuais
{
    public class Jogo 
    {
      private List<int>tirosIA = new List<int>();
      private List<int> tirosJogador = new List<int>();
      private string nomeJogador;
        public string NomeJogador { get => nomeJogador; }
       public  Jogo(string nomeJogador)
        {
            this.nomeJogador = nomeJogador;

        }

     

        public void addTiroIA(int multiplo) { 
            if(tirosIA.Contains(multiplo)) return;

            tirosIA.Add(multiplo);
        }

        public void addTiroJogador(int multiplo)
        {
            if (tirosJogador.Contains(multiplo)) return;

            tirosJogador.Add(multiplo);
        }

        public bool contemTiroIA(int multiplo) {

            return tirosIA.Contains(multiplo);
        }

        public bool contemTiroJogador(int multiplo)
        {

            return tirosJogador.Contains(multiplo);
        }
    }
}
