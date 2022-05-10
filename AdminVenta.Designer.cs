namespace AppCyberSC
{
    partial class AdminVenta
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminVenta));
            this.dataGridViewVentas = new System.Windows.Forms.DataGridView();
            this.errorProviderConsultaVentas = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtFModificacion = new System.Windows.Forms.TextBox();
            this.txtIDVentaUpdate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductoVentaUpdate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescripcionVentaUpdate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCantidadVentaUpdate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecioVentaUpdate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotalVentaUpdate = new System.Windows.Forms.TextBox();
            this.txtIDVentaDelete = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonUpdateVenta = new System.Windows.Forms.Button();
            this.buttonDeleteVenta = new System.Windows.Forms.Button();
            this.buttonCargarTablaVentas = new System.Windows.Forms.Button();
            this.toolTipAdminVentas = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConsultaVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVentas
            // 
            this.dataGridViewVentas.AllowUserToAddRows = false;
            this.dataGridViewVentas.AllowUserToDeleteRows = false;
            this.dataGridViewVentas.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewVentas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewVentas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewVentas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewVentas.GridColor = System.Drawing.Color.Gray;
            this.dataGridViewVentas.Location = new System.Drawing.Point(15, 147);
            this.dataGridViewVentas.Name = "dataGridViewVentas";
            this.dataGridViewVentas.ReadOnly = true;
            this.dataGridViewVentas.Size = new System.Drawing.Size(1053, 459);
            this.dataGridViewVentas.TabIndex = 7;
            // 
            // errorProviderConsultaVentas
            // 
            this.errorProviderConsultaVentas.ContainerControl = this;
            // 
            // txtFModificacion
            // 
            this.txtFModificacion.BackColor = System.Drawing.Color.White;
            this.txtFModificacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFModificacion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFModificacion.Location = new System.Drawing.Point(963, 9);
            this.txtFModificacion.Name = "txtFModificacion";
            this.txtFModificacion.ReadOnly = true;
            this.txtFModificacion.Size = new System.Drawing.Size(111, 19);
            this.txtFModificacion.TabIndex = 15;
            // 
            // txtIDVentaUpdate
            // 
            this.txtIDVentaUpdate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDVentaUpdate.Location = new System.Drawing.Point(12, 59);
            this.txtIDVentaUpdate.Name = "txtIDVentaUpdate";
            this.txtIDVentaUpdate.Size = new System.Drawing.Size(73, 22);
            this.txtIDVentaUpdate.TabIndex = 1;
            this.txtIDVentaUpdate.TextChanged += new System.EventHandler(this.TxtIDVentaUpdate_TextChanged);
            this.txtIDVentaUpdate.Validating += new System.ComponentModel.CancelEventHandler(this.TxtIDVentaUpdate_Validating);
            this.txtIDVentaUpdate.Validated += new System.EventHandler(this.TxtIDVentaUpdate_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Actualizar Registro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "IDVenta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Producto";
            // 
            // txtProductoVentaUpdate
            // 
            this.txtProductoVentaUpdate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductoVentaUpdate.Location = new System.Drawing.Point(91, 59);
            this.txtProductoVentaUpdate.Name = "txtProductoVentaUpdate";
            this.txtProductoVentaUpdate.Size = new System.Drawing.Size(115, 22);
            this.txtProductoVentaUpdate.TabIndex = 2;
            this.txtProductoVentaUpdate.Validating += new System.ComponentModel.CancelEventHandler(this.TxtProductoVentaUpdate_Validating);
            this.txtProductoVentaUpdate.Validated += new System.EventHandler(this.TxtProductoVentaUpdate_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(209, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Descripción";
            // 
            // txtDescripcionVentaUpdate
            // 
            this.txtDescripcionVentaUpdate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionVentaUpdate.Location = new System.Drawing.Point(212, 59);
            this.txtDescripcionVentaUpdate.Multiline = true;
            this.txtDescripcionVentaUpdate.Name = "txtDescripcionVentaUpdate";
            this.txtDescripcionVentaUpdate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcionVentaUpdate.Size = new System.Drawing.Size(187, 73);
            this.txtDescripcionVentaUpdate.TabIndex = 3;
            this.txtDescripcionVentaUpdate.Validating += new System.ComponentModel.CancelEventHandler(this.TxtDescripcionVentaUpdate_Validating);
            this.txtDescripcionVentaUpdate.Validated += new System.EventHandler(this.TxtDescripcionVentaUpdate_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(402, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cantidad";
            // 
            // txtCantidadVentaUpdate
            // 
            this.txtCantidadVentaUpdate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadVentaUpdate.Location = new System.Drawing.Point(405, 59);
            this.txtCantidadVentaUpdate.Name = "txtCantidadVentaUpdate";
            this.txtCantidadVentaUpdate.Size = new System.Drawing.Size(91, 22);
            this.txtCantidadVentaUpdate.TabIndex = 4;
            this.txtCantidadVentaUpdate.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCantidadVentaUpdate_Validating);
            this.txtCantidadVentaUpdate.Validated += new System.EventHandler(this.TxtCantidadVentaUpdate_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(499, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Precio";
            // 
            // txtPrecioVentaUpdate
            // 
            this.txtPrecioVentaUpdate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVentaUpdate.Location = new System.Drawing.Point(502, 59);
            this.txtPrecioVentaUpdate.Name = "txtPrecioVentaUpdate";
            this.txtPrecioVentaUpdate.Size = new System.Drawing.Size(91, 22);
            this.txtPrecioVentaUpdate.TabIndex = 5;
            this.txtPrecioVentaUpdate.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPrecioVentaUpdate_Validating);
            this.txtPrecioVentaUpdate.Validated += new System.EventHandler(this.TxtPrecioVentaUpdate_Validated);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(596, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "GTotal";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(788, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "IDVenta:";
            // 
            // txtTotalVentaUpdate
            // 
            this.txtTotalVentaUpdate.BackColor = System.Drawing.Color.White;
            this.txtTotalVentaUpdate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalVentaUpdate.Location = new System.Drawing.Point(599, 59);
            this.txtTotalVentaUpdate.Name = "txtTotalVentaUpdate";
            this.txtTotalVentaUpdate.ReadOnly = true;
            this.txtTotalVentaUpdate.Size = new System.Drawing.Size(111, 22);
            this.txtTotalVentaUpdate.TabIndex = 6;
            this.txtTotalVentaUpdate.Validating += new System.ComponentModel.CancelEventHandler(this.TxtTotalVentaUpdate_Validating);
            this.txtTotalVentaUpdate.Validated += new System.EventHandler(this.TxtTotalVentaUpdate_Validated);
            // 
            // txtIDVentaDelete
            // 
            this.txtIDVentaDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIDVentaDelete.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDVentaDelete.Location = new System.Drawing.Point(791, 62);
            this.txtIDVentaDelete.Name = "txtIDVentaDelete";
            this.txtIDVentaDelete.Size = new System.Drawing.Size(73, 22);
            this.txtIDVentaDelete.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(765, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Eliminar Registro";
            // 
            // buttonUpdateVenta
            // 
            this.buttonUpdateVenta.BackColor = System.Drawing.Color.Orange;
            this.buttonUpdateVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdateVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateVenta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateVenta.ForeColor = System.Drawing.Color.White;
            this.buttonUpdateVenta.Location = new System.Drawing.Point(628, 87);
            this.buttonUpdateVenta.Name = "buttonUpdateVenta";
            this.buttonUpdateVenta.Size = new System.Drawing.Size(82, 26);
            this.buttonUpdateVenta.TabIndex = 7;
            this.buttonUpdateVenta.Text = "Actualizar";
            this.toolTipAdminVentas.SetToolTip(this.buttonUpdateVenta, "Actualizar registro");
            this.buttonUpdateVenta.UseVisualStyleBackColor = false;
            this.buttonUpdateVenta.Click += new System.EventHandler(this.ButtonUpdateVenta_Click);
            // 
            // buttonDeleteVenta
            // 
            this.buttonDeleteVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDeleteVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteVenta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteVenta.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteVenta.Location = new System.Drawing.Point(791, 90);
            this.buttonDeleteVenta.Name = "buttonDeleteVenta";
            this.buttonDeleteVenta.Size = new System.Drawing.Size(73, 26);
            this.buttonDeleteVenta.TabIndex = 9;
            this.buttonDeleteVenta.Text = "Eliminar";
            this.toolTipAdminVentas.SetToolTip(this.buttonDeleteVenta, "Eliminar registro");
            this.buttonDeleteVenta.UseVisualStyleBackColor = false;
            this.buttonDeleteVenta.Click += new System.EventHandler(this.ButtonDeleteVenta_Click);
            // 
            // buttonCargarTablaVentas
            // 
            this.buttonCargarTablaVentas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCargarTablaVentas.BackgroundImage")));
            this.buttonCargarTablaVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCargarTablaVentas.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.buttonCargarTablaVentas.FlatAppearance.BorderSize = 0;
            this.buttonCargarTablaVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCargarTablaVentas.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCargarTablaVentas.Location = new System.Drawing.Point(15, 109);
            this.buttonCargarTablaVentas.Name = "buttonCargarTablaVentas";
            this.buttonCargarTablaVentas.Size = new System.Drawing.Size(38, 32);
            this.buttonCargarTablaVentas.TabIndex = 10;
            this.toolTipAdminVentas.SetToolTip(this.buttonCargarTablaVentas, "Cargar Tabla");
            this.buttonCargarTablaVentas.UseVisualStyleBackColor = true;
            this.buttonCargarTablaVentas.Click += new System.EventHandler(this.buttonCargarTablaVentas_Click);
            // 
            // AdminVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 618);
            this.Controls.Add(this.buttonCargarTablaVentas);
            this.Controls.Add(this.buttonDeleteVenta);
            this.Controls.Add(this.txtFModificacion);
            this.Controls.Add(this.buttonUpdateVenta);
            this.Controls.Add(this.dataGridViewVentas);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtIDVentaDelete);
            this.Controls.Add(this.txtTotalVentaUpdate);
            this.Controls.Add(this.txtIDVentaUpdate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrecioVentaUpdate);
            this.Controls.Add(this.txtProductoVentaUpdate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCantidadVentaUpdate);
            this.Controls.Add(this.txtDescripcionVentaUpdate);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminVenta";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "ConsultaVentas";
            this.Load += new System.EventHandler(this.AdminVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConsultaVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewVentas;
        private System.Windows.Forms.ErrorProvider errorProviderConsultaVentas;
        private System.Windows.Forms.TextBox txtFModificacion;
        private System.Windows.Forms.Button buttonDeleteVenta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIDVentaDelete;
        private System.Windows.Forms.TextBox txtTotalVentaUpdate;
        private System.Windows.Forms.TextBox txtIDVentaUpdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecioVentaUpdate;
        private System.Windows.Forms.TextBox txtProductoVentaUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantidadVentaUpdate;
        private System.Windows.Forms.TextBox txtDescripcionVentaUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCargarTablaVentas;
        private System.Windows.Forms.ToolTip toolTipAdminVentas;
        private System.Windows.Forms.Button buttonUpdateVenta;
    }
}