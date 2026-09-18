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
    public partial class SearchCar : Form
    {
        public SearchCar()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.поиск_По_АвтоTableAdapter.Fill(this.грузоперевозкиDataSet.Поиск_По_Авто, маркаПроцToolStripTextBox.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(объемдвигателяПроцToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.поиск_По_АвтоTableAdapter.Fill(this.грузоперевозкиDataSet.Поиск_По_Авто, маркаПроцToolStripTextBox.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(объемдвигателяПроцToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
