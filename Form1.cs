using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace ArduinoLED
{
    
    public partial class Form1 : Form
    {
        // Troque COM3 pela porta do seu Arduino.
        private readonly SerialPort porta =
            new SerialPort("COM3", 9600);

        public Form1()
        {
            InitializeComponent();

            porta.NewLine = "\n";

            btnLigar.Click += btnLigar_Click;
            btnDesligar.Click += btnDesligar_Click;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            try
            {
                porta.Open();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao abrir a porta: " + erro.Message);
            }
        }

     
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          //  EnviarComando("DESLIGAR");
        }
        private void EnviarComando(string comando)
        {
            try
            {
                if (porta.IsOpen)
                    porta.WriteLine(comando);
                else
                    MessageBox.Show("A porta serial está fechada.");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao enviar: " + erro.Message);
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            porta.Dispose();
            base.OnFormClosed(e);
        }

        private void btnLigar_Click(object sender, EventArgs e)
        {
            EnviarComando("ON");
        }

        private void btnDesligar_Click(object sender, EventArgs e)
        {
            EnviarComando("OFF");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}