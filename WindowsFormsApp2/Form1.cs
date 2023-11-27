using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Collections;
using System.Windows.Forms.DataVisualization.Charting;
using System.Reflection;
using System.Diagnostics;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public string str;
        string Comando = "";
        string vDC;
        int i = 0;
        Form degrau;
        public Form1()
        {

            InitializeComponent();
            str = " ";
            // Evento para receber dados pela porta de comunicação serial
            serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(serialPort1_DataReceived);
            // Lê nome das portas seriais disponíveis no computador
            foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(s);
            }
        }

        // Método para leitura de dados recebidos da porta serial
        void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            // Lê dados
            string data = serialPort1.ReadLine();
            // Escreve dados lidos no console
            Console.WriteLine(data);
            // Escreve dados lidos na TextBox
            this.BeginInvoke(new SetTextDeleg(serial_DataReceived), new object[] { data });

        }
        // Método para abrir ou fechar porta de comunicação serial
        //private void button1_Click(object sender, EventArgs e )  
        //{


        //}
        // Método para escrever (enviar) dados pela porta serial
        //private void button2_Click(object sender, EventArgs e)
        //{

        //}
        private delegate void SetTextDeleg(string text);
        // Método para escrever dados lidos na TextBox
        public void serial_DataReceived(string data)
        {

            if (Comando == "degrau")
            {

                (degrau as Form_Degrau).dados = data.Trim();
                // Add series.


                //(degrau as Form_Degrau).chart_degrau.Update();
                this.textBox1.Text = data.Trim();

            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.PortName = comboBox1.Text;
                serialPort1.Open();
                serialPort1.BaudRate = 500000;
                button1.Text = "Stop";
            }
            else
            {
                serialPort1.Close();
                button1.Text = "Start";
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            serialPort1.WriteLine("zero");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            degrau = new Form_Degrau(this);
            degrau.Show();
            Comando = "degrau";


        }
        public void parar()
        {
            serialPort1.WriteLine("zero");
        }
        public void iniciar(string Comando)
        {
            serialPort1.WriteLine(Comando);
        }

    }
}