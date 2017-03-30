using System;
using System.Collections;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interactivity;
using DevExpress.Xpf.Grid;
using System.Collections.Generic;

namespace WPFGridControlCustomBandBehaviour
{
    public class BandBehaviour : Behavior<GridControl>
    {
        public static readonly DependencyProperty BandsSourceProperty = DependencyProperty.Register("BandsSource", typeof(IEnumerable<Band>), typeof(BandBehaviour), new PropertyMetadata(default(IEnumerable<Band>)));

        protected override void OnAttached()
        {
            if (BandsSource == null || !BandsSource.Any()) return;

            AssociatedObject.ColumnGeneratorTemplateSelector = new ColumnTemplateSelector(AssociatedObject);

            foreach (var band in BandsSource)
            {
                var bandTemplate = AssociatedObject.TryFindResource(band.Type + "BandTemplate") as DataTemplate;
                if (bandTemplate == null)
                {
                    throw new Exception(string.Format("Could not find Band DataTemplate '{0}' for Band '{1}'", band.Type + "BandTemplate", band.Header));
                }

                var contentControl = (ContentControl)bandTemplate.LoadContent();
                var gridControlBand = (GridControlBand)contentControl.Content;
                contentControl.Content = null;

                gridControlBand.Header = band.Header;
                gridControlBand.ColumnsSource = band.ChildColumns;

                AssociatedObject.Bands.Add(gridControlBand);
            }
        }

        public IEnumerable<Band> BandsSource
        {
            get { return (IEnumerable<Band>)GetValue(BandsSourceProperty); }
            set { SetValue(BandsSourceProperty, value); }
        }
    }
}
