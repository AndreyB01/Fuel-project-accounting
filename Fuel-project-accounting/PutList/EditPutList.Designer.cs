namespace Fuel_project_accounting.PutList
{
    partial class EditPutList
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
            System.Windows.Forms.Label литровКВыдачеLabel;
            System.Windows.Forms.Label idМаршрутаПередвеженияLabel;
            System.Windows.Forms.Label idАвтоLabel;
            this.грузоперевозкиDataSet = new Fuel_project_accounting.ГрузоперевозкиDataSet();
            this.путевойЛистBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.путевойЛистTableAdapter = new Fuel_project_accounting.ГрузоперевозкиDataSetTableAdapters.ПутевойЛистTableAdapter();
            this.tableAdapterManager = new Fuel_project_accounting.ГрузоперевозкиDataSetTableAdapters.TableAdapterManager();
            this.литровКВыдачеTextBox = new System.Windows.Forms.TextBox();
            this.idМаршрутаПередвеженияTextBox = new System.Windows.Forms.TextBox();
            this.idАвтоTextBox = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            литровКВыдачеLabel = new System.Windows.Forms.Label();
            idМаршрутаПередвеженияLabel = new System.Windows.Forms.Label();
            idАвтоLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.грузоперевозкиDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.путевойЛистBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // грузоперевозкиDataSet
            // 
            this.грузоперевозкиDataSet.DataSetName = "ГрузоперевозкиDataSet";
            this.грузоперевозкиDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // путевойЛистBindingSource
            // 
            this.путевойЛистBindingSource.DataMember = "ПутевойЛист";
            this.путевойЛистBindingSource.DataSource = this.грузоперевозкиDataSet;
            // 
            // путевойЛистTableAdapter
            // 
            this.путевойЛистTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ПутевойЛистTableAdapter = this.путевойЛистTableAdapter;
            this.tableAdapterManager.УчетГСНTableAdapter = null;
            // 
            // литровКВыдачеLabel
            // 
            литровКВыдачеLabel.AutoSize = true;
            литровКВыдачеLabel.ForeColor = System.Drawing.Color.Turquoise;
            литровКВыдачеLabel.Location = new System.Drawing.Point(183, 130);
            литровКВыдачеLabel.Name = "литровКВыдачеLabel";
            литровКВыдачеLabel.Size = new System.Drawing.Size(119, 16);
            литровКВыдачеLabel.TabIndex = 3;
            литровКВыдачеLabel.Text = "Литров КВыдаче:";
            // 
            // литровКВыдачеTextBox
            // 
            this.литровКВыдачеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.путевойЛистBindingSource, "ЛитровКВыдаче", true));
            this.литровКВыдачеTextBox.Location = new System.Drawing.Point(381, 127);
            this.литровКВыдачеTextBox.Name = "литровКВыдачеTextBox";
            this.литровКВыдачеTextBox.Size = new System.Drawing.Size(100, 22);
            this.литровКВыдачеTextBox.TabIndex = 4;
            // 
            // idМаршрутаПередвеженияLabel
            // 
            idМаршрутаПередвеженияLabel.AutoSize = true;
            idМаршрутаПередвеженияLabel.ForeColor = System.Drawing.Color.Turquoise;
            idМаршрутаПередвеженияLabel.Location = new System.Drawing.Point(183, 158);
            idМаршрутаПередвеженияLabel.Name = "idМаршрутаПередвеженияLabel";
            idМаршрутаПередвеженияLabel.Size = new System.Drawing.Size(178, 16);
            idМаршрутаПередвеженияLabel.TabIndex = 5;
            idМаршрутаПередвеженияLabel.Text = "Маршрута Передвежения:";
            // 
            // idМаршрутаПередвеженияTextBox
            // 
            this.idМаршрутаПередвеженияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.путевойЛистBindingSource, "IdМаршрутаПередвежения", true));
            this.idМаршрутаПередвеженияTextBox.Location = new System.Drawing.Point(381, 155);
            this.idМаршрутаПередвеженияTextBox.Name = "idМаршрутаПередвеженияTextBox";
            this.idМаршрутаПередвеженияTextBox.Size = new System.Drawing.Size(100, 22);
            this.idМаршрутаПередвеженияTextBox.TabIndex = 6;
            // 
            // idАвтоLabel
            // 
            idАвтоLabel.AutoSize = true;
            idАвтоLabel.ForeColor = System.Drawing.Color.Turquoise;
            idАвтоLabel.Location = new System.Drawing.Point(183, 186);
            idАвтоLabel.Name = "idАвтоLabel";
            idАвтоLabel.Size = new System.Drawing.Size(42, 16);
            idАвтоLabel.TabIndex = 7;
            idАвтоLabel.Text = "Авто:";
            // 
            // idАвтоTextBox
            // 
            this.idАвтоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.путевойЛистBindingSource, "IdАвто", true));
            this.idАвтоTextBox.Location = new System.Drawing.Point(381, 183);
            this.idАвтоTextBox.Name = "idАвтоTextBox";
            this.idАвтоTextBox.Size = new System.Drawing.Size(100, 22);
            this.idАвтоTextBox.TabIndex = 8;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button7.Location = new System.Drawing.Point(440, 330);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(61, 40);
            this.button7.TabIndex = 52;
            this.button7.Text = "Save";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button6.Location = new System.Drawing.Point(507, 330);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(61, 40);
            this.button6.TabIndex = 51;
            this.button6.Text = "Del";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button5.Location = new System.Drawing.Point(375, 330);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(61, 40);
            this.button5.TabIndex = 50;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.Location = new System.Drawing.Point(308, 330);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 40);
            this.button4.TabIndex = 49;
            this.button4.Text = ">|";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Location = new System.Drawing.Point(107, 330);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 40);
            this.button3.TabIndex = 48;
            this.button3.Text = "|<";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Location = new System.Drawing.Point(174, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 40);
            this.button2.TabIndex = 47;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(241, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 40);
            this.button1.TabIndex = 46;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditPutList
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
            this.Controls.Add(литровКВыдачеLabel);
            this.Controls.Add(this.литровКВыдачеTextBox);
            this.Controls.Add(idМаршрутаПередвеженияLabel);
            this.Controls.Add(this.idМаршрутаПередвеженияTextBox);
            this.Controls.Add(idАвтоLabel);
            this.Controls.Add(this.idАвтоTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditPutList";
            this.Text = "EditPutList";
            this.Load += new System.EventHandler(this.EditPutList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.грузоперевозкиDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.путевойЛистBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ГрузоперевозкиDataSet грузоперевозкиDataSet;
        private System.Windows.Forms.BindingSource путевойЛистBindingSource;
        private ГрузоперевозкиDataSetTableAdapters.ПутевойЛистTableAdapter путевойЛистTableAdapter;
        private ГрузоперевозкиDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox литровКВыдачеTextBox;
        private System.Windows.Forms.TextBox idМаршрутаПередвеженияTextBox;
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