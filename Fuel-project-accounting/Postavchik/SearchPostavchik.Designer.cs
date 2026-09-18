namespace Fuel_project_accounting.Postavchik
{
    partial class SearchPostavchik
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
            this.грузоперевозкиDataSet = new Fuel_project_accounting.ГрузоперевозкиDataSet();
            this.поиск_По_ПоставщикамBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поиск_По_ПоставщикамTableAdapter = new Fuel_project_accounting.ГрузоперевозкиDataSetTableAdapters.Поиск_По_ПоставщикамTableAdapter();
            this.tableAdapterManager = new Fuel_project_accounting.ГрузоперевозкиDataSetTableAdapters.TableAdapterManager();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.наименованиеПроцToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.наименованиеПроцToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.поиск_По_ПоставщикамDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.грузоперевозкиDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поиск_По_ПоставщикамBindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.поиск_По_ПоставщикамDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // грузоперевозкиDataSet
            // 
            this.грузоперевозкиDataSet.DataSetName = "ГрузоперевозкиDataSet";
            this.грузоперевозкиDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // поиск_По_ПоставщикамBindingSource
            // 
            this.поиск_По_ПоставщикамBindingSource.DataMember = "Поиск_По_Поставщикам";
            this.поиск_По_ПоставщикамBindingSource.DataSource = this.грузоперевозкиDataSet;
            // 
            // поиск_По_ПоставщикамTableAdapter
            // 
            this.поиск_По_ПоставщикамTableAdapter.ClearBeforeFill = true;
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
            // fillToolStrip
            // 
            this.fillToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.наименованиеПроцToolStripLabel,
            this.наименованиеПроцToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(651, 27);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // наименованиеПроцToolStripLabel
            // 
            this.наименованиеПроцToolStripLabel.Name = "наименованиеПроцToolStripLabel";
            this.наименованиеПроцToolStripLabel.Size = new System.Drawing.Size(119, 24);
            this.наименованиеПроцToolStripLabel.Text = "Наименование:";
            // 
            // наименованиеПроцToolStripTextBox
            // 
            this.наименованиеПроцToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.наименованиеПроцToolStripTextBox.Name = "наименованиеПроцToolStripTextBox";
            this.наименованиеПроцToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(56, 24);
            this.fillToolStripButton.Text = "Поиск";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // поиск_По_ПоставщикамDataGridView
            // 
            this.поиск_По_ПоставщикамDataGridView.AutoGenerateColumns = false;
            this.поиск_По_ПоставщикамDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.поиск_По_ПоставщикамDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.поиск_По_ПоставщикамDataGridView.DataSource = this.поиск_По_ПоставщикамBindingSource;
            this.поиск_По_ПоставщикамDataGridView.Location = new System.Drawing.Point(0, 30);
            this.поиск_По_ПоставщикамDataGridView.Name = "поиск_По_ПоставщикамDataGridView";
            this.поиск_По_ПоставщикамDataGridView.RowHeadersWidth = 51;
            this.поиск_По_ПоставщикамDataGridView.RowTemplate.Height = 24;
            this.поиск_По_ПоставщикамDataGridView.Size = new System.Drawing.Size(651, 402);
            this.поиск_По_ПоставщикамDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "НаименованиеОрганизаци";
            this.dataGridViewTextBoxColumn1.HeaderText = "НаименованиеОрганизаци";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "РасчетныйСчет";
            this.dataGridViewTextBoxColumn2.HeaderText = "РасчетныйСчет";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Адрес";
            this.dataGridViewTextBoxColumn3.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // SearchPostavchik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(651, 435);
            this.Controls.Add(this.поиск_По_ПоставщикамDataGridView);
            this.Controls.Add(this.fillToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchPostavchik";
            this.Text = "SearchPostavchik";
            ((System.ComponentModel.ISupportInitialize)(this.грузоперевозкиDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поиск_По_ПоставщикамBindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.поиск_По_ПоставщикамDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ГрузоперевозкиDataSet грузоперевозкиDataSet;
        private System.Windows.Forms.BindingSource поиск_По_ПоставщикамBindingSource;
        private ГрузоперевозкиDataSetTableAdapters.Поиск_По_ПоставщикамTableAdapter поиск_По_ПоставщикамTableAdapter;
        private ГрузоперевозкиDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel наименованиеПроцToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox наименованиеПроцToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridView поиск_По_ПоставщикамDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}