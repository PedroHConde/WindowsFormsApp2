using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DateTimeSeries;
using MindFusion.Charting;
using MindFusion.Charting.Commands;
using MindFusion.Charting.WinForms;
using Brush = MindFusion.Drawing.Brush;
using Margins = MindFusion.Charting.Margins;
using Series = MindFusion.Charting.Series;
using SolidBrush = MindFusion.Drawing.SolidBrush;

namespace WindowsFormsApp2
{

    public partial class Form_Degrau : Form
    {
        public bool graf_liberado = false;
        Timer myTimer = new Timer();
        bool primeiraVez = true;
        MyDateTimeSeries series1, series2, series3, series4, series5, series6;
        public string dados;
        Form f1;
        public Form_Degrau(Form f)
        {
            this.f1 = f;
            InitializeComponent();



            series1 = new MyDateTimeSeries(DateTime.Now, DateTime.Now, DateTime.Now.AddMinutes(1));
            series1.DateTimeFormat = DateTimeFormat.CustomDateTime;
            series1.CustomDateTimeFormat = "mm:ss";

            series1.LabelInterval = 10;
            series1.MinValue = 0;
            series1.MaxValue = 120;
            series1.Title = "Referência";
            series1.SupportedLabels = LabelKinds.XAxisLabel;

            series2 = new MyDateTimeSeries(DateTime.Now, DateTime.Now, DateTime.Now.AddMinutes(1));
            series2.DateTimeFormat = DateTimeFormat.ShortTime;
            series2.LabelInterval = 10;
            series2.MinValue = 0;
            series2.MaxValue = 120;
            series2.Title = "Temperatura NTC";
            series2.SupportedLabels = LabelKinds.None;


            series3 = new MyDateTimeSeries(DateTime.Now, DateTime.Now, DateTime.Now.AddMinutes(1));
            series3.DateTimeFormat = DateTimeFormat.ShortTime;
            series3.LabelInterval = 10;
            series3.MinValue = 0;
            series3.MaxValue = 120;
            series3.Title = "Temperatura DS18B20";
            series3.SupportedLabels = LabelKinds.None;

            series4 = new MyDateTimeSeries(DateTime.Now, DateTime.Now, DateTime.Now.AddMinutes(1));
            series4.DateTimeFormat = DateTimeFormat.ShortTime;
            series4.LabelInterval = 10;
            series4.MinValue = 0;
            series4.MaxValue = 120;
            series4.Title = "Referência 1,02%";
            series4.SupportedLabels = LabelKinds.None;

            series5 = new MyDateTimeSeries(DateTime.Now, DateTime.Now, DateTime.Now.AddMinutes(1));
            series5.DateTimeFormat = DateTimeFormat.ShortTime;
            series5.LabelInterval = 10;
            series5.MinValue = 0;
            series5.MaxValue = 120;
            series5.Title = "Referência 0.98%";
            series5.SupportedLabels = LabelKinds.None;

            series6 = new MyDateTimeSeries(DateTime.Now, DateTime.Now, DateTime.Now.AddMinutes(1));
            series6.DateTimeFormat = DateTimeFormat.CustomDateTime;
            series6.CustomDateTimeFormat = "mm:ss";
            series6.LabelInterval = 10;
            series6.MinValue = 0;
            series6.MaxValue = 120;
            series6.Title = "Duty Cycle";
            series6.SupportedLabels = LabelKinds.XAxisLabel;


        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            string val = dados;
            // Taking a string
            String str1 = val.Trim();

            char[] spearator = { ',' };
            Int32 count = 2;

            // Using the Method
            String[] strlist = str1.Split(spearator,
                   count, StringSplitOptions.None);

            series1.addValue(double.Parse(strlist[0]));
            series2.addValue(double.Parse(strlist[1]));

            series3.addValue(double.Parse(strlist[2]));
            series4.addValue(1.02 * double.Parse(strlist[0]));

            series5.addValue(0.98 * double.Parse(strlist[0]));
            series6.addValue(double.Parse(strlist[3]));



            if (series1.Size > 1)
            {
                double currVal = series1.GetValue(series1.Size - 1, 0);

                if (currVal > lineChart.XAxis.MaxValue)
                {
                    double span = currVal - series1.GetValue(series1.Size - 2, 0);
                    lineChart.XAxis.MinValue += span;
                    lineChart.XAxis.MaxValue += span;

                }
                lineChart.ChartPanel.InvalidateLayout();
                lineChart1.ChartPanel.InvalidateLayout();

            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            (f1 as Form1).parar();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string valor1;
            string valor2;

            (f1 as Form1).iniciar("configD");

            if (this.trackBar3.Value < 100 && this.trackBar3.Value > 9)
            {
                valor1 = "0" + this.trackBar3.Value.ToString();
            }
            else if (this.trackBar3.Value < 10)
            {
                valor1 = "0" + "0" + this.trackBar3.Value.ToString();

            }
            else
            {
                valor1 = this.trackBar3.Value.ToString();
            }
            if (this.trackBar4.Value < 10)
            {
                valor2 = "0" + this.trackBar4.Value.ToString();
            }
            else
            {
                valor2 = this.trackBar4.Value.ToString();
            }

            string degraus = valor1 + "," + valor2;
            
            (f1 as Form1).iniciar(degraus);
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            this.textBox3.Text = this.trackBar3.Value.ToString();

        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            this.textBox4.Text = this.trackBar4.Value.ToString();
        }

        private void p2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            (f1 as Form1).iniciar("configD");
        }

