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
    public partial class EditPutList : Form
    {
        public EditPutList()
        {
            InitializeComponent();
        }

        private void путевойЛистBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.путевойЛистBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.грузоперевозкиDataSet);

        }

        private void путевойЛистBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.путевойЛистBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.грузоперевозкиDataSet);

        }

        private void EditPutList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "грузоперевозкиDataSet.ПутевойЛист". При необходимости она может быть перемещена или удалена.
            this.путевойЛистTableAdapter.Fill(this.грузоперевозкиDataSet.ПутевойЛист);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            путевойЛистBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            путевойЛистBindingSource.MovePrevious();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            путевойЛистBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            путевойЛистBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            путевойЛистBindingSource.AddNew();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.путевойЛистBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.грузоперевозкиDataSet);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            путевойЛистBindingSource.RemoveCurrent();
        }
    }
}
