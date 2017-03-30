using System.Collections.ObjectModel;
using WPFGridControlCustomBehavior;

namespace WPFGridControlCustomBandBehaviour
{
    public class ViewModel
    {
        public ObservableCollection<Security> Securities { get; set; }

        public ObservableCollection<Band> Bands { get; set; }

        public ObservableCollection<Column> Columns { get; set; }

        public ViewModel()
        {
            Securities = new ObservableCollection<Security>();
            Securities.Add(new Security{ Id = 1, Name = "APPL", BrokerName = "MS"});
            Securities.Add(new Security{ Id = 2, Name = "BLOOMBERG", BrokerName = "BA"});

            Columns = new ObservableCollection<Column>();
            Columns.Add(new Column { Header = "ID", FieldName = "Id", Type = "CenterAllignment" });
            Columns.Add(new Column { Header = "Name", FieldName = "Name", Type = "Default" });

            Bands = new ObservableCollection<Band>
            {
                new Band
                {
                    Header = "Security",
                    Type = "MultiColumn",
                    ChildColumns = new ObservableCollection<Column>
                    {
                        new Column {Header = "ID", FieldName = "Id", Type = "CenterAllignment"},
                        new Column {Header = "Name", FieldName = "Name", Type = "Default"}
                    }
                },
                new Band
                {
                    Header = "Broker",
                    Type = "ingleColumn",
                    ChildColumns = new ObservableCollection<Column>
                    {
                        new Column {Header = "Name", FieldName = "BrokerName", Type = "Default"}
                    }
                }
            };
        }
    }
}
