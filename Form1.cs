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
            contadorTempo = new DateTime(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            contadorTempo = contadorTempo.Add(new TimeSpan(0, 0, 1));
            toolStripStatusLabelHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabelContador_Click(object sender, EventArgs e)
        { 
        }
            private DateTime contadorTempo;
        }
    }