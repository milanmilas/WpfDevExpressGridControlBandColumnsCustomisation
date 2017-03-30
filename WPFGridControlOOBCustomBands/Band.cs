using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFGridControlOOBCustomBands
{
    public class Band
    {
        public string Header { get; set; }
        public ObservableCollection<Column> ChildColumns { get; set; }
    }
}
