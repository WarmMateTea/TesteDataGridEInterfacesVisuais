using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteDataGridEInterfacesVisuais
{
    public static class GlbVar
    {
        /// <summary>
        /// O dicionário que eu uso pra ajeitar os botões bonitinho.
        /// </summary>
        public static Dictionary<int, Button> dicBotoes = new Dictionary<int, Button>();


        //As imagens mais padrão possíveis
        public static Bitmap defaultBG = Properties.Resources._default;
        public static Bitmap selectedBG = Properties.Resources.selected;
        public static Bitmap forbiddenBG = Properties.Resources.forbidden;


        /// <summary>
        /// O tabuleiro do jogador [inicialização dinâmica? e o tabuleiro do oponente?]
        /// </summary>
        public static TabuleiroCasa[,] matrizJogador = new TabuleiroCasa[10, 10];


        /// <summary>
        /// a quantidade de casas selecionadas (exemplo: 2 para o destróier, 3 para o encouraçado etc)
        /// <br>sempre é somado à row ou column</br>
        /// </summary>
        public static int paramQtdSelecao = 2;


        /// <summary>
        /// se o barco vai ser colocado na vertical ou horizontal.
        /// <br>0 = horizontal; 1 = vertical;</br>
        /// </summary>
        public static int paramRotacao = 1;


        /// <summary>
        /// pilha de DataGridViewCellEventArgs modificadas no DGV_mouse_enter
        /// <br>acesso elas para restaurar o sprite no DGV_mouse_leave</br>
        /// </summary>
        public static Stack<Par> pilhaMods = new Stack<Par>();


        /// <summary>
        /// gambiarra.png
        /// </summary>
        public static Par lastIndex = new Par(0, 0);
    }
}
