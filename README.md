# How to get the filtered Value in GridGroupingControl

In [WinForms GridGroupingControl](https://help.syncfusion.com/windowsforms/gridgrouping/overview), filtered values can be accessed through the [RecordFiltersItemChanged](https://help.syncfusion.com/cr/windowsforms/Syncfusion.GridHelperClasses.GridExcelFilter.html#Syncfusion_GridHelperClasses_GridExcelFilter_RecordFiltersItemChanged) event of [GridExcelFilter](https://help.syncfusion.com/cr/windowsforms/Syncfusion.GridHelperClasses.GridExcelFilter.html). This event is triggered once a filter has been applied to the **GridGroupingControl**.

 ```C#
//Event subscription
gridExcelFilter.RecordFiltersItemChanged += OnRecordFiltersItemChanged;

//Event customization
private void OnRecordFiltersItemChanged(object sender, ListPropertyChangedEventArgs e)
{
     var filteredValues = (e.Tag as Dictionary<string, List<string>>).Values;
}
 ```
 
Take a moment to peruse the [WinForms GridGroupingControl - RecordFiltersItemChanged](https://help.syncfusion.com/windowsforms/gridgrouping/filtering#events-2) event documentation, where you can find about the filtering with code examples.