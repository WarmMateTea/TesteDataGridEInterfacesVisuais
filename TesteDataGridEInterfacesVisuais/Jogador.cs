using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace TesteDataGridEInterfacesVisuais
{
    public class Jogador
    {
        private string nome;
        private int vitorias;
        private List<Partida> registroPartidas;

        public Jogador(string nome)
        {
            registroPartidas = new List<Partida>();
            this.Nome = nome;
            Vitorias = 0;
        }

        public string Nome { get => nome; set => nome = value; }
        public int Vitorias { get => vitorias; set => vitorias = value; }
        internal List<Partida> RegistroPartidas { get => registroPartidas; }

        public override string ToString()
        {
            return $"{nome} - Vitórias: {vitorias}";
        }
    }
}
