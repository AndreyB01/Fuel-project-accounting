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
    public partial class SearchMarsrut : Form
    {
        public SearchMarsrut()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.поиск_По_МаршрутамTableAdapter.Fill(this.грузоперевозкиDataSet.Поиск_По_Маршрутам, откудаПроцToolStripTextBox.Text, кудаПроцToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
