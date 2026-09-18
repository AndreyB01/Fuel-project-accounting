namespace Fuel_project_accounting.Car
{
    partial class EditCar
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
            System.Windows.Forms.Label маркаLabel;
            System.Windows.Forms.Label модельLabel;
            System.Windows.Forms.Label максимальнаяСкоростьLabel;
            System.Windows.Forms.Label объемДвигателяLabel;
            System.Windows.Forms.Label среднийРасходТопливаLabel;
            System.Windows.Forms.Label цветLabel;
            System.Windows.Forms.Label видТопливаLabel;
            this.грузоперевозкиDataSet = new Fuel_project_accounting.ГрузоперевозкиDataSet();
            this.просмотрАвтоBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.просмотрАвтоTableAdapter = new Fuel_project_accounting.ГрузоперевозкиDataSetTableAdapters.ПросмотрАвтоTableAdapter();
            this.tableAdapterManager = new Fuel_project_accounting.ГрузоперевозкиDataSetTableAdapters.TableAdapterManager();
            this.маркаTextBox = new System.Windows.Forms.TextBox();
            this.модельTextBox = new System.Windows.Forms.TextBox();
            this.максимальнаяСкоростьTextBox = new System.Windows.Forms.TextBox();
            this.объемДвигателяTextBox = new System.Windows.Forms.TextBox();
            this.среднийРасходТопливаTextBox = new System.Windows.Forms.TextBox();
            this.цветTextBox = new System.Windows.Forms.TextBox();
            this.видТопливаTextBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            маркаLabel = new System.Windows.Forms.Label();
            модельLabel = new System.Windows.Forms.Label();
            максимальнаяСкоростьLabel = new System.Windows.Forms.Label();
            объемДвигателяLabel = new System.Windows.Forms.Label();
            среднийРасходТопливаLabel = new System.Windows.Forms.Label();
            цветLabel = new System.Windows.Forms.Label();
            видТопливаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.грузоперевозкиDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.просмотрАвтоBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // маркаLabel
            // 
            маркаLabel.AutoSize = true;
            маркаLabel.ForeColor = System.Drawing.Color.Turquoise;
            маркаLabel.Location = new System.Drawing.Point(191, 84);
            маркаLabel.Name = "маркаLabel";
            маркаLabel.Size = new System.Drawing.Size(52, 16);
            маркаLabel.TabIndex = 1;
            маркаLabel.Text = "Марка:";
            // 
            // модельLabel
            // 
            модельLabel.AutoSize = true;
            модельLabel.ForeColor = System.Drawing.Color.Turquoise;
            модельLabel.Location = new System.Drawing.Point(191, 112);
            модельLabel.Name = "модельLabel";
            модельLabel.Size = new System.Drawing.Size(60, 16);
            модельLabel.TabIndex = 3;
            модельLabel.Text = "Модель:";
            // 
            // максимальнаяСкоростьLabel
            // 
            максимальнаяСкоростьLabel.AutoSize = true;
            максимальнаяСкоростьLabel.ForeColor = System.Drawing.Color.Turquoise;
            максимальнаяСкоростьLabel.Location = new System.Drawing.Point(191, 140);
            максимальнаяСкоростьLabel.Name = "максимальнаяСкоростьLabel";
            максимальнаяСкоростьLabel.Size = new System.Drawing.Size(170, 16);
            максимальнаяСкоростьLabel.TabIndex = 5;
            максимальнаяСкоростьLabel.Text = "Максимальная Скорость:";
            // 
            // объемДвигателяLabel
            // 
            объемДвигателяLabel.AutoSize = true;
            объемДвигателяLabel.ForeColor = System.Drawing.Color.Turquoise;
            объемДвигателяLabel.Location = new System.Drawing.Point(191, 168);
            объемДвигателяLabel.Name = "объемДвигателяLabel";
            объемДвигателяLabel.Size = new System.Drawing.Size(126, 16);
            объемДвигателяLabel.TabIndex = 7;
            объемДвигателяLabel.Text = "Объем Двигателя:";
            // 
            // среднийРасходТопливаLabel
            // 
            среднийРасходТопливаLabel.AutoSize = true;
            среднийРасходТопливаLabel.ForeColor = System.Drawing.Color.Turquoise;
            среднийРасходТопливаLabel.Location = new System.Drawing.Point(191, 196);
            среднийРасходТопливаLabel.Name = "среднийРасходТопливаLabel";
            среднийРасходТопливаLabel.Size = new System.Drawing.Size(176, 16);
            среднийРасходТопливаLabel.TabIndex = 9;
            среднийРасходТопливаLabel.Text = "Средний Расход Топлива:";
            // 
            // цветLabel
            // 
            цветLabel.AutoSize = true;
            цветLabel.ForeColor = System.Drawing.Color.Turquoise;
            цветLabel.Location = new System.Drawing.Point(191, 224);
            цветLabel.Name = "цветLabel";
            цветLabel.Size = new System.Drawing.Size(42, 16);
            цветLabel.TabIndex = 11;
            цветLabel.Text = "Цвет:";
            // 
            // видТопливаLabel
            // 
            видТопливаLabel.AutoSize = true;
            видТопливаLabel.ForeColor = System.Drawing.Color.Turquoise;
            видТопливаLabel.Location = new System.Drawing.Point(191, 252);
            видТопливаLabel.Name = "видТопливаLabel";
            видТопливаLabel.Size = new System.Drawing.Size(95, 16);
            видТопливаLabel.TabIndex = 13;
            видТопливаLabel.Text = "Вид Топлива:";
            // 
            // грузоперевозкиDataSet
            // 
            this.грузоперевозкиDataSet.DataSetName = "ГрузоперевозкиDataSet";
            this.грузоперевозкиDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // просмотрАвтоBindingSource
            // 
            this.просмотрАвтоBindingSource.DataMember = "ПросмотрАвто";
            this.просмотрАвтоBindingSource.DataSource = this.грузоперевозкиDataSet;
            // 
            // просмотрАвтоTableAdapter
            // 
            this.просмотрАвтоTableAdapter.ClearBeforeFill = true;
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
            // маркаTextBox
            // 
            this.маркаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.просмотрАвтоBindingSource, "Марка", true));
            this.маркаTextBox.Location = new System.Drawing.Point(373, 81);
            this.маркаTextBox.Name = "маркаTextBox";
            this.маркаTextBox.Size = new System.Drawing.Size(100, 22);
            this.маркаTextBox.TabIndex = 2;
            // 
            // модельTextBox
            // 
            this.модельTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.просмотрАвтоBindingSource, "Модель", true));
            this.модельTextBox.Location = new System.Drawing.Point(373, 109);
            this.модельTextBox.Name = "модельTextBox";
            this.модельTextBox.Size = new System.Drawing.Size(100, 22);
            this.модельTextBox.TabIndex = 4;
            // 
            // максимальнаяСкоростьTextBox
            // 
            this.максимальнаяСкоростьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.просмотрАвтоBindingSource, "МаксимальнаяСкорость", true));
            this.максимальнаяСкоростьTextBox.Location = new System.Drawing.Point(373, 137);
            this.максимальнаяСкоростьTextBox.Name = "максимальнаяСкоростьTextBox";
            this.максимальнаяСкоростьTextBox.Size = new System.Drawing.Size(100, 22);
            this.максимальнаяСкоростьTextBox.TabIndex = 6;
            // 
            // объемДвигателяTextBox
            // 
            this.объемДвигателяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.просмотрАвтоBindingSource, "ОбъемДвигателя", true));
            this.объемДвигателяTextBox.Location = new System.Drawing.Point(373, 165);
            this.объемДвигателяTextBox.Name = "объемДвигателяTextBox";
            this.объемДвигателяTextBox.Size = new System.Drawing.Size(100, 22);
            this.объемДвигателяTextBox.TabIndex = 8;
            // 
            // среднийРасходТопливаTextBox
            // 
            this.среднийРасходТопливаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.просмотрАвтоBindingSource, "СреднийРасходТоплива", true));
            this.среднийРасходТопливаTextBox.Location = new System.Drawing.Point(373, 193);
            this.среднийРасходТопливаTextBox.Name = "среднийРасходТопливаTextBox";
            this.среднийРасходТопливаTextBox.Size = new System.Drawing.Size(100, 22);
            this.среднийРасходТопливаTextBox.TabIndex = 10;
            // 
            // цветTextBox
            // 
            this.цветTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.просмотрАвтоBindingSource, "Цвет", true));
            this.цветTextBox.Location = new System.Drawing.Point(373, 221);
            this.цветTextBox.Name = "цветTextBox";
            this.цветTextBox.Size = new System.Drawing.Size(100, 22);
            this.цветTextBox.TabIndex = 12;
            // 
            // видТопливаTextBox
            // 
            this.видТопливаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.просмотрАвтоBindingSource, "ВидТоплива", true));
            this.видТопливаTextBox.Location = new System.Drawing.Point(373, 249);
            this.видТопливаTextBox.Name = "видТопливаTextBox";
            this.видТопливаTextBox.Size = new System.Drawing.Size(100, 22);
            this.видТопливаTextBox.TabIndex = 14;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.Location = new System.Drawing.Point(409, 290);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(69, 40);
            this.button4.TabIndex = 36;
            this.button4.Text = ">|";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Location = new System.Drawing.Point(186, 290);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 40);
            this.button3.TabIndex = 35;
            this.button3.Text = "|<";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Location = new System.Drawing.Point(259, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 40);
            this.button2.TabIndex = 34;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(334, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 40);
            this.button1.TabIndex = 33;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(651, 435);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(маркаLabel);
            this.Controls.Add(this.маркаTextBox);
            this.Controls.Add(модельLabel);
            this.Controls.Add(this.модельTextBox);
            this.Controls.Add(максимальнаяСкоростьLabel);
            this.Controls.Add(this.максимальнаяСкоростьTextBox);
            this.Controls.Add(объемДвигателяLabel);
            this.Controls.Add(this.объемДвигателяTextBox);
            this.Controls.Add(среднийРасходТопливаLabel);
            this.Controls.Add(this.среднийРасходТопливаTextBox);
            this.Controls.Add(цветLabel);
            this.Controls.Add(this.цветTextBox);
            this.Controls.Add(видТопливаLabel);
            this.Controls.Add(this.видТопливаTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditCar";
            this.Text = "EditCar";
            this.Load += new System.EventHandler(this.EditCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.грузоперевозкиDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.просмотрАвтоBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ГрузоперевозкиDataSet грузоперевозкиDataSet;
        private System.Windows.Forms.BindingSource просмотрАвтоBindingSource;
        private ГрузоперевозкиDataSetTableAdapters.ПросмотрАвтоTableAdapter просмотрАвтоTableAdapter;
        private ГрузоперевозкиDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox маркаTextBox;
        private System.Windows.Forms.TextBox модельTextBox;
        private System.Windows.Forms.TextBox максимальнаяСкоростьTextBox;
        private System.Windows.Forms.TextBox объемДвигателяTextBox;
        private System.Windows.Forms.TextBox среднийРасходТопливаTextBox;
        private System.Windows.Forms.TextBox цветTextBox;
        private System.Windows.Forms.TextBox видТопливаTextBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}