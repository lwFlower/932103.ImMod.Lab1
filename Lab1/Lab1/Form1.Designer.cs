namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.panel1 = new System.Windows.Forms.Panel();
            this.eddt = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.edWeight = new System.Windows.Forms.NumericUpDown();
            this.edSize = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btLaunch = new System.Windows.Forms.Button();
            this.edSpeed = new System.Windows.Forms.NumericUpDown();
            this.edAngle = new System.Windows.Forms.NumericUpDown();
            this.edHeight = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbSpeed = new System.Windows.Forms.TextBox();
            this.tbMaxh = new System.Windows.Forms.TextBox();
            this.tbDis = new System.Windows.Forms.TextBox();
            this.tbStep = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eddt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.eddt);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.edWeight);
            this.panel1.Controls.Add(this.edSize);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btLaunch);
            this.panel1.Controls.Add(this.edSpeed);
            this.panel1.Controls.Add(this.edAngle);
            this.panel1.Controls.Add(this.edHeight);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1299, 100);
            this.panel1.TabIndex = 0;
            // 
            // eddt
            // 
            this.eddt.DecimalPlaces = 4;
            this.eddt.Location = new System.Drawing.Point(464, 71);
            this.eddt.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.eddt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.eddt.Name = "eddt";
            this.eddt.Size = new System.Drawing.Size(120, 22);
            this.eddt.TabIndex = 14;
            this.eddt.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(396, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Шаг";
            // 
            // edWeight
            // 
            this.edWeight.Location = new System.Drawing.Point(464, 40);
            this.edWeight.Name = "edWeight";
            this.edWeight.Size = new System.Drawing.Size(120, 22);
            this.edWeight.TabIndex = 12;
            this.edWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // edSize
            // 
            this.edSize.Location = new System.Drawing.Point(464, 7);
            this.edSize.Name = "edSize";
            this.edSize.Size = new System.Drawing.Size(120, 22);
            this.edSize.TabIndex = 11;
            this.edSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(397, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Вес";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Размер";
            // 
            // btLaunch
            // 
            this.btLaunch.Location = new System.Drawing.Point(725, 18);
            this.btLaunch.Name = "btLaunch";
            this.btLaunch.Size = new System.Drawing.Size(122, 54);
            this.btLaunch.TabIndex = 8;
            this.btLaunch.Text = "Запуск";
            this.btLaunch.UseVisualStyleBackColor = true;
            this.btLaunch.Click += new System.EventHandler(this.btLaunch_Click);
            // 
            // edSpeed
            // 
            this.edSpeed.Location = new System.Drawing.Point(118, 71);
            this.edSpeed.Name = "edSpeed";
            this.edSpeed.Size = new System.Drawing.Size(120, 22);
            this.edSpeed.TabIndex = 5;
            this.edSpeed.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // edAngle
            // 
            this.edAngle.Location = new System.Drawing.Point(118, 40);
            this.edAngle.Name = "edAngle";
            this.edAngle.Size = new System.Drawing.Size(120, 22);
            this.edAngle.TabIndex = 4;
            this.edAngle.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // edHeight
            // 
            this.edHeight.Location = new System.Drawing.Point(118, 7);
            this.edHeight.Name = "edHeight";
            this.edHeight.Size = new System.Drawing.Size(120, 22);
            this.edHeight.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Скорость";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Угол";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Высота";
            // 
            // chart1
            // 
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Maximum = 3D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(4, 103);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(968, 503);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbSpeed);
            this.panel2.Controls.Add(this.tbMaxh);
            this.panel2.Controls.Add(this.tbDis);
            this.panel2.Controls.Add(this.tbStep);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(978, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 500);
            this.panel2.TabIndex = 2;
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(179, 121);
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(117, 22);
            this.tbSpeed.TabIndex = 7;
            // 
            // tbMaxh
            // 
            this.tbMaxh.Location = new System.Drawing.Point(179, 85);
            this.tbMaxh.Name = "tbMaxh";
            this.tbMaxh.Size = new System.Drawing.Size(117, 22);
            this.tbMaxh.TabIndex = 6;
            // 
            // tbDis
            // 
            this.tbDis.Location = new System.Drawing.Point(179, 49);
            this.tbDis.Name = "tbDis";
            this.tbDis.Size = new System.Drawing.Size(117, 22);
            this.tbDis.TabIndex = 5;
            // 
            // tbStep
            // 
            this.tbStep.Location = new System.Drawing.Point(179, 17);
            this.tbStep.Name = "tbStep";
            this.tbStep.Size = new System.Drawing.Size(117, 22);
            this.tbStep.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "Скорость (в конце)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Макс. высота";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Дальность";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Шаг";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1299, 639);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eddt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown edSpeed;
        private System.Windows.Forms.NumericUpDown edAngle;
        private System.Windows.Forms.NumericUpDown edHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btLaunch;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown edWeight;
        private System.Windows.Forms.NumericUpDown edSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown eddt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbSpeed;
        private System.Windows.Forms.TextBox tbMaxh;
        private System.Windows.Forms.TextBox tbDis;
        private System.Windows.Forms.TextBox tbStep;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

