using System.Collections.ObjectModel;

namespace WPFGridControlCustomBehavior
{
    public class Band
    {
        public string Header { get; set; }
        public ObservableCollection<Column> ChildColumns { get; set; }
    }
}
