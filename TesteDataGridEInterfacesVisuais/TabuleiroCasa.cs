using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDataGridEInterfacesVisuais
{
    public class TabuleiroCasa
    {
        /// <summary>
        /// 0 - Não atingido; 1 - Atingido
        /// </summary>
        int estado;

        /// <summary>
        /// 0 - Nenhum; 1 - Destróier (2pcs); 2 - Encouraçado (3pcs); 3 - Cruzador (4pcs); 4 - Porta-aviões (5pcs)
        /// </summary>
        int tipoBarco;

        /// <summary>
        /// Só é relevante se tipoBarco for != 0
        /// <br>0 - Horizontal; 1 - Vertical</br>
        /// </summary>
        int orientacao;

        /// <summary>
        /// Só é relevante se tipoBarco for != 0
        /// <br>0 - "Bunda" do barco; 1 - "Meio" do barco; 2 - "Frente" do barco</br>
        /// </summary>
        int tipoSprite;

        public int Estado { get => estado; set => estado = value; }
        public int TipoBarco { get => tipoBarco; set => tipoBarco = value; }
        public int Orientacao { get => orientacao; set => orientacao = value; }
        public int TipoSprite { get => tipoSprite; set => tipoSprite = value; }


        /// <summary>
        /// Inicializa com os seguintes valores: estado: não atingido, tipoBarco: nenhum barco, orientacao e tipoSprite = 0
        /// </summary>
        public TabuleiroCasa()
        {
            Estado = 0;
            TipoBarco = 0;
            Orientacao = 0;
            TipoSprite = 0;
        }

        /// <summary>
        /// Reseta a casa com os seguintes valores: estado: não atingido, tipoBarco: nenhum barco, orientacao e tipoSprite = 0
        /// </summary>
        public void ResetCasa()
        {
            Estado = 0;
            TipoBarco = 0;
            Orientacao = 0;
            TipoSprite = 0;
        }

        /// <summary>
        /// Determina qual é o sprite apropriado para essa casa com base nas variáveis internas de estado, tipoBarco, orientacao e tipoSprite
        /// </summary>
        /// <returns>O sprite Bitmap apropriado</returns>
        public Bitmap DeterminarSprite()
        {
            return SpriteSheet.sprites[estado,tipoBarco,orientacao,tipoSprite];
        }
    }
}
