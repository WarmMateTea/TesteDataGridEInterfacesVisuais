using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDataGridEInterfacesVisuais
{
     class GerenciadorDeJogadores
    {

        //Classe gerenciador que controlar todos os jogadores da aplicação

        private static List<Jogador> jogadores = new List<Jogador>();
        public static List<Jogador> Jogadores { get => jogadores; }
        public static void addJogador(Jogador jogador) {

            jogadores.Add(jogador);
        }

        public static Jogador obterJogador(String nome) {
            return jogadores.Find(jogador => jogador.Nome.Equals(nome));
        }

        public static bool contemJogador(string nome)
        {
            return obterJogador(nome) != null;
        }

    }
}
