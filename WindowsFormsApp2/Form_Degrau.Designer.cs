namespace WindowsFormsApp2
{
    partial class Form_Degrau
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
            this.label1 = new System.Windows.Forms.Label();
            this.Iniciar_degrau = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lineChart = new MindFusion.Charting.WinForms.LineChart();
            this.lineChart1 = new MindFusion.Charting.WinForms.LineChart();
            this.button1 = new System.Windows.Forms.Button();
            this.p1 = new System.Windows.Forms.ProgressBar();
            this.l_ref = new System.Windows.Forms.TextBox();
            this.l_ntc = new System.Windows.Forms.TextBox();
            this.p2 = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.p3 = new System.Windows.Forms.ProgressBar();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entrada em degrau";
            // 
            // Iniciar_degrau
            // 
            this.Iniciar_degrau.Location = new System.Drawing.Point(49, 288);
            this.Iniciar_degrau.Name = "Iniciar_degrau";
            this.Iniciar_degrau.Size = new System.Drawing.Size(164, 23);
            this.Iniciar_degrau.TabIndex = 2;
            this.Iniciar_degrau.Text = "Iniciar";
            this.Iniciar_degrau.UseVisualStyleBackColor = true;
            this.Iniciar_degrau.Click += new System.EventHandler(this.Iniciar_degrau_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Escolha o número de degraus";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Escolha a duração do degrau ";
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(34, 98);
            this.trackBar3.Maximum = 200;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(198, 45);
            this.trackBar3.TabIndex = 9;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // trackBar4
            // 
            this.trackBar4.Location = new System.Drawing.Point(34, 172);
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(198, 45);
            this.trackBar4.TabIndex = 11;
            this.trackBar4.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(188, 69);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(38, 20);
            this.textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(188, 149);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(38, 20);
            this.textBox4.TabIndex = 15;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            // 
            // lineChart
            // 
            this.lineChart.LegendHorizontalAlignment = MindFusion.Charting.Components.LayoutAlignment.Far;
            this.lineChart.LegendTitle = "Legend";
            this.lineChart.Location = new System.Drawing.Point(256, 51);
            this.lineChart.Name = "lineChart";
            this.lineChart.Padding = new System.Windows.Forms.Padding(5);
            this.lineChart.ShowLegend = true;
            this.lineChart.Size = new System.Drawing.Size(1133, 512);
            this.lineChart.SubtitleFontName = null;
            this.lineChart.SubtitleFontSize = null;
            this.lineChart.SubtitleFontStyle = null;
            this.lineChart.TabIndex = 16;
            this.lineChart.Text = "lineChart";
            this.lineChart.Theme.UniformSeriesFill = new MindFusion.Drawing.SolidBrush("#FF90EE90");
            this.lineChart.Theme.UniformSeriesStroke = new MindFusion.Drawing.SolidBrush("#FF000000");
            this.lineChart.Theme.UniformSeriesStrokeThickness = 2D;
            this.lineChart.TitleFontName = null;
            this.lineChart.TitleFontSize = null;
            this.lineChart.TitleFontStyle = null;
            // 
            // lineChart1
            // 
            this.lineChart1.LegendTitle = "Legend";
            this.lineChart1.Location = new System.Drawing.Point(256, 548);
            this.lineChart1.Name = "lineChart1";
            this.lineChart1.Padding = new System.Windows.Forms.Padding(5);
            this.lineChart1.ShowLegend = true;
            this.lineChart1.Size = new System.Drawing.Size(1133, 256);
            this.lineChart1.SubtitleFontName = null;
            this.lineChart1.SubtitleFontSize = null;
            this.lineChart1.SubtitleFontStyle = null;
            this.lineChart1.TabIndex = 17;
            this.lineChart1.Text = "lineChart1";
            this.lineChart1.Theme.UniformSeriesFill = new MindFusion.Drawing.SolidBrush("#FF90EE90");
            this.lineChart1.Theme.UniformSeriesStroke = new MindFusion.Drawing.SolidBrush("#FF000000");
            this.lineChart1.Theme.UniformSeriesStrokeThickness = 2D;
            this.lineChart1.TitleFontName = null;
            this.lineChart1.TitleFontSize = null;
            this.lineChart1.TitleFontStyle = null;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Parar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // p1
            // 
            this.p1.ForeColor = System.Drawing.Color.Crimson;
            this.p1.Location = new System.Drawing.Point(37, 393);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(136, 23);
            this.p1.TabIndex = 19;
            this.p1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // l_ref
            // 
            this.l_ref.Location = new System.Drawing.Point(179, 396);
            this.l_ref.Name = "l_ref";
            this.l_ref.Size = new System.Drawing.Size(53, 20);
            this.l_ref.TabIndex = 20;
            // 
            // l_ntc
            // 
            this.l_ntc.Location = new System.Drawing.Point(179, 445);
            this.l_ntc.Name = "l_ntc";
            this.l_ntc.Size = new System.Drawing.Size(53, 20);
            this.l_ntc.TabIndex = 22;
            // 
            // p2
            // 
            this.p2.ForeColor = System.Drawing.Color.DarkOrange;
            this.p2.Location = new System.Drawing.Point(37, 442);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(136, 23);
            this.p2.TabIndex = 21;
            this.p2.Click += new System.EventHandler(this.p2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Referência";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 426);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Temperatura NTC";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(130, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Temperatura DC256";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(179, 493);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(53, 20);
            this.textBox1.TabIndex = 27;
            // 
            // p3
            // 
            this.p3.ForeColor = System.Drawing.Color.DarkOrange;
            this.p3.Location = new System.Drawing.Point(37, 490);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(136, 23);
            this.p3.TabIndex = 26;
            this.p3.Click += new System.EventHandler(this.progressBar1_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(41, 211);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 23);
            this.button3.TabIndex = 29;
            this.button3.Text = "Configuração";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form_Degrau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1507, 816);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.l_ntc);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.l_ref);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lineChart1);
            this.Controls.Add(this.lineChart);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.trackBar4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Iniciar_degrau);
            this.Controls.Add(this.label1);
            this.Name = "Form_Degrau";
            this.Text = "Form_Degrau";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Iniciar_degrau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private MindFusion.Charting.WinForms.LineChart lineChart;
        private MindFusion.Charting.WinForms.LineChart lineChart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar p1;
        private System.Windows.Forms.TextBox l_ref;
        private System.Windows.Forms.TextBox l_ntc;
        private System.Windows.Forms.ProgressBar p2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar p3;
        private System.Windows.Forms.Button button3;
    }
}