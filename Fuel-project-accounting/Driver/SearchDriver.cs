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
    public partial class SearchDriver : Form
    {
        public SearchDriver()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.поиск_По_ВодителямTableAdapter.Fill(this.грузоперевозкиDataSet.Поиск_По_Водителям, категорияПроцToolStripTextBox.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(стажПроцToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
