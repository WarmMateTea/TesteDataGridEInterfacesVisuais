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
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNomeJogador.Text == String.Empty)
            {
                lblNomeAviso.Visible = true;
                return;
            }   
            foreach (Jogador jogador in GlbVar.jogadores)
            {
                if (jogador.Nome == txtNomeJogador.Text)
                {
                    MessageBox.Show("O jogador já está cadastrado!", "Cadastro duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            GlbVar.jogadores.Add(new Jogador(txtNomeJogador.Text));
            MessageBox.Show("O jogador foi cadastrado com sucesso!", "Cadastro bem-sucedido!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeJogador.Text = "";
        }
    }
}
