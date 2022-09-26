using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteDataGridEInterfacesVisuais
{
    /// <summary>
    /// Startup:
    /// <br>1 - Puxe os comandos BatalhaNaval.InicializarDGV() e BatalhaNaval.InicializaTabuleiro();</br>
    /// <br>2 - Implemente InicializaDicionarioBotoes(); Basta adicionar ao dicionário os botões com as chaves sendo a qtd de casas que o barco correspondente ocupa.</br>
    /// <br>3 - Tô com preguiça de escrever agora mas vc precisa criar os eventos Form_KeyDown, DGV_CellMouseEnter, DVG_CellMouseLeave, DVG_CellClick e os vários botões,</br>
    /// <br>e incluir as funções e métodos apropriados, que geralmente estão bem sinalizados com !!! conteúdo !!!. </br>
    /// </summary>
    public static class BatalhaNaval
    {
        /// <summary>
        /// Deve ser chamado no onLoad ou construtor do form onde os barcos são posicionados.
        /// Inicializa e preenche aleatoriamente um array bidimensional de TabuleiroCasa já criado, para o oponente jogar
        /// <para>Recebe o ponteiro para essa matriz</para>
        /// <para>Depende das globais paramQtdSelecao e paramRotacao</para>
        /// </summary>
        /// <param name="matriz"></param>
        public static void PreencheTabuleiroOponente(ref TabuleiroCasa[,] matriz)
        {
            Par p = new Par(0, 0);
            Random r = new Random();    
            for (int i = 2; i <= 5; )
            {
                //Coloca os 4 tipos de barco (2-5 casas cada)
                GlbVar.paramQtdSelecao = i;
                //Randomiza a rotação no posicionamento
                GlbVar.paramRotacao = r.Next(0, 2);
                //Randomiza a posição selecionada
                p.RowIndex = r.Next(0, 10);
                p.ColumnIndex = r.Next(0, 10);

                //Se o posicionamento não for bem-sucedido (por quaisquer motivos), i não é incrementado e o barco tenta ser posicionado novamente
                if (MatrixUpdater_Clique(p, matriz))
                    i++;
            }
            //Reseta as globais para seus padrões. Talvez uma prop para elas fosse mais adequada desde o começo, talvez eu revise depois.
            GlbVar.paramQtdSelecao = 2;
            GlbVar.paramRotacao = 0;
        }

        /// <summary>
        /// Deve ser chamado no onLoad ou construtor do form onde os barcos são posicionados, e depois no form de jogo em si, para cada DGV.
        /// Inicializa um array bidimensional de TabuleiroCasa já criado
        /// <br>Inicializa com os seguintes valores: estado: não atingido, tipoBarco: nenhum barco, orientacao e tipoSprite = 0; </br>
        /// <para>Recebe o ponteiro para essa matriz</para>
        /// </summary>
        /// <param name="matriz"></param>
        public static void InicializaTabuleiro(ref TabuleiroCasa[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = new TabuleiroCasa();
                }
            }
        }


        /// <summary>
        /// Deve ser chamado no onLoad ou construtor do form onde os barcos são posicionados.
        /// Cria as colunas e linhas no DGV no formato 10x10, com o tamanho 32x32.
        /// <para>Depende de defaultBG.</para>
        /// </summary>
        public static void InicializarDGV(DataGridView dgv)
        {
            dgv.ColumnHeadersHeight = 32;   //não funciona nem aqui nem no designer, por alguma razão maluca o DGV não deixa mudar a altura do header de coluna dele

            //Adiciona 10 colunas do tipo DataGridViewImageColumn (ou seja: as Cells contém imagens)
            //Seta o número de linhas para 10
            //É interessante notar que no DGV, a Column é determinante, e as Rows simplesmente seguem o que foi estipulado pela sua Column mãe;
            for (int i = 0; i < 10; i++)
            {
                DataGridViewImageColumn DGVIC = new DataGridViewImageColumn();
                DGVIC.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dgv.Columns.Add(DGVIC);
            }
            dgv.RowCount = 10;


            //Padroniza o tamanho das Cells para 32x32
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                dgv.Columns[i].Width = 32;
                dgv.Rows[i].Height = 32;
            }
            
            
            //Seta o background padrao de cada Cell
            //Coloca os números nos headers
            //vai ser mudado pra chamar a função de sprite mais pra frente [vai nada.]
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                dgv.Rows[i].HeaderCell.Value = $"{i + 1}";
                dgv.Columns[i].HeaderCell.Value = $"{i + 1}";
                for (int j = 0; j < dgv.RowCount; j++)
                {
                    dgv.Rows[i].Cells[j].Value = GlbVar.defaultBG;
                }
            }
        }


        /// <summary>
        /// <para>!!! DEVE (?) SER CHAMADO A PARTIR DE UM EVENTO buttonReset_Click NO FORM DE POSICIONAMENTO DE BARCOS !!! </para>
        /// Chamado pela GUI para resetar o posicionamento dos barcos.
        /// <para>Depende das variáves globais: paramQtdSelecao, paramRotacao</para>
        /// </summary>
        /// <param name="matriz"></param>
        public static void ResetarGUI(ref TabuleiroCasa[,] matriz, DataGridView dgv, Form form)
        {
            foreach (Control ctrl in form.Controls)
            {
                if (ctrl is Button) ctrl.Enabled = true;
            }

            void ResetTabuleiro(ref TabuleiroCasa[,] matrizL)
            {
                for (int i = 0; i < matrizL.GetLength(0); i++)
                    for (int j = 0; j < matrizL.GetLength(1); j++)
                    {
                        matrizL[i, j].ResetCasa();
                        dgv.Rows[i].Cells[j].Value = matrizL[i, j].DeterminarSprite();
                    }
            }

            GlbVar.paramQtdSelecao = 2;
            GlbVar.paramRotacao = 1;
            ResetTabuleiro(ref matriz);
        }


        /// <summary>
        /// Essa função é chamada nos hovers, e no clique, para inibi-lo ou permiti-lo. Verifica se a seleção é válida.
        /// <para>Recebe a posição do cursor na matriz, e conhece os parâmetros de rotação e qtd.</para>
        /// <para>Depende das variáveis globais: paramRotacao, paramQtdSelecao</para>
        /// </summary>
        /// <param name="e"></param>
        /// <param name="matriz"></param>
        /// <returns>Se as posições selecionadas são válidas, retorna positivo - as células podem ser usadas.
        /// <br>Senão, retorna negativo - as células recebem um tom indicativo e não podem ser usadas.</br></returns>
        public static bool SelecaoValidaMatriz(Par e, TabuleiroCasa[,] matriz)
        {
            int rowindex = e.RowIndex;
            int columnindex = e.ColumnIndex;
            //Conheço: paramQtdSelecao, paramRotacao
            //Como paramRotacao não roda em 4 sentidos, a função é simples
            switch (GlbVar.paramRotacao)
            {
                case 0:     //Barco colocado na Horizontal
                    if (columnindex + GlbVar.paramQtdSelecao > matriz.GetLength(0))
                        return false;
                    break;
                case 1:     //Barco colocado na Vertical
                    if (rowindex + GlbVar.paramQtdSelecao > matriz.GetLength(1))
                        return false;
                    break;
            }

            int row = (GlbVar.paramRotacao == 1) ? 1 : 0;
            int col = (GlbVar.paramRotacao == 0) ? 1 : 0;
            for (int i = 0;
                i < GlbVar.paramQtdSelecao &&
                ((GlbVar.paramRotacao == 0 || i + e.RowIndex < matriz.GetLength(0)) &&     //vertical = 1, horiz = 0
                (GlbVar.paramRotacao == 1 || i + e.ColumnIndex < matriz.GetLength(1)));
                i++)
            {
                if (matriz[e.RowIndex + i * row, e.ColumnIndex + i * col].TipoBarco != 0)
                    return false;
            }

            return true;
        }


        /// <summary>
        /// Devolve os indexes válidos ou não dada uma posição de cursor.
        /// <para>Recebe um Par e representando a posição do cursor sobre a matriz (row, column), e recebe a matriz para verificar as posições </para>
        /// <para>Depende das variáveis globais: paramRotacao, paramQtdSelecao.</para>
        /// </summary>
        /// <param name="e"></param>
        /// <param name="matriz"></param>
        /// <returns>Retorna uma pilha de Par com os pares de índices válidos para posicionamento na matriz, partindo da posição dada.</returns>
        public static Stack<Par> GetValidIndexes(Par e, TabuleiroCasa[,] matriz)
        {
            Stack<Par> pilhaIndexes = new Stack<Par>();
            int row = (GlbVar.paramRotacao == 1) ? 1 : 0;
            int col = (GlbVar.paramRotacao == 0) ? 1 : 0;
            if (SelecaoValidaMatriz(e, matriz))
            {
                for (int i = 0; i < GlbVar.paramQtdSelecao; i++)
                {
                    Par p = new Par(e.RowIndex + i * row,
                                    e.ColumnIndex + i * col);
                    pilhaIndexes.Push(p);
                }
            }
            else
            {
                for (int i = 0;
                    i < GlbVar.paramQtdSelecao &&
                    ((GlbVar.paramRotacao == 0 || i + e.RowIndex < matriz.GetLength(0)) &&     //vertical = 1, horiz = 0
                    (GlbVar.paramRotacao == 1 || i + e.ColumnIndex < matriz.GetLength(1)));
                    i++)
                {
                    Par p = new Par(e.RowIndex + i * row,
                                    e.ColumnIndex + i * col);
                    pilhaIndexes.Push(p);
                }
            }
            return pilhaIndexes;
        }


        /// <summary>
        /// Posiciona o barco na matriz inicial do jogador (tabuleiro vazio)
        /// <br>Assume que a posição fornecida é válida. Não é usada sem o SelecaoValidaMatriz() para permiti-la.</br>
        /// <para>Recebe um Par e, representando a posição do cursor sobre a matriz (row, column), e recebe a matriz para colocar os barcos</para>
        /// <para>Depende das variáveis globais: paramRotacao, paramQtdSelecao</para>
        /// </summary>
        /// <param name="e"></param>
        /// <param name="matriz"></param>
        private static void PosicionarBarcoMatriz(Par e, TabuleiroCasa[,] matriz)
        {
            //Depende das globais:
            // paramQtdSelecao;
            // paramRotacao

            int rowindex = e.RowIndex;
            int columnindex = e.ColumnIndex;
            int tipoBarco = GlbVar.paramQtdSelecao - 1;
            TabuleiroCasa casa = null;

            for (int i = 0; i < GlbVar.paramQtdSelecao; i++)
            {
                switch (GlbVar.paramRotacao)
                {
                    case 0:     //Barco colocado na horizontal
                        casa = matriz[rowindex, columnindex + i];
                        if (i == 0) { casa.TipoSprite = 0; }                      //Início do barco
                        else
                        {
                            if (i == GlbVar.paramQtdSelecao - 1) { casa.TipoSprite = 2; } //Final do barco
                            else { casa.TipoSprite = 1; }                          //Meio do barco
                        }
                        break;

                    case 1:     //Barco colocado na vertical
                        casa = matriz[rowindex + i, columnindex];
                        if (i == 0) { casa.TipoSprite = 2; }                      //Início do barco
                        else
                        {
                            if (i == GlbVar.paramQtdSelecao - 1) { casa.TipoSprite = 0; } //Final do barco
                            else { casa.TipoSprite = 1; }                          //Meio do barco
                        }
                        break;
                }

                casa.TipoBarco = tipoBarco;
                casa.Orientacao = GlbVar.paramRotacao;
            }
        }


        /// <summary>
        /// !!! DEVE SER INVOCADA A PARTIR DE UM EVENTO KeyDown VINDO DO FORM DE MONTAR O TABULEIRO !!!
        /// <para>Recebe a tecla pressionada. Se for 'R', efetua a rotação para posicionar o barco no tabuleiro.</para>
        /// <br>Recebe também o DGV onde está o tabuleiro do jogador. </br>
        /// </summary>
        /// <param name="e">É a tecla que foi pressionada.</param>
        public static void Rotacao(KeyEventArgs e, DataGridView dgv)
        {
            if (e.KeyCode.ToString() == "R")
            {
                GlbVar.paramRotacao = (GlbVar.paramRotacao == 1) ? 0 : 1;
                DGV_VisualUpdater_Saida(new Par(GlbVar.lastIndex.RowIndex, GlbVar.lastIndex.ColumnIndex), GlbVar.matrizJogador, dgv);
                DGV_VisualUpdater_Entrada(new Par(GlbVar.lastIndex.RowIndex, GlbVar.lastIndex.ColumnIndex), GlbVar.matrizJogador, dgv);
            }
        }


        /// <summary>
        /// !!! DEVE SER INVOCADA A PARTIR DE UM EVENTO CellMouseEnter VINDO DO FORM DE MONTAR O TABULEIRO !!!
        /// <para>Atualiza a seleção visual (highlights e forbiddens) quando o cursor entra numa célula.</para>
        /// <br>Caso a célula esteja vazia, seu BG é alterado para emular um "highlight". Caso a célula possua um barco, seu BG não é alterado.</br>
        /// <br>A função leva em consideração posições impossíveis, exibindo o "highlight" em vermelho.</br>
        /// <para>Recebe as coordenadas do cursor, a matriz sobre a qual o cursor está, e o DGV a ser modificado.</para>
        /// <para>Dependente de pilhaMods, lastIndex, paramRotacao</para>
        /// </summary>
        /// <param name="e"></param>
        /// <returns>Verdadeiro caso o update tenha sido bem sucedido, falso caso tenha sido interrompido</returns>
        public static bool DGV_VisualUpdater_Entrada(Par e, TabuleiroCasa[,] matriz, DataGridView dgv)
        {
            // Evita crashes com hover sobre headers
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            { return false; }
            if (GlbVar.paramQtdSelecao < 2)
            { return false; }

            Stack<Par> pilhaIndexes = GetValidIndexes(new Par(e.RowIndex, e.ColumnIndex), matriz);
            GlbVar.pilhaMods.Clear();
            Bitmap substBG;
            //VERY SCUFFED:
            GlbVar.lastIndex.RowIndex = e.RowIndex;
            GlbVar.lastIndex.ColumnIndex = e.ColumnIndex;

            while (pilhaIndexes.Count > 0)
            {
                Par idx = pilhaIndexes.Pop();

                //Se a seleção for válida, o BG é só um "highlight"; senão, ele é vermelho.
                if (SelecaoValidaMatriz(new Par(e.RowIndex, e.ColumnIndex), matriz))
                    substBG = GlbVar.selectedBG;
                else
                    substBG = GlbVar.forbiddenBG;

                //Se não há um barco na posição destacada na matriz, o DGV altera o valor da Cell. Senão, ela fica como está.
                //Quando há alteração de valor, os índices das Cells alteradas são armazenados num stack que a DGV_Mouse_Leave usa.
                if (matriz[idx.RowIndex, idx.ColumnIndex].TipoBarco == 0)
                {
                    dgv.Rows[idx.RowIndex].Cells[idx.ColumnIndex].Value = substBG;               // !!! imagem !!!
                    GlbVar.pilhaMods.Push(idx);
                }
            }
            return true;
        }


        /// <summary>
        /// !!! DEVE SER INVOCADA A PARTIR DE UM EVENTO CellMouseLeave VINDO DO FORM DE MONTAR O TABULEIRO !!!
        /// <para>Atualiza a seleção visual para remover highlights e forbiddens quando o cursor sai de uma célula.</para>
        /// <br>Usa uma pilha global montada por DGV_VisualUpdater_Entrada. </br>
        /// <para>Dependente de pilhaMods</para>
        /// </summary>
        /// <param name="e"></param>
        /// <param name="matriz"></param>
        /// <returns>Verdadeiro caso o update tenha sido bem sucedido, falso caso tenha sido interrompido</returns>
        public static bool DGV_VisualUpdater_Saida(Par e, TabuleiroCasa[,] matriz, DataGridView dgv)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            { return false; }

            while (GlbVar.pilhaMods.Count > 0)
            {
                Par idx = GlbVar.pilhaMods.Pop();
                dgv.Rows[idx.RowIndex].Cells[idx.ColumnIndex].Value = matriz[idx.RowIndex, idx.ColumnIndex].DeterminarSprite();
            }

            return true;
        }


        /// <summary>
        /// !!! DEVE SER INVOCADA A PARTIR DE UM EVENTO dataGridView_CellClick VINDO DE UM DGV NO FORM DE MONTAR O TABULEIRO !!!
        /// <para>Coloca o barco selecionado na matriz. O barco selecionado é controlado por paramQtdSelecao</para>
        /// <para>Dependente de dicBotoes, paramQtdSelecao</para>
        /// </summary>
        /// <param name="e"></param>
        /// <param name="matriz"></param>
        /// <returns>Verdadeiro caso o posicionamento tenha sido bem sucedido, falso caso tenha sido interrompido</returns>
        public static bool MatrixUpdater_Clique(Par e, TabuleiroCasa[,] matriz)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            { return false; }
            if (GlbVar.paramQtdSelecao < 2)
            { return false; }

            if (SelecaoValidaMatriz(new Par(e.RowIndex, e.ColumnIndex), matriz))
            {
                PosicionarBarcoMatriz(new Par(e.RowIndex, e.ColumnIndex), matriz); //fazer maluqices de modificar a matriz
                                                                                   //e depois chamar a função de modificar o dgv [nunca foi feito! preguiça...]
                GlbVar.dicBotoes[GlbVar.paramQtdSelecao].Enabled = false;         //desabilitar botões também. aqui o dicionário pode ser bem útil...
                GlbVar.paramQtdSelecao = 0;
            }
            else
            {
                return false;
            }
            return true;
        }


        /// <summary>
        /// !!! DEVE SER INVOCADA A PARTIR DE UM EVENTO btn_Click VINDO DE UM BUTTON START NO FORM DE MONTAR O TABULEIRO !!!
        /// <para>Checa se o jogo pode começar. A condição é todos os barcos estarem posicionados - ou todos os botões estarem desabilitados...</para>
        /// <para>Depende de dicBotoes</para>
        /// </summary>
        /// <returns>Retorna verdadeiro caso todos os barcos estejam no tabuleiro, falso caso contrário</returns>
        public static bool ChecarCondicoesInicio()
        {
            bool flag = true;
            for (int i = 2; i < 6; i++)
            {
                flag = flag && !GlbVar.dicBotoes[i].Enabled;       //Se todos os botões estiverem desabilitados (barcos posicionados), sinal verde
            }
            if (flag)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /* Seção para funções usadas exclusivamente enqaunto o jogador está jogando, após se preparar
         *
         */

        /// <summary>
        /// Edita a matriz que recebeu um tiro.
        /// <br>Recebe um Par e, que representa a posição do tiro no tabuleiro, e recebe a matriz onde vai colocar o tiro.</br>
        /// </summary>
        /// <param name="e"></param>
        /// <param name="matriz"></param>
        /// <returns>Retorna verdadeiro caso o tiro acerte um barco, e falso caso contrário.</returns>
        public static bool TiroMatriz(Par e, TabuleiroCasa[,] matriz)
        {
            int rowindex = e.RowIndex;
            int columnindex = e.ColumnIndex;

            if (rowindex > 9 || rowindex < 0 || columnindex > 9 || columnindex < 0) { return false; }       // .... just in case.

            TabuleiroCasa casa = matriz[rowindex, columnindex];

            casa.Estado = 1;
            return (casa.TipoBarco != 0) ? true : false;
        }


        /// <summary>
        /// Atualiza o display do DGV de acordo com a configuração de cada casa da matriz recebida.
        /// <para>Recebe o DGV a ser modificado, e a matriz de onde puxar os dados.</para>
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="matriz"></param>
        public static void UpdateDGVTotal(DataGridView dgv, TabuleiroCasa[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for(int j = 0; j < matriz.GetLength(1); j++)
                {
                    dgv.Rows[i].Cells[j].Value = matriz[i, j].DeterminarSprite();
                }
            }
        }


        /// <summary>
        /// Atualiza o display do DGV do tabuleiro apenas na posição do último tiro dado.
        /// <para>Recebe o DGV a ser modificado, a matriz de onde puxar os dados, e a posição do último tiro.</para>
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="p"></param>
        public static void UpdateDGVTiroUnico(DataGridView dgv, TabuleiroCasa[,] matriz, Par p)
        {
            dgv.Rows[p.RowIndex].Cells[p.ColumnIndex].Value = matriz[p.RowIndex, p.ColumnIndex].DeterminarSprite();
        }


        /// <summary>
        /// Recebe um DGV e inicializa ele com o sprite de selectedBG, como névoa de guerra.
        /// <br>Normalmente chamado para o tabuleiro do oponente, antes de iniciar o jogo.</br>
        /// <para>Recebe o DGV a ser atualizado, e a matriz correspondente (para pegar as dimensões)</para>
        /// </summary>
        /// <param name="dgv"></param>
        public static void UpdateDGVFogOfWar(DataGridView dgv, TabuleiroCasa[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0);i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    dgv.Rows[i].Cells[j].Value = GlbVar.selectedBG;
                }
            }
        }


        /// <summary>
        /// Checa se o tabuleiro recebido perdeu todos os barcos.
        /// </summary>
        /// <para>Recebe a matriz (tabuleiro) a ser verificada</para>
        /// <param name="matriz"></param>
        /// <returns>True se o tabuleiro recebido tiver perdido todos os barcos, False caso contrário</returns>
        public static bool ChecarFimDeJogo(TabuleiroCasa[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j].TipoBarco != 0 && matriz[i, j].Estado == 0)  //Significa que há um barco, e ele não está afundado
                        return false;
                }
            }
            return true;
        }
    }
}
