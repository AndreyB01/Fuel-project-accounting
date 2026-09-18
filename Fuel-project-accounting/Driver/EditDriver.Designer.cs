namespace Fuel_project_accounting.Driver
{
    partial class EditDriver
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
            System.Windows.Forms.Label idАвтоLabel;
            this.грузоперевозкиDataSet = new Fuel_project_accounting.ГрузоперевозкиDataSet();
            this.водителиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.водителиTableAdapter = new Fuel_project_accounting.ГрузоперевозкиDataSetTableAdapters.ВодителиTableAdapter();
            this.tableAdapterManager = new Fuel_project_accounting.ГрузоперевозкиDataSetTableAdapters.TableAdapterManager();
            this.фамилияTextBox = new System.Windows.Forms.TextBox();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            this.отчествоTextBox = new System.Windows.Forms.TextBox();
            this.датаРодженияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.полTextBox = new System.Windows.Forms.TextBox();
            this.категорияTextBox = new System.Windows.Forms.TextBox();
            this.стажTextBox = new System.Windows.Forms.TextBox();
            this.idАвтоTextBox = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
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
            idАвтоLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.грузоперевозкиDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.водителиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.ForeColor = System.Drawing.Color.Turquoise;
            фамилияLabel.Location = new System.Drawing.Point(190, 72);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(69, 16);
            фамилияLabel.TabIndex = 3;
            фамилияLabel.Text = "Фамилия:";
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.ForeColor = System.Drawing.Color.Turquoise;
            имяLabel.Location = new System.Drawing.Point(190, 100);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(36, 16);
            имяLabel.TabIndex = 5;
            имяLabel.Text = "Имя:";
            // 
            // отчествоLabel
            // 
            отчествоLabel.AutoSize = true;
            отчествоLabel.ForeColor = System.Drawing.Color.Turquoise;
            отчествоLabel.Location = new System.Drawing.Point(190, 128);
            отчествоLabel.Name = "отчествоLabel";
            отчествоLabel.Size = new System.Drawing.Size(73, 16);
            отчествоLabel.TabIndex = 7;
            отчествоLabel.Text = "Отчество:";
            // 
            // датаРодженияLabel
            // 
            датаРодженияLabel.AutoSize = true;
            датаРодженияLabel.ForeColor = System.Drawing.Color.Turquoise;
            датаРодженияLabel.Location = new System.Drawing.Point(190, 157);
            датаРодженияLabel.Name = "датаРодженияLabel";
            датаРодженияLabel.Size = new System.Drawing.Size(110, 16);
            датаРодженияLabel.TabIndex = 9;
            датаРодженияLabel.Text = "Дата Роджения:";
            // 
            // полLabel
            // 
            полLabel.AutoSize = true;
            полLabel.ForeColor = System.Drawing.Color.Turquoise;
            полLabel.Location = new System.Drawing.Point(190, 184);
            полLabel.Name = "полLabel";
            полLabel.Size = new System.Drawing.Size(36, 16);
            полLabel.TabIndex = 11;
            полLabel.Text = "Пол:";
            // 
            // категорияLabel
            // 
            категорияLabel.AutoSize = true;
            категорияLabel.ForeColor = System.Drawing.Color.Turquoise;
            категорияLabel.Location = new System.Drawing.Point(190, 212);
            категорияLabel.Name = "категорияLabel";
            категорияLabel.Size = new System.Drawing.Size(78, 16);
            категорияLabel.TabIndex = 13;
            категорияLabel.Text = "Категория:";
            // 
            // стажLabel
            // 
            стажLabel.AutoSize = true;
            стажLabel.ForeColor = System.Drawing.Color.Turquoise;
            стажLabel.Location = new System.Drawing.Point(190, 240);
            стажLabel.Name = "стажLabel";
            стажLabel.Size = new System.Drawing.Size(43, 16);
            стажLabel.TabIndex = 15;
            стажLabel.Text = "Стаж:";
            // 
            // idАвтоLabel
            // 
            idАвтоLabel.AutoSize = true;
            idАвтоLabel.ForeColor = System.Drawing.Color.Turquoise;
            idАвтоLabel.Location = new System.Drawing.Point(190, 268);
            idАвтоLabel.Name = "idАвтоLabel";
            idАвтоLabel.Size = new System.Drawing.Size(56, 16);
            idАвтоLabel.TabIndex = 17;
            idАвтоLabel.Text = "Id Авто:";
            // 
            // грузоперевозкиDataSet
            // 
            this.грузоперевозкиDataSet.DataSetName = "ГрузоперевозкиDataSet";
            this.грузоперевозкиDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // водителиBindingSource
            // 
            this.водителиBindingSource.DataMember = "Водители";
            this.водителиBindingSource.DataSource = this.грузоперевозкиDataSet;
            // 
            // водителиTableAdapter
            // 
            this.водителиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Fuel_project_accounting.ГрузоперевозкиDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвтоTableAdapter = null;
            this.tableAdapterManager.ВидыГСМTableAdapter = null;
            this.tableAdapterManager.ВодителиTableAdapter = this.водителиTableAdapter;
            this.tableAdapterManager.ГСНTableAdapter = null;
            this.tableAdapterManager.МаршрутПередвеженияTableAdapter = null;
            this.tableAdapterManager.ПостовщикГСМTableAdapter = null;
            this.tableAdapterManager.ПутевойЛистTableAdapter = null;
            this.tableAdapterManager.УчетГСНTableAdapter = null;
            // 
            // фамилияTextBox
            // 
            this.фамилияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.водителиBindingSource, "Фамилия", true));
            this.фамилияTextBox.Location = new System.Drawing.Point(306, 69);
            this.фамилияTextBox.Name = "фамилияTextBox";
            this.фамилияTextBox.Size = new System.Drawing.Size(200, 22);
            this.фамилияTextBox.TabIndex = 4;
            // 
            // имяTextBox
            // 
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.водителиBindingSource, "Имя", true));
            this.имяTextBox.Location = new System.Drawing.Point(306, 97);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(200, 22);
            this.имяTextBox.TabIndex = 6;
            // 
            // отчествоTextBox
            // 
            this.отчествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.водителиBindingSource, "Отчество", true));
            this.отчествоTextBox.Location = new System.Drawing.Point(306, 125);
            this.отчествоTextBox.Name = "отчествоTextBox";
            this.отчествоTextBox.Size = new System.Drawing.Size(200, 22);
            this.отчествоTextBox.TabIndex = 8;
            // 
            // датаРодженияDateTimePicker
            // 
            this.датаРодженияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.водителиBindingSource, "ДатаРоджения", true));
            this.датаРодженияDateTimePicker.Location = new System.Drawing.Point(306, 153);
            this.датаРодженияDateTimePicker.Name = "датаРодженияDateTimePicker";
            this.датаРодженияDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.датаРодженияDateTimePicker.TabIndex = 10;
            // 
            // полTextBox
            // 
            this.полTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.водителиBindingSource, "Пол", true));
            this.полTextBox.Location = new System.Drawing.Point(306, 181);
            this.полTextBox.Name = "полTextBox";
            this.полTextBox.Size = new System.Drawing.Size(200, 22);
            this.полTextBox.TabIndex = 12;
            // 
            // категорияTextBox
            // 
            this.категорияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.водителиBindingSource, "Категория", true));
            this.категорияTextBox.Location = new System.Drawing.Point(306, 209);
            this.категорияTextBox.Name = "категорияTextBox";
            this.категорияTextBox.Size = new System.Drawing.Size(200, 22);
            this.категорияTextBox.TabIndex = 14;
            // 
            // стажTextBox
            // 
            this.стажTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.водителиBindingSource, "Стаж", true));
            this.стажTextBox.Location = new System.Drawing.Point(306, 237);
            this.стажTextBox.Name = "стажTextBox";
            this.стажTextBox.Size = new System.Drawing.Size(200, 22);
            this.стажTextBox.TabIndex = 16;
            // 
            // idАвтоTextBox
            // 
            this.idАвтоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.водителиBindingSource, "IdАвто", true));
            this.idАвтоTextBox.Location = new System.Drawing.Point(306, 265);
            this.idАвтоTextBox.Name = "idАвтоTextBox";
            this.idАвтоTextBox.Size = new System.Drawing.Size(200, 22);
            this.idАвтоTextBox.TabIndex = 18;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button7.Location = new System.Drawing.Point(438, 318);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(61, 40);
            this.button7.TabIndex = 45;
            this.button7.Text = "Save";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button6.Location = new System.Drawing.Point(505, 318);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(61, 40);
            this.button6.TabIndex = 44;
            this.button6.Text = "Del";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button5.Location = new System.Drawing.Point(373, 318);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(61, 40);
            this.button5.TabIndex = 43;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.Location = new System.Drawing.Point(306, 318);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 40);
            this.button4.TabIndex = 42;
            this.button4.Text = ">|";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Location = new System.Drawing.Point(105, 318);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 40);
            this.button3.TabIndex = 41;
            this.button3.Text = "|<";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Location = new System.Drawing.Point(172, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 40);
            this.button2.TabIndex = 40;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(239, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 40);
            this.button1.TabIndex = 39;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(651, 435);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
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
            this.Controls.Add(idАвтоLabel);
            this.Controls.Add(this.idАвтоTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditDriver";
            this.Text = "EditDriver";
            this.Load += new System.EventHandler(this.EditDriver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.грузоперевозкиDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.водителиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ГрузоперевозкиDataSet грузоперевозкиDataSet;
        private System.Windows.Forms.BindingSource водителиBindingSource;
        private ГрузоперевозкиDataSetTableAdapters.ВодителиTableAdapter водителиTableAdapter;
        private ГрузоперевозкиDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox фамилияTextBox;
        private System.Windows.Forms.TextBox имяTextBox;
        private System.Windows.Forms.TextBox отчествоTextBox;
        private System.Windows.Forms.DateTimePicker датаРодженияDateTimePicker;
        private System.Windows.Forms.TextBox полTextBox;
        private System.Windows.Forms.TextBox категорияTextBox;
        private System.Windows.Forms.TextBox стажTextBox;
        private System.Windows.Forms.TextBox idАвтоTextBox;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}