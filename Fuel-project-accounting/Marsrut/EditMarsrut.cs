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
    public partial class EditMarsrut : Form
    {
        public EditMarsrut()
        {
            InitializeComponent();
        }

        private void маршрутПередвеженияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.маршрутПередвеженияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.грузоперевозкиDataSet);

        }

        private void EditMarsrut_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "грузоперевозкиDataSet.МаршрутПередвежения". При необходимости она может быть перемещена или удалена.
            this.маршрутПередвеженияTableAdapter.Fill(this.грузоперевозкиDataSet.МаршрутПередвежения);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            маршрутПередвеженияBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            маршрутПередвеженияBindingSource.MovePrevious();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            маршрутПередвеженияBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            маршрутПередвеженияBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            маршрутПередвеженияBindingSource.AddNew();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.маршрутПередвеженияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.грузоперевозкиDataSet);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            маршрутПередвеженияBindingSource.RemoveCurrent();
        }
    }
}
