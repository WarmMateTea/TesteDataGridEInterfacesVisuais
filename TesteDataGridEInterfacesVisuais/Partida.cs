using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDataGridEInterfacesVisuais
{
    internal class Partida
    {
        private DateTime tempo;
        private bool vitoria;

        public Partida(DateTime tempo, bool vitoria)
        {
            this.tempo = tempo;
            this.vitoria = vitoria;
        }

        public string TempoFormatado()
        {
            return tempo.ToString("HH:mm:ss");
        }

        public DateTime Tempo { get => tempo; }
        public bool Vitoria { get => vitoria; }
    }
}
