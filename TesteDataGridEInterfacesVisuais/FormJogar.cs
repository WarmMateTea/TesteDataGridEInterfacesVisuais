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
            BatalhaNaval.UpdateDGVTotal(dgvJogador, GlbVar.matrizJogador);
        }

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
            //Esse rolê de extrair o texto dos botões é lógica temporária, pq o jogo final provavelmente vai receber um número, o coiso calcula os divisores dele e rebenta a pitanga nessa casas - tabuada.
            if (txtNumeroLinha.Text == String.Empty) txtNumeroLinha.Text = "0";
            if (txtNumeroColuna.Text == String.Empty) txtNumeroColuna.Text = "0";

            int row = int.Parse(txtNumeroLinha.Text);
            int col = int.Parse(txtNumeroColuna.Text);
            txtNumeroColuna.Text = "";
            txtNumeroLinha.Text = "";
            Random rnd = new Random();

            //Atira no tabuleiro do oponente e revela o status da posição acertada.
            BatalhaNaval.TiroMatriz(new Par(row, col), GlbVar.matrizOponente);
            BatalhaNaval.UpdateDGVTiroUnico(dgvOponente, GlbVar.matrizOponente, new Par(row, col));

            //Atira no tabuleiro do jogador e atualiza o display de toda a matriz do jogador.
            BatalhaNaval.TiroMatriz(new Par(rnd.Next(0,10), rnd.Next(0, 10)), GlbVar.matrizJogador);
            BatalhaNaval.UpdateDGVTotal(dgvJogador, GlbVar.matrizJogador);

            if (BatalhaNaval.ChecarFimDeJogo(GlbVar.matrizOponente))
                lblVitoria.Text = "Você venceu!";
            else if (BatalhaNaval.ChecarFimDeJogo(GlbVar.matrizJogador))
                lblVitoria.Text = "Derrota!!!!!!!!";
        }
    }
}
