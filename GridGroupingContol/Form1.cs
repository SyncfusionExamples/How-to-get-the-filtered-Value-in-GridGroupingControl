using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Collections;
using Syncfusion.GridHelperClasses;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;

namespace GridGroupingControl_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Create a new DataTable
            DataTable dt = new DataTable();

            // Add 5 columns: mix of int and string
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Age", typeof(int));
            dt.Columns.Add("City", typeof(string));
            dt.Columns.Add("Score", typeof(int));

            // Add 10 rows of sample data
            for (int i = 1; i <= 10; i++)
            {
                dt.Rows.Add(i, $"Name{i}", 20 + i, $"City{i}", 80 + i);
            }

            // Bind the DataTable to GridGroupingControl
            gridGroupingControl1.DataSource = dt;

            GridExcelFilter gridExcelFilter = new GridExcelFilter();

            // Allowing Filter Bar for all columns in the Parent Table.
            foreach (GridColumnDescriptor col in this.gridGroupingControl1.TableDescriptor.Columns)
            {
                col.AllowFilter = true;
            }

            //Wiring GridExcelFilter to GridGroupingControl
            gridExcelFilter.WireGrid(this.gridGroupingControl1);

            gridExcelFilter.RecordFiltersItemChanged += OnRecordFiltersItemChanged;

        }

        private void OnRecordFiltersItemChanged(object sender, ListPropertyChangedEventArgs e)
        {
            var filteredValues = (e.Tag as Dictionary<string, List<string>>).Values;
        }
    }
}
