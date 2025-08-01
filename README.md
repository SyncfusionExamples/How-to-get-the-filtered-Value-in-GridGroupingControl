# How to get the filtered Value in GridGroupingControl

In [WinForms GridGroupingControl](https://help.syncfusion.com/windowsforms/gridgrouping/overview), you can retrieve the filtered values by using the [RecordFiltersItemChanged](https://help.syncfusion.com/cr/windowsforms/Syncfusion.GridHelperClasses.GridExcelFilter.html#Syncfusion_GridHelperClasses_GridExcelFilter_RecordFiltersItemChanged) event of [GridExcelFilter](https://help.syncfusion.com/cr/windowsforms/Syncfusion.GridHelperClasses.GridExcelFilter.html). This event is triggered after a filter is applied to the GridGroupingControl.
 
 ```C#
gridExcelFilter.RecordFiltersItemChanged += Filter_RecordFiltersItemChanged;

private void Filter_RecordFiltersItemChanged(object sender, ListPropertyChangedEventArgs e)
{
     var filteredValues = (e.Tag as Dictionary<string,
     System.Collections.Generic.List<string>>).Values;
}
 ```
 
Take a moment to peruse the [WinForms GridGroupingControl - RecordFiltersItemChanged](https://help.syncfusion.com/windowsforms/gridgrouping/filtering#events-2) event documentation, where you can find about the filtering with code examples.