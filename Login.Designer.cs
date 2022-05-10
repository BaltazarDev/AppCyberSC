namespace AppCyberSC
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BarraTituloLogin = new System.Windows.Forms.Panel();
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.BarraTituloLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(494, 11);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(192, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "App Cyber SC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.SystemColors.Window;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUser.Location = new System.Drawing.Point(344, 87);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(168, 16);
            this.txtUser.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(344, 148);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(168, 16);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.BackColor = System.Drawing.Color.Green;
            this.buttonIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIngresar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIngresar.ForeColor = System.Drawing.Color.White;
            this.buttonIngresar.Location = new System.Drawing.Point(439, 200);
            this.buttonIngresar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(73, 38);
            this.buttonIngresar.TabIndex = 3;
            this.buttonIngresar.Text = "Iniciar";
            this.buttonIngresar.UseVisualStyleBackColor = false;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(312, 242);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(8, 17);
            this.lblMensaje.TabIndex = 5;
            this.lblMensaje.Text = "\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // BarraTituloLogin
            // 
            this.BarraTituloLogin.BackColor = System.Drawing.Color.Teal;
            this.BarraTituloLogin.Controls.Add(this.label3);
            this.BarraTituloLogin.Controls.Add(this.btnCerrar);
            this.BarraTituloLogin.Location = new System.Drawing.Point(0, -2);
            this.BarraTituloLogin.Name = "BarraTituloLogin";
            this.BarraTituloLogin.Size = new System.Drawing.Size(534, 36);
            this.BarraTituloLogin.TabIndex = 9;
            this.BarraTituloLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTituloLogin_MouseDown);
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegresar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegresar.ForeColor = System.Drawing.Color.White;
            this.buttonRegresar.Location = new System.Drawing.Point(344, 200);
            this.buttonRegresar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(73, 38);
            this.buttonRegresar.TabIndex = 4;
            this.buttonRegresar.Text = "Regresar";
            this.buttonRegresar.UseVisualStyleBackColor = false;
            this.buttonRegresar.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(344, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 2);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(344, 168);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 2);
            this.panel2.TabIndex = 12;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(531, 271);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonRegresar);
            this.Controls.Add(this.BarraTituloLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.BarraTituloLogin.ResumeLayout(false);
            this.BarraTituloLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel BarraTituloLogin;
        private System.Windows.Forms.Button buttonRegresar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}