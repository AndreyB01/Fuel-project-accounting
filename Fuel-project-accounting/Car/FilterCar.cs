using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_project_accounting.Car
{
    public partial class FilterCar : Form
    {
        private DataGridViewColumn Col { get; set; }
        public FilterCar()
        {
            InitializeComponent();
        }

        private void FilterCar_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "грузоперевозкиDataSet.ПросмотрАвто". При необходимости она может быть перемещена или удалена.
            this.просмотрАвтоTableAdapter.Fill(this.грузоперевозкиDataSet.ПросмотрАвто);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            просмотрАвтоBindingSource.Filter = $"Марка='{comboBox1.Text}'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= просмотрАвтоDataGridView.Columns.Count - 1; i++)
            {
                for (int j = 0; j < просмотрАвтоDataGridView.Rows.Count - 1; j++)
                {
                    просмотрАвтоDataGridView[i, j].Style.BackColor = Color.White;
                    просмотрАвтоDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i <= просмотрАвтоDataGridView.Columns.Count - 1; i++)
            {
                for (int j = 0; j < просмотрАвтоDataGridView.Rows.Count - 1; j++)
                {
                    if (просмотрАвтоDataGridView[i, j].Value.ToString().IndexOf(textBox1.Text) >= 0)
                    {
                        просмотрАвтоDataGridView[i, j].Style.BackColor = Color.Yellow;
                        просмотрАвтоDataGridView[i, j].Style.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            просмотрАвтоBindingSource.Filter = "";
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
                case 3:
                    Col = dataGridViewTextBoxColumn4;
                    break;
                case 4:
                    Col = dataGridViewTextBoxColumn5;
                    break;
                case 5:
                    Col = dataGridViewTextBoxColumn6;
                    break;
                case 6:
                    Col = dataGridViewTextBoxColumn7;
                    break;
                default:
                    break;
            }
            if (radioButton1.Checked == true)
            {
                просмотрАвтоDataGridView.Sort(Col, ListSortDirection.Ascending);
            }
            else
            {
                просмотрАвтоDataGridView.Sort(Col, ListSortDirection.Descending);
            }
        }
    }
}
