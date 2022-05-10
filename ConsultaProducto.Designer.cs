namespace AppCyberSC
{
    partial class ConsultaProducto
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
            this.txtIDProductoUpdate = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonUpdateProductos = new System.Windows.Forms.Button();
            this.txtPrecioProductoUpdate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescripcionProductoUpdate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreProductoUpdate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewConsultaProductos = new System.Windows.Forms.DataGridView();
            this.errorProviderProductosUpdate = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultaProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProductosUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIDProductoUpdate
            // 
            this.txtIDProductoUpdate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDProductoUpdate.Location = new System.Drawing.Point(115, 37);
            this.txtIDProductoUpdate.Name = "txtIDProductoUpdate";
            this.txtIDProductoUpdate.Size = new System.Drawing.Size(138, 22);
            this.txtIDProductoUpdate.TabIndex = 3;
            this.txtIDProductoUpdate.TextChanged += new System.EventHandler(this.TxtIDProductoUpdate_TextChanged);
            this.txtIDProductoUpdate.Validating += new System.ComponentModel.CancelEventHandler(this.TxtIDProductoUpdate_Validating);
            this.txtIDProductoUpdate.Validated += new System.EventHandler(this.TxtIDProductoUpdate_Validated);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonUpdateProductos);
            this.panel1.Controls.Add(this.txtPrecioProductoUpdate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtDescripcionProductoUpdate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtNombreProductoUpdate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtIDProductoUpdate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(15, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 292);
            this.panel1.TabIndex = 4;
            // 
            // buttonUpdateProductos
            // 
            this.buttonUpdateProductos.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonUpdateProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdateProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateProductos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateProductos.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonUpdateProductos.Location = new System.Drawing.Point(115, 239);
            this.buttonUpdateProductos.Name = "buttonUpdateProductos";
            this.buttonUpdateProductos.Size = new System.Drawing.Size(100, 29);
            this.buttonUpdateProductos.TabIndex = 12;
            this.buttonUpdateProductos.Text = "Actualizar";
            this.buttonUpdateProductos.UseVisualStyleBackColor = false;
            this.buttonUpdateProductos.Click += new System.EventHandler(this.ButtonUpdateProductos_Click);
            // 
            // txtPrecioProductoUpdate
            // 
            this.txtPrecioProductoUpdate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioProductoUpdate.Location = new System.Drawing.Point(115, 206);
            this.txtPrecioProductoUpdate.MaxLength = 11;
            this.txtPrecioProductoUpdate.Name = "txtPrecioProductoUpdate";
            this.txtPrecioProductoUpdate.Size = new System.Drawing.Size(138, 22);
            this.txtPrecioProductoUpdate.TabIndex = 11;
            this.txtPrecioProductoUpdate.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPrecioProductoUpdate_Validating);
            this.txtPrecioProductoUpdate.Validated += new System.EventHandler(this.TxtPrecioProductoUpdate_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Precio:";
            // 
            // txtDescripcionProductoUpdate
            // 
            this.txtDescripcionProductoUpdate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionProductoUpdate.Location = new System.Drawing.Point(115, 103);
            this.txtDescripcionProductoUpdate.MaxLength = 150;
            this.txtDescripcionProductoUpdate.Multiline = true;
            this.txtDescripcionProductoUpdate.Name = "txtDescripcionProductoUpdate";
            this.txtDescripcionProductoUpdate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcionProductoUpdate.Size = new System.Drawing.Size(138, 94);
            this.txtDescripcionProductoUpdate.TabIndex = 9;
            this.txtDescripcionProductoUpdate.Validating += new System.ComponentModel.CancelEventHandler(this.TxtDescripcionProductoUpdate_Validating);
            this.txtDescripcionProductoUpdate.Validated += new System.EventHandler(this.TxtDescripcionProductoUpdate_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Descripción:";
            // 
            // txtNombreProductoUpdate
            // 
            this.txtNombreProductoUpdate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProductoUpdate.Location = new System.Drawing.Point(115, 71);
            this.txtNombreProductoUpdate.MaxLength = 50;
            this.txtNombreProductoUpdate.Name = "txtNombreProductoUpdate";
            this.txtNombreProductoUpdate.Size = new System.Drawing.Size(138, 22);
            this.txtNombreProductoUpdate.TabIndex = 7;
            this.txtNombreProductoUpdate.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNombreProductoUpdate_Validating);
            this.txtNombreProductoUpdate.Validated += new System.EventHandler(this.TxtNombreProductoUpdate_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "IDProducto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Actualizar Producto";
            // 
            // dataGridViewConsultaProductos
            // 
            this.dataGridViewConsultaProductos.AllowUserToAddRows = false;
            this.dataGridViewConsultaProductos.AllowUserToDeleteRows = false;
            this.dataGridViewConsultaProductos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewConsultaProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewConsultaProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConsultaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewConsultaProductos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewConsultaProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewConsultaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewConsultaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewConsultaProductos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewConsultaProductos.GridColor = System.Drawing.Color.Gray;
            this.dataGridViewConsultaProductos.Location = new System.Drawing.Point(301, 29);
            this.dataGridViewConsultaProductos.Name = "dataGridViewConsultaProductos";
            this.dataGridViewConsultaProductos.ReadOnly = true;
            this.dataGridViewConsultaProductos.Size = new System.Drawing.Size(751, 515);
            this.dataGridViewConsultaProductos.TabIndex = 5;
            // 
            // errorProviderProductosUpdate
            // 
            this.errorProviderProductosUpdate.ContainerControl = this;
            // 
            // ConsultaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 579);
            this.Controls.Add(this.dataGridViewConsultaProductos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultaProducto";
            this.Text = "ConsultaProductos";
            this.Load += new System.EventHandler(this.ConsultaProductos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultaProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProductosUpdate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtIDProductoUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonUpdateProductos;
        private System.Windows.Forms.TextBox txtPrecioProductoUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescripcionProductoUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreProductoUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewConsultaProductos;
        private System.Windows.Forms.ErrorProvider errorProviderProductosUpdate;
    }
}