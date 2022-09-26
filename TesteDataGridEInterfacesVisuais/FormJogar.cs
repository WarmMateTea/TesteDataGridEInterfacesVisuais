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

        public Jogo jogo;
        public FormJogar()
        {
            jogo = GerenciadorDeJogos.obterJogo(GlbVar.jogadorSelecionado.Nome);
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
            if (txtMultiplo.Text == String.Empty) {
                lblAviso.Visible = true;
                return;
            }
            int multiplo = 0;
            try
            {
                multiplo= int.Parse(txtMultiplo.Text);
               
            }
            catch (Exception) {
                lblAviso.Visible = true;
                return;
            }

                lblAviso.Visible = false;

                if (jogo.contemTiroJogador(multiplo)) {
                    MessageBox.Show("Você já inseriu este multiplo");
                     return;
                }

                Random rnd = new Random();
                int tiroAi = rnd.Next(1, 11) * rnd.Next(1, 11);

                 while (jogo.contemTiroIA(tiroAi))
                  {
                    tiroAi = rnd.Next(1, 11) * rnd.Next(1, 11);
                 }

                lblRegistroAtaque.Text = $"Ataque do oponente: {tiroAi.ToString()}";
                lstboxHistorico.Items.Add($"{GlbVar.jogadorSelecionado.Nome}: {txtMultiplo.Text}");
                lstboxHistorico.Items.Add($"Oponente: {tiroAi.ToString()}");
                //Atira no tabuleiro do oponente e revela o status da posição acertada.
                for (int i = 1; i < 11; i++)
                {
                    for (int j = 1; j < 11; j++)
                    {
                        if (i * j == multiplo )
                        {
                            BatalhaNaval.TiroMatriz(new Par(i - 1, j - 1), GlbVar.matrizOponente);
                            BatalhaNaval.UpdateDGVTiroUnico(dgvOponente, GlbVar.matrizOponente, new Par(i - 1, j - 1));
                           
                           
                        }
                        if (i * j == tiroAi )
                        {
                            //Tiros da AI
                            BatalhaNaval.TiroMatriz(new Par(i - 1, j - 1), GlbVar.matrizJogador);
                        //Adiciona o tiro da IA na lista do jogo
                        
                    }
                    }
                }
            //Adiciona o tiro da IA na lista do jogo
            jogo.addTiroIA(tiroAi);
            //Adiciona o tiro do Jogador na lista do jogo
            jogo.addTiroJogador(multiplo);

            txtMultiplo.Text = "";

                //Atira no tabuleiro do jogador e atualiza o display de toda a matriz do jogador.
                lblVitoria.Text = "O oponente está jogando...";
                dgvOponente.Invalidate();
                dgvOponente.Update();
                lblVitoria.Invalidate();
                lblVitoria.Update();
                Thread.Sleep(1250);

                BatalhaNaval.UpdateDGVTotal(dgvJogador, GlbVar.matrizJogador);

                lblVitoria.Text = "Faça sua jogada!";

                if (BatalhaNaval.ChecarFimDeJogo(GlbVar.matrizOponente))
                {
                    lblVitoria.Text = "Você venceu!";
                    lblVitoria.ForeColor = Color.Green;
                    lblVitoria.Update();
                    picboxFimDeJogo.Image = Properties.Resources.fotoBarcoVencedor;
                    picboxFimDeJogo.Visible = true;
                    picboxFimDeJogo.Update();
                    timer.Enabled = false;

                    FimDeJogo(true);
                }

                else if (BatalhaNaval.ChecarFimDeJogo(GlbVar.matrizJogador))
                {
                    lblVitoria.Text = "Derrota!!!!!!!!";
                    lblVitoria.ForeColor = Color.Red;
                    lblVitoria.Update();
                    picboxFimDeJogo.Image = Properties.Resources.fotoBarcoPerdedor;
                    picboxFimDeJogo.Visible = true;
                    picboxFimDeJogo.Update();
                    timer.Enabled = false;
                    FimDeJogo(false);
                }
      
        
        }
        
        private void FimDeJogo(bool vitoria)
        {
            GlbVar.jogadorSelecionado.RegistroPartidas.Add(
                new Partida(tempo, vitoria));
            GlbVar.jogadorSelecionado.Vitorias += (vitoria) ?  1 : 0;
            txtMultiplo.Enabled = btnTiro.Enabled = false;  //desabilita os comandos de jogar, porque quando a pessoa continua jogando continua contando vítorias;
            lblRegistroAtaque.Enabled = false; // Desabilita o label de tiro

        }
        private void timer_Tick(object sender, EventArgs e)
        {
            lblTempo.Text = tempo.ToString("HH:mm:ss");
            tempo = tempo.AddSeconds(1.0);
        }
    }
}
