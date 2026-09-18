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
    public partial class EditCar : Form
    {
        public EditCar()
        {
            InitializeComponent();
        }

        

        private void EditCar_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "грузоперевозкиDataSet.ПросмотрАвто". При необходимости она может быть перемещена или удалена.
            this.просмотрАвтоTableAdapter.Fill(this.грузоперевозкиDataSet.ПросмотрАвто);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            просмотрАвтоBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            просмотрАвтоBindingSource.MovePrevious();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            просмотрАвтоBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            просмотрАвтоBindingSource.MoveLast();
        }
    }
}
