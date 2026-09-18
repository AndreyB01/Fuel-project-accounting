using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_project_accounting.Driver
{
    public partial class EditDriver : Form
    {
        public EditDriver()
        {
            InitializeComponent();
        }

        private void водителиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.водителиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.грузоперевозкиDataSet);

        }

        private void EditDriver_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "грузоперевозкиDataSet.Водители". При необходимости она может быть перемещена или удалена.
            this.водителиTableAdapter.Fill(this.грузоперевозкиDataSet.Водители);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            водителиBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            водителиBindingSource.MovePrevious();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            водителиBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            водителиBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            водителиBindingSource.AddNew();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.водителиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.грузоперевозкиDataSet);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            водителиBindingSource.RemoveCurrent();
        }
    }
}
