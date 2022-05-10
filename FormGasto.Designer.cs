namespace AppCyberSC
{
    partial class FormGasto
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
            this.txtServicio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrarG = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtServicio
            // 
            this.txtServicio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServicio.Location = new System.Drawing.Point(201, 42);
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.Size = new System.Drawing.Size(312, 26);
            this.txtServicio.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Servicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Proveedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Costo";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedor.Location = new System.Drawing.Point(201, 85);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(312, 26);
            this.txtProveedor.TabIndex = 23;
            // 
            // txtCosto
            // 
            this.txtCosto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.Location = new System.Drawing.Point(201, 171);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(312, 26);
            this.txtCosto.TabIndex = 25;
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFecha.Location = new System.Drawing.Point(201, 128);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePickerFecha.Size = new System.Drawing.Size(312, 26);
            this.dateTimePickerFecha.TabIndex = 27;
            // 
            // btnRegistrarG
            // 
            this.btnRegistrarG.BackColor = System.Drawing.Color.Green;
            this.btnRegistrarG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarG.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarG.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarG.Location = new System.Drawing.Point(428, 213);
            this.btnRegistrarG.Name = "btnRegistrarG";
            this.btnRegistrarG.Size = new System.Drawing.Size(85, 33);
            this.btnRegistrarG.TabIndex = 28;
            this.btnRegistrarG.Text = "Registrar";
            this.btnRegistrarG.UseVisualStyleBackColor = false;
            this.btnRegistrarG.Click += new System.EventHandler(this.btnRegistrarG_Click);
            // 
            // FormGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 618);
            this.Controls.Add(this.btnRegistrarG);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServicio);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGasto";
            this.Text = "Gastos";
            this.Load += new System.EventHandler(this.Gastos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.Button btnRegistrarG;
    }
}