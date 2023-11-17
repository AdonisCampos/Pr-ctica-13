namespace loginC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            UsuarioPictureBox = new PictureBox();
            label1 = new Label();
            txtUsuario = new TextBox();
            txtPass = new TextBox();
            btnIniciar = new Button();
            linkRecuperar = new LinkLabel();
            pictureBoxMinizar = new PictureBox();
            pictureBoxCerrar = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UsuarioPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCerrar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(UsuarioPictureBox);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(228, 315);
            panel1.TabIndex = 0;
            // 
            // UsuarioPictureBox
            // 
            UsuarioPictureBox.Image = (Image)resources.GetObject("UsuarioPictureBox.Image");
            UsuarioPictureBox.Location = new Point(21, 77);
            UsuarioPictureBox.Name = "UsuarioPictureBox";
            UsuarioPictureBox.Size = new Size(149, 142);
            UsuarioPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            UsuarioPictureBox.TabIndex = 0;
            UsuarioPictureBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(495, 30);
            label1.Name = "label1";
            label1.Size = new Size(124, 28);
            label1.TabIndex = 1;
            label1.Text = "MI LOGIN";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(15, 15, 15);
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.ForeColor = Color.DimGray;
            txtUsuario.Location = new Point(389, 77);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(335, 26);
            txtUsuario.TabIndex = 1;
            txtUsuario.Text = "USUARIO";
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.FromArgb(15, 15, 15);
            txtPass.BorderStyle = BorderStyle.None;
            txtPass.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.ForeColor = Color.DimGray;
            txtPass.Location = new Point(389, 122);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(335, 26);
            txtPass.TabIndex = 2;
            txtPass.Text = "CONTRASEÑA";
            txtPass.Enter += txtPass_Enter;
            txtPass.Leave += txtPass_Leave;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.FromArgb(40, 40, 40);
            btnIniciar.FlatAppearance.BorderSize = 0;
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnIniciar.ForeColor = Color.LightGray;
            btnIniciar.Location = new Point(389, 169);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(335, 40);
            btnIniciar.TabIndex = 3;
            btnIniciar.Text = "INGRESAR";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // linkRecuperar
            // 
            linkRecuperar.ActiveLinkColor = Color.Blue;
            linkRecuperar.AutoSize = true;
            linkRecuperar.LinkColor = Color.DimGray;
            linkRecuperar.Location = new Point(457, 236);
            linkRecuperar.Name = "linkRecuperar";
            linkRecuperar.Size = new Size(196, 15);
            linkRecuperar.TabIndex = 5;
            linkRecuperar.TabStop = true;
            linkRecuperar.Text = "¿HAS OLVIDADO LA CONTRASEÑA?";
            linkRecuperar.LinkClicked += linkRecuperar_LinkClicked;
            // 
            // pictureBoxMinizar
            // 
            pictureBoxMinizar.Image = (Image)resources.GetObject("pictureBoxMinizar.Image");
            pictureBoxMinizar.Location = new Point(770, 12);
            pictureBoxMinizar.Name = "pictureBoxMinizar";
            pictureBoxMinizar.Size = new Size(32, 30);
            pictureBoxMinizar.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMinizar.TabIndex = 6;
            pictureBoxMinizar.TabStop = false;
            pictureBoxMinizar.Click += pictureBoxMinizar_Click;
            // 
            // pictureBoxCerrar
            // 
            pictureBoxCerrar.Image = (Image)resources.GetObject("pictureBoxCerrar.Image");
            pictureBoxCerrar.Location = new Point(808, 12);
            pictureBoxCerrar.Name = "pictureBoxCerrar";
            pictureBoxCerrar.Size = new Size(32, 30);
            pictureBoxCerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCerrar.TabIndex = 7;
            pictureBoxCerrar.TabStop = false;
            pictureBoxCerrar.Click += pictureBoxCerrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(852, 315);
            Controls.Add(pictureBoxCerrar);
            Controls.Add(pictureBoxMinizar);
            Controls.Add(linkRecuperar);
            Controls.Add(btnIniciar);
            Controls.Add(txtPass);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Controls.Add(panel1);
            ForeColor = Color.Coral;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)UsuarioPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtUsuario;
        private TextBox txtPass;
        private Button btnIniciar;
        private PictureBox UsuarioPictureBox;
        private LinkLabel linkRecuperar;
        private PictureBox pictureBoxMinizar;
        private PictureBox pictureBoxCerrar;
    }
}