using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentador;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form, IVistaOperaciones
    {
        private readonly PresentadorOperaciones _operaciones;
        public Form1()
        {
            InitializeComponent();
            _operaciones = new PresentadorOperaciones(this);

        }

        public double n1
        {
            get
            {
                return !String.IsNullOrEmpty(textBox1.Text) ? Convert.ToDouble(textBox1.Text) : 0;
            }

            set
            {
                textBox1.Text = value.ToString();
            }
        }

        public double n2
        {
            get
            {
                return !string.IsNullOrEmpty(textBox2.Text) ? Convert.ToDouble(textBox2.Text) : 0;

            }

            set
            {
                textBox2.Text = value.ToString();
            }
        }

        public double resultado
        {
            set
            {
                label3.Text = value.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _operaciones.IniciarVista();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _operaciones.ActualizarVista();
        }
    }
}
