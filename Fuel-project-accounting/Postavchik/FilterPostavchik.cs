using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_project_accounting.Postavchik
{
    public partial class FilterPostavchik : Form
    {
        private DataGridViewColumn Col { get; set; }
        public FilterPostavchik()
        {
            InitializeComponent();
        }

        private void FilterPostavchik_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "грузоперевозкиDataSet.ПросмотрПоставщиков". При необходимости она может быть перемещена или удалена.
            this.просмотрПоставщиковTableAdapter.Fill(this.грузоперевозкиDataSet.ПросмотрПоставщиков);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            просмотрПоставщиковBindingSource.Filter = $"НаименованиеОрганизаци='{comboBox1.Text}'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= просмотрПоставщиковDataGridView.Columns.Count - 1; i++)
            {
                for (int j = 0; j < просмотрПоставщиковDataGridView.Rows.Count - 1; j++)
                {
                    просмотрПоставщиковDataGridView[i, j].Style.BackColor = Color.White;
                    просмотрПоставщиковDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i <= просмотрПоставщиковDataGridView.Columns.Count - 1; i++)
            {
                for (int j = 0; j < просмотрПоставщиковDataGridView.Rows.Count - 1; j++)
                {
                    if (просмотрПоставщиковDataGridView[i, j].Value.ToString().IndexOf(textBox1.Text) >= 0)
                    {
                        просмотрПоставщиковDataGridView[i, j].Style.BackColor = Color.Yellow;
                        просмотрПоставщиковDataGridView[i, j].Style.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            просмотрПоставщиковBindingSource.Filter = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    Col = dataGridViewTextBoxColumn1;
                    break;
                case 1:
                    Col = dataGridViewTextBoxColumn2;
                    break;
                case 2:
                    Col = dataGridViewTextBoxColumn3;
                    break;
                default:
                    break;
            }
            if (radioButton1.Checked == true)
            {
                просмотрПоставщиковDataGridView.Sort(Col, ListSortDirection.Ascending);
            }
            else
            {
                просмотрПоставщиковDataGridView.Sort(Col, ListSortDirection.Descending);
            }
        }
    }
}
