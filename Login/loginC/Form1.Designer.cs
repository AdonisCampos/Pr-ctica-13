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
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.btnIniciar = new System.Windows.Forms.Button();
			this.btnPass2 = new System.Windows.Forms.LinkLabel();
			this.pictureBoxMinizar = new System.Windows.Forms.PictureBox();
			this.pictureBoxCerrar = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinizar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrar)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(150, 316);
			this.panel1.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(21, 77);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(110, 142);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(240, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(124, 28);
			this.label1.TabIndex = 1;
			this.label1.Text = "MI LOGIN";
			// 
			// txtUsuario
			// 
			this.txtUsuario.BackColor = System.Drawing.Color.Black;
			this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtUsuario.ForeColor = System.Drawing.Color.White;
			this.txtUsuario.Location = new System.Drawing.Point(222, 89);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(190, 16);
			this.txtUsuario.TabIndex = 2;
			this.txtUsuario.Text = "USUARIO";
			this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
			this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
			// 
			// txtPass
			// 
			this.txtPass.BackColor = System.Drawing.Color.Black;
			this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPass.ForeColor = System.Drawing.Color.White;
			this.txtPass.Location = new System.Drawing.Point(222, 139);
			this.txtPass.Name = "txtPass";
			this.txtPass.Size = new System.Drawing.Size(190, 16);
			this.txtPass.TabIndex = 3;
			this.txtPass.Text = "CONTRASEÑA";
			this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
			this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
			// 
			// btnIniciar
			// 
			this.btnIniciar.BackColor = System.Drawing.Color.Black;
			this.btnIniciar.ForeColor = System.Drawing.Color.White;
			this.btnIniciar.Location = new System.Drawing.Point(222, 196);
			this.btnIniciar.Name = "btnIniciar";
			this.btnIniciar.Size = new System.Drawing.Size(190, 23);
			this.btnIniciar.TabIndex = 4;
			this.btnIniciar.Text = "INICIAR SESION";
			this.btnIniciar.UseVisualStyleBackColor = false;
			// 
			// btnPass2
			// 
			this.btnPass2.AutoSize = true;
			this.btnPass2.LinkColor = System.Drawing.Color.White;
			this.btnPass2.Location = new System.Drawing.Point(216, 239);
			this.btnPass2.Name = "btnPass2";
			this.btnPass2.Size = new System.Drawing.Size(196, 15);
			this.btnPass2.TabIndex = 5;
			this.btnPass2.TabStop = true;
			this.btnPass2.Text = "¿HAS OLVIDADO LA CONTRASEÑA?";
			// 
			// pictureBoxMinizar
			// 
			this.pictureBoxMinizar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMinizar.Image")));
			this.pictureBoxMinizar.Location = new System.Drawing.Point(400, 20);
			this.pictureBoxMinizar.Name = "pictureBoxMinizar";
			this.pictureBoxMinizar.Size = new System.Drawing.Size(32, 30);
			this.pictureBoxMinizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxMinizar.TabIndex = 6;
			this.pictureBoxMinizar.TabStop = false;
			this.pictureBoxMinizar.Click += new System.EventHandler(this.pictureBoxMinizar_Click);
			// 
			// pictureBoxCerrar
			// 
			this.pictureBoxCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCerrar.Image")));
			this.pictureBoxCerrar.Location = new System.Drawing.Point(438, 20);
			this.pictureBoxCerrar.Name = "pictureBoxCerrar";
			this.pictureBoxCerrar.Size = new System.Drawing.Size(32, 30);
			this.pictureBoxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxCerrar.TabIndex = 7;
			this.pictureBoxCerrar.TabStop = false;
			this.pictureBoxCerrar.Click += new System.EventHandler(this.pictureBoxCerrar_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.ClientSize = new System.Drawing.Size(495, 316);
			this.Controls.Add(this.pictureBoxCerrar);
			this.Controls.Add(this.pictureBoxMinizar);
			this.Controls.Add(this.btnPass2);
			this.Controls.Add(this.btnIniciar);
			this.Controls.Add(this.txtPass);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.ForeColor = System.Drawing.Color.Coral;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.Opacity = 0.9D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinizar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Panel panel1;
		private Label label1;
		private TextBox txtUsuario;
		private TextBox txtPass;
		private Button btnIniciar;
		private PictureBox pictureBox1;
		private LinkLabel btnPass2;
		private PictureBox pictureBoxMinizar;
		private PictureBox pictureBoxCerrar;
	}
}