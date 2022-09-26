using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteDataGridEInterfacesVisuais
{
    public partial class FormHighscore : Form
    {
        public FormHighscore()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            bool flagJogadorEncontrado = false;

            foreach (Jogador jogador in GlbVar.jogadores)
            {
                if (txtNomeBusca.Text == jogador.Nome)
                {
                    listBox1.Items.Add(jogador);
                    flagJogadorEncontrado = true;
                    break;
                }
            }

            if (!flagJogadorEncontrado)
                MessageBox.Show("O jogador não foi encontrado", "Jogador não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnListarTodos_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Jogador jogador in GlbVar.jogadores)
            {
                listBox1.Items.Add(jogador);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblResultadoBusca.Text = $"{((Jogador)listBox1.SelectedItem).Nome} - Vitórias:{((Jogador)listBox1.SelectedItem).Vitorias}\n\n";
            foreach(Partida partida in ((Jogador)listBox1.SelectedItem).RegistroPartidas)
            {
                lblResultadoBusca.Text += (partida.Vitoria) ? "Vitória" : "Derrota";
                lblResultadoBusca.Text += $" - {partida.TempoFormatado()}\n";
            }
        }
    }
}
