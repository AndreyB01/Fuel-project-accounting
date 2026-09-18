using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_project_accounting.Marsrut
{
    public partial class FilterMarsrut : Form
    {
        private DataGridViewColumn Col { get; set; }
        public FilterMarsrut()
        {
            InitializeComponent();
        }

        private void FilterMarsrut_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "грузоперевозкиDataSet.ПросмотрМаршрутов". При необходимости она может быть перемещена или удалена.
            this.просмотрМаршрутовTableAdapter.Fill(this.грузоперевозкиDataSet.ПросмотрМаршрутов);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            просмотрМаршрутовBindingSource.Filter = $"ВремяГода='{comboBox1.Text}'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= просмотрМаршрутовDataGridView.Columns.Count - 1; i++)
            {
                for (int j = 0; j < просмотрМаршрутовDataGridView.Rows.Count - 1; j++)
                {
                    просмотрМаршрутовDataGridView[i, j].Style.BackColor = Color.White;
                    просмотрМаршрутовDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i <= просмотрМаршрутовDataGridView.Columns.Count - 1; i++)
            {
                for (int j = 0; j < просмотрМаршрутовDataGridView.Rows.Count - 1; j++)
                {
                    if (просмотрМаршрутовDataGridView[i, j].Value.ToString().IndexOf(textBox1.Text) >= 0)
                    {
                        просмотрМаршрутовDataGridView[i, j].Style.BackColor = Color.Yellow;
                        просмотрМаршрутовDataGridView[i, j].Style.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            просмотрМаршрутовBindingSource.Filter = "";
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
                default:
                    break;
            }
            if (radioButton1.Checked == true)
            {
                просмотрМаршрутовDataGridView.Sort(Col, ListSortDirection.Ascending);
            }
            else
            {
                просмотрМаршрутовDataGridView.Sort(Col, ListSortDirection.Descending);
            }
        }
    }
}