        private void progressBar1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Iniciar_degrau_Click(object sender, EventArgs e)
        {
            if (primeiraVez)
            {
                (f1 as Form1).iniciar("degrau");
                primeiraVez = false;
                // setup chart
                lineChart.Series.Add(series1);
                lineChart.Series.Add(series2);
                lineChart.Series.Add(series3);
                lineChart.Series.Add(series4);
                lineChart.Series.Add(series5);


                //lineChart.Series.Add(series3);
                lineChart.Title = "Sistema de controle de Temperatura";
                lineChart.ShowXCoordinates = false;
                lineChart.ShowLegendTitle = false;
                lineChart.LayoutPanel.Margin = new Margins(0, 0, 20, 0);

                lineChart.XAxis.Title = "tempo (s)";
                lineChart.XAxis.MinValue = 0;
                lineChart.XAxis.MaxValue = 200;
                lineChart.XAxis.Interval = 5;

                lineChart.YAxis.MinValue = 15;
                lineChart.YAxis.MaxValue = 100;
                lineChart.YAxis.Interval = 5;
                lineChart.YAxis.Title = "Temperatura (ºC)";
                // setup chart
                lineChart1.Series.Add(series6);


                lineChart1.Title = "Ação de controle";
                lineChart1.ShowXCoordinates = false;
                lineChart1.ShowLegendTitle = false;
                lineChart1.LayoutPanel.Margin = new Margins(0, 0, 20, 0);

                lineChart1.XAxis.Title = "tempo (s)";
                lineChart1.XAxis.MinValue = 0;
                lineChart1.XAxis.MaxValue = 200;
                lineChart1.XAxis.Interval = 10;

                lineChart1.YAxis.MinValue = 0;
                lineChart1.YAxis.MaxValue = 100;
                lineChart1.YAxis.Interval = 10;
                lineChart1.YAxis.Title = "Duty Clycle (%)";

                List<Brush> brushes = new List<Brush>()
            {
                new SolidBrush(Color.Red),
                new SolidBrush(Color.Orange),
                new SolidBrush(Color.Green),
                new SolidBrush(Color.Blue),
               new SolidBrush(Color.Violet)

            };
                List<Brush> brushes1 = new List<Brush>()
            {
                new SolidBrush(Color.Black)
            };
                List<double> thicknesses = new List<double>() { 2 };

                PerSeriesStyle style = new PerSeriesStyle(brushes, brushes, thicknesses, null);
                lineChart.Plot.SeriesStyle = style;
                lineChart.Theme.PlotBackground = new SolidBrush(Color.White);
                lineChart.Theme.GridLineColor = Color.LightGray;
                lineChart.Theme.GridLineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                lineChart.TitleMargin = new Margins(10);
                lineChart.GridType = GridType.Horizontal;

                PerSeriesStyle style1 = new PerSeriesStyle(brushes1, brushes1, thicknesses, null);
                lineChart1.Plot.SeriesStyle = style1;
                lineChart1.Theme.PlotBackground = new SolidBrush(Color.White);
                lineChart1.Theme.GridLineColor = Color.LightGray;
                lineChart1.Theme.GridLineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                lineChart1.TitleMargin = new Margins(10);
                lineChart1.GridType = GridType.Horizontal;
                myTimer.Tick += new EventHandler(TimerEventProcessor);

                // Sets the timer interval to half a seconds.
                myTimer.Interval = 500;
                myTimer.Start();

            }
            else
            {
                (f1 as Form1).iniciar("degrau");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void TimerEventProcessor(Object myObject,
                                                EventArgs myEventArgs)
        {

            string val = dados;
            // Taking a string
            String str1 = val.Trim();

            char[] spearator = { ',' };
            Int32 count = 4;

            // Using the Method
            String[] strlist = str1.Split(spearator,
                   count, StringSplitOptions.None);

            series1.addValue(double.Parse(strlist[0]) / 100);
            series2.addValue(double.Parse(strlist[1]) / 100);

            series3.addValue(double.Parse(strlist[2]) / 100);
            series4.addValue(1.02 * double.Parse(strlist[0]) / 100);

            series5.addValue(0.98 * double.Parse(strlist[0]) / 100);
            series6.addValue(double.Parse(strlist[3]) / 100);
            if (((double.Parse(strlist[1]) / 100)) < ((double.Parse(strlist[0]) / 100) + 5))
            {
                lineChart.YAxis.MinValue = (double.Parse(strlist[2]) / 100) - 5;
                lineChart.YAxis.MaxValue = (double.Parse(strlist[0]) / 100) + 5;
                lineChart.YAxis.Interval = ((double.Parse(strlist[0]) / 100) + 5 - ((double.Parse(strlist[2]) / 100) - 5)) / 10;

            }

            this.l_ref.Text = (double.Parse(strlist[0]) / 100).ToString();
            this.l_ntc.Text = (double.Parse(strlist[1]) / 100).ToString();
            this.textBox1.Text = (double.Parse(strlist[2]) / 100).ToString();
            this.p1.Value = (int)Math.Round((double.Parse(strlist[0]) / 100.0));
            this.p2.Value = (int)Math.Round(double.Parse(strlist[1]) / 100.0);
            this.p3.Value = (int)Math.Round(double.Parse(strlist[2]) / 100.0);
            if (series1.Size > 1)
            {
                double currVal = series1.GetValue(series1.Size - 1, 0);

                if (currVal > lineChart.XAxis.MaxValue)
                {
                    double span = currVal - series1.GetValue(series1.Size - 2, 0);
                    lineChart.XAxis.MinValue += span;
                    lineChart.XAxis.MaxValue += span;
                    lineChart1.XAxis.MinValue += span;
                    lineChart1.XAxis.MaxValue += span;

                }
                lineChart.ChartPanel.InvalidateLayout();
                lineChart1.ChartPanel.InvalidateLayout();
            }

        }
    }

}

