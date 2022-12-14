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

           Jogador jogador =  GerenciadorDeJogadores.obterJogador(txtNomeBusca.Text);

            if(jogador != null)
            {
                listBox1.Items.Add(jogador);
                return;
            }

             MessageBox.Show("O jogador não foi encontrado", "Jogador não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnListarTodos_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Jogador jogador in GerenciadorDeJogadores.Jogadores)
            {
                listBox1.Items.Add(jogador);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
                return;
            lblResultadoBusca.Text = $"{((Jogador)listBox1.SelectedItem).Nome} - Vitórias: {((Jogador)listBox1.SelectedItem).Vitorias}\n\n";
            foreach(Partida partida in ((Jogador)listBox1.SelectedItem).RegistroPartidas)
            {
                lblResultadoBusca.Text += (partida.Vitoria) ? "Vitória" : "Derrota";
                lblResultadoBusca.Text += $" - {partida.TempoFormatado()}\n";
            }
        }
    }
}
