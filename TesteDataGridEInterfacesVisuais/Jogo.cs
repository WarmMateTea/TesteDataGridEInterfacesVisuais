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
      private Jogador jogador;
      public static TabuleiroCasa[,] matrizJogador = new TabuleiroCasa[10, 10];

        //Se eu colocar props: só getter
        /// <summary>
        /// O tabuleiro do oponente (computador)
        /// </summary>
      public static TabuleiroCasa[,] matrizOponente = new TabuleiroCasa[10, 10];

        public Jogador Jogador{ get => jogador; }
       public  Jogo(Jogador jogador)
        {
            this.jogador = jogador;

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
