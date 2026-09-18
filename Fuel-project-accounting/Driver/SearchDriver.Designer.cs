namespace Fuel_project_accounting.Driver
{
    partial class SearchDriver
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
            this.поиск_По_ВодителямBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поиск_По_ВодителямTableAdapter = new Fuel_project_accounting.ГрузоперевозкиDataSetTableAdapters.Поиск_По_ВодителямTableAdapter();
            this.tableAdapterManager = new Fuel_project_accounting.ГрузоперевозкиDataSetTableAdapters.TableAdapterManager();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.категорияПроцToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.категорияПроцToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.стажПроцToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.стажПроцToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.поиск_По_ВодителямDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.грузоперевозкиDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поиск_По_ВодителямBindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.поиск_По_ВодителямDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // грузоперевозкиDataSet
            // 
            this.грузоперевозкиDataSet.DataSetName = "ГрузоперевозкиDataSet";
            this.грузоперевозкиDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // поиск_По_ВодителямBindingSource
            // 
            this.поиск_По_ВодителямBindingSource.DataMember = "Поиск_По_Водителям";
            this.поиск_По_ВодителямBindingSource.DataSource = this.грузоперевозкиDataSet;
            // 
            // поиск_По_ВодителямTableAdapter
            // 
            this.поиск_По_ВодителямTableAdapter.ClearBeforeFill = true;
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
            this.категорияПроцToolStripLabel,
            this.категорияПроцToolStripTextBox,
            this.стажПроцToolStripLabel,
            this.стажПроцToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(651, 27);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // категорияПроцToolStripLabel
            // 
            this.категорияПроцToolStripLabel.Name = "категорияПроцToolStripLabel";
            this.категорияПроцToolStripLabel.Size = new System.Drawing.Size(84, 24);
            this.категорияПроцToolStripLabel.Text = "Категория:";
            // 
            // категорияПроцToolStripTextBox
            // 
            this.категорияПроцToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.категорияПроцToolStripTextBox.Name = "категорияПроцToolStripTextBox";
            this.категорияПроцToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // стажПроцToolStripLabel
            // 
            this.стажПроцToolStripLabel.Name = "стажПроцToolStripLabel";
            this.стажПроцToolStripLabel.Size = new System.Drawing.Size(46, 24);
            this.стажПроцToolStripLabel.Text = "Стаж:";
            // 
            // стажПроцToolStripTextBox
            // 
            this.стажПроцToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.стажПроцToolStripTextBox.Name = "стажПроцToolStripTextBox";
            this.стажПроцToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(56, 24);
            this.fillToolStripButton.Text = "Поиск";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // поиск_По_ВодителямDataGridView
            // 
            this.поиск_По_ВодителямDataGridView.AutoGenerateColumns = false;
            this.поиск_По_ВодителямDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.поиск_По_ВодителямDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.поиск_По_ВодителямDataGridView.DataSource = this.поиск_По_ВодителямBindingSource;
            this.поиск_По_ВодителямDataGridView.Location = new System.Drawing.Point(0, 30);
            this.поиск_По_ВодителямDataGridView.Name = "поиск_По_ВодителямDataGridView";
            this.поиск_По_ВодителямDataGridView.RowHeadersWidth = 51;
            this.поиск_По_ВодителямDataGridView.RowTemplate.Height = 24;
            this.поиск_По_ВодителямDataGridView.Size = new System.Drawing.Size(651, 405);
            this.поиск_По_ВодителямDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Фамилия";
            this.dataGridViewTextBoxColumn1.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Имя";
            this.dataGridViewTextBoxColumn2.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Отчество";
            this.dataGridViewTextBoxColumn3.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ДатаРоджения";
            this.dataGridViewTextBoxColumn4.HeaderText = "ДатаРоджения";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Пол";
            this.dataGridViewTextBoxColumn5.HeaderText = "Пол";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Категория";
            this.dataGridViewTextBoxColumn6.HeaderText = "Категория";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Стаж";
            this.dataGridViewTextBoxColumn7.HeaderText = "Стаж";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // SearchDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(651, 435);
            this.Controls.Add(this.поиск_По_ВодителямDataGridView);
            this.Controls.Add(this.fillToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchDriver";
            this.Text = "SearchDriver";
            ((System.ComponentModel.ISupportInitialize)(this.грузоперевозкиDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поиск_По_ВодителямBindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.поиск_По_ВодителямDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ГрузоперевозкиDataSet грузоперевозкиDataSet;
        private System.Windows.Forms.BindingSource поиск_По_ВодителямBindingSource;
        private ГрузоперевозкиDataSetTableAdapters.Поиск_По_ВодителямTableAdapter поиск_По_ВодителямTableAdapter;
        private ГрузоперевозкиDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel категорияПроцToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox категорияПроцToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel стажПроцToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox стажПроцToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridView поиск_По_ВодителямDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}