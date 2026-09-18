namespace Fuel_project_accounting.Driver
{
    partial class ViewDriver
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
            System.Windows.Forms.Label фамилияLabel;
            System.Windows.Forms.Label имяLabel;
            System.Windows.Forms.Label отчествоLabel;
            System.Windows.Forms.Label датаРодженияLabel;
            System.Windows.Forms.Label полLabel;
            System.Windows.Forms.Label категорияLabel;
            System.Windows.Forms.Label стажLabel;
            System.Windows.Forms.Label маркаLabel;
            this.грузоперевозкиDataSet = new Fuel_project_accounting.ГрузоперевозкиDataSet();
            this.просмотрВодителиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.просмотрВодителиTableAdapter = new Fuel_project_accounting.ГрузоперевозкиDataSetTableAdapters.ПросмотрВодителиTableAdapter();
            this.tableAdapterManager = new Fuel_project_accounting.ГрузоперевозкиDataSetTableAdapters.TableAdapterManager();
            this.фамилияTextBox = new System.Windows.Forms.TextBox();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            this.отчествоTextBox = new System.Windows.Forms.TextBox();
            this.датаРодженияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.полTextBox = new System.Windows.Forms.TextBox();
            this.категорияTextBox = new System.Windows.Forms.TextBox();
            this.стажTextBox = new System.Windows.Forms.TextBox();
            this.маркаTextBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            фамилияLabel = new System.Windows.Forms.Label();
            имяLabel = new System.Windows.Forms.Label();
            отчествоLabel = new System.Windows.Forms.Label();
            датаРодженияLabel = new System.Windows.Forms.Label();
            полLabel = new System.Windows.Forms.Label();
            категорияLabel = new System.Windows.Forms.Label();
            стажLabel = new System.Windows.Forms.Label();
            маркаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.грузоперевозкиDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.просмотрВодителиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // грузоперевозкиDataSet
            // 
            this.грузоперевозкиDataSet.DataSetName = "ГрузоперевозкиDataSet";
            this.грузоперевозкиDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // просмотрВодителиBindingSource
            // 
            this.просмотрВодителиBindingSource.DataMember = "ПросмотрВодители";
            this.просмотрВодителиBindingSource.DataSource = this.грузоперевозкиDataSet;
            // 
            // просмотрВодителиTableAdapter
            // 
            this.просмотрВодителиTableAdapter.ClearBeforeFill = true;
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
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.ForeColor = System.Drawing.Color.Turquoise;
            фамилияLabel.Location = new System.Drawing.Point(186, 75);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(69, 16);
            фамилияLabel.TabIndex = 1;
            фамилияLabel.Text = "Фамилия:";
            // 
            // фамилияTextBox
            // 
            this.фамилияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.просмотрВодителиBindingSource, "Фамилия", true));
            this.фамилияTextBox.Location = new System.Drawing.Point(311, 72);
            this.фамилияTextBox.Name = "фамилияTextBox";
            this.фамилияTextBox.Size = new System.Drawing.Size(200, 22);
            this.фамилияTextBox.TabIndex = 2;
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.ForeColor = System.Drawing.Color.Turquoise;
            имяLabel.Location = new System.Drawing.Point(186, 103);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(36, 16);
            имяLabel.TabIndex = 3;
            имяLabel.Text = "Имя:";
            // 
            // имяTextBox
            // 
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.просмотрВодителиBindingSource, "Имя", true));
            this.имяTextBox.Location = new System.Drawing.Point(311, 100);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(200, 22);
            this.имяTextBox.TabIndex = 4;
            // 
            // отчествоLabel
            // 
            отчествоLabel.AutoSize = true;
            отчествоLabel.ForeColor = System.Drawing.Color.Turquoise;
            отчествоLabel.Location = new System.Drawing.Point(186, 131);
            отчествоLabel.Name = "отчествоLabel";
            отчествоLabel.Size = new System.Drawing.Size(73, 16);
            отчествоLabel.TabIndex = 5;
            отчествоLabel.Text = "Отчество:";
            // 
            // отчествоTextBox
            // 
            this.отчествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.просмотрВодителиBindingSource, "Отчество", true));
            this.отчествоTextBox.Location = new System.Drawing.Point(311, 128);
            this.отчествоTextBox.Name = "отчествоTextBox";
            this.отчествоTextBox.Size = new System.Drawing.Size(200, 22);
            this.отчествоTextBox.TabIndex = 6;
            // 
            // датаРодженияLabel
            // 
            датаРодженияLabel.AutoSize = true;
            датаРодженияLabel.ForeColor = System.Drawing.Color.Turquoise;
            датаРодженияLabel.Location = new System.Drawing.Point(186, 160);
            датаРодженияLabel.Name = "датаРодженияLabel";
            датаРодженияLabel.Size = new System.Drawing.Size(110, 16);
            датаРодженияLabel.TabIndex = 7;
            датаРодженияLabel.Text = "Дата Роджения:";
            // 
            // датаРодженияDateTimePicker
            // 
            this.датаРодженияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.просмотрВодителиBindingSource, "ДатаРоджения", true));
            this.датаРодженияDateTimePicker.Location = new System.Drawing.Point(311, 156);
            this.датаРодженияDateTimePicker.Name = "датаРодженияDateTimePicker";
            this.датаРодженияDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.датаРодженияDateTimePicker.TabIndex = 8;
            // 
            // полLabel
            // 
            полLabel.AutoSize = true;
            полLabel.ForeColor = System.Drawing.Color.Turquoise;
            полLabel.Location = new System.Drawing.Point(186, 187);
            полLabel.Name = "полLabel";
            полLabel.Size = new System.Drawing.Size(36, 16);
            полLabel.TabIndex = 9;
            полLabel.Text = "Пол:";
            // 
            // полTextBox
            // 
            this.полTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.просмотрВодителиBindingSource, "Пол", true));
            this.полTextBox.Location = new System.Drawing.Point(311, 184);
            this.полTextBox.Name = "полTextBox";
            this.полTextBox.Size = new System.Drawing.Size(200, 22);
            this.полTextBox.TabIndex = 10;
            // 
            // категорияLabel
            // 
            категорияLabel.AutoSize = true;
            категорияLabel.ForeColor = System.Drawing.Color.Turquoise;
            категорияLabel.Location = new System.Drawing.Point(186, 215);
            категорияLabel.Name = "категорияLabel";
            категорияLabel.Size = new System.Drawing.Size(78, 16);
            категорияLabel.TabIndex = 11;
            категорияLabel.Text = "Категория:";
            // 
            // категорияTextBox
            // 
            this.категорияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.просмотрВодителиBindingSource, "Категория", true));
            this.категорияTextBox.Location = new System.Drawing.Point(311, 212);
            this.категорияTextBox.Name = "категорияTextBox";
            this.категорияTextBox.Size = new System.Drawing.Size(200, 22);
            this.категорияTextBox.TabIndex = 12;
            // 
            // стажLabel
            // 
            стажLabel.AutoSize = true;
            стажLabel.ForeColor = System.Drawing.Color.Turquoise;
            стажLabel.Location = new System.Drawing.Point(186, 243);
            стажLabel.Name = "стажLabel";
            стажLabel.Size = new System.Drawing.Size(43, 16);
            стажLabel.TabIndex = 13;
            стажLabel.Text = "Стаж:";
            // 
            // стажTextBox
            // 
            this.стажTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.просмотрВодителиBindingSource, "Стаж", true));
            this.стажTextBox.Location = new System.Drawing.Point(311, 240);
            this.стажTextBox.Name = "стажTextBox";
            this.стажTextBox.Size = new System.Drawing.Size(200, 22);
            this.стажTextBox.TabIndex = 14;
            // 
            // маркаLabel
            // 
            маркаLabel.AutoSize = true;
            маркаLabel.ForeColor = System.Drawing.Color.Turquoise;
            маркаLabel.Location = new System.Drawing.Point(186, 271);
            маркаLabel.Name = "маркаLabel";
            маркаLabel.Size = new System.Drawing.Size(52, 16);
            маркаLabel.TabIndex = 15;
            маркаLabel.Text = "Марка:";
            // 
            // маркаTextBox
            // 
            this.маркаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.просмотрВодителиBindingSource, "Марка", true));
            this.маркаTextBox.Location = new System.Drawing.Point(311, 268);
            this.маркаTextBox.Name = "маркаTextBox";
            this.маркаTextBox.Size = new System.Drawing.Size(200, 22);
            this.маркаTextBox.TabIndex = 16;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.Location = new System.Drawing.Point(427, 307);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(69, 40);
            this.button4.TabIndex = 40;
            this.button4.Text = ">|";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Location = new System.Drawing.Point(204, 307);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 40);
            this.button3.TabIndex = 39;
            this.button3.Text = "|<";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Location = new System.Drawing.Point(277, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 40);
            this.button2.TabIndex = 38;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(352, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 40);
            this.button1.TabIndex = 37;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(651, 435);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(фамилияLabel);
            this.Controls.Add(this.фамилияTextBox);
            this.Controls.Add(имяLabel);
            this.Controls.Add(this.имяTextBox);
            this.Controls.Add(отчествоLabel);
            this.Controls.Add(this.отчествоTextBox);
            this.Controls.Add(датаРодженияLabel);
            this.Controls.Add(this.датаРодженияDateTimePicker);
            this.Controls.Add(полLabel);
            this.Controls.Add(this.полTextBox);
            this.Controls.Add(категорияLabel);
            this.Controls.Add(this.категорияTextBox);
            this.Controls.Add(стажLabel);
            this.Controls.Add(this.стажTextBox);
            this.Controls.Add(маркаLabel);
            this.Controls.Add(this.маркаTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewDriver";
            this.Text = "ViewDriver";
            this.Load += new System.EventHandler(this.ViewDriver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.грузоперевозкиDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.просмотрВодителиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ГрузоперевозкиDataSet грузоперевозкиDataSet;
        private System.Windows.Forms.BindingSource просмотрВодителиBindingSource;
        private ГрузоперевозкиDataSetTableAdapters.ПросмотрВодителиTableAdapter просмотрВодителиTableAdapter;
        private ГрузоперевозкиDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox фамилияTextBox;
        private System.Windows.Forms.TextBox имяTextBox;
        private System.Windows.Forms.TextBox отчествоTextBox;
        private System.Windows.Forms.DateTimePicker датаРодженияDateTimePicker;
        private System.Windows.Forms.TextBox полTextBox;
        private System.Windows.Forms.TextBox категорияTextBox;
        private System.Windows.Forms.TextBox стажTextBox;
        private System.Windows.Forms.TextBox маркаTextBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}