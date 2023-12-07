using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginC
{
    public partial class VistaLogin2 : Form
    {
        public VistaLogin2()
        {
            InitializeComponent();
        }

        private void pictureBoxCerrarVista_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxAtras_Click(object sender, EventArgs e)
        {
            //Instanciar el formulario nuevo
            Form1 vistaAnterior = new Form1();
            //Indicarle al nuevo formulario de donde viene su instancia
            AddOwnedForm(vistaAnterior);
            //Se accede al control deseado 
            vistaAnterior.Show();
            //Mininizamos la ventana anterior
            this.Hide();
        }
    }
}
