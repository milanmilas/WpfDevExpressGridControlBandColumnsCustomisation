using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFGridControlOOBCustomColumns
{
    public class Column
    {
        public string Header { get; set; }
        public string FieldName { get; set; }

        /// <summary>
        /// DataTemplate of "Type"+"ColumnTemplate" will be applied
        /// </summary>
        public string Type { get; set; }

    }
}
