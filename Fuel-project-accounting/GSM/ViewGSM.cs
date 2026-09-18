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
    public partial class ViewGSM : Form
    {
        public ViewGSM()
        {
            InitializeComponent();
        }

        private void гСНBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.учетГСНBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.грузоперевозкиDataSet);

        }

        private void учетГСНBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.учетГСНBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.грузоперевозкиDataSet);

        }

        private void ViewGSM_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "грузоперевозкиDataSet.УчетГСН". При необходимости она может быть перемещена или удалена.
            this.учетГСНTableAdapter.Fill(this.грузоперевозкиDataSet.УчетГСН);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            учетГСНBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            учетГСНBindingSource.MovePrevious();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            учетГСНBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            учетГСНBindingSource.MoveLast();
        }
    }
}
