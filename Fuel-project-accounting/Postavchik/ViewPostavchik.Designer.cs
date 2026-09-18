namespace Fuel_project_accounting.Postavchik
{
    partial class ViewPostavchik
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
            System.Windows.Forms.Label наименованиеОрганизациLabel;
            System.Windows.Forms.Label расчетныйСчетLabel;
            System.Windows.Forms.Label адресLabel;
            this.грузоперевозкиDataSet = new Fuel_project_accounting.ГрузоперевозкиDataSet();
            this.просмотрПоставщиковBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.просмотрПоставщиковTableAdapter = new Fuel_project_accounting.ГрузоперевозкиDataSetTableAdapters.ПросмотрПоставщиковTableAdapter();
            this.tableAdapterManager = new Fuel_project_accounting.ГрузоперевозкиDataSetTableAdapters.TableAdapterManager();
            this.наименованиеОрганизациTextBox = new System.Windows.Forms.TextBox();
            this.расчетныйСчетTextBox = new System.Windows.Forms.TextBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            наименованиеОрганизациLabel = new System.Windows.Forms.Label();
            расчетныйСчетLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.грузоперевозкиDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.просмотрПоставщиковBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // грузоперевозкиDataSet
            // 
            this.грузоперевозкиDataSet.DataSetName = "ГрузоперевозкиDataSet";
            this.грузоперевозкиDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // просмотрПоставщиковBindingSource
            // 
            this.просмотрПоставщиковBindingSource.DataMember = "ПросмотрПоставщиков";
            this.просмотрПоставщиковBindingSource.DataSource = this.грузоперевозкиDataSet;
            // 
            // просмотрПоставщиковTableAdapter
            // 
            this.просмотрПоставщиковTableAdapter.ClearBeforeFill = true;
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
            // наименованиеОрганизациLabel
            // 
            наименованиеОрганизациLabel.AutoSize = true;
            наименованиеОрганизациLabel.ForeColor = System.Drawing.Color.Turquoise;
            наименованиеОрганизациLabel.Location = new System.Drawing.Point(153, 109);
            наименованиеОрганизациLabel.Name = "наименованиеОрганизациLabel";
            наименованиеОрганизациLabel.Size = new System.Drawing.Size(192, 16);
            наименованиеОрганизациLabel.TabIndex = 1;
            наименованиеОрганизациLabel.Text = "Наименование Организаци:";
            // 
            // наименованиеОрганизациTextBox
            // 
            this.наименованиеОрганизациTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.просмотрПоставщиковBindingSource, "НаименованиеОрганизаци", true));
            this.наименованиеОрганизациTextBox.Location = new System.Drawing.Point(351, 106);
            this.наименованиеОрганизациTextBox.Name = "наименованиеОрганизациTextBox";
            this.наименованиеОрганизациTextBox.Size = new System.Drawing.Size(201, 22);
            this.наименованиеОрганизациTextBox.TabIndex = 2;
            // 
            // расчетныйСчетLabel
            // 
            расчетныйСчетLabel.AutoSize = true;
            расчетныйСчетLabel.ForeColor = System.Drawing.Color.Turquoise;
            расчетныйСчетLabel.Location = new System.Drawing.Point(153, 137);
            расчетныйСчетLabel.Name = "расчетныйСчетLabel";
            расчетныйСчетLabel.Size = new System.Drawing.Size(117, 16);
            расчетныйСчетLabel.TabIndex = 3;
            расчетныйСчетLabel.Text = "Расчетный Счет:";
            // 
            // расчетныйСчетTextBox
            // 
            this.расчетныйСчетTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.просмотрПоставщиковBindingSource, "РасчетныйСчет", true));
            this.расчетныйСчетTextBox.Location = new System.Drawing.Point(351, 134);
            this.расчетныйСчетTextBox.Name = "расчетныйСчетTextBox";
            this.расчетныйСчетTextBox.Size = new System.Drawing.Size(201, 22);
            this.расчетныйСчетTextBox.TabIndex = 4;
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.ForeColor = System.Drawing.Color.Turquoise;
            адресLabel.Location = new System.Drawing.Point(153, 165);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(50, 16);
            адресLabel.TabIndex = 5;
            адресLabel.Text = "Адрес:";
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.просмотрПоставщиковBindingSource, "Адрес", true));
            this.адресTextBox.Location = new System.Drawing.Point(351, 162);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(201, 22);
            this.адресTextBox.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.Location = new System.Drawing.Point(426, 332);
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
            this.button3.Location = new System.Drawing.Point(203, 332);
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
            this.button2.Location = new System.Drawing.Point(276, 332);
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
            this.button1.Location = new System.Drawing.Point(351, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 40);
            this.button1.TabIndex = 41;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewPostavchik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(651, 435);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(наименованиеОрганизациLabel);
            this.Controls.Add(this.наименованиеОрганизациTextBox);
            this.Controls.Add(расчетныйСчетLabel);
            this.Controls.Add(this.расчетныйСчетTextBox);
            this.Controls.Add(адресLabel);
            this.Controls.Add(this.адресTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewPostavchik";
            this.Text = "ViewPostavchik";
            this.Load += new System.EventHandler(this.ViewPostavchik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.грузоперевозкиDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.просмотрПоставщиковBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ГрузоперевозкиDataSet грузоперевозкиDataSet;
        private System.Windows.Forms.BindingSource просмотрПоставщиковBindingSource;
        private ГрузоперевозкиDataSetTableAdapters.ПросмотрПоставщиковTableAdapter просмотрПоставщиковTableAdapter;
        private ГрузоперевозкиDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox наименованиеОрганизациTextBox;
        private System.Windows.Forms.TextBox расчетныйСчетTextBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}