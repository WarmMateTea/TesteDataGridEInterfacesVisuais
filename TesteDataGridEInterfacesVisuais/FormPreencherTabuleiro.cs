using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesteDataGridEInterfacesVisuais.Properties;

namespace TesteDataGridEInterfacesVisuais
{
    public partial class FormPreencherTabuleiro : Form
    {
      
        public FormPreencherTabuleiro()
        {
            InitializeComponent();
           

            //Inicializar o DGV (interface visual), a matriz (dados reais) e o dicionário dentro da classe BatalhaNaval
            dgv.Enabled = false;
            this.MdiParent = null;
            BatalhaNaval.InicializaTabuleiro(ref GlbVar.matrizJogador);
            BatalhaNaval.InicializaTabuleiro(ref GlbVar.matrizOponente);
            BatalhaNaval.InicializarDGV(dgv);
            InicializaDicionarioBotoes();

            PreencheComboBox();
            dgv.Enabled = true;
        }

        /// <summary>
        /// Essa função infelizmente é necessária para adicionar os botões de seleção de barco no dicionário que algumas funções no BatalhaNaval usam.
        /// <br>Não tem como desacoplar pq os botões realmente vem direto desse form.</br>
        /// </summary>
        private void InicializaDicionarioBotoes()
        {
            GlbVar.dicBotoes.Clear();
            GlbVar.dicBotoes.Add(2, btnDestroier);
            GlbVar.dicBotoes.Add(3, btnEncouracado);
            GlbVar.dicBotoes.Add(4, btnCruzador);
            GlbVar.dicBotoes.Add(5, btnPortaAvioes);
        }

        /// <summary>
        /// Evento que captura uma tecla pressionada. Redireciona e trata apenas o 'R', para rotacionar a seleção.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            BatalhaNaval.Rotacao(e, dgv);
        }


        /// <summary>
        /// Afeta o display de todas as células incluídas na seleção.
        /// <br>Caso a célula esteja vazia, seu BG é alterado para emular um "highlight".</br>
        /// <br>Caso a célula possua um barco, seu BG não é alterado.</br>
        /// <br>A função leva em consideração posições impossíveis, exibindo o "highlight" em vermelho.</br>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            BatalhaNaval.DGV_VisualUpdater_Entrada(new Par(e.RowIndex, e.ColumnIndex), GlbVar.matrizJogador, sender as DataGridView);
        }

        /// <summary>
        /// Restaura/corrige o display das células incluídas na seleção, caso o sprite tenha sido alterado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            BatalhaNaval.DGV_VisualUpdater_Saida(new Par(e.RowIndex, e.ColumnIndex), GlbVar.matrizJogador, sender as DataGridView);
            GlbVar.lastIndex.RowIndex = -1;
            GlbVar.lastIndex.ColumnIndex = -1;
        }

        /// <summary>
        /// Coloca o barco selecionado no tabuleiro.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BatalhaNaval.MatrixUpdater_Clique(new Par(e.RowIndex, e.ColumnIndex), GlbVar.matrizJogador);
        }

        /// <summary>
        /// Seleciona o destróier para colocação.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDestroier_Click(object sender, EventArgs e)
        {
            GlbVar.paramQtdSelecao = 2;
        }

        /// <summary>
        /// Seleciona o encouraçado para colocação.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEncouracado_Click(object sender, EventArgs e)
        {
            GlbVar.paramQtdSelecao = 3;
        }

        /// <summary>
        /// Seleciona o cruzador para colocação.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCruzador_Click(object sender, EventArgs e)
        {
            GlbVar.paramQtdSelecao = 4;
        }

        /// <summary>
        /// Seleciona o porta-aviões para colocação.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPortaAvioes_Click(object sender, EventArgs e)
        {
            GlbVar.paramQtdSelecao = 5;
        }

        /// <summary>
        /// Limpa o tabuleiro e reseta os botões.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            BatalhaNaval.ResetarGUI(ref GlbVar.matrizJogador, dgv, this);
        }

        /// <summary>
        /// Pode iniciar o jogo. Por ora, não faz nada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {

            Jogador jogador = carregarJogador();

            bool flag = BatalhaNaval.ChecarCondicoesInicio();
            if (flag)
            {
                BatalhaNaval.PreencheTabuleiroOponente(ref GlbVar.matrizOponente);
                //GerenciadorDeJogos.addJogo(jogador);

                FormJogar formJogar = new FormJogar(jogador);
          
                this.Hide();
                formJogar.ShowDialog();
                this.Close();         
                //começar jogo :)
            }
            else
            {
                MessageBox.Show("Coloque todos os seus barcos!", "Ainda há barcos!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //não começar jogo :(
            }


        }

        //Método responsável por carregar e criar um jogo
        private Jogador carregarJogador()
        {
            //Verifica se é um usuario anonimo
            if (rbtnAnonimo.Checked)
            {
                if (!GerenciadorDeJogadores.contemJogador("Anônimo"))
                {
                    Jogador anonimo = new Jogador("Anônimo");
                  
                    GerenciadorDeJogos.addJogo(anonimo);
                    return anonimo;
                }

                return GerenciadorDeJogadores.obterJogador("Anônimo");
            }

            //Verifica se tem algo selecionado no combobox dos jogadores
            if (cboxSelecionarUsuario.SelectedItem == null)
            {

                if (!GerenciadorDeJogadores.contemJogador("Anônimo"))
                {
                    Jogador jogadorAnonimo = new Jogador("Anônimo");
                   GerenciadorDeJogos.addJogo(new Jogador("Anônimo"));
                    return jogadorAnonimo;
                }

                return GerenciadorDeJogadores.obterJogador("Anônimo");
            }

            //Se tiver algum jogador no combobox ele adiciona ao jogo
            //Caso não existir

            Jogador jogador = (Jogador)cboxSelecionarUsuario.SelectedItem;
            if (!GerenciadorDeJogos.jogadorEmPartida(jogador.Nome))
            {
                GerenciadorDeJogos.addJogo((Jogador)cboxSelecionarUsuario.SelectedItem);
               
            }
            return jogador;
           
        }

        private void rbtnSelecaoUsuario_CheckedChanged(object sender, EventArgs e)
        {
            PreencheComboBox();
            if (rbtnSelecionar.Checked)
            {
                cboxSelecionarUsuario.Enabled = true;
                
            }
            else
            {
                cboxSelecionarUsuario.Enabled = false;
            }
        }

        private void PreencheComboBox() //Colocar os jogadores
        {
            cboxSelecionarUsuario.Items.Clear();
            foreach(Jogador jogador in GerenciadorDeJogadores.Jogadores)
            {
                cboxSelecionarUsuario.Items.Add(jogador);
            }
        }
    }
}
