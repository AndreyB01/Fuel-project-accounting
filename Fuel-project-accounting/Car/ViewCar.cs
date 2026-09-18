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
    public partial class ViewCar : Form
    {
        public ViewCar()
        {
            InitializeComponent();
        }

        private void автоBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.автоBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.грузоперевозкиDataSet);

        }

        private void ViewCar_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "грузоперевозкиDataSet.Авто". При необходимости она может быть перемещена или удалена.
            this.автоTableAdapter.Fill(this.грузоперевозкиDataSet.Авто);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            автоBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            автоBindingSource.MovePrevious();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            автоBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            автоBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            автоBindingSource.AddNew();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.автоBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.грузоперевозкиDataSet);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            автоBindingSource.RemoveCurrent();
        }
    }
}
