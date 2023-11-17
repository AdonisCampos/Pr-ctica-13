using MailKit.Net.Smtp;
using MailKit;
using MimeKit;


namespace loginC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.RoyalBlue;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.RoyalBlue;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.ForeColor = Color.DimGray;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void pictureBoxCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxMinizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkRecuperar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Creamos la variable de nuestro email e inicializamos nuestro MimeMessage
            var mensaje = new MimeMessage();
            //Creamos la direccion del correo del emisor
            mensaje.From.Add(new MailboxAddress("Bernarod Adonis campos", "bernardoadonis@hotmail.com"));
            //Creamos la direccion del correo del receptor 
            mensaje.To.Add(new MailboxAddress("Emely Janel", "emelycampos@hotmail.com"));
            //Creamos el motivo de nuestro correo
            mensaje.Subject = "Recuperar contraseña de usuario";
            //Creamos el cuerpo de nuestro correo donde ira el contenido 
            mensaje.Body = new TextPart("plain")//TextPart
            {
                //Contenido
                Text = "Hola, este es el link para que puedas recuperar tu contraseña"
            };

            //Credenciales que nos permita la comunicacion entre MailTrap, y las libreria de MailKit Visual Studio

            //vamos ocupar el using MailKit.Net.Smtp
            using (var cliente = new SmtpClient())
            {
                //Creamos la conexion con los parametros como url y puerto
                cliente.Connect("sandbox.smtp.mailtrap.io", 2525);
                //Creamos la auntentificacion con nuestro usuario y contraseña de MailTrap
                cliente.Authenticate("cfc9a751780a2e", "cb1987d27218a6");

                //Instanciamos el mensaje que habiamos creado arriba

                cliente.Send(mensaje);

                //Desconectamos el servicio una vez iniciado el servicio, una vez enviado el mensaje

                cliente.Disconnect(true);

                MessageBox.Show("Tu correo ha sido enviado");
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //Instanciar el formulario nuevo
            VistaLogin2 vistaNueva = new VistaLogin2();
            //Indicarle el nuevo formulario de donde viene la instancia
            AddOwnedForm(vistaNueva);
            //Se accede la control deseado
            vistaNueva.Show();
            //Mininizamos la ventana anterior
            this.Hide();
        }


    }
}