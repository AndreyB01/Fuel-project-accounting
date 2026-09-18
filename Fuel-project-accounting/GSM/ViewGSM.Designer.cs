namespace Fuel_project_accounting.GSM
{
    partial class ViewGSM
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
            System.Windows.Forms.Label колличествоЛитровУчетаLabel;
            System.Windows.Forms.Label названиеОперацииВыданоПринятоLabel;
            System.Windows.Forms.Label датаLabel;
            this.грузоперевозкиDataSet = new Fuel_project_accounting.ГрузоперевозкиDataSet();
            this.учетГСНBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.учетГСНTableAdapter = new Fuel_project_accounting.ГрузоперевозкиDataSetTableAdapters.УчетГСНTableAdapter();
            this.tableAdapterManager = new Fuel_project_accounting.ГрузоперевозкиDataSetTableAdapters.TableAdapterManager();
            this.колличествоЛитровУчетаTextBox = new System.Windows.Forms.TextBox();
            this.датаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.названиеОперацииВыданоПринятоTextBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            колличествоЛитровУчетаLabel = new System.Windows.Forms.Label();
            названиеОперацииВыданоПринятоLabel = new System.Windows.Forms.Label();
            датаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.грузоперевозкиDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учетГСНBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // грузоперевозкиDataSet
            // 
            this.грузоперевозкиDataSet.DataSetName = "ГрузоперевозкиDataSet";
            this.грузоперевозкиDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // учетГСНBindingSource
            // 
            this.учетГСНBindingSource.DataMember = "УчетГСН";
            this.учетГСНBindingSource.DataSource = this.грузоперевозкиDataSet;
            // 
            // учетГСНTableAdapter
            // 
            this.учетГСНTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Fuel_project_accounting.ГрузоперевозкиDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвтоTableAdapter = null;
            this.tableAdapterManager.ВидыГСМTableAdapter = null;
            this.tableAdapterManager.ВодителиTableAdapter = null;
            this.tableAdapterManager.ГСНTableAdapter = null;
            this.tableAdapterManager.МаршрутПередвеженияTableAdapter = null;
            this.tableAdapterManager.ПостовщикГСМTableAdapter = null;
            this.tableAdapterManager.ПутевойЛистTableAdapter = null;
            this.tableAdapterManager.УчетГСНTableAdapter = this.учетГСНTableAdapter;
            // 
            // колличествоЛитровУчетаLabel
            // 
            колличествоЛитровУчетаLabel.AutoSize = true;
            колличествоЛитровУчетаLabel.ForeColor = System.Drawing.Color.Turquoise;
            колличествоЛитровУчетаLabel.Location = new System.Drawing.Point(114, 94);
            колличествоЛитровУчетаLabel.Name = "колличествоЛитровУчетаLabel";
            колличествоЛитровУчетаLabel.Size = new System.Drawing.Size(190, 16);
            колличествоЛитровУчетаLabel.TabIndex = 3;
            колличествоЛитровУчетаLabel.Text = "Колличество Литров Учета:";
            // 
            // колличествоЛитровУчетаTextBox
            // 
            this.колличествоЛитровУчетаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.учетГСНBindingSource, "КолличествоЛитровУчета", true));
            this.колличествоЛитровУчетаTextBox.Location = new System.Drawing.Point(377, 91);
            this.колличествоЛитровУчетаTextBox.Name = "колличествоЛитровУчетаTextBox";
            this.колличествоЛитровУчетаTextBox.Size = new System.Drawing.Size(200, 22);
            this.колличествоЛитровУчетаTextBox.TabIndex = 4;
            // 
            // названиеОперацииВыданоПринятоLabel
            // 
            названиеОперацииВыданоПринятоLabel.AutoSize = true;
            названиеОперацииВыданоПринятоLabel.ForeColor = System.Drawing.Color.Turquoise;
            названиеОперацииВыданоПринятоLabel.Location = new System.Drawing.Point(114, 122);
            названиеОперацииВыданоПринятоLabel.Name = "названиеОперацииВыданоПринятоLabel";
            названиеОперацииВыданоПринятоLabel.Size = new System.Drawing.Size(257, 16);
            названиеОперацииВыданоПринятоLabel.TabIndex = 5;
            названиеОперацииВыданоПринятоLabel.Text = "Название Операции Выдано Принято:";
            // 
            // датаLabel
            // 
            датаLabel.AutoSize = true;
            датаLabel.ForeColor = System.Drawing.Color.Turquoise;
            датаLabel.Location = new System.Drawing.Point(114, 151);
            датаLabel.Name = "датаLabel";
            датаLabel.Size = new System.Drawing.Size(42, 16);
            датаLabel.TabIndex = 13;
            датаLabel.Text = "Дата:";
            // 
            // датаDateTimePicker
            // 
            this.датаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.учетГСНBindingSource, "Дата", true));
            this.датаDateTimePicker.Location = new System.Drawing.Point(377, 147);
            this.датаDateTimePicker.Name = "датаDateTimePicker";
            this.датаDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.датаDateTimePicker.TabIndex = 14;
            // 
            // названиеОперацииВыданоПринятоTextBox
            // 
            this.названиеОперацииВыданоПринятоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.учетГСНBindingSource, "НазваниеОперацииВыданоПринято", true));
            this.названиеОперацииВыданоПринятоTextBox.Location = new System.Drawing.Point(377, 119);
            this.названиеОперацииВыданоПринятоTextBox.Name = "названиеОперацииВыданоПринятоTextBox";
            this.названиеОперацииВыданоПринятоTextBox.Size = new System.Drawing.Size(200, 22);
            this.названиеОперацииВыданоПринятоTextBox.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.Location = new System.Drawing.Point(405, 336);
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
            this.button3.Location = new System.Drawing.Point(182, 336);
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
            this.button2.Location = new System.Drawing.Point(255, 336);
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
            this.button1.Location = new System.Drawing.Point(330, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 40);
            this.button1.TabIndex = 41;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewGSM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(651, 435);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(колличествоЛитровУчетаLabel);
            this.Controls.Add(this.колличествоЛитровУчетаTextBox);
            this.Controls.Add(названиеОперацииВыданоПринятоLabel);
            this.Controls.Add(this.названиеОперацииВыданоПринятоTextBox);
            this.Controls.Add(датаLabel);
            this.Controls.Add(this.датаDateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewGSM";
            this.Text = "ViewGSM";
            this.Load += new System.EventHandler(this.ViewGSM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.грузоперевозкиDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учетГСНBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ГрузоперевозкиDataSet грузоперевозкиDataSet;
        private System.Windows.Forms.BindingSource учетГСНBindingSource;
        private ГрузоперевозкиDataSetTableAdapters.УчетГСНTableAdapter учетГСНTableAdapter;
        private ГрузоперевозкиDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox колличествоЛитровУчетаTextBox;
        private System.Windows.Forms.DateTimePicker датаDateTimePicker;
        private System.Windows.Forms.TextBox названиеОперацииВыданоПринятоTextBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}