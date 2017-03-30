using System.Collections.ObjectModel;

namespace WPFGridControlCustomBandBehaviour
{
    public class Band
    {
        public string Header { get; set; }
        public ObservableCollection<Column> ChildColumns { get; set; }
        public string Type { get; set; }
    }
}
