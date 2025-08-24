using Guia2._2Ejercicio2.Models;
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
    public partial class FormPrincipal : Form
    {
        Concesionaria c;
        Embarque nuevo;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            FormDatoInicio fDato = new FormDatoInicio();
            if (fDato.ShowDialog() == DialogResult.OK)
            {
                int añoActual = Convert.ToInt32(fDato.tbAñoActual.Text);
                c = new Concesionaria(añoActual);

            
            }
            else
            {
                Close();
            }
            fDato.Dispose();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDatosEmbarque fDatos = new FormDatosEmbarque();

            fDatos.ShowDialog();

            while (fDatos.DialogResult != DialogResult.OK && fDatos.DialogResult != DialogResult.Cancel)
            {
                //similar a la lógica del menu de consola, voy viend que botón accionó

                if (fDatos.DialogResult == DialogResult.Yes)
                {
                    #region alta embarque
                    int numeroEmbarque = Convert.ToInt32(fDatos.tbNroEmbarque.Text);
                    nuevo = new Embarque(numeroEmbarque,
                                          c.PorcentajeDepreciacion,
                                          c.AñoActual);
                    #endregion
                }
                else if (fDatos.DialogResult == DialogResult.Retry)
                {
                    #region descarga de las motos del embarque
                    int añoFabricacion = Convert.ToInt32(fDatos.tbAñoFabricacion.Text);
                    double montoFabricacion = Convert.ToDouble(fDatos.tbMontoFabricacion.Text);

                    nuevo.RegistrarMoto(añoFabricacion, montoFabricacion);

                    fDatos.tbAñoFabricacion.Clear();
                    fDatos.tbMontoFabricacion.Clear();
                    #endregion
                }

                fDatos.ShowDialog();
            }

            #region completando el registro
            if (fDatos.DialogResult == DialogResult.OK)
            {
                c.IngresarEmbarque(nuevo);

                MessageBox.Show("Embarque ingresado!.");
            }
            else
            {
                MessageBox.Show("Proceso de ingreso del embarque cancelado.");
            }
            #endregion
        }
        

        private void btnRecaudacion_Click(object sender, EventArgs e)
        {
            ltbInforme.Items.Clear();
            ltbInforme.Items.Add("\t\t Informe de resultados");
            ltbInforme.Items.Add("");
            ltbInforme.Items.Add(string.Format("Monto de todos los embarques : ${0:f2}", c.ImporteEnEmbarques));
            ltbInforme.Items.Add(string.Format("Cantidad de embarques: {0}", c.CantidadEmbarques));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ltbInforme.Items.Clear();

            Embarque emb = c.MayorCantidadMotos;

            #region actualización listbox
            ltbInforme.Items.Add("\t\tEmbarque con mayor cantidad de motos\n");
            if (emb != null)
            {
                ltbInforme.Items.Add($"Numero de embarque: {emb.Numero}");
                ltbInforme.Items.Add($"Promedio de costo por moto: $ {emb.PromedioCosto:f2}");
                ltbInforme.Items.Add($"Monto Total del embarque: $ {emb.MontoTotal}");
            }
            else
            {
                ltbInforme.Items.Add($"No se han registrado embarques.");
            }
            ;
            #endregion
        }

        private void btnEmbarquePorNumero_Click(object sender, EventArgs e)
        {
            int numeroEmbarque = Convert.ToInt32(tbNumeroEmbBusq.Text);

            Embarque buscado = c.VerEmbarquePorNumero(numeroEmbarque);

            #region actualización listbox
            ltbInforme.Items.Clear();
            ltbInforme.Items.Add($"{"Numero",10} {"Cant. de Motos",-20} {"MontoTotal",20}");
            ltbInforme.Items.Add("------------------------------------------------------------");
            if (buscado != null)
            {
                ltbInforme.Items.Add($"{buscado.Numero,10}{buscado.CantidadMotos,20}{buscado.MontoTotal,20:f2}");
            }
            else
            {
                ltbInforme.Items.Add($"No existe el embarque con  número: {numeroEmbarque}");
            }
            #endregion
        }

        private void btnListadoEmbarques_Click(object sender, EventArgs e)
        {
            int numeroEmbarque = Convert.ToInt32(tbNumeroEmbBusq.Text);

            Embarque buscado = c.VerEmbarquePorNumero(numeroEmbarque);

            #region actualización listbox
            ltbInforme.Items.Clear();
            ltbInforme.Items.Add($"{"Numero",10} {"Cant. de Motos",-20} {"MontoTotal",20}");
            ltbInforme.Items.Add("------------------------------------------------------------");
            if (buscado != null)
            {
                ltbInforme.Items.Add($"{buscado.Numero,10}{buscado.CantidadMotos,20}{buscado.MontoTotal,20:f2}");
            }
            else
            {
                ltbInforme.Items.Add($"No existe el embarque con  número: {numeroEmbarque}");
            }
            #endregion


        }

        private void ltbInforme_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
