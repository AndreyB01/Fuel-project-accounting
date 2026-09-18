namespace Fuel_project_accounting.PutList
{
    partial class ViewPutList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label откудаLabel;
            System.Windows.Forms.Label кудаLabel;
            System.Windows.Forms.Label километражLabel;
            System.Windows.Forms.Label времяГодаLabel;
            System.Windows.Forms.Label маршрутМестностиLabel;
            System.Windows.Forms.Label маркаLabel;
            System.Windows.Forms.Label модельLabel;
            System.Windows.Forms.Label номерLabel;
            System.Windows.Forms.Label видТопливаLabel;
            System.Windows.Forms.Label литровКВыдачеLabel;
            System.Windows.Forms.Label фамилияLabel;
            System.Windows.Forms.Label имяLabel;
            System.Windows.Forms.Label отчествоLabel;
            this.грузоперевозкиDataSet = new Fuel_project_accounting.ГрузоперевозкиDataSet();
            this.просмотрПутевойЛистBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.просмотрПутевойЛистTableAdapter = new Fuel_project_accounting.ГрузоперевозкиDataSetTableAdapters.ПросмотрПутевойЛистTableAdapter();
            this.tableAdapterManager = new Fuel_project_accounting.ГрузоперевозкиDataSetTableAdapters.TableAdapterManager();
            this.откудаTextBox = new System.Windows.Forms.TextBox();
            this.кудаTextBox = new System.Windows.Forms.TextBox();
            this.километражTextBox = new System.Windows.Forms.TextBox();
            this.времяГодаTextBox = new System.Windows.Forms.TextBox();
            this.маршрутМестностиTextBox = new System.Windows.Forms.TextBox();
            this.маркаTextBox = new System.Windows.Forms.TextBox();
            this.модельTextBox = new System.Windows.Forms.TextBox();
            this.номерTextBox = new System.Windows.Forms.TextBox();
            this.видТопливаTextBox = new System.Windows.Forms.TextBox();
            this.литровКВыдачеTextBox = new System.Windows.Forms.TextBox();
            this.фамилияTextBox = new System.Windows.Forms.TextBox();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            this.отчествоTextBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            откудаLabel = new System.Windows.Forms.Label();
            кудаLabel = new System.Windows.Forms.Label();
            километражLabel = new System.Windows.Forms.Label();
            времяГодаLabel = new System.Windows.Forms.Label();
            маршрутМестностиLabel = new System.Windows.Forms.Label();
            маркаLabel = new System.Windows.Forms.Label();
            модельLabel = new System.Windows.Forms.Label();
            номерLabel = new System.Windows.Forms.Label();
            видТопливаLabel = new System.Windows.Forms.Label();
            литровКВыдачеLabel = new System.Windows.Forms.Label();
            фамилияLabel = new System.Windows.Forms.Label();
            имяLabel = new System.Windows.Forms.Label();
            отчествоLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.грузоперевозкиDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.просмотрПутевойЛистBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // грузоперевозкиDataSet
            // 
            this.грузоперевозкиDataSet.DataSetName = "ГрузоперевозкиDataSet";
            this.грузоперевозкиDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // просмотрПутевойЛистBindingSource
            // 
            this.просмотрПутевойЛистBindingSource.DataMember = "ПросмотрПутевойЛист";
            this.просмотрПутевойЛистBindingSource.DataSource = this.грузоперевозкиDataSet;
            // 
            // просмотрПутевойЛистTableAdapter
            // 
            this.просмотрПутевойЛистTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Fuel_project_accounting.ГрузоперевозкиDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвтоTableAdapter = null;
            this.tableAdapterManager.ВидыГСМTableAdapter = null;
            this.tableAdapterManager.ВодителиTableAdapter = null;
            this.tableAdapterManager.ГСНTableAdapter = null;
            this.tableAdapterManager.МаршрутПередвеженияTableAdapter = null;
            this.tableAdapterManager.ПостовщикГСМTableAdapter = null;
            this.tableAdapterManager.ПутевойЛистTableAdapter = null;
            this.tableAdapterManager.УчетГСНTableAdapter = null;
            // 
            // откудаLabel
            // 
            откудаLabel.AutoSize = true;
            откудаLabel.ForeColor = System.Drawing.Color.Turquoise;
            откудаLabel.Location = new System.Drawing.Point(214, 18);
            откудаLabel.Name = "откудаLabel";
            откудаLabel.Size = new System.Drawing.Size(58, 16);
            откудаLabel.TabIndex = 1;
            откудаLabel.Text = "Откуда:";
            // 
            // откудаTextBox
            // 
            this.откудаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.просмотрПутевойЛистBindingSource, "Откуда", true));
            this.откудаTextBox.Location = new System.Drawing.Point(363, 15);
            this.откудаTextBox.Name = "откудаTextBox";
            this.откудаTextBox.Size = new System.Drawing.Size(100, 22);
            this.откудаTextBox.TabIndex = 2;
            // 
            // кудаLabel
            // 
            кудаLabel.AutoSize = true;
            кудаLabel.ForeColor = System.Drawing.Color.Turquoise;
            кудаLabel.Location = new System.Drawing.Point(214, 46);
            кудаLabel.Name = "кудаLabel";
            кудаLabel.Size = new System.Drawing.Size(42, 16);
            кудаLabel.TabIndex = 3;
            кудаLabel.Text = "Куда:";
            // 
            // кудаTextBox
            // 
            this.кудаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.просмотрПутевойЛистBindingSource, "Куда", true));
            this.кудаTextBox.Location = new System.Drawing.Point(363, 43);
            this.кудаTextBox.Name = "кудаTextBox";
            this.кудаTextBox.Size = new System.Drawing.Size(100, 22);
            this.кудаTextBox.TabIndex = 4;
            // 
            // километражLabel
            // 
            километражLabel.AutoSize = true;
            километражLabel.ForeColor = System.Drawing.Color.Turquoise;
            километражLabel.Location = new System.Drawing.Point(214, 74);
            километражLabel.Name = "километражLabel";
            километражLabel.Size = new System.Drawing.Size(91, 16);
            километражLabel.TabIndex = 5;
            километражLabel.Text = "Километраж:";
            // 
            // километражTextBox
            // 
            this.километражTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.просмотрПутевойЛистBindingSource, "Километраж", true));
            this.километражTextBox.Location = new System.Drawing.Point(363, 71);
            this.километражTextBox.Name = "километражTextBox";
            this.километражTextBox.Size = new System.Drawing.Size(100, 22);
            this.километражTextBox.TabIndex = 6;
            // 
            // времяГодаLabel
            // 
            времяГодаLabel.AutoSize = true;
            времяГодаLabel.ForeColor = System.Drawing.Color.Turquoise;
            времяГодаLabel.Location = new System.Drawing.Point(214, 102);
            времяГодаLabel.Name = "времяГодаLabel";
            времяГодаLabel.Size = new System.Drawing.Size(85, 16);
            времяГодаLabel.TabIndex = 7;
            времяГодаLabel.Text = "Время Года:";
            // 
            // времяГодаTextBox
            // 
            this.времяГодаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.просмотрПутевойЛистBindingSource, "ВремяГода", true));
            this.времяГодаTextBox.Location = new System.Drawing.Point(363, 99);
            this.времяГодаTextBox.Name = "времяГодаTextBox";
            this.времяГодаTextBox.Size = new System.Drawing.Size(100, 22);
            this.времяГодаTextBox.TabIndex = 8;
            // 
            // маршрутМестностиLabel
            // 
            маршрутМестностиLabel.AutoSize = true;
            маршрутМестностиLabel.ForeColor = System.Drawing.Color.Turquoise;
            маршрутМестностиLabel.Location = new System.Drawing.Point(214, 130);
            маршрутМестностиLabel.Name = "маршрутМестностиLabel";
            маршрутМестностиLabel.Size = new System.Drawing.Size(143, 16);
            маршрутМестностиLabel.TabIndex = 9;
            маршрутМестностиLabel.Text = "Маршрут Местности:";
            // 
            // маршрутМестностиTextBox
            // 
            this.маршрутМестностиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.просмотрПутевойЛистBindingSource, "МаршрутМестности", true));
            this.маршрутМестностиTextBox.Location = new System.Drawing.Point(363, 127);
            this.маршрутМестностиTextBox.Name = "маршрутМестностиTextBox";
            this.маршрутМестностиTextBox.Size = new System.Drawing.Size(100, 22);
            this.маршрутМестностиTextBox.TabIndex = 10;
            // 
            // маркаLabel
            // 
            маркаLabel.AutoSize = true;
            маркаLabel.ForeColor = System.Drawing.Color.Turquoise;
            маркаLabel.Location = new System.Drawing.Point(214, 158);
            маркаLabel.Name = "маркаLabel";
            маркаLabel.Size = new System.Drawing.Size(52, 16);
            маркаLabel.TabIndex = 11;
            маркаLabel.Text = "Марка:";
            // 
            // маркаTextBox
            // 
            this.маркаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.просмотрПутевойЛистBindingSource, "Марка", true));
            this.маркаTextBox.Location = new System.Drawing.Point(363, 155);
            this.маркаTextBox.Name = "маркаTextBox";
            this.маркаTextBox.Size = new System.Drawing.Size(100, 22);
            this.маркаTextBox.TabIndex = 12;
            // 
            // модельLabel
            // 
            модельLabel.AutoSize = true;
            модельLabel.ForeColor = System.Drawing.Color.Turquoise;
            модельLabel.Location = new System.Drawing.Point(214, 186);
            модельLabel.Name = "модельLabel";
            модельLabel.Size = new System.Drawing.Size(60, 16);
            модельLabel.TabIndex = 13;
            модельLabel.Text = "Модель:";
            // 
            // модельTextBox
            // 
            this.модельTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.просмотрПутевойЛистBindingSource, "Модель", true));
            this.модельTextBox.Location = new System.Drawing.Point(363, 183);
            this.модельTextBox.Name = "модельTextBox";
            this.модельTextBox.Size = new System.Drawing.Size(100, 22);
            this.модельTextBox.TabIndex = 14;
            // 
            // номерLabel
            // 
            номерLabel.AutoSize = true;
            номерLabel.ForeColor = System.Drawing.Color.Turquoise;
            номерLabel.Location = new System.Drawing.Point(214, 214);
            номерLabel.Name = "номерLabel";
            номерLabel.Size = new System.Drawing.Size(53, 16);
            номерLabel.TabIndex = 15;
            номерLabel.Text = "Номер:";
            // 
            // номерTextBox
            // 
            this.номерTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.просмотрПутевойЛистBindingSource, "Номер", true));
            this.номерTextBox.Location = new System.Drawing.Point(363, 211);
            this.номерTextBox.Name = "номерTextBox";
            this.номерTextBox.Size = new System.Drawing.Size(100, 22);
            this.номерTextBox.TabIndex = 16;
            // 
            // видТопливаLabel
            // 
            видТопливаLabel.AutoSize = true;
            видТопливаLabel.ForeColor = System.Drawing.Color.Turquoise;
            видТопливаLabel.Location = new System.Drawing.Point(214, 242);
            видТопливаLabel.Name = "видТопливаLabel";
            видТопливаLabel.Size = new System.Drawing.Size(95, 16);
            видТопливаLabel.TabIndex = 17;
            видТопливаLabel.Text = "Вид Топлива:";
            // 
            // видТопливаTextBox
            // 
            this.видТопливаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.просмотрПутевойЛистBindingSource, "ВидТоплива", true));
            this.видТопливаTextBox.Location = new System.Drawing.Point(363, 239);
            this.видТопливаTextBox.Name = "видТопливаTextBox";
            this.видТопливаTextBox.Size = new System.Drawing.Size(100, 22);
            this.видТопливаTextBox.TabIndex = 18;
            // 
            // литровКВыдачеLabel
            // 
            литровКВыдачеLabel.AutoSize = true;
            литровКВыдачеLabel.ForeColor = System.Drawing.Color.Turquoise;
            литровКВыдачеLabel.Location = new System.Drawing.Point(214, 270);
            литровКВыдачеLabel.Name = "литровКВыдачеLabel";
            литровКВыдачеLabel.Size = new System.Drawing.Size(119, 16);
            литровКВыдачеLabel.TabIndex = 19;
            литровКВыдачеLabel.Text = "Литров КВыдаче:";
            // 
            // литровКВыдачеTextBox
            // 
            this.литровКВыдачеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.просмотрПутевойЛистBindingSource, "ЛитровКВыдаче", true));
            this.литровКВыдачеTextBox.Location = new System.Drawing.Point(363, 267);
            this.литровКВыдачеTextBox.Name = "литровКВыдачеTextBox";
            this.литровКВыдачеTextBox.Size = new System.Drawing.Size(100, 22);
            this.литровКВыдачеTextBox.TabIndex = 20;
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.ForeColor = System.Drawing.Color.Turquoise;
            фамилияLabel.Location = new System.Drawing.Point(214, 298);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(69, 16);
            фамилияLabel.TabIndex = 21;
            фамилияLabel.Text = "Фамилия:";
            // 
            // фамилияTextBox
            // 
            this.фамилияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.просмотрПутевойЛистBindingSource, "Фамилия", true));
            this.фамилияTextBox.Location = new System.Drawing.Point(363, 295);
            this.фамилияTextBox.Name = "фамилияTextBox";
            this.фамилияTextBox.Size = new System.Drawing.Size(100, 22);
            this.фамилияTextBox.TabIndex = 22;
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.ForeColor = System.Drawing.Color.Turquoise;
            имяLabel.Location = new System.Drawing.Point(214, 326);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(36, 16);
            имяLabel.TabIndex = 23;
            имяLabel.Text = "Имя:";
            // 
            // имяTextBox
            // 
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.просмотрПутевойЛистBindingSource, "Имя", true));
            this.имяTextBox.Location = new System.Drawing.Point(363, 323);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(100, 22);
            this.имяTextBox.TabIndex = 24;
            // 
            // отчествоLabel
            // 
            отчествоLabel.AutoSize = true;
            отчествоLabel.ForeColor = System.Drawing.Color.Turquoise;
            отчествоLabel.Location = new System.Drawing.Point(214, 354);
            отчествоLabel.Name = "отчествоLabel";
            отчествоLabel.Size = new System.Drawing.Size(73, 16);
            отчествоLabel.TabIndex = 25;
            отчествоLabel.Text = "Отчество:";
            // 
            // отчествоTextBox
            // 
            this.отчествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.просмотрПутевойЛистBindingSource, "Отчество", true));
            this.отчествоTextBox.Location = new System.Drawing.Point(363, 351);
            this.отчествоTextBox.Name = "отчествоTextBox";
            this.отчествоTextBox.Size = new System.Drawing.Size(100, 22);
            this.отчествоTextBox.TabIndex = 26;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.Location = new System.Drawing.Point(417, 403);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(69, 40);
            this.button4.TabIndex = 44;
            this.button4.Text = ">|";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Location = new System.Drawing.Point(194, 403);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 40);
            this.button3.TabIndex = 43;
            this.button3.Text = "|<";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Location = new System.Drawing.Point(267, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 40);
            this.button2.TabIndex = 42;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(342, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 40);
            this.button1.TabIndex = 41;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewPutList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(651, 517);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(откудаLabel);
            this.Controls.Add(this.откудаTextBox);
            this.Controls.Add(кудаLabel);
            this.Controls.Add(this.кудаTextBox);
            this.Controls.Add(километражLabel);
            this.Controls.Add(this.километражTextBox);
            this.Controls.Add(времяГодаLabel);
            this.Controls.Add(this.времяГодаTextBox);
            this.Controls.Add(маршрутМестностиLabel);
            this.Controls.Add(this.маршрутМестностиTextBox);
            this.Controls.Add(маркаLabel);
            this.Controls.Add(this.маркаTextBox);
            this.Controls.Add(модельLabel);
            this.Controls.Add(this.модельTextBox);
            this.Controls.Add(номерLabel);
            this.Controls.Add(this.номерTextBox);
            this.Controls.Add(видТопливаLabel);
            this.Controls.Add(this.видТопливаTextBox);
            this.Controls.Add(литровКВыдачеLabel);
            this.Controls.Add(this.литровКВыдачеTextBox);
            this.Controls.Add(фамилияLabel);
            this.Controls.Add(this.фамилияTextBox);
            this.Controls.Add(имяLabel);
            this.Controls.Add(this.имяTextBox);
            this.Controls.Add(отчествоLabel);
            this.Controls.Add(this.отчествоTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewPutList";
            this.Text = "ViewPutList";
            this.Load += new System.EventHandler(this.ViewPutList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.грузоперевозкиDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.просмотрПутевойЛистBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ГрузоперевозкиDataSet грузоперевозкиDataSet;
        private System.Windows.Forms.BindingSource просмотрПутевойЛистBindingSource;
        private ГрузоперевозкиDataSetTableAdapters.ПросмотрПутевойЛистTableAdapter просмотрПутевойЛистTableAdapter;
        private ГрузоперевозкиDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox откудаTextBox;
        private System.Windows.Forms.TextBox кудаTextBox;
        private System.Windows.Forms.TextBox километражTextBox;
        private System.Windows.Forms.TextBox времяГодаTextBox;
        private System.Windows.Forms.TextBox маршрутМестностиTextBox;
        private System.Windows.Forms.TextBox маркаTextBox;
        private System.Windows.Forms.TextBox модельTextBox;
        private System.Windows.Forms.TextBox номерTextBox;
        private System.Windows.Forms.TextBox видТопливаTextBox;
        private System.Windows.Forms.TextBox литровКВыдачеTextBox;
        private System.Windows.Forms.TextBox фамилияTextBox;
        private System.Windows.Forms.TextBox имяTextBox;
        private System.Windows.Forms.TextBox отчествоTextBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}