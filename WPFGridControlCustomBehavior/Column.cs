namespace WPFGridControlCustomBehavior
{
    public class Column
    {
        public string Header { get; set; }
        public string FieldName { get; set; }

        /// <summary>
        /// DataTemplate of "Type"+"ColumnTemplate" will be applied
        /// </summary>
        public string Type { get; set; }

    }
}
