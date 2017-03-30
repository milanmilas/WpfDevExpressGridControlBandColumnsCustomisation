using System.Windows;
using System.Windows.Controls;

namespace WPFGridControlOOBCustomBands
{
    public class ColumnTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            Column column = (Column)item;
            var dt = (DataTemplate)Application.Current.FindResource(column.Type + "ColumnTemplate");
            return (DataTemplate)((Control)container).FindResource(column.Type + "ColumnTemplate");
        }
    }
}
