using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_project_accounting.GSM
{
    public partial class EditGSM : Form
    {
        public EditGSM()
        {
            InitializeComponent();
        }

        private void гСНBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.гСНBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.грузоперевозкиDataSet);

        }

        private void EditGSM_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "грузоперевозкиDataSet.ГСН". При необходимости она может быть перемещена или удалена.
            this.гСНTableAdapter.Fill(this.грузоперевозкиDataSet.ГСН);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            гСНBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            гСНBindingSource.MoveFirst();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            гСНBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            гСНBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            гСНBindingSource.AddNew();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.гСНBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.грузоперевозкиDataSet);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            гСНBindingSource.RemoveCurrent();
        }
    }
}
