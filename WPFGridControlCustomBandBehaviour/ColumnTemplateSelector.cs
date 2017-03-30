using System.Windows;
using System.Windows.Controls;
using DevExpress.Xpf.Grid;

namespace WPFGridControlCustomBandBehaviour
{
    public class ColumnTemplateSelector : DataTemplateSelector
    {
        private readonly GridControl _gridControl;

        public ColumnTemplateSelector()
        {
        }
        public ColumnTemplateSelector(GridControl gridControl)
        {
            _gridControl = gridControl;
        }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            Column column = (Column)item;
            var control = _gridControl ?? ((Control) container);
            return (DataTemplate)control.FindResource(column.Type + "ColumnTemplate");
        }
    }
}
