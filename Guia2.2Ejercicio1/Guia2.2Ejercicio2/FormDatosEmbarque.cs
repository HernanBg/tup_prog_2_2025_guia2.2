using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia2._2Ejercicio2
{
    public partial class FormDatosEmbarque : Form
    {


        public FormDatosEmbarque()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            btnIngresarVehiculo.Enabled = true;
            gbAltaEmbarque.Enabled = false;
            btnAceptar.Enabled = true;
        }

        private void FormDatosEmbarque_Load(object sender, EventArgs e)
        {

        }
    }
}
