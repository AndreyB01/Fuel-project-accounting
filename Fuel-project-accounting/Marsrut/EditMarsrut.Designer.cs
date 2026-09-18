namespace Fuel_project_accounting.Marsrut
{
    partial class EditMarsrut
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
            this.маршрутПередвеженияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.маршрутПередвеженияTableAdapter = new Fuel_project_accounting.ГрузоперевозкиDataSetTableAdapters.МаршрутПередвеженияTableAdapter();
            this.tableAdapterManager = new Fuel_project_accounting.ГрузоперевозкиDataSetTableAdapters.TableAdapterManager();
            this.откудаTextBox = new System.Windows.Forms.TextBox();
            this.кудаTextBox = new System.Windows.Forms.TextBox();
            this.километражTextBox = new System.Windows.Forms.TextBox();
            this.времяГодаTextBox = new System.Windows.Forms.TextBox();
            this.маршрутМестностиTextBox = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.маршрутПередвеженияBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // грузоперевозкиDataSet
            // 
            this.грузоперевозкиDataSet.DataSetName = "ГрузоперевозкиDataSet";
            this.грузоперевозкиDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // маршрутПередвеженияBindingSource
            // 
            this.маршрутПередвеженияBindingSource.DataMember = "МаршрутПередвежения";
            this.маршрутПередвеженияBindingSource.DataSource = this.грузоперевозкиDataSet;
            // 
            // маршрутПередвеженияTableAdapter
            // 
            this.маршрутПередвеженияTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Fuel_project_accounting.ГрузоперевозкиDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвтоTableAdapter = null;
            this.tableAdapterManager.ВидыГСМTableAdapter = null;
            this.tableAdapterManager.ВодителиTableAdapter = null;
            this.tableAdapterManager.ГСНTableAdapter = null;
            this.tableAdapterManager.МаршрутПередвеженияTableAdapter = this.маршрутПередвеженияTableAdapter;
            this.tableAdapterManager.ПостовщикГСМTableAdapter = null;
            this.tableAdapterManager.ПутевойЛистTableAdapter = null;
            this.tableAdapterManager.УчетГСНTableAdapter = null;
            // 
            // откудаLabel
            // 
            откудаLabel.AutoSize = true;
            откудаLabel.ForeColor = System.Drawing.Color.Turquoise;
            откудаLabel.Location = new System.Drawing.Point(186, 105);
            откудаLabel.Name = "откудаLabel";
            откудаLabel.Size = new System.Drawing.Size(58, 16);
            откудаLabel.TabIndex = 3;
            откудаLabel.Text = "Откуда:";
            // 
            // откудаTextBox
            // 
            this.откудаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.маршрутПередвеженияBindingSource, "Откуда", true));
            this.откудаTextBox.Location = new System.Drawing.Point(384, 102);
            this.откудаTextBox.Name = "откудаTextBox";
            this.откудаTextBox.Size = new System.Drawing.Size(100, 22);
            this.откудаTextBox.TabIndex = 4;
            // 
            // кудаLabel
            // 
            кудаLabel.AutoSize = true;
            кудаLabel.ForeColor = System.Drawing.Color.Turquoise;
            кудаLabel.Location = new System.Drawing.Point(186, 133);
            кудаLabel.Name = "кудаLabel";
            кудаLabel.Size = new System.Drawing.Size(42, 16);
            кудаLabel.TabIndex = 5;
            кудаLabel.Text = "Куда:";
            // 
            // кудаTextBox
            // 
            this.кудаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.маршрутПередвеженияBindingSource, "Куда", true));
            this.кудаTextBox.Location = new System.Drawing.Point(384, 130);
            this.кудаTextBox.Name = "кудаTextBox";
            this.кудаTextBox.Size = new System.Drawing.Size(100, 22);
            this.кудаTextBox.TabIndex = 6;
            // 
            // километражLabel
            // 
            километражLabel.AutoSize = true;
            километражLabel.ForeColor = System.Drawing.Color.Turquoise;
            километражLabel.Location = new System.Drawing.Point(186, 161);
            километражLabel.Name = "километражLabel";
            километражLabel.Size = new System.Drawing.Size(91, 16);
            километражLabel.TabIndex = 7;
            километражLabel.Text = "Километраж:";
            // 
            // километражTextBox
            // 
            this.километражTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.маршрутПередвеженияBindingSource, "Километраж", true));
            this.километражTextBox.Location = new System.Drawing.Point(384, 158);
            this.километражTextBox.Name = "километражTextBox";
            this.километражTextBox.Size = new System.Drawing.Size(100, 22);
            this.километражTextBox.TabIndex = 8;
            // 
            // времяГодаLabel
            // 
            времяГодаLabel.AutoSize = true;
            времяГодаLabel.ForeColor = System.Drawing.Color.Turquoise;
            времяГодаLabel.Location = new System.Drawing.Point(186, 189);
            времяГодаLabel.Name = "времяГодаLabel";
            времяГодаLabel.Size = new System.Drawing.Size(85, 16);
            времяГодаLabel.TabIndex = 9;
            времяГодаLabel.Text = "Время Года:";
            // 
            // времяГодаTextBox
            // 
            this.времяГодаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.маршрутПередвеженияBindingSource, "ВремяГода", true));
            this.времяГодаTextBox.Location = new System.Drawing.Point(384, 186);
            this.времяГодаTextBox.Name = "времяГодаTextBox";
            this.времяГодаTextBox.Size = new System.Drawing.Size(100, 22);
            this.времяГодаTextBox.TabIndex = 10;
            // 
            // маршрутМестностиLabel
            // 
            маршрутМестностиLabel.AutoSize = true;
            маршрутМестностиLabel.ForeColor = System.Drawing.Color.Turquoise;
            маршрутМестностиLabel.Location = new System.Drawing.Point(186, 217);
            маршрутМестностиLabel.Name = "маршрутМестностиLabel";
            маршрутМестностиLabel.Size = new System.Drawing.Size(143, 16);
            маршрутМестностиLabel.TabIndex = 11;
            маршрутМестностиLabel.Text = "Маршрут Местности:";
            // 
            // маршрутМестностиTextBox
            // 
            this.маршрутМестностиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.маршрутПередвеженияBindingSource, "МаршрутМестности", true));
            this.маршрутМестностиTextBox.Location = new System.Drawing.Point(384, 214);
            this.маршрутМестностиTextBox.Name = "маршрутМестностиTextBox";
            this.маршрутМестностиTextBox.Size = new System.Drawing.Size(100, 22);
            this.маршрутМестностиTextBox.TabIndex = 12;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button7.Location = new System.Drawing.Point(433, 284);
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
            this.button6.Location = new System.Drawing.Point(500, 284);
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
            this.button5.Location = new System.Drawing.Point(368, 284);
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
            this.button4.Location = new System.Drawing.Point(301, 284);
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
            this.button3.Location = new System.Drawing.Point(100, 284);
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
            this.button2.Location = new System.Drawing.Point(167, 284);
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
            this.button1.Location = new System.Drawing.Point(234, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 40);
            this.button1.TabIndex = 46;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditMarsrut
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
            this.Name = "EditMarsrut";
            this.Text = "EditMarsrut";
            this.Load += new System.EventHandler(this.EditMarsrut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.грузоперевозкиDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.маршрутПередвеженияBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ГрузоперевозкиDataSet грузоперевозкиDataSet;
        private System.Windows.Forms.BindingSource маршрутПередвеженияBindingSource;
        private ГрузоперевозкиDataSetTableAdapters.МаршрутПередвеженияTableAdapter маршрутПередвеженияTableAdapter;
        private ГрузоперевозкиDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox откудаTextBox;
        private System.Windows.Forms.TextBox кудаTextBox;
        private System.Windows.Forms.TextBox километражTextBox;
        private System.Windows.Forms.TextBox времяГодаTextBox;
        private System.Windows.Forms.TextBox маршрутМестностиTextBox;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}