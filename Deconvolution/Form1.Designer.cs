
namespace Deconvolution
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox_ImpSigma = new System.Windows.Forms.TextBox();
            this.textBox_ImpA = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox_t03 = new System.Windows.Forms.TextBox();
            this.textBox_Sigma3 = new System.Windows.Forms.TextBox();
            this.textBox_A3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_t02 = new System.Windows.Forms.TextBox();
            this.textBox_Sigma2 = new System.Windows.Forms.TextBox();
            this.textBox_A2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_t01 = new System.Windows.Forms.TextBox();
            this.textBox_Sigma1 = new System.Windows.Forms.TextBox();
            this.textBox_A1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(13, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 457);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры сигнала";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Controls.Add(this.textBox_ImpSigma);
            this.groupBox5.Controls.Add(this.textBox_ImpA);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Location = new System.Drawing.Point(7, 338);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(187, 113);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Импульсная характеристика";
            // 
            // textBox_ImpSigma
            // 
            this.textBox_ImpSigma.Location = new System.Drawing.Point(81, 53);
            this.textBox_ImpSigma.Name = "textBox_ImpSigma";
            this.textBox_ImpSigma.Size = new System.Drawing.Size(100, 20);
            this.textBox_ImpSigma.TabIndex = 5;
            this.textBox_ImpSigma.Text = "3";
            // 
            // textBox_ImpA
            // 
            this.textBox_ImpA.Location = new System.Drawing.Point(81, 22);
            this.textBox_ImpA.Name = "textBox_ImpA";
            this.textBox_ImpA.Size = new System.Drawing.Size(100, 20);
            this.textBox_ImpA.TabIndex = 4;
            this.textBox_ImpA.Text = "1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "σ=";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "A=";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox_t03);
            this.groupBox4.Controls.Add(this.textBox_Sigma3);
            this.groupBox4.Controls.Add(this.textBox_A3);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(7, 232);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(187, 100);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Купол №3";
            // 
            // textBox_t03
            // 
            this.textBox_t03.Location = new System.Drawing.Point(81, 70);
            this.textBox_t03.Name = "textBox_t03";
            this.textBox_t03.Size = new System.Drawing.Size(100, 20);
            this.textBox_t03.TabIndex = 3;
            this.textBox_t03.Text = "40";
            // 
            // textBox_Sigma3
            // 
            this.textBox_Sigma3.Location = new System.Drawing.Point(81, 44);
            this.textBox_Sigma3.Name = "textBox_Sigma3";
            this.textBox_Sigma3.Size = new System.Drawing.Size(100, 20);
            this.textBox_Sigma3.TabIndex = 3;
            this.textBox_Sigma3.Text = "5";
            // 
            // textBox_A3
            // 
            this.textBox_A3.Location = new System.Drawing.Point(81, 18);
            this.textBox_A3.Name = "textBox_A3";
            this.textBox_A3.Size = new System.Drawing.Size(100, 20);
            this.textBox_A3.TabIndex = 3;
            this.textBox_A3.Text = "3,5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "t0=";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "A=";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "σ=";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_t02);
            this.groupBox3.Controls.Add(this.textBox_Sigma2);
            this.groupBox3.Controls.Add(this.textBox_A2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(7, 126);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(187, 100);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Купол №2";
            // 
            // textBox_t02
            // 
            this.textBox_t02.Location = new System.Drawing.Point(81, 70);
            this.textBox_t02.Name = "textBox_t02";
            this.textBox_t02.Size = new System.Drawing.Size(100, 20);
            this.textBox_t02.TabIndex = 5;
            this.textBox_t02.Text = "30";
            // 
            // textBox_Sigma2
            // 
            this.textBox_Sigma2.Location = new System.Drawing.Point(81, 44);
            this.textBox_Sigma2.Name = "textBox_Sigma2";
            this.textBox_Sigma2.Size = new System.Drawing.Size(100, 20);
            this.textBox_Sigma2.TabIndex = 5;
            this.textBox_Sigma2.Text = "3";
            // 
            // textBox_A2
            // 
            this.textBox_A2.Location = new System.Drawing.Point(81, 18);
            this.textBox_A2.Name = "textBox_A2";
            this.textBox_A2.Size = new System.Drawing.Size(100, 20);
            this.textBox_A2.TabIndex = 5;
            this.textBox_A2.Text = "2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "t0=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "σ=";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "A=";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_t01);
            this.groupBox2.Controls.Add(this.textBox_Sigma1);
            this.groupBox2.Controls.Add(this.textBox_A1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(7, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Купол №1";
            // 
            // textBox_t01
            // 
            this.textBox_t01.Location = new System.Drawing.Point(81, 72);
            this.textBox_t01.Name = "textBox_t01";
            this.textBox_t01.Size = new System.Drawing.Size(100, 20);
            this.textBox_t01.TabIndex = 2;
            this.textBox_t01.Text = "8";
            // 
            // textBox_Sigma1
            // 
            this.textBox_Sigma1.Location = new System.Drawing.Point(81, 46);
            this.textBox_Sigma1.Name = "textBox_Sigma1";
            this.textBox_Sigma1.Size = new System.Drawing.Size(100, 20);
            this.textBox_Sigma1.TabIndex = 2;
            this.textBox_Sigma1.Text = "4";
            // 
            // textBox_A1
            // 
            this.textBox_A1.Location = new System.Drawing.Point(81, 20);
            this.textBox_A1.Name = "textBox_A1";
            this.textBox_A1.Size = new System.Drawing.Size(100, 20);
            this.textBox_A1.TabIndex = 2;
            this.textBox_A1.Text = "4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "t0=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "σ=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "A=";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сгенерировать сигнал";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(220, 13);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Series2";
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(778, 300);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(220, 319);
            this.chart2.Name = "chart2";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart2.Series.Add(series6);
            this.chart2.Size = new System.Drawing.Size(778, 300);
            this.chart2.TabIndex = 3;
            this.chart2.Text = "chart2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "3";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "мю=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 938);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox_t03;
        private System.Windows.Forms.TextBox textBox_Sigma3;
        private System.Windows.Forms.TextBox textBox_A3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_t02;
        private System.Windows.Forms.TextBox textBox_Sigma2;
        private System.Windows.Forms.TextBox textBox_A2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_t01;
        private System.Windows.Forms.TextBox textBox_Sigma1;
        private System.Windows.Forms.TextBox textBox_A1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox_ImpSigma;
        private System.Windows.Forms.TextBox textBox_ImpA;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
    }
}

