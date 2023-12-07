namespace loginC
{
    partial class ingresarUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ingresarUsuario));
            pictureBoxAtrasCrearUsuario = new PictureBox();
            pictureBoxCerrarVistaCrearUsuario = new PictureBox();
            TituloLabelCrearUsuario = new Label();
            btnRegistra = new Button();
            txtPassCrearNuevoUsuario = new TextBox();
            txtUsuarioCrearNuevo = new TextBox();
            checkBoxVerContraseña = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAtrasCrearUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCerrarVistaCrearUsuario).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAtrasCrearUsuario
            // 
            pictureBoxAtrasCrearUsuario.BackgroundImageLayout = ImageLayout.None;
            pictureBoxAtrasCrearUsuario.Image = (Image)resources.GetObject("pictureBoxAtrasCrearUsuario.Image");
            pictureBoxAtrasCrearUsuario.Location = new Point(694, 12);
            pictureBoxAtrasCrearUsuario.Name = "pictureBoxAtrasCrearUsuario";
            pictureBoxAtrasCrearUsuario.Size = new Size(45, 42);
            pictureBoxAtrasCrearUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAtrasCrearUsuario.TabIndex = 4;
            pictureBoxAtrasCrearUsuario.TabStop = false;
            pictureBoxAtrasCrearUsuario.Click += pictureBoxAtrasCrearUsuario_Click;
            // 
            // pictureBoxCerrarVistaCrearUsuario
            // 
            pictureBoxCerrarVistaCrearUsuario.BackgroundImageLayout = ImageLayout.None;
            pictureBoxCerrarVistaCrearUsuario.Image = (Image)resources.GetObject("pictureBoxCerrarVistaCrearUsuario.Image");
            pictureBoxCerrarVistaCrearUsuario.Location = new Point(743, 12);
            pictureBoxCerrarVistaCrearUsuario.Name = "pictureBoxCerrarVistaCrearUsuario";
            pictureBoxCerrarVistaCrearUsuario.Size = new Size(45, 42);
            pictureBoxCerrarVistaCrearUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCerrarVistaCrearUsuario.TabIndex = 3;
            pictureBoxCerrarVistaCrearUsuario.TabStop = false;
            pictureBoxCerrarVistaCrearUsuario.Click += pictureBoxCerrarVistaCrearUsuario_Click;
            // 
            // TituloLabelCrearUsuario
            // 
            TituloLabelCrearUsuario.AutoSize = true;
            TituloLabelCrearUsuario.BackColor = Color.Transparent;
            TituloLabelCrearUsuario.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            TituloLabelCrearUsuario.ForeColor = Color.White;
            TituloLabelCrearUsuario.Location = new Point(82, 89);
            TituloLabelCrearUsuario.Name = "TituloLabelCrearUsuario";
            TituloLabelCrearUsuario.Size = new Size(672, 65);
            TituloLabelCrearUsuario.TabIndex = 5;
            TituloLabelCrearUsuario.Text = "CREAR UN NUEVO USUARIO";
            // 
            // btnRegistra
            // 
            btnRegistra.BackColor = Color.FromArgb(40, 40, 40);
            btnRegistra.FlatAppearance.BorderSize = 0;
            btnRegistra.FlatStyle = FlatStyle.Flat;
            btnRegistra.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistra.ForeColor = Color.LightGray;
            btnRegistra.Location = new Point(231, 312);
            btnRegistra.Name = "btnRegistra";
            btnRegistra.Size = new Size(335, 40);
            btnRegistra.TabIndex = 8;
            btnRegistra.Text = "REGISTRAR USUARIO";
            btnRegistra.UseVisualStyleBackColor = false;
            btnRegistra.Click += btnRegistra_Click;
            // 
            // txtPassCrearNuevoUsuario
            // 
            txtPassCrearNuevoUsuario.BackColor = Color.FromArgb(15, 15, 15);
            txtPassCrearNuevoUsuario.BorderStyle = BorderStyle.None;
            txtPassCrearNuevoUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassCrearNuevoUsuario.ForeColor = Color.DimGray;
            txtPassCrearNuevoUsuario.Location = new Point(231, 235);
            txtPassCrearNuevoUsuario.Name = "txtPassCrearNuevoUsuario";
            txtPassCrearNuevoUsuario.Size = new Size(335, 26);
            txtPassCrearNuevoUsuario.TabIndex = 7;
            txtPassCrearNuevoUsuario.Text = "CONTRASEÑA";
            txtPassCrearNuevoUsuario.Enter += txtPassCrearNuevoUsuario_Enter;
            txtPassCrearNuevoUsuario.Leave += txtPassCrearNuevoUsuario_Leave;
            // 
            // txtUsuarioCrearNuevo
            // 
            txtUsuarioCrearNuevo.BackColor = Color.FromArgb(15, 15, 15);
            txtUsuarioCrearNuevo.BorderStyle = BorderStyle.None;
            txtUsuarioCrearNuevo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuarioCrearNuevo.ForeColor = Color.DimGray;
            txtUsuarioCrearNuevo.Location = new Point(231, 190);
            txtUsuarioCrearNuevo.Name = "txtUsuarioCrearNuevo";
            txtUsuarioCrearNuevo.Size = new Size(335, 26);
            txtUsuarioCrearNuevo.TabIndex = 6;
            txtUsuarioCrearNuevo.Text = "USUARIO";
            txtUsuarioCrearNuevo.Enter += txtUsuarioCrearNuevo_Enter;
            txtUsuarioCrearNuevo.Leave += txtUsuarioCrearNuevo_Leave;
            // 
            // checkBoxVerContraseña
            // 
            checkBoxVerContraseña.AutoSize = true;
            checkBoxVerContraseña.ForeColor = Color.DimGray;
            checkBoxVerContraseña.Location = new Point(231, 276);
            checkBoxVerContraseña.Name = "checkBoxVerContraseña";
            checkBoxVerContraseña.Size = new Size(125, 19);
            checkBoxVerContraseña.TabIndex = 9;
            checkBoxVerContraseña.Text = "VER CONTRASEÑA";
            checkBoxVerContraseña.UseVisualStyleBackColor = true;
            checkBoxVerContraseña.CheckedChanged += checkBoxVerContraseña_CheckedChanged;
            // 
            // ingresarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(800, 450);
            Controls.Add(checkBoxVerContraseña);
            Controls.Add(btnRegistra);
            Controls.Add(txtPassCrearNuevoUsuario);
            Controls.Add(txtUsuarioCrearNuevo);
            Controls.Add(TituloLabelCrearUsuario);
            Controls.Add(pictureBoxAtrasCrearUsuario);
            Controls.Add(pictureBoxCerrarVistaCrearUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ingresarUsuario";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ingresarUsuario";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAtrasCrearUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCerrarVistaCrearUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAtrasCrearUsuario;
        private PictureBox pictureBoxCerrarVistaCrearUsuario;
        private Label TituloLabelCrearUsuario;
        private Button btnRegistra;
        private TextBox txtPassCrearNuevoUsuario;
        private TextBox txtUsuarioCrearNuevo;
        private CheckBox checkBoxVerContraseña;
    }
}