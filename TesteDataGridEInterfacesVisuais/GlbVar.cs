using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteDataGridEInterfacesVisuais
{
    /// <summary>
    /// Aqui ficam as variáveis "globais" que o BatalhaNaval precisa usar para muitas das implementações menos elegantes.
    /// <br>Não é bonito, e provavelmente não é seguro, mas tá ok pra um joguinho pequeno.</br>
    /// </summary>
    public static class GlbVar
    {
        //Se props: só getter;
        /// <summary>
        /// Lista de jogadores
        /// </summary>
        public static List<Jogador> jogadores = new List<Jogador>();
        public static Jogador jogadorSelecionado;




        //Se eu colocar props: só getter
        /// <summary>
        /// O dicionário que eu uso pra ajeitar os botões bonitinho.
        /// </summary>
        public static Dictionary<int, Button> dicBotoes = new Dictionary<int, Button>();


        //As imagens mais padrão possíveis
        //Se eu colocar props: só getter
        public static Bitmap defaultBG = Properties.Resources._default;
        public static Bitmap selectedBG = Properties.Resources.selected;
        public static Bitmap forbiddenBG = Properties.Resources.forbidden;

        //Se eu colocar props: só getter
        /// <summary>
        /// O tabuleiro do jogador [inicialização dinâmica? e o tabuleiro do oponente?]
        /// </summary>
        public static TabuleiroCasa[,] matrizJogador = new TabuleiroCasa[10, 10];

        //Se eu colocar props: só getter
        /// <summary>
        /// O tabuleiro do oponente (computador)
        /// </summary>
        public static TabuleiroCasa[,] matrizOponente = new TabuleiroCasa[10, 10];

        //Se eu colocar props: getter e setter com cuidados
        /// <summary>
        /// a quantidade de casas selecionadas (exemplo: 2 para o destróier, 3 para o encouraçado etc)
        /// <br>sempre é somado à row ou column</br>
        /// </summary>
        public static int paramQtdSelecao = 2;

        //Se eu colocar props: getter e setter com cuidados
        /// <summary>
        /// se o barco vai ser colocado na vertical ou horizontal.
        /// <br>0 = horizontal; 1 = vertical;</br>
        /// </summary>
        public static int paramRotacao = 1;

        //Se eu colocar props: só getter
        /// <summary>
        /// pilha de DataGridViewCellEventArgs modificadas no DGV_mouse_enter
        /// <br>acesso elas para restaurar o sprite no DGV_mouse_leave</br>
        /// </summary>
        public static Stack<Par> pilhaMods = new Stack<Par>();

        //Se eu colocar props: só getter
        /// <summary>
        /// gambiarra.png
        /// </summary>
        public static Par lastIndex = new Par(0, 0);
    }
}
