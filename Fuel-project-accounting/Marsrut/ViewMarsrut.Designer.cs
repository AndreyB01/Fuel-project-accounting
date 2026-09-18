namespace Fuel_project_accounting.Marsrut
{
    partial class ViewMarsrut
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
            this.грузоперевозкиDataSet = new Fuel_project_accounting.ГрузоперевозкиDataSet();
            this.просмотрМаршрутовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.просмотрМаршрутовTableAdapter = new Fuel_project_accounting.ГрузоперевозкиDataSetTableAdapters.ПросмотрМаршрутовTableAdapter();
            this.tableAdapterManager = new Fuel_project_accounting.ГрузоперевозкиDataSetTableAdapters.TableAdapterManager();
            this.откудаTextBox = new System.Windows.Forms.TextBox();
            this.кудаTextBox = new System.Windows.Forms.TextBox();
            this.километражTextBox = new System.Windows.Forms.TextBox();
            this.времяГодаTextBox = new System.Windows.Forms.TextBox();
            this.маршрутМестностиTextBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            откудаLabel = new System.Windows.Forms.Label();
            кудаLabel = new System.Windows.Forms.Label();
            километражLabel = new System.Windows.Forms.Label();
            времяГодаLabel = new System.Windows.Forms.Label();
            маршрутМестностиLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.грузоперевозкиDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.просмотрМаршрутовBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // грузоперевозкиDataSet
            // 
            this.грузоперевозкиDataSet.DataSetName = "ГрузоперевозкиDataSet";
            this.грузоперевозкиDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // просмотрМаршрутовBindingSource
            // 
            this.просмотрМаршрутовBindingSource.DataMember = "ПросмотрМаршрутов";
            this.просмотрМаршрутовBindingSource.DataSource = this.грузоперевозкиDataSet;
            // 
            // просмотрМаршрутовTableAdapter
            // 
            this.просмотрМаршрутовTableAdapter.ClearBeforeFill = true;
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
            откудаLabel.Location = new System.Drawing.Point(209, 94);
            откудаLabel.Name = "откудаLabel";
            откудаLabel.Size = new System.Drawing.Size(58, 16);
            откудаLabel.TabIndex = 1;
            откудаLabel.Text = "Откуда:";
            // 
            // откудаTextBox
            // 
            this.откудаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.просмотрМаршрутовBindingSource, "Откуда", true));
            this.откудаTextBox.Location = new System.Drawing.Point(358, 91);
            this.откудаTextBox.Name = "откудаTextBox";
            this.откудаTextBox.Size = new System.Drawing.Size(100, 22);
            this.откудаTextBox.TabIndex = 2;
            // 
            // кудаLabel
            // 
            кудаLabel.AutoSize = true;
            кудаLabel.ForeColor = System.Drawing.Color.Turquoise;
            кудаLabel.Location = new System.Drawing.Point(209, 122);
            кудаLabel.Name = "кудаLabel";
            кудаLabel.Size = new System.Drawing.Size(42, 16);
            кудаLabel.TabIndex = 3;
            кудаLabel.Text = "Куда:";
            // 
            // кудаTextBox
            // 
            this.кудаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.просмотрМаршрутовBindingSource, "Куда", true));
            this.кудаTextBox.Location = new System.Drawing.Point(358, 119);
            this.кудаTextBox.Name = "кудаTextBox";
            this.кудаTextBox.Size = new System.Drawing.Size(100, 22);
            this.кудаTextBox.TabIndex = 4;
            // 
            // километражLabel
            // 
            километражLabel.AutoSize = true;
            километражLabel.ForeColor = System.Drawing.Color.Turquoise;
            километражLabel.Location = new System.Drawing.Point(209, 150);
            километражLabel.Name = "километражLabel";
            километражLabel.Size = new System.Drawing.Size(91, 16);
            километражLabel.TabIndex = 5;
            километражLabel.Text = "Километраж:";
            // 
            // километражTextBox
            // 
            this.километражTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.просмотрМаршрутовBindingSource, "Километраж", true));
            this.километражTextBox.Location = new System.Drawing.Point(358, 147);
            this.километражTextBox.Name = "километражTextBox";
            this.километражTextBox.Size = new System.Drawing.Size(100, 22);
            this.километражTextBox.TabIndex = 6;
            // 
            // времяГодаLabel
            // 
            времяГодаLabel.AutoSize = true;
            времяГодаLabel.ForeColor = System.Drawing.Color.Turquoise;
            времяГодаLabel.Location = new System.Drawing.Point(209, 178);
            времяГодаLabel.Name = "времяГодаLabel";
            времяГодаLabel.Size = new System.Drawing.Size(85, 16);
            времяГодаLabel.TabIndex = 7;
            времяГодаLabel.Text = "Время Года:";
            // 
            // времяГодаTextBox
            // 
            this.времяГодаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.просмотрМаршрутовBindingSource, "ВремяГода", true));
            this.времяГодаTextBox.Location = new System.Drawing.Point(358, 175);
            this.времяГодаTextBox.Name = "времяГодаTextBox";
            this.времяГодаTextBox.Size = new System.Drawing.Size(100, 22);
            this.времяГодаTextBox.TabIndex = 8;
            // 
            // маршрутМестностиLabel
            // 
            маршрутМестностиLabel.AutoSize = true;
            маршрутМестностиLabel.ForeColor = System.Drawing.Color.Turquoise;
            маршрутМестностиLabel.Location = new System.Drawing.Point(209, 206);
            маршрутМестностиLabel.Name = "маршрутМестностиLabel";
            маршрутМестностиLabel.Size = new System.Drawing.Size(143, 16);
            маршрутМестностиLabel.TabIndex = 9;
            маршрутМестностиLabel.Text = "Маршрут Местности:";
            // 
            // маршрутМестностиTextBox
            // 
            this.маршрутМестностиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.просмотрМаршрутовBindingSource, "МаршрутМестности", true));
            this.маршрутМестностиTextBox.Location = new System.Drawing.Point(358, 203);
            this.маршрутМестностиTextBox.Name = "маршрутМестностиTextBox";
            this.маршрутМестностиTextBox.Size = new System.Drawing.Size(100, 22);
            this.маршрутМестностиTextBox.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.Location = new System.Drawing.Point(419, 317);
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
            this.button3.Location = new System.Drawing.Point(196, 317);
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
            this.button2.Location = new System.Drawing.Point(269, 317);
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
            this.button1.Location = new System.Drawing.Point(344, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 40);
            this.button1.TabIndex = 41;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewMarsrut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(651, 435);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewMarsrut";
            this.Text = "ViewMarsrut";
            this.Load += new System.EventHandler(this.ViewMarsrut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.грузоперевозкиDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.просмотрМаршрутовBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ГрузоперевозкиDataSet грузоперевозкиDataSet;
        private System.Windows.Forms.BindingSource просмотрМаршрутовBindingSource;
        private ГрузоперевозкиDataSetTableAdapters.ПросмотрМаршрутовTableAdapter просмотрМаршрутовTableAdapter;
        private ГрузоперевозкиDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox откудаTextBox;
        private System.Windows.Forms.TextBox кудаTextBox;
        private System.Windows.Forms.TextBox километражTextBox;
        private System.Windows.Forms.TextBox времяГодаTextBox;
        private System.Windows.Forms.TextBox маршрутМестностиTextBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}