using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using OfficeOpenXml; // Не забудьте добавить этот using
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace Fuel_project_accounting.PutList
{
    public partial class FilterPutList : Form
    {
        private WordEx wordEx;
        private ExcelEx excelEx;
        private DataGridViewColumn Col { get; set; }
        public FilterPutList()
        {
            wordEx = new WordEx();
            excelEx = new ExcelEx();
            InitializeComponent();

        }

        private void FilterPutList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "грузоперевозкиDataSet.ПросмотрПутевойЛист". При необходимости она может быть перемещена или удалена.
            this.просмотрПутевойЛистTableAdapter.Fill(this.грузоперевозкиDataSet.ПросмотрПутевойЛист);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            просмотрПутевойЛистBindingSource.Filter = $"Номер='{comboBox1.Text}'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= просмотрПутевойЛистDataGridView.Columns.Count - 1; i++)
            {
                for (int j = 0; j < просмотрПутевойЛистDataGridView.Rows.Count - 1; j++)
                {
                    просмотрПутевойЛистDataGridView[i, j].Style.BackColor = Color.White;
                    просмотрПутевойЛистDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i <= просмотрПутевойЛистDataGridView.Columns.Count - 1; i++)
            {
                for (int j = 0; j < просмотрПутевойЛистDataGridView.Rows.Count - 1; j++)
                {
                    if (просмотрПутевойЛистDataGridView[i, j].Value.ToString().IndexOf(textBox1.Text) >= 0)
                    {
                        просмотрПутевойЛистDataGridView[i, j].Style.BackColor = Color.Yellow;
                        просмотрПутевойЛистDataGridView[i, j].Style.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            просмотрПутевойЛистBindingSource.Filter = "";
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
                    Col = dataGridViewTextBoxColumn6;
                    break;
                case 4:
                    Col = dataGridViewTextBoxColumn7;
                    break;
                case 5:
                    Col = dataGridViewTextBoxColumn8;
                    break;
                case 6:
                    Col = dataGridViewTextBoxColumn11;
                    break;
                default:
                    break;
            }
            if (radioButton1.Checked == true)
            {
                просмотрПутевойЛистDataGridView.Sort(Col, ListSortDirection.Ascending);
            }
            else
            {
                просмотрПутевойЛистDataGridView.Sort(Col, ListSortDirection.Descending);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            wordEx.WordExpotr(просмотрПутевойЛистDataGridView);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            excelEx.ExcelExpotr(просмотрПутевойЛистDataGridView);
        }
    }
}
