using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDataGridEInterfacesVisuais
{
    public class Par
    {
        private int rowIndex, columnIndex;

        public Par(int rowIndex, int columnIndex)
        {
            this.RowIndex = rowIndex;
            this.ColumnIndex = columnIndex; 
        }

        public int RowIndex { get => rowIndex; set => rowIndex = value; }
        public int ColumnIndex { get => columnIndex; set => columnIndex = value; }

        public Boolean parIdentico(Par par)
        {
            if(par == null)
            {
                return false;
            }

            if(!(rowIndex== par.rowIndex))
            {
                return false;
            }

            if (!(ColumnIndex == par.ColumnIndex))
            {
                return false;
            }

            return true;
        }
    }
}
