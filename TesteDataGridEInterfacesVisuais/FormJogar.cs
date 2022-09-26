using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteDataGridEInterfacesVisuais
{
    public partial class FormJogar : Form
    {
        public FormJogar()
        {
            InitializeComponent();

            //Inicializar os DGVs
            BatalhaNaval.InicializarDGV(dgvJogador);
            BatalhaNaval.InicializarDGV(dgvOponente);

            //Inicializar o display dos tabuleiros. O do oponente é coberto por "névoa de guerra".
            BatalhaNaval.UpdateDGVFogOfWar(dgvOponente, GlbVar.matrizOponente);
            //BatalhaNaval.UpdateDGVTotal(dgvOponente, GlbVar.matrizOponente);
            BatalhaNaval.UpdateDGVTotal(dgvJogador, GlbVar.matrizJogador);
        }

        DateTime tempo = new DateTime(1, 1, 1, 0, 0, 0);

        private void txtNumeroLinha_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Dispara quando a tecla pressionada não é um dígito ou backspace,
            // impedindo que o caracter seja registrado
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                e.Handled = true;   
        }

        private void txtNumeroColuna_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Dispara quando a tecla pressionada não é um dígito ou backspace,
            // impedindo que o caracter seja registrado
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                e.Handled = true;
        }

        private void btnTiro_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int tiroAi = rnd.Next(1,11) * rnd.Next(1, 11);
            //Atira no tabuleiro do oponente e revela o status da posição acertada.
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    if (i*j == int.Parse(txtMultiplo.Text))
                    {
                        BatalhaNaval.TiroMatriz(new Par(i-1, j-1), GlbVar.matrizOponente);
                        BatalhaNaval.UpdateDGVTiroUnico(dgvOponente, GlbVar.matrizOponente, new Par(i - 1, j - 1));
                    }
                    if (i*j == tiroAi)
                    {
                        //Tiros da AI
                        BatalhaNaval.TiroMatriz(new Par(i-1, j-1), GlbVar.matrizJogador);
                    }
                }
            }

            txtMultiplo.Text = "";

            //Atira no tabuleiro do jogador e atualiza o display de toda a matriz do jogador.
            lblVitoria.Text = "O oponente está jogando...";
            dgvOponente.Invalidate();
            dgvOponente.Update();
            lblVitoria.Invalidate();
            lblVitoria.Update();
            Thread.Sleep(1500);

            BatalhaNaval.UpdateDGVTotal(dgvJogador, GlbVar.matrizJogador);

            lblVitoria.Text = "Faça sua jogada!";

            if (BatalhaNaval.ChecarFimDeJogo(GlbVar.matrizOponente))
            {
                lblVitoria.Text = "Você venceu!";
                FimDeJogo(true);
            }
                
            else if (BatalhaNaval.ChecarFimDeJogo(GlbVar.matrizJogador))
            {
                lblVitoria.Text = "Derrota!!!!!!!!";
                FimDeJogo(false);
            }
                
        }

        private void FimDeJogo(bool vitoria)
        {
            GlbVar.jogadorSelecionado.RegistroPartidas.Add(
                new Partida(tempo, vitoria));
            GlbVar.jogadorSelecionado.Vitorias += (vitoria) ?  1 : 0 ;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTempo.Text = tempo.ToString("HH:mm:ss");
            tempo = tempo.AddSeconds(1.0);
        }
    }
}
