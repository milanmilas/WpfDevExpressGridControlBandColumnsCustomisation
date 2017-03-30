using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfGridControlOutOfBox
{
    public class ViewModel
    {
        public ObservableCollection<Security> Securities { get; set; }

        public ViewModel()
        {
            Securities = new ObservableCollection<Security>();
            Securities.Add(new Security{ Id = 1, Name = "APPL", BrokerName = "MS"});
            Securities.Add(new Security{ Id = 2, Name = "BLOOMBERG", BrokerName = "BA"});
        }
    }
}
