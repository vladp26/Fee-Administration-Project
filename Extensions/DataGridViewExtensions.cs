using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_v2.Extensions
{
    public static class DataGridViewExtensions
    {
        public static DataGridView refreshDataGridView<T>(this DataGridView dataGridView, List<T> data)
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = data;
            return dataGridView;
        }
        public static DataGridView addColumn(this DataGridView dataGridView, int index, string headerText, string dataPropertyName)
        {
            dataGridView.ColumnCount++;
            dataGridView.Columns[index].HeaderText = headerText;
            dataGridView.Columns[index].DataPropertyName = dataPropertyName;
            return dataGridView;
        }
        public static DataGridView addButtonColumn(this DataGridView dataGridView, string name, string buttonText, string headerText)
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = name;
            buttonColumn.Text = buttonText;
            buttonColumn.HeaderText = headerText;
            buttonColumn.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Add(buttonColumn);
            return dataGridView;
        }
    }
}
