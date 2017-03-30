using System.Windows;
using System.Windows.Controls;
using DevExpress.Xpf.Grid;

namespace WPFGridControlCustomBehavior
{
    public class ColumnTemplateSelector : DataTemplateSelector
    {
        private readonly GridControl _gridControl;

        public ColumnTemplateSelector(GridControl gridControl)
        {
            _gridControl = gridControl;
        }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            Column column = (Column)item;
            return (DataTemplate)_gridControl.FindResource(column.Type + "ColumnTemplate");
        }
    }
}
