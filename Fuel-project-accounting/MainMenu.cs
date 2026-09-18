using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_project_accounting
{
    public partial class MainMenu : Form
    {
        Point lastPoint;
        public MainMenu()
        {
            InitializeComponent();
            AbrirFormasas(new FormMenu());
        }


        private void AbrirFormasas(object Formasas)
        {
            if (this.panel4.Controls.Count > 0)
                this.panel4.Controls.RemoveAt(0);
            Form fn = Formasas as Form;
            fn.TopLevel = false;
            fn.Dock = DockStyle.Fill;
            this.panel4.Controls.Add(fn);
            this.panel4.Tag = fn;
            fn.Show();

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 205)
            {
                pictureBox1.Visible = false;
                panel1.Width = 40;
                button6.Visible = true;
            }
            else
                panel1.Width = 205;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 40)
            {
                pictureBox1.Visible = true;
                panel1.Width = 205;
                button6.Visible = false;
            }
            else
                panel1.Width = 40;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormasas(new Car.CarMainForm());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormasas(new Driver.DriverMainForm());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormasas(new PutList.PutListMainForm());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormasas(new Postavchik.PostavchikMainForm());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AbrirFormasas(new Marsrut.MarsrutMainForm());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AbrirFormasas(new GSM.GSMMainForm());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AbrirFormasas(new PostavkaGSM.PostavkaGSMMainForm());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AbrirFormasas(new VidachaGSM.VidachaGSMMainForm());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AbrirFormasas(new Functions.FunctionsMainForm());
        }
    }
}
