using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_project_accounting.Functions
{
    public partial class FunctionsMainForm : Form
    {
        public FunctionsMainForm()
        {
            InitializeComponent();
        }

        private void FunctionsMainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "грузоперевозкиDataSet.ПросмотрВодители". При необходимости она может быть перемещена или удалена.
            this.просмотрВодителиTableAdapter.Fill(this.грузоперевозкиDataSet.ПросмотрВодители);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "грузоперевозкиDataSet.ОтчетДвижениеГНС_Выдача". При необходимости она может быть перемещена или удалена.
            this.отчетДвижениеГНС_ВыдачаTableAdapter.Fill(this.грузоперевозкиDataSet.ОтчетДвижениеГНС_Выдача);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateChart2(просмотрВодителиDataGridView, "Отчет по стажу вождения", "Name my series");
        }

        private void CreateChart2(DataGridView grid, string nameTitle, string seriesName)
        {
            try
            {
                chart1.Series.Clear();
                chart1.Series.Add(seriesName);

                for (int i = 0; i < grid.RowCount; i++)
                {
                    var name = grid.Rows[i].Cells[0].Value?.ToString() ?? "";
                    var value = grid.Rows[i].Cells[1].Value?.ToString() ?? "";
                    chart1.Series[seriesName].Points.AddXY(name, value);
                }
                chart1.Titles.Clear();
                chart1.Titles.Add(nameTitle);

                chart1.ChartAreas[0].AxisX.Title = grid.Columns[0].HeaderText;
                chart1.ChartAreas[0].AxisY.Title = grid.Columns[1].HeaderText;

                MessageBox.Show("График сформирован", "Успех");
            }

            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Ошибка: Недостаточно столбцов в DataGridView", "Ошибка");
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка: недопустимые данные в DataGridView", "Ошибка");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[0].ChartType =System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
        }
    }
}
