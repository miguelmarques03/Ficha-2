using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DateTime contadorTempo = new DateTime(0);

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var hora = new DateTime();
            hora = DateTime.Now;
            toolStripStatusLabelHora.Text = hora.ToLongTimeString();
            toolStripStatusLabelContador.Text = contadorTempo.ToLongTimeString();
            contadorTempo = contadorTempo.AddSeconds(1);
        }

        private void toolStripStatusLabelContador_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Ativado")
            {
                button1.Text = "Parado";
                timer1.Stop();
            }
            else if (button1.Text == "Parado")
            {
                button1.Text = "Ativado";
                timer1.Start();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            contadorTempo = resetTime();
            toolStripStatusLabelContador.Text = contadorTempo.ToLongTimeString();

        }

        DateTime resetTime()
        {
            return new DateTime(0);
        }
    }
}