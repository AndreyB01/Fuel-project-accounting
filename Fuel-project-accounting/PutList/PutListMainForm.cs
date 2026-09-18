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
    public partial class PutListMainForm : Form
    {
        public PutListMainForm()
        {
            InitializeComponent();
            AbrirFormasas(new PutList.ViewPutList());
        }
        private void AbrirFormasas(object Formasas)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form fn = Formasas as Form;
            fn.TopLevel = false;
            fn.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fn);
            this.panel1.Tag = fn;
            fn.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormasas(new PutList.ViewPutList());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormasas(new PutList.EditPutList());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormasas(new PutList.SearchPutList());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormasas(new PutList.FilterPutList());
        }
    }
}
