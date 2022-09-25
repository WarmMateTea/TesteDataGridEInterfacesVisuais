using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteDataGridEInterfacesVisuais
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
            label1.BackColor = System.Drawing.Color.FromArgb(255, 145, 228, 250);
        }

        private void jogarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPreencherTabuleiro formPreTab = new FormPreencherTabuleiro();
            formPreTab.ShowDialog();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastro formCadastro = new FormCadastro();
            formCadastro.ShowDialog();
        }

        private void highscoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHighscore formHighscore = new FormHighscore();
            formHighscore.ShowDialog();
        }

        private void Carregamento()
        {
            menuStrip1.Visible = false;
            menuStrip1.Enabled = false;

            for (int i = 0; i < 100000001; i++)
            {
                progressBar.Value = i;
            }

            notifyIcon1.Icon = null;
            notifyIcon1.BalloonTipText = "Batalha Naval está pronto!";
            notifyIcon1.ShowBalloonTip(1000);

            menuStrip1.Enabled = true;
            menuStrip1.Visible = true;
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            Carregamento();
        }
    }
}
