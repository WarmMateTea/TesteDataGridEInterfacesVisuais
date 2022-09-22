using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDataGridEInterfacesVisuais
{
    public static class SpriteSheet
    {
        //                                     [2     , 5        , 2         , 3         ]
        //                                     [estado, tipoBarco, orientacao, tipoSprite]

        /// <summary>
        /// Isso é um array 4-dimensional que contém os sprites apropriados, visto que não há possibilidade padrão de sobreposição + transparência no forms.
        /// <br>O array contém ~2*5*2*3 = 60 sprites, embora eu não os tenha diferenciado suficientemente entre si.</br>
        /// <br>Se vc quiser mexer aqui, boa sorte. Salve um backup antes.</br>
        /// </summary>
        static public Bitmap[,,,] sprites = new Bitmap[2, 5, 2, 3]
        {

            {//Estado: não atingido
                {//Tipo de Barco: água, 2, 3, 4 ,5
                    {//Orientação: horizontal, vertical
                        //tipo sprite: bunda, meio, frente
                        Properties.Resources._default, Properties.Resources._default, Properties.Resources._default
                    },
                    {
                        Properties.Resources._default, Properties.Resources._default, Properties.Resources._default
                    }
                },
                {//2
                    {//h
                        Properties.Resources._0barco2H0, null, Properties.Resources._0barco2H2
                    },
                    {//v
                        Properties.Resources._0barco2V0, null, Properties.Resources._0barco2V2
                    }
                },
                {//3
                    {//h
                        Properties.Resources._0barco2H0, Properties.Resources._0barco2H1, Properties.Resources._0barco2H2
                    },
                    {//v
                        Properties.Resources._0barco2V0, Properties.Resources._0barco2V1, Properties.Resources._0barco2V2
                    }
                },
                {//4
                    {//h
                        Properties.Resources._0barco2H0, Properties.Resources._0barco2H1, Properties.Resources._0barco2H2
                    },
                    {//v
                        Properties.Resources._0barco2V0, Properties.Resources._0barco2V1, Properties.Resources._0barco2V2
                    }
                },
                {//5
                    {//h
                        Properties.Resources._0barco2H0, Properties.Resources._0barco2H1, Properties.Resources._0barco2H2
                    },
                    {//v
                        Properties.Resources._0barco2V0, Properties.Resources._0barco2V1, Properties.Resources._0barco2V2
                    }
                }
            },


            {//Estado: atingido
                {//Tipo de Barco: água, 2, 3, 4 ,5
                    {//Orientação: vertical, horizontal
                        //tipo sprite: bunda, meio, frente
                        Properties.Resources.forbidden, Properties.Resources.forbidden, Properties.Resources.forbidden
                    },
                    {
                        Properties.Resources.forbidden, Properties.Resources.forbidden, Properties.Resources.forbidden
                    }
                },
                {//2
                    {
                        Properties.Resources._1barco2H0, null, Properties.Resources._1barco2H20
                    },
                    {
                        Properties.Resources._1barco2V0, null, Properties.Resources._1barco2V20
                    }
                },
                {//3
                    {
                        Properties.Resources._1barco2H0, Properties.Resources._1barco2H1, Properties.Resources._1barco2H20
                    },
                    {
                        Properties.Resources._1barco2V0, Properties.Resources._1barco2V1, Properties.Resources._1barco2V20
                    }
                },
                {//4
                    {
                        Properties.Resources._1barco2H0, Properties.Resources._1barco2H1, Properties.Resources._1barco2H20
                    },
                    {
                        Properties.Resources._1barco2V0, Properties.Resources._1barco2V1, Properties.Resources._1barco2V20
                    }
                },
                {//5
                    {
                        Properties.Resources._1barco2H0, Properties.Resources._1barco2H1, Properties.Resources._1barco2H20
                    },
                    {
                        Properties.Resources._1barco2V0, Properties.Resources._1barco2V1, Properties.Resources._1barco2V20
                    }
                }
            }
        };
        

        
    }
}
