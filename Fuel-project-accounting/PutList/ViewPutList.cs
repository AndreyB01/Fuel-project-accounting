using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_project_accounting.PutList
{
    public partial class ViewPutList : Form
    {
        public ViewPutList()
        {
            InitializeComponent();
        }

        private void ViewPutList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "грузоперевозкиDataSet.ПросмотрПутевойЛист". При необходимости она может быть перемещена или удалена.
            this.просмотрПутевойЛистTableAdapter.Fill(this.грузоперевозкиDataSet.ПросмотрПутевойЛист);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            просмотрПутевойЛистBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            просмотрПутевойЛистBindingSource.MovePrevious();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            просмотрПутевойЛистBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            просмотрПутевойЛистBindingSource.MoveLast();
        }
    }
}
