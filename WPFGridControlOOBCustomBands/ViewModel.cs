using System.Collections.ObjectModel;

namespace WPFGridControlOOBCustomBands
{
    public class ViewModel
    {
        public ObservableCollection<Security> Securities { get; set; }

        public ObservableCollection<Band> Bands { get; set; }

        public ViewModel()
        {
            Securities = new ObservableCollection<Security>();
            Securities.Add(new Security{ Id = 1, Name = "APPL", BrokerName = "MS"});
            Securities.Add(new Security{ Id = 2, Name = "BLOOMBERG", BrokerName = "BA"});

            Bands = new ObservableCollection<Band>
            {
                new Band
                {
                    Header = "Security",
                    ChildColumns = new ObservableCollection<Column>
                    {
                        new Column {Header = "ID", FieldName = "Id", Type = "CenterAllignment"},
                        new Column {Header = "ID", FieldName = "Id", Type = "Default"}
                    }
                },
                new Band
                {
                    Header = "Broker",
                    ChildColumns = new ObservableCollection<Column>
                    {
                        new Column {Header = "Name", FieldName = "BrokerName", Type = "Default"}
                    }
                }
            };
        }
    }
}
