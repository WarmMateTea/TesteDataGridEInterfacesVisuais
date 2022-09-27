using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteDataGridEInterfacesVisuais
{
     class GerenciadorDeJogos
    {
        private static List<Jogo> jogos = new List<Jogo>();

        public static void addJogo(Jogador jogador)
        {
            if (jogadorEmPartida(jogador.Nome))
            {
                return;
            }
            Jogo jogo = new Jogo(jogador);
            jogos.Add(jogo);

        }


        public static  bool jogadorEmPartida(String nomeJogador)
        {
            if(obterJogo(nomeJogador)== null)
            {
                return false;
            }

            return true;
        }

       public static Jogo obterJogo(string nomeJogador)
        {
            Jogo jogoAchado;
            foreach(Jogo jogo in jogos)
            {
                if(jogo.Jogador.Nome == nomeJogador)
                {
                    jogoAchado = jogo;
                    return jogoAchado;
                }

            }
            return null;


        }
    }
}
