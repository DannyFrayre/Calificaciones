using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Practica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (ServiceReference1.Service2Client cliente = new ServiceReference1.Service2Client())
            { 
                cliente.guardar(tbAlumno.Text, Int32.Parse(tb1.Text),Int32.Parse(tb2.Text), Int32.Parse(tb3.Text),Int32.Parse(tb4.Text),Int32.Parse(tb5.Text));
            }
            tbAlumno.Text = "";
            tb1.Text = "";
            tb2.Text = "";
            tb3.Text = "";
            tb4.Text = "";
            tb5.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string[] vector = new string[5];
            using (ServiceReference1.Service2Client cliente = new ServiceReference1.Service2Client())
            {
                try
                {
                    vector = cliente.buscar(tbAlumno.Text);
                    tb1.Text = vector[1];
                    tb2.Text = vector[2];
                    tb3.Text = vector[3];
                    tb4.Text = vector[4];
                    tb5.Text = vector[5];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Alumno no encontrado");
                }
            }
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            using (ServiceReference1.Service2Client cliente = new ServiceReference1.Service2Client())
            {
                tbPromedio.Text = cliente.promedio(Int32.Parse(tb1.Text), Int32.Parse(tb2.Text), Int32.Parse(tb3.Text), Int32.Parse(tb4.Text), Int32.Parse(tb5.Text)).ToString();
            }
        }
    }
}
 