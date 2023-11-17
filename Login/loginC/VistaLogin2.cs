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
    }
}
