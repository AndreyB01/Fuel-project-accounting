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
    public partial class EditPostavchik : Form
    {
        public EditPostavchik()
        {
            InitializeComponent();
        }

        private void постовщикГСМBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.постовщикГСМBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.грузоперевозкиDataSet);

        }

        private void EditPostavchik_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "грузоперевозкиDataSet.ПостовщикГСМ". При необходимости она может быть перемещена или удалена.
            this.постовщикГСМTableAdapter.Fill(this.грузоперевозкиDataSet.ПостовщикГСМ);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            постовщикГСМBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            постовщикГСМBindingSource.MovePrevious();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            постовщикГСМBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            постовщикГСМBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            постовщикГСМBindingSource.AddNew();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.постовщикГСМBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.грузоперевозкиDataSet);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            постовщикГСМBindingSource.RemoveCurrent();
        }
    }
}
