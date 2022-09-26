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
            this.Hide();
            formPreTab.ShowDialog();
            this.Show();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastro formCadastro = new FormCadastro();
            formCadastro.ShowDialog();
        }

        private void highscoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHighscore formHighscore = new FormHighscore();
            this.Hide();
            formHighscore.ShowDialog();
            this.Show();
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;
            menuStrip1.Enabled = false;
            backgroundWorker.RunWorkerAsync();
        }


        //Barra de loading + notificação

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var backgroundWorker = sender as BackgroundWorker;
            for (int j = 0; j < 101; j++)
            {
                Thread.Sleep(20);
                backgroundWorker.ReportProgress(j);
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipText = "Batalha Naval está pronto!";
            notifyIcon1.ShowBalloonTip(1000);

            menuStrip1.Enabled = true;
            menuStrip1.Visible = true;
        }
    }
}
