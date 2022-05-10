namespace AppCyberSC
{
    partial class AdminReparacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminReparacion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonCargarTablaVentas = new System.Windows.Forms.Button();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.dataGridViewReparaciones = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIDReDelete = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTxtCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtGTotal = new System.Windows.Forms.TextBox();
            this.txtCostoR = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtEquipo = new System.Windows.Forms.TextBox();
            this.txtPropietario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.dateTimePickerFEntrega = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIDRe = new System.Windows.Forms.TextBox();
            this.btnUpdateRe = new System.Windows.Forms.Button();
            this.btnDeleteRe = new System.Windows.Forms.Button();
            this.dateTimePickerFRecepcion = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReparaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCargarTablaVentas
            // 
            this.buttonCargarTablaVentas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCargarTablaVentas.BackgroundImage")));
            this.buttonCargarTablaVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCargarTablaVentas.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.buttonCargarTablaVentas.FlatAppearance.BorderSize = 0;
            this.buttonCargarTablaVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCargarTablaVentas.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCargarTablaVentas.Location = new System.Drawing.Point(12, 135);
            this.buttonCargarTablaVentas.Name = "buttonCargarTablaVentas";
            this.buttonCargarTablaVentas.Size = new System.Drawing.Size(28, 32);
            this.buttonCargarTablaVentas.TabIndex = 13;
            this.buttonCargarTablaVentas.UseVisualStyleBackColor = true;
            this.buttonCargarTablaVentas.Click += new System.EventHandler(this.buttonCargarTablaVentas_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFecha.BackColor = System.Drawing.Color.White;
            this.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFecha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(952, 12);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(111, 19);
            this.txtFecha.TabIndex = 36;
            // 
            // dataGridViewReparaciones
            // 
            this.dataGridViewReparaciones.AllowUserToAddRows = false;
            this.dataGridViewReparaciones.AllowUserToDeleteRows = false;
            this.dataGridViewReparaciones.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewReparaciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewReparaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewReparaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewReparaciones.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewReparaciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReparaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewReparaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewReparaciones.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewReparaciones.GridColor = System.Drawing.Color.Gray;
            this.dataGridViewReparaciones.Location = new System.Drawing.Point(12, 173);
            this.dataGridViewReparaciones.Name = "dataGridViewReparaciones";
            this.dataGridViewReparaciones.ReadOnly = true;
            this.dataGridViewReparaciones.Size = new System.Drawing.Size(1051, 433);
            this.dataGridViewReparaciones.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(946, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 16);
            this.label9.TabIndex = 39;
            this.label9.Text = "Eliminar Registro";
            // 
            // txtIDReDelete
            // 
            this.txtIDReDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIDReDelete.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDReDelete.Location = new System.Drawing.Point(990, 104);
            this.txtIDReDelete.Name = "txtIDReDelete";
            this.txtIDReDelete.Size = new System.Drawing.Size(73, 22);
            this.txtIDReDelete.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(927, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 16);
            this.label10.TabIndex = 37;
            this.label10.Text = "IDVenta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Actualizar Registro";
            // 
            // maskedTxtCelular
            // 
            this.maskedTxtCelular.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTxtCelular.Location = new System.Drawing.Point(136, 99);
            this.maskedTxtCelular.Mask = "00-00-00-00-00";
            this.maskedTxtCelular.Name = "maskedTxtCelular";
            this.maskedTxtCelular.Size = new System.Drawing.Size(117, 22);
            this.maskedTxtCelular.TabIndex = 3;
            // 
            // txtGTotal
            // 
            this.txtGTotal.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.txtGTotal.Location = new System.Drawing.Point(630, 67);
            this.txtGTotal.Name = "txtGTotal";
            this.txtGTotal.Size = new System.Drawing.Size(117, 22);
            this.txtGTotal.TabIndex = 8;
            // 
            // txtCostoR
            // 
            this.txtCostoR.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoR.Location = new System.Drawing.Point(630, 35);
            this.txtCostoR.Name = "txtCostoR";
            this.txtCostoR.Size = new System.Drawing.Size(117, 22);
            this.txtCostoR.TabIndex = 7;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(358, 67);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(117, 82);
            this.txtDescripcion.TabIndex = 6;
            // 
            // txtModelo
            // 
            this.txtModelo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(358, 35);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(117, 22);
            this.txtModelo.TabIndex = 5;
            // 
            // txtEquipo
            // 
            this.txtEquipo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipo.Location = new System.Drawing.Point(136, 133);
            this.txtEquipo.Name = "txtEquipo";
            this.txtEquipo.Size = new System.Drawing.Size(117, 22);
            this.txtEquipo.TabIndex = 4;
            // 
            // txtPropietario
            // 
            this.txtPropietario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropietario.Location = new System.Drawing.Point(136, 67);
            this.txtPropietario.Name = "txtPropietario";
            this.txtPropietario.Size = new System.Drawing.Size(117, 22);
            this.txtPropietario.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(496, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 53;
            this.label7.Text = "Ganancia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(496, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 16);
            this.label6.TabIndex = 52;
            this.label6.Text = "Costo Reparación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(273, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 51;
            this.label5.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(273, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 49;
            this.label4.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "Equipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Celular";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(56, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 40;
            this.label8.Text = "Propietario";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(57, 38);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(35, 16);
            this.labelID.TabIndex = 54;
            this.labelID.Text = "IDRe";
            // 
            // dateTimePickerFEntrega
            // 
            this.dateTimePickerFEntrega.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFEntrega.Location = new System.Drawing.Point(630, 135);
            this.dateTimePickerFEntrega.Name = "dateTimePickerFEntrega";
            this.dateTimePickerFEntrega.Size = new System.Drawing.Size(117, 20);
            this.dateTimePickerFEntrega.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(496, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 16);
            this.label11.TabIndex = 57;
            this.label11.Text = "Fecha de entrega";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(496, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 16);
            this.label12.TabIndex = 59;
            this.label12.Text = "Fecha de recepción";
            // 
            // txtIDRe
            // 
            this.txtIDRe.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDRe.Location = new System.Drawing.Point(136, 35);
            this.txtIDRe.Name = "txtIDRe";
            this.txtIDRe.Size = new System.Drawing.Size(117, 22);
            this.txtIDRe.TabIndex = 1;
            this.txtIDRe.TextChanged += new System.EventHandler(this.txtIDRe_TextChanged);
            // 
            // btnUpdateRe
            // 
            this.btnUpdateRe.BackColor = System.Drawing.Color.Orange;
            this.btnUpdateRe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateRe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateRe.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRe.ForeColor = System.Drawing.Color.White;
            this.btnUpdateRe.Location = new System.Drawing.Point(765, 124);
            this.btnUpdateRe.Name = "btnUpdateRe";
            this.btnUpdateRe.Size = new System.Drawing.Size(82, 31);
            this.btnUpdateRe.TabIndex = 10;
            this.btnUpdateRe.Text = "Actualizar";
            this.btnUpdateRe.UseVisualStyleBackColor = false;
            this.btnUpdateRe.Click += new System.EventHandler(this.btnUpdateRe_Click);
            // 
            // btnDeleteRe
            // 
            this.btnDeleteRe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteRe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteRe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteRe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRe.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRe.ForeColor = System.Drawing.Color.White;
            this.btnDeleteRe.Location = new System.Drawing.Point(990, 133);
            this.btnDeleteRe.Name = "btnDeleteRe";
            this.btnDeleteRe.Size = new System.Drawing.Size(73, 31);
            this.btnDeleteRe.TabIndex = 12;
            this.btnDeleteRe.Text = "Eliminar";
            this.btnDeleteRe.UseVisualStyleBackColor = false;
            this.btnDeleteRe.Click += new System.EventHandler(this.btnDeleteRe_Click);
            // 
            // dateTimePickerFRecepcion
            // 
            this.dateTimePickerFRecepcion.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFRecepcion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFRecepcion.Location = new System.Drawing.Point(630, 102);
            this.dateTimePickerFRecepcion.Name = "dateTimePickerFRecepcion";
            this.dateTimePickerFRecepcion.Size = new System.Drawing.Size(117, 20);
            this.dateTimePickerFRecepcion.TabIndex = 60;
            // 
            // AdminReparacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 618);
            this.Controls.Add(this.dateTimePickerFRecepcion);
            this.Controls.Add(this.btnDeleteRe);
            this.Controls.Add(this.btnUpdateRe);
            this.Controls.Add(this.txtIDRe);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateTimePickerFEntrega);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.maskedTxtCelular);
            this.Controls.Add(this.txtGTotal);
            this.Controls.Add(this.txtCostoR);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtEquipo);
            this.Controls.Add(this.txtPropietario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonCargarTablaVentas);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.dataGridViewReparaciones);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtIDReDelete);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminReparacion";
            this.Text = "AdminReparacion";
            this.Load += new System.EventHandler(this.AdminReparacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReparaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCargarTablaVentas;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.DataGridView dataGridViewReparaciones;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIDReDelete;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTxtCelular;
        private System.Windows.Forms.TextBox txtGTotal;
        private System.Windows.Forms.TextBox txtCostoR;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtEquipo;
        private System.Windows.Forms.TextBox txtPropietario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.DateTimePicker dateTimePickerFEntrega;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtIDRe;
        private System.Windows.Forms.Button btnUpdateRe;
        private System.Windows.Forms.Button btnDeleteRe;
        private System.Windows.Forms.DateTimePicker dateTimePickerFRecepcion;
    }
}