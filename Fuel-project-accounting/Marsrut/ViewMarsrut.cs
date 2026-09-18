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
    public partial class ViewMarsrut : Form
    {
        public ViewMarsrut()
        {
            InitializeComponent();
        }

        private void ViewMarsrut_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "грузоперевозкиDataSet.ПросмотрМаршрутов". При необходимости она может быть перемещена или удалена.
            this.просмотрМаршрутовTableAdapter.Fill(this.грузоперевозкиDataSet.ПросмотрМаршрутов);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            просмотрМаршрутовBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            просмотрМаршрутовBindingSource.MovePrevious();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            просмотрМаршрутовBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            просмотрМаршрутовBindingSource.MoveLast();
        }
    }
}
