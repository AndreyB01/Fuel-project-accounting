namespace Fuel_project_accounting.Marsrut
{
    partial class SearchMarsrut
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
            this.поиск_По_МаршрутамBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поиск_По_МаршрутамTableAdapter = new Fuel_project_accounting.ГрузоперевозкиDataSetTableAdapters.Поиск_По_МаршрутамTableAdapter();
            this.tableAdapterManager = new Fuel_project_accounting.ГрузоперевозкиDataSetTableAdapters.TableAdapterManager();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.откудаПроцToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.откудаПроцToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.кудаПроцToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.кудаПроцToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.поиск_По_МаршрутамDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.грузоперевозкиDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поиск_По_МаршрутамBindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.поиск_По_МаршрутамDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // грузоперевозкиDataSet
            // 
            this.грузоперевозкиDataSet.DataSetName = "ГрузоперевозкиDataSet";
            this.грузоперевозкиDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // поиск_По_МаршрутамBindingSource
            // 
            this.поиск_По_МаршрутамBindingSource.DataMember = "Поиск_По_Маршрутам";
            this.поиск_По_МаршрутамBindingSource.DataSource = this.грузоперевозкиDataSet;
            // 
            // поиск_По_МаршрутамTableAdapter
            // 
            this.поиск_По_МаршрутамTableAdapter.ClearBeforeFill = true;
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
            this.откудаПроцToolStripLabel,
            this.откудаПроцToolStripTextBox,
            this.кудаПроцToolStripLabel,
            this.кудаПроцToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(651, 27);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // откудаПроцToolStripLabel
            // 
            this.откудаПроцToolStripLabel.Name = "откудаПроцToolStripLabel";
            this.откудаПроцToolStripLabel.Size = new System.Drawing.Size(59, 24);
            this.откудаПроцToolStripLabel.Text = "Откуда:";
            // 
            // откудаПроцToolStripTextBox
            // 
            this.откудаПроцToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.откудаПроцToolStripTextBox.Name = "откудаПроцToolStripTextBox";
            this.откудаПроцToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // кудаПроцToolStripLabel
            // 
            this.кудаПроцToolStripLabel.Name = "кудаПроцToolStripLabel";
            this.кудаПроцToolStripLabel.Size = new System.Drawing.Size(44, 24);
            this.кудаПроцToolStripLabel.Text = "Куда:";
            // 
            // кудаПроцToolStripTextBox
            // 
            this.кудаПроцToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.кудаПроцToolStripTextBox.Name = "кудаПроцToolStripTextBox";
            this.кудаПроцToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(56, 24);
            this.fillToolStripButton.Text = "Поиск";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // поиск_По_МаршрутамDataGridView
            // 
            this.поиск_По_МаршрутамDataGridView.AutoGenerateColumns = false;
            this.поиск_По_МаршрутамDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.поиск_По_МаршрутамDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.поиск_По_МаршрутамDataGridView.DataSource = this.поиск_По_МаршрутамBindingSource;
            this.поиск_По_МаршрутамDataGridView.Location = new System.Drawing.Point(0, 30);
            this.поиск_По_МаршрутамDataGridView.Name = "поиск_По_МаршрутамDataGridView";
            this.поиск_По_МаршрутамDataGridView.RowHeadersWidth = 51;
            this.поиск_По_МаршрутамDataGridView.RowTemplate.Height = 24;
            this.поиск_По_МаршрутамDataGridView.Size = new System.Drawing.Size(651, 431);
            this.поиск_По_МаршрутамDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Откуда";
            this.dataGridViewTextBoxColumn1.HeaderText = "Откуда";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Куда";
            this.dataGridViewTextBoxColumn2.HeaderText = "Куда";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Километраж";
            this.dataGridViewTextBoxColumn3.HeaderText = "Километраж";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ВремяГода";
            this.dataGridViewTextBoxColumn4.HeaderText = "ВремяГода";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "МаршрутМестности";
            this.dataGridViewTextBoxColumn5.HeaderText = "МаршрутМестности";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // SearchMarsrut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(651, 463);
            this.Controls.Add(this.поиск_По_МаршрутамDataGridView);
            this.Controls.Add(this.fillToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchMarsrut";
            this.Text = "SearchMarsrut";
            ((System.ComponentModel.ISupportInitialize)(this.грузоперевозкиDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поиск_По_МаршрутамBindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.поиск_По_МаршрутамDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ГрузоперевозкиDataSet грузоперевозкиDataSet;
        private System.Windows.Forms.BindingSource поиск_По_МаршрутамBindingSource;
        private ГрузоперевозкиDataSetTableAdapters.Поиск_По_МаршрутамTableAdapter поиск_По_МаршрутамTableAdapter;
        private ГрузоперевозкиDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel откудаПроцToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox откудаПроцToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel кудаПроцToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox кудаПроцToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridView поиск_По_МаршрутамDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}