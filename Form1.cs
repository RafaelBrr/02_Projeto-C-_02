using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace ArduinoLED
{
    
    public partial class Form1 : Form
    {
        // Troque COM3 pela porta do seu Arduino.
        private readonly SerialPort porta =
            new SerialPort("COM11", 9600);

        public Form1()
        {
            InitializeComponent();

            porta.NewLine = "\n";

            btnGreenLigar.Click += btnGreenLigar_Click;
            btnGreenDesligar.Click += btnGreenDesligar_Click;
            btnRedLigar.Click += btnRedLigar_Click;
            btnRedDesligar.Click += btnRedDesligar_Click;
            btnBlueLigar.Click += btnBlueLigar_Click;
            btnBlueDesligar.Click += btnBlueDesligar_Click;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGreenLigar_Click(object sender, EventArgs e)
        {
            EnviarComando("A");
        }

        private void btnGreenDesligar_Click(object sender, EventArgs e)
        {
            EnviarComando("B");
        }

        private void btnRedLigar_Click(object sender, EventArgs e)
        {
            EnviarComando("C");
        }

        private void btnRedDesligar_Click(object sender, EventArgs e)
        {
            EnviarComando("D");
        }

        private void btnBlueLigar_Click(object sender, EventArgs e)
        {
            EnviarComando("E");
        }

        private void btnBlueDesligar_Click(object sender, EventArgs e)
        {
            EnviarComando("F");
        }
    }
}