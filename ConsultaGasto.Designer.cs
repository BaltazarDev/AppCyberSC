namespace AppCyberSC
{
    partial class ConsultaGasto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaGasto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCargarTablaAdminVentas = new System.Windows.Forms.Button();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.txtFechaH = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBuscardeFechaAFecha = new System.Windows.Forms.Button();
            this.dataGridViewConsultaGasto = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonBuscarMes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultaGasto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargarTablaAdminVentas
            // 
            this.btnCargarTablaAdminVentas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCargarTablaAdminVentas.BackgroundImage")));
            this.btnCargarTablaAdminVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCargarTablaAdminVentas.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnCargarTablaAdminVentas.FlatAppearance.BorderSize = 0;
            this.btnCargarTablaAdminVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarTablaAdminVentas.Location = new System.Drawing.Point(12, 59);
            this.btnCargarTablaAdminVentas.Name = "btnCargarTablaAdminVentas";
            this.btnCargarTablaAdminVentas.Size = new System.Drawing.Size(33, 29);
            this.btnCargarTablaAdminVentas.TabIndex = 69;
            this.btnCargarTablaAdminVentas.UseVisualStyleBackColor = true;
            this.btnCargarTablaAdminVentas.Click += new System.EventHandler(this.btnCargarTablaAdminVentas_Click);
            // 
            // txtSuma
            // 
            this.txtSuma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSuma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSuma.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuma.ForeColor = System.Drawing.Color.Green;
            this.txtSuma.Location = new System.Drawing.Point(807, 63);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(114, 19);
            this.txtSuma.TabIndex = 68;
            // 
            // txtFechaH
            // 
            this.txtFechaH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFechaH.BackColor = System.Drawing.Color.White;
            this.txtFechaH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFechaH.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaH.Location = new System.Drawing.Point(968, 12);
            this.txtFechaH.Name = "txtFechaH";
            this.txtFechaH.ReadOnly = true;
            this.txtFechaH.Size = new System.Drawing.Size(100, 19);
            this.txtFechaH.TabIndex = 67;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(786, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 18);
            this.label12.TabIndex = 66;
            this.label12.Text = "$";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(783, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 18);
            this.label11.TabIndex = 65;
            this.label11.Text = "Total de conulta";
            // 
            // dateTimePickerFechaFin
            // 
            this.dateTimePickerFechaFin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePickerFechaFin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaFin.Location = new System.Drawing.Point(479, 56);
            this.dateTimePickerFechaFin.Name = "dateTimePickerFechaFin";
            this.dateTimePickerFechaFin.Size = new System.Drawing.Size(119, 26);
            this.dateTimePickerFechaFin.TabIndex = 64;
            // 
            // dateTimePickerFechaInicio
            // 
            this.dateTimePickerFechaInicio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePickerFechaInicio.CustomFormat = "";
            this.dateTimePickerFechaInicio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaInicio.Location = new System.Drawing.Point(321, 56);
            this.dateTimePickerFechaInicio.Name = "dateTimePickerFechaInicio";
            this.dateTimePickerFechaInicio.Size = new System.Drawing.Size(119, 26);
            this.dateTimePickerFechaInicio.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(449, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 16);
            this.label4.TabIndex = 62;
            this.label4.Text = "A";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(497, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 61;
            this.label3.Text = "Fecha Fin";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(340, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 60;
            this.label2.Text = "Fecha Inicio";
            // 
            // buttonBuscardeFechaAFecha
            // 
            this.buttonBuscardeFechaAFecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonBuscardeFechaAFecha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBuscardeFechaAFecha.BackgroundImage")));
            this.buttonBuscardeFechaAFecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBuscardeFechaAFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuscardeFechaAFecha.FlatAppearance.BorderSize = 0;
            this.buttonBuscardeFechaAFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscardeFechaAFecha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscardeFechaAFecha.Location = new System.Drawing.Point(604, 56);
            this.buttonBuscardeFechaAFecha.Name = "buttonBuscardeFechaAFecha";
            this.buttonBuscardeFechaAFecha.Size = new System.Drawing.Size(27, 26);
            this.buttonBuscardeFechaAFecha.TabIndex = 59;
            this.buttonBuscardeFechaAFecha.UseVisualStyleBackColor = true;
            this.buttonBuscardeFechaAFecha.Click += new System.EventHandler(this.buttonBuscardeFechaAFecha_Click);
            // 
            // dataGridViewConsultaGasto
            // 
            this.dataGridViewConsultaGasto.AllowUserToAddRows = false;
            this.dataGridViewConsultaGasto.AllowUserToDeleteRows = false;
            this.dataGridViewConsultaGasto.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewConsultaGasto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewConsultaGasto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConsultaGasto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewConsultaGasto.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewConsultaGasto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewConsultaGasto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewConsultaGasto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewConsultaGasto.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewConsultaGasto.GridColor = System.Drawing.Color.Gray;
            this.dataGridViewConsultaGasto.Location = new System.Drawing.Point(12, 101);
            this.dataGridViewConsultaGasto.Name = "dataGridViewConsultaGasto";
            this.dataGridViewConsultaGasto.ReadOnly = true;
            this.dataGridViewConsultaGasto.RowHeadersWidth = 50;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataGridViewConsultaGasto.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewConsultaGasto.Size = new System.Drawing.Size(1056, 505);
            this.dataGridViewConsultaGasto.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(86, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 71;
            this.label5.Text = "Mes";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // buttonBuscarMes
            // 
            this.buttonBuscarMes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonBuscarMes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBuscarMes.BackgroundImage")));
            this.buttonBuscarMes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBuscarMes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuscarMes.FlatAppearance.BorderSize = 0;
            this.buttonBuscarMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarMes.Location = new System.Drawing.Point(80, 56);
            this.buttonBuscarMes.Name = "buttonBuscarMes";
            this.buttonBuscarMes.Size = new System.Drawing.Size(49, 42);
            this.buttonBuscarMes.TabIndex = 70;
            this.buttonBuscarMes.UseVisualStyleBackColor = true;
            this.buttonBuscarMes.Click += new System.EventHandler(this.buttonBuscarMes_Click);
            // 
            // ConsultaGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 618);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonBuscarMes);
            this.Controls.Add(this.btnCargarTablaAdminVentas);
            this.Controls.Add(this.txtSuma);
            this.Controls.Add(this.txtFechaH);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateTimePickerFechaFin);
            this.Controls.Add(this.dateTimePickerFechaInicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBuscardeFechaAFecha);
            this.Controls.Add(this.dataGridViewConsultaGasto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultaGasto";
            this.Text = "ConsultaGastos";
            this.Load += new System.EventHandler(this.ConsultaGasto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultaGasto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCargarTablaAdminVentas;
        private System.Windows.Forms.TextBox txtSuma;
        private System.Windows.Forms.TextBox txtFechaH;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaFin;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBuscardeFechaAFecha;
        private System.Windows.Forms.DataGridView dataGridViewConsultaGasto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonBuscarMes;
    }
}