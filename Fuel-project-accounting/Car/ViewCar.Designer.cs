namespace Fuel_project_accounting.Car
{
    partial class ViewCar
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
            System.Windows.Forms.Label номерLabel;
            System.Windows.Forms.Label максимальнаяСкоростьLabel;
            System.Windows.Forms.Label объемДвигателяLabel;
            System.Windows.Forms.Label среднийРасходТопливаLabel;
            System.Windows.Forms.Label цветLabel;
            System.Windows.Forms.Label видТопливаLabel;
            this.грузоперевозкиDataSet = new Fuel_project_accounting.ГрузоперевозкиDataSet();
            this.автоBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.автоTableAdapter = new Fuel_project_accounting.ГрузоперевозкиDataSetTableAdapters.АвтоTableAdapter();
            this.tableAdapterManager = new Fuel_project_accounting.ГрузоперевозкиDataSetTableAdapters.TableAdapterManager();
            this.маркаTextBox = new System.Windows.Forms.TextBox();
            this.модельTextBox = new System.Windows.Forms.TextBox();
            this.номерTextBox = new System.Windows.Forms.TextBox();
            this.максимальнаяСкоростьTextBox = new System.Windows.Forms.TextBox();
            this.объемДвигателяTextBox = new System.Windows.Forms.TextBox();
            this.среднийРасходТопливаTextBox = new System.Windows.Forms.TextBox();
            this.цветTextBox = new System.Windows.Forms.TextBox();
            this.видТопливаTextBox = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            маркаLabel = new System.Windows.Forms.Label();
            модельLabel = new System.Windows.Forms.Label();
            номерLabel = new System.Windows.Forms.Label();
            максимальнаяСкоростьLabel = new System.Windows.Forms.Label();
            объемДвигателяLabel = new System.Windows.Forms.Label();
            среднийРасходТопливаLabel = new System.Windows.Forms.Label();
            цветLabel = new System.Windows.Forms.Label();
            видТопливаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.грузоперевозкиDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автоBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // грузоперевозкиDataSet
            // 
            this.грузоперевозкиDataSet.DataSetName = "ГрузоперевозкиDataSet";
            this.грузоперевозкиDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // автоBindingSource
            // 
            this.автоBindingSource.DataMember = "Авто";
            this.автоBindingSource.DataSource = this.грузоперевозкиDataSet;
            // 
            // автоTableAdapter
            // 
            this.автоTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Fuel_project_accounting.ГрузоперевозкиDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвтоTableAdapter = this.автоTableAdapter;
            this.tableAdapterManager.ВидыГСМTableAdapter = null;
            this.tableAdapterManager.ВодителиTableAdapter = null;
            this.tableAdapterManager.ГСНTableAdapter = null;
            this.tableAdapterManager.МаршрутПередвеженияTableAdapter = null;
            this.tableAdapterManager.ПостовщикГСМTableAdapter = null;
            this.tableAdapterManager.ПутевойЛистTableAdapter = null;
            this.tableAdapterManager.УчетГСНTableAdapter = null;
            // 
            // маркаLabel
            // 
            маркаLabel.AutoSize = true;
            маркаLabel.ForeColor = System.Drawing.Color.Turquoise;
            маркаLabel.Location = new System.Drawing.Point(194, 81);
            маркаLabel.Name = "маркаLabel";
            маркаLabel.Size = new System.Drawing.Size(52, 16);
            маркаLabel.TabIndex = 3;
            маркаLabel.Text = "Марка:";
            // 
            // маркаTextBox
            // 
            this.маркаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автоBindingSource, "Марка", true));
            this.маркаTextBox.Location = new System.Drawing.Point(376, 78);
            this.маркаTextBox.Name = "маркаTextBox";
            this.маркаTextBox.Size = new System.Drawing.Size(100, 22);
            this.маркаTextBox.TabIndex = 4;
            // 
            // модельLabel
            // 
            модельLabel.AutoSize = true;
            модельLabel.ForeColor = System.Drawing.Color.Turquoise;
            модельLabel.Location = new System.Drawing.Point(194, 109);
            модельLabel.Name = "модельLabel";
            модельLabel.Size = new System.Drawing.Size(60, 16);
            модельLabel.TabIndex = 5;
            модельLabel.Text = "Модель:";
            // 
            // модельTextBox
            // 
            this.модельTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автоBindingSource, "Модель", true));
            this.модельTextBox.Location = new System.Drawing.Point(376, 106);
            this.модельTextBox.Name = "модельTextBox";
            this.модельTextBox.Size = new System.Drawing.Size(100, 22);
            this.модельTextBox.TabIndex = 6;
            // 
            // номерLabel
            // 
            номерLabel.AutoSize = true;
            номерLabel.ForeColor = System.Drawing.Color.Turquoise;
            номерLabel.Location = new System.Drawing.Point(194, 137);
            номерLabel.Name = "номерLabel";
            номерLabel.Size = new System.Drawing.Size(53, 16);
            номерLabel.TabIndex = 7;
            номерLabel.Text = "Номер:";
            // 
            // номерTextBox
            // 
            this.номерTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автоBindingSource, "Номер", true));
            this.номерTextBox.Location = new System.Drawing.Point(376, 134);
            this.номерTextBox.Name = "номерTextBox";
            this.номерTextBox.Size = new System.Drawing.Size(100, 22);
            this.номерTextBox.TabIndex = 8;
            // 
            // максимальнаяСкоростьLabel
            // 
            максимальнаяСкоростьLabel.AutoSize = true;
            максимальнаяСкоростьLabel.ForeColor = System.Drawing.Color.Turquoise;
            максимальнаяСкоростьLabel.Location = new System.Drawing.Point(194, 165);
            максимальнаяСкоростьLabel.Name = "максимальнаяСкоростьLabel";
            максимальнаяСкоростьLabel.Size = new System.Drawing.Size(170, 16);
            максимальнаяСкоростьLabel.TabIndex = 9;
            максимальнаяСкоростьLabel.Text = "Максимальная Скорость:";
            // 
            // максимальнаяСкоростьTextBox
            // 
            this.максимальнаяСкоростьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автоBindingSource, "МаксимальнаяСкорость", true));
            this.максимальнаяСкоростьTextBox.Location = new System.Drawing.Point(376, 162);
            this.максимальнаяСкоростьTextBox.Name = "максимальнаяСкоростьTextBox";
            this.максимальнаяСкоростьTextBox.Size = new System.Drawing.Size(100, 22);
            this.максимальнаяСкоростьTextBox.TabIndex = 10;
            // 
            // объемДвигателяLabel
            // 
            объемДвигателяLabel.AutoSize = true;
            объемДвигателяLabel.ForeColor = System.Drawing.Color.Turquoise;
            объемДвигателяLabel.Location = new System.Drawing.Point(194, 193);
            объемДвигателяLabel.Name = "объемДвигателяLabel";
            объемДвигателяLabel.Size = new System.Drawing.Size(126, 16);
            объемДвигателяLabel.TabIndex = 11;
            объемДвигателяLabel.Text = "Объем Двигателя:";
            // 
            // объемДвигателяTextBox
            // 
            this.объемДвигателяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автоBindingSource, "ОбъемДвигателя", true));
            this.объемДвигателяTextBox.Location = new System.Drawing.Point(376, 190);
            this.объемДвигателяTextBox.Name = "объемДвигателяTextBox";
            this.объемДвигателяTextBox.Size = new System.Drawing.Size(100, 22);
            this.объемДвигателяTextBox.TabIndex = 12;
            // 
            // среднийРасходТопливаLabel
            // 
            среднийРасходТопливаLabel.AutoSize = true;
            среднийРасходТопливаLabel.ForeColor = System.Drawing.Color.Turquoise;
            среднийРасходТопливаLabel.Location = new System.Drawing.Point(194, 221);
            среднийРасходТопливаLabel.Name = "среднийРасходТопливаLabel";
            среднийРасходТопливаLabel.Size = new System.Drawing.Size(176, 16);
            среднийРасходТопливаLabel.TabIndex = 13;
            среднийРасходТопливаLabel.Text = "Средний Расход Топлива:";
            // 
            // среднийРасходТопливаTextBox
            // 
            this.среднийРасходТопливаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автоBindingSource, "СреднийРасходТоплива", true));
            this.среднийРасходТопливаTextBox.Location = new System.Drawing.Point(376, 218);
            this.среднийРасходТопливаTextBox.Name = "среднийРасходТопливаTextBox";
            this.среднийРасходТопливаTextBox.Size = new System.Drawing.Size(100, 22);
            this.среднийРасходТопливаTextBox.TabIndex = 14;
            // 
            // цветLabel
            // 
            цветLabel.AutoSize = true;
            цветLabel.ForeColor = System.Drawing.Color.Turquoise;
            цветLabel.Location = new System.Drawing.Point(194, 249);
            цветLabel.Name = "цветLabel";
            цветLabel.Size = new System.Drawing.Size(42, 16);
            цветLabel.TabIndex = 15;
            цветLabel.Text = "Цвет:";
            // 
            // цветTextBox
            // 
            this.цветTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автоBindingSource, "Цвет", true));
            this.цветTextBox.Location = new System.Drawing.Point(376, 246);
            this.цветTextBox.Name = "цветTextBox";
            this.цветTextBox.Size = new System.Drawing.Size(100, 22);
            this.цветTextBox.TabIndex = 16;
            // 
            // видТопливаLabel
            // 
            видТопливаLabel.AutoSize = true;
            видТопливаLabel.ForeColor = System.Drawing.Color.Turquoise;
            видТопливаLabel.Location = new System.Drawing.Point(194, 277);
            видТопливаLabel.Name = "видТопливаLabel";
            видТопливаLabel.Size = new System.Drawing.Size(95, 16);
            видТопливаLabel.TabIndex = 17;
            видТопливаLabel.Text = "Вид Топлива:";
            // 
            // видТопливаTextBox
            // 
            this.видТопливаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автоBindingSource, "ВидТоплива", true));
            this.видТопливаTextBox.Location = new System.Drawing.Point(376, 274);
            this.видТопливаTextBox.Name = "видТопливаTextBox";
            this.видТопливаTextBox.Size = new System.Drawing.Size(100, 22);
            this.видТопливаTextBox.TabIndex = 18;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button7.Location = new System.Drawing.Point(446, 323);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(61, 40);
            this.button7.TabIndex = 38;
            this.button7.Text = "Save";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button6.Location = new System.Drawing.Point(513, 323);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(61, 40);
            this.button6.TabIndex = 37;
            this.button6.Text = "Del";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button5.Location = new System.Drawing.Point(381, 323);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(61, 40);
            this.button5.TabIndex = 36;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.Location = new System.Drawing.Point(314, 323);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 40);
            this.button4.TabIndex = 35;
            this.button4.Text = ">|";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Location = new System.Drawing.Point(113, 323);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 40);
            this.button3.TabIndex = 34;
            this.button3.Text = "|<";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Location = new System.Drawing.Point(180, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 40);
            this.button2.TabIndex = 33;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(247, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 40);
            this.button1.TabIndex = 32;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewCar
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
            this.Controls.Add(маркаLabel);
            this.Controls.Add(this.маркаTextBox);
            this.Controls.Add(модельLabel);
            this.Controls.Add(this.модельTextBox);
            this.Controls.Add(номерLabel);
            this.Controls.Add(this.номерTextBox);
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
            this.Name = "ViewCar";
            this.Text = "ViewCar";
            this.Load += new System.EventHandler(this.ViewCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.грузоперевозкиDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автоBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ГрузоперевозкиDataSet грузоперевозкиDataSet;
        private System.Windows.Forms.BindingSource автоBindingSource;
        private ГрузоперевозкиDataSetTableAdapters.АвтоTableAdapter автоTableAdapter;
        private ГрузоперевозкиDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox маркаTextBox;
        private System.Windows.Forms.TextBox модельTextBox;
        private System.Windows.Forms.TextBox номерTextBox;
        private System.Windows.Forms.TextBox максимальнаяСкоростьTextBox;
        private System.Windows.Forms.TextBox объемДвигателяTextBox;
        private System.Windows.Forms.TextBox среднийРасходТопливаTextBox;
        private System.Windows.Forms.TextBox цветTextBox;
        private System.Windows.Forms.TextBox видТопливаTextBox;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}