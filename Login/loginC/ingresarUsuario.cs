using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginC
{
    public partial class ingresarUsuario : Form
    {
        public ingresarUsuario()
        {
            InitializeComponent();
        }

        private void btnRegistra_Click(object sender, EventArgs e)
        {
            //Usar un bloque using para asegurar la liberacion de recursos
            using (SqlConnection conexion = new SqlConnection("Data Source=BERNARDOCAMPOS\\SERVIDORSQL;Initial Catalog=Usuarios;Integrated Security=True;"))
            {
                try
                {
                    conexion.Open();

                    //Utilizar parametros para prevenir la inyeccion SQL 
                    string consulta = "INSERT INTO Credenciales (usuario,clave)VALUES (@usuario, @clave)";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        //Agregar parametros con valores seguros
                        comando.Parameters.AddWithValue("@usuario", txtUsuarioCrearNuevo.Text);
                        comando.Parameters.AddWithValue("@clave", txtPassCrearNuevoUsuario.Text);

                        //Ejecutar la consulta
                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            //Registro exitoso
                            MessageBox.Show("Usuario creado exitosamente");

                            //Instanciar el formulario nuevo

                            Form1 vistaInicio = new Form1();

                            //Mostrar el nuevo formulario
                            vistaInicio.Show();

                            //Minimizar la ventana actual
                            this.Hide();
                        }
                        else
                        {
                            //No se insertaron filas, usuario no creado
                            MessageBox.Show("Usuario no creado");

                        }
                    }
                }
                catch (Exception ex)
                {
                    //Manejar cualquier excepcion que pueda ocurrir durante la ejecucion
                    MessageBox.Show("Error al registrar usuario: " + ex.Message);
                }
            }
        }

        private void txtUsuarioCrearNuevo_Enter(object sender, EventArgs e)
        {
            if (txtUsuarioCrearNuevo.Text == "USUARIO")
            {
                txtUsuarioCrearNuevo.Text = "";
                txtUsuarioCrearNuevo.ForeColor = Color.RoyalBlue;
            }
        }

        private void txtUsuarioCrearNuevo_Leave(object sender, EventArgs e)
        {
            if (txtUsuarioCrearNuevo.Text == "")
            {
                txtUsuarioCrearNuevo.Text = "USUARIO";
                txtUsuarioCrearNuevo.ForeColor = Color.DimGray;
            }
        }

        private void txtPassCrearNuevoUsuario_Enter(object sender, EventArgs e)
        {
            if (txtPassCrearNuevoUsuario.Text == "CONTRASEÑA")
            {
                txtPassCrearNuevoUsuario.Text = "";
                txtPassCrearNuevoUsuario.ForeColor = Color.RoyalBlue;
                txtPassCrearNuevoUsuario.UseSystemPasswordChar = true;
            }
        }

        private void txtPassCrearNuevoUsuario_Leave(object sender, EventArgs e)
        {

            if (txtPassCrearNuevoUsuario.Text == "")
            {
                txtPassCrearNuevoUsuario.Text = "CONTRASEÑA";
                txtPassCrearNuevoUsuario.ForeColor = Color.DimGray;
                txtPassCrearNuevoUsuario.UseSystemPasswordChar = false;
            }
        }

        private void checkBoxVerContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxVerContraseña.Checked == true)
            {
                txtPassCrearNuevoUsuario.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassCrearNuevoUsuario.UseSystemPasswordChar = true;
            }
        }

        private void pictureBoxAtrasCrearUsuario_Click(object sender, EventArgs e)
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

        private void pictureBoxCerrarVistaCrearUsuario_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
