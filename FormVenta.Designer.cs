namespace AppCyberSC
{
    partial class FormVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVenta));
            this.label2 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonInsertVenta = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtFCreacion = new System.Windows.Forms.TextBox();
            this.errorProviderVenta = new System.Windows.Forms.ErrorProvider(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Producto";
            // 
            // txtProducto
            // 
            this.txtProducto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(16, 52);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(153, 22);
            this.txtProducto.TabIndex = 9;
            this.txtProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtProducto_KeyPress);
            this.txtProducto.Validating += new System.ComponentModel.CancelEventHandler(this.TxtProducto_Validating);
            this.txtProducto.Validated += new System.EventHandler(this.TxtProducto_Validated);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonInsertVenta);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.txtPrecio);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtCantidad);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtProducto);
            this.panel1.Location = new System.Drawing.Point(15, 212);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 146);
            this.panel1.TabIndex = 3;
            // 
            // buttonInsertVenta
            // 
            this.buttonInsertVenta.BackColor = System.Drawing.Color.Green;
            this.buttonInsertVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonInsertVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInsertVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsertVenta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertVenta.ForeColor = System.Drawing.Color.White;
            this.buttonInsertVenta.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonInsertVenta.Location = new System.Drawing.Point(784, 41);
            this.buttonInsertVenta.Name = "buttonInsertVenta";
            this.buttonInsertVenta.Size = new System.Drawing.Size(85, 33);
            this.buttonInsertVenta.TabIndex = 14;
            this.buttonInsertVenta.Text = "Registrar";
            this.buttonInsertVenta.UseVisualStyleBackColor = false;
            this.buttonInsertVenta.Click += new System.EventHandler(this.ButtonInsertVenta_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(658, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Green;
            this.txtTotal.Location = new System.Drawing.Point(658, 58);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(120, 16);
            this.txtTotal.TabIndex = 13;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(541, 52);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(81, 22);
            this.txtPrecio.TabIndex = 12;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecio_KeyPress);
            this.txtPrecio.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPrecio_Validating);
            this.txtPrecio.Validated += new System.EventHandler(this.TxtPrecio_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(541, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Precio";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(419, 52);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(88, 22);
            this.txtCantidad.TabIndex = 11;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantidad_KeyPress);
            this.txtCantidad.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCantidad_Validating);
            this.txtCantidad.Validated += new System.EventHandler(this.TxtCantidad_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(419, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cantidad";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(192, 52);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(190, 66);
            this.txtDescripcion.TabIndex = 10;
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDescripcion_KeyPress);
            this.txtDescripcion.Validating += new System.ComponentModel.CancelEventHandler(this.TxtDescripcion_Validating);
            this.txtDescripcion.Validated += new System.EventHandler(this.TxtDescripcion_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(192, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descripción";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(15, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 104);
            this.button1.TabIndex = 1;
            this.toolTip.SetToolTip(this.button1, "Impresión, Copias, B/N");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtFCreacion
            // 
            this.txtFCreacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFCreacion.BackColor = System.Drawing.Color.White;
            this.txtFCreacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFCreacion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFCreacion.Location = new System.Drawing.Point(959, 12);
            this.txtFCreacion.Name = "txtFCreacion";
            this.txtFCreacion.ReadOnly = true;
            this.txtFCreacion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFCreacion.Size = new System.Drawing.Size(109, 19);
            this.txtFCreacion.TabIndex = 11;
            this.txtFCreacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // errorProviderVenta
            // 
            this.errorProviderVenta.ContainerControl = this;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(140, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 104);
            this.button2.TabIndex = 2;
            this.toolTip.SetToolTip(this.button2, "Impresión, Copias, Color");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(265, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 104);
            this.button3.TabIndex = 3;
            this.toolTip.SetToolTip(this.button3, "Curp");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(390, 74);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 104);
            this.button4.TabIndex = 4;
            this.toolTip.SetToolTip(this.button4, "Scanneo");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Location = new System.Drawing.Point(515, 74);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 104);
            this.button5.TabIndex = 5;
            this.toolTip.SetToolTip(this.button5, "Folder Carta");
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Location = new System.Drawing.Point(640, 74);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(119, 104);
            this.button6.TabIndex = 6;
            this.toolTip.SetToolTip(this.button6, "Folder Oficio");
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Location = new System.Drawing.Point(765, 74);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(119, 104);
            this.button7.TabIndex = 7;
            this.toolTip.SetToolTip(this.button7, "Copia CD");
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(890, 74);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(119, 104);
            this.button8.TabIndex = 8;
            this.button8.Text = "Otros Servicios";
            this.toolTip.SetToolTip(this.button8, "Otros Servicios");
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(637, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(520, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "$";
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 618);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtFCreacion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVenta";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "FormVenta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonInsertVenta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtFCreacion;
        private System.Windows.Forms.ErrorProvider errorProviderVenta;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
    }
}