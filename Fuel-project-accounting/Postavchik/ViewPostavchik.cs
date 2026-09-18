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
    public partial class ViewPostavchik : Form
    {
        public ViewPostavchik()
        {
            InitializeComponent();
        }

        private void ViewPostavchik_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "грузоперевозкиDataSet.ПросмотрПоставщиков". При необходимости она может быть перемещена или удалена.
            this.просмотрПоставщиковTableAdapter.Fill(this.грузоперевозкиDataSet.ПросмотрПоставщиков);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            просмотрПоставщиковBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            просмотрПоставщиковBindingSource.MovePrevious();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            просмотрПоставщиковBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            просмотрПоставщиковBindingSource.MoveLast();
        }
    }
}
