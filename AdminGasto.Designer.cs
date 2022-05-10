namespace AppCyberSC
{
    partial class AdminGasto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminGasto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDGasto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.buttonCargarTablaGastos = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtServicio = new System.Windows.Forms.TextBox();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIDGastoDelete = new System.Windows.Forms.TextBox();
            this.btnGastoUpdate = new System.Windows.Forms.Button();
            this.btnGastoDelete = new System.Windows.Forms.Button();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewGastos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGastos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "IDGasto";
            // 
            // txtIDGasto
            // 
            this.txtIDGasto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDGasto.Location = new System.Drawing.Point(29, 74);
            this.txtIDGasto.Name = "txtIDGasto";
            this.txtIDGasto.Size = new System.Drawing.Size(73, 22);
            this.txtIDGasto.TabIndex = 1;
            this.txtIDGasto.TextChanged += new System.EventHandler(this.txtIDGasto_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Actualizar Registro";
            // 
            // txtFecha
            // 
            this.txtFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFecha.BackColor = System.Drawing.Color.White;
            this.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFecha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(957, 12);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(111, 19);
            this.txtFecha.TabIndex = 37;
            // 
            // buttonCargarTablaGastos
            // 
            this.buttonCargarTablaGastos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCargarTablaGastos.BackgroundImage")));
            this.buttonCargarTablaGastos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCargarTablaGastos.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.buttonCargarTablaGastos.FlatAppearance.BorderSize = 0;
            this.buttonCargarTablaGastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCargarTablaGastos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCargarTablaGastos.Location = new System.Drawing.Point(12, 109);
            this.buttonCargarTablaGastos.Name = "buttonCargarTablaGastos";
            this.buttonCargarTablaGastos.Size = new System.Drawing.Size(28, 32);
            this.buttonCargarTablaGastos.TabIndex = 9;
            this.buttonCargarTablaGastos.UseVisualStyleBackColor = true;
            this.buttonCargarTablaGastos.Click += new System.EventHandler(this.buttonCargarTablaGastos_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(251, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Servicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(124, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Proveedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(376, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "Fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(515, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 42;
            this.label6.Text = "Costo";
            // 
            // txtServicio
            // 
            this.txtServicio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServicio.Location = new System.Drawing.Point(127, 74);
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.Size = new System.Drawing.Size(100, 22);
            this.txtServicio.TabIndex = 2;
            // 
            // txtProveedor
            // 
            this.txtProveedor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedor.Location = new System.Drawing.Point(254, 74);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(100, 22);
            this.txtProveedor.TabIndex = 3;
            // 
            // txtCosto
            // 
            this.txtCosto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.Location = new System.Drawing.Point(518, 74);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(100, 22);
            this.txtCosto.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(935, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 18);
            this.label7.TabIndex = 47;
            this.label7.Text = "Eliminar Registro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(914, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 16);
            this.label8.TabIndex = 48;
            this.label8.Text = "IDGasto";
            // 
            // txtIDGastoDelete
            // 
            this.txtIDGastoDelete.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDGastoDelete.Location = new System.Drawing.Point(979, 88);
            this.txtIDGastoDelete.Name = "txtIDGastoDelete";
            this.txtIDGastoDelete.Size = new System.Drawing.Size(73, 22);
            this.txtIDGastoDelete.TabIndex = 7;
            // 
            // btnGastoUpdate
            // 
            this.btnGastoUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGastoUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGastoUpdate.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGastoUpdate.ForeColor = System.Drawing.Color.White;
            this.btnGastoUpdate.Location = new System.Drawing.Point(634, 72);
            this.btnGastoUpdate.Name = "btnGastoUpdate";
            this.btnGastoUpdate.Size = new System.Drawing.Size(75, 27);
            this.btnGastoUpdate.TabIndex = 6;
            this.btnGastoUpdate.Text = "Actualizar";
            this.btnGastoUpdate.UseVisualStyleBackColor = false;
            this.btnGastoUpdate.Click += new System.EventHandler(this.btnGastoUpdate_Click);
            // 
            // btnGastoDelete
            // 
            this.btnGastoDelete.BackColor = System.Drawing.Color.Red;
            this.btnGastoDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGastoDelete.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGastoDelete.ForeColor = System.Drawing.Color.White;
            this.btnGastoDelete.Location = new System.Drawing.Point(979, 114);
            this.btnGastoDelete.Name = "btnGastoDelete";
            this.btnGastoDelete.Size = new System.Drawing.Size(75, 27);
            this.btnGastoDelete.TabIndex = 8;
            this.btnGastoDelete.Text = "Eliminar";
            this.btnGastoDelete.UseVisualStyleBackColor = false;
            this.btnGastoDelete.Click += new System.EventHandler(this.btnGastoDelete_Click);
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFecha.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFecha.Location = new System.Drawing.Point(379, 74);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(117, 22);
            this.dateTimePickerFecha.TabIndex = 4;
            // 
            // dataGridViewGastos
            // 
            this.dataGridViewGastos.AllowUserToAddRows = false;
            this.dataGridViewGastos.AllowUserToDeleteRows = false;
            this.dataGridViewGastos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewGastos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewGastos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewGastos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewGastos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewGastos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewGastos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewGastos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewGastos.GridColor = System.Drawing.Color.Gray;
            this.dataGridViewGastos.Location = new System.Drawing.Point(12, 147);
            this.dataGridViewGastos.Name = "dataGridViewGastos";
            this.dataGridViewGastos.ReadOnly = true;
            this.dataGridViewGastos.Size = new System.Drawing.Size(1056, 459);
            this.dataGridViewGastos.TabIndex = 49;
            // 
            // AdminGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 618);
            this.Controls.Add(this.dataGridViewGastos);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.btnGastoDelete);
            this.Controls.Add(this.btnGastoUpdate);
            this.Controls.Add(this.txtIDGastoDelete);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.txtServicio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCargarTablaGastos);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDGasto);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminGasto";
            this.Text = "AdminGasto";
            this.Load += new System.EventHandler(this.AdminGasto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGastos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDGasto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Button buttonCargarTablaGastos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtServicio;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIDGastoDelete;
        private System.Windows.Forms.Button btnGastoUpdate;
        private System.Windows.Forms.Button btnGastoDelete;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.DataGridView dataGridViewGastos;
    }
}