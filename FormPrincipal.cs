using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AppCyberSC
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BtnInicio_Click(null, e);
        }

        //*****************************************************
        //Agrega el poder mover la ventana de lugar desde la barra de titulo.
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lparam);
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //*****************************************************

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Capturar posición y tamaño antes de maximizar para restaurar
        int lx, ly;
        int sw, sh;
        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = PanelContenedor.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                //formulario.FormBorderStyle = FormBorderStyle.None;
                //formulario.Dock = DockStyle.Fill;
                PanelContenedor.Controls.Add(formulario);
                PanelContenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(EffectColorButtons);
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void AbrirFormHijo(object formhijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form newMDIChild = formhijo as Form;
            newMDIChild.TopLevel = false;
            newMDIChild.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(newMDIChild);
            this.PanelContenedor.Tag = newMDIChild;
            //newMDIChild.MdiParent = this;
            newMDIChild.Show();
            newMDIChild.FormClosed += new FormClosedEventHandler(EffectColorButtons);
        }
        private void BtnInicio_Click(object sender, EventArgs e)
        {
            CerrarFormsHijos();
            //AbrirFormulario<InicioApp>();
            AbrirFormHijo(new InicioApp());
            hideSubMenu();
        }

        private void buttonMenu1_Click(object sender, EventArgs e)
        {
            CerrarFormsHijos();
            //AbrirFormulario<FormVenta>();
            AbrirFormHijo(new FormVenta());
            buttonMenu1.BackColor = Color.FromArgb(0, 128, 128);
            hideSubMenu();
        }

        private void buttonMenu2_Click(object sender, EventArgs e)
        {
            CerrarFormsHijos();
            //AbrirFormulario<FormVenta>();
            AbrirFormHijo(new FormReparacion());
            buttonMenu2.BackColor = Color.FromArgb(0, 128, 128);
            hideSubMenu();
        }

        private void buttonMenu3_Click(object sender, EventArgs e)
        {
            CerrarFormsHijos();
            //AbrirFormulario<ConsultaVentas>();
            AbrirFormHijo(new FormGasto());
            buttonMenu3.BackColor = Color.FromArgb(0, 128, 128);
            hideSubMenu();
        }

        private void buttonMenu4_Click(object sender, EventArgs e)
        {
            CerrarFormsHijos();
            //AbrirFormulario<ConsultaVentas>();
            AbrirFormHijo(new ConsultaProducto());
            buttonMenu4.BackColor = Color.FromArgb(0, 128, 128);
            hideSubMenu();
        }
        private void buttonMenu5_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenu5);
        }

        private void button1SubMenu5_Click(object sender, EventArgs e)
        {
            CerrarFormsHijos();
            //AbrirFormulario<ConsultaVentas>();
            AbrirFormHijo(new AdminVenta());
            buttonMenu5.BackColor = Color.FromArgb(0, 128, 128);
            panel1SubMenu5.BackColor = Color.FromArgb(0, 128, 128);
            //hideSubMenu();
        }

        private void button2SubMenu5_Click(object sender, EventArgs e)
        {
            CerrarFormsHijos();
            //AbrirFormulario<ConsultaVentas>();
            AbrirFormHijo(new AdminReparacion());
            buttonMenu5.BackColor = Color.FromArgb(0, 128, 128);
            panel2SubMenu5.BackColor = Color.FromArgb(0, 128, 128);
            //hideSubMenu();
        }

        private void button3SubMenu5_Click(object sender, EventArgs e)
        {
            CerrarFormsHijos();
            //AbrirFormulario<ConsultaVentas>();
            AbrirFormHijo(new AdminGasto());
            buttonMenu5.BackColor = Color.FromArgb(0, 128, 128);
            panel3SubMenu5.BackColor = Color.FromArgb(0, 128, 128);
            //hideSubMenu();
        }

        private void buttonMenu6_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenu6);
        }

        private void button1SubMenu6_Click(object sender, EventArgs e)
        {
            CerrarFormsHijos();
            //AbrirFormulario<ConsultaVentas>();
            AbrirFormHijo(new ConsultaVenta());
            buttonMenu6.BackColor = Color.FromArgb(0, 128, 128);
            panel1SubMenu6.BackColor = Color.FromArgb(0, 128, 128);
            //hideSubMenu();
        }

        private void button2SubMenu6_Click(object sender, EventArgs e)
        {
            CerrarFormsHijos();
            //AbrirFormulario<ConsultaVentas>();
            AbrirFormHijo(new ConsultaReparacion());
            buttonMenu6.BackColor = Color.FromArgb(0, 128, 128);
            panel2SubMenu6.BackColor = Color.FromArgb(0, 128, 128);
            //hideSubMenu();
        }

        private void button3SubMenu6_Click(object sender, EventArgs e)
        {
            CerrarFormsHijos();
            //AbrirFormulario<ConsultaVentas>();
            AbrirFormHijo(new ConsultaGasto());
            buttonMenu6.BackColor = Color.FromArgb(0, 128, 128);
            panel3SubMenu6.BackColor = Color.FromArgb(0, 128, 128);
            //hideSubMenu();
        }

        private void buttonMenu7_Click(object sender, EventArgs e)
        {
            CerrarFormsHijos();
            //AbrirFormulario<ConsultaVentas>();
            AbrirFormHijo(new Estadisticas());
            buttonMenu7.BackColor = Color.FromArgb(0, 128, 128);
            hideSubMenu();
        }

        private void hideSubMenu()
        {
            if (panelSubMenu5.Visible == true)
                panelSubMenu5.Visible = false;
            if (panelSubMenu6.Visible == true)
                panelSubMenu6.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        //Cierra los forms hijos que detecta abiertos
        private void CerrarFormsHijos()
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            else
            {
                Form[] formsList = Application.OpenForms.Cast<Form>().Where(x => x.Name == "InicioApp" || x.Name == "Login" || x.Name == "FormVenta" || x.Name == "FormReparacion" || x.Name == "FormGasto" || x.Name == "AdminVenta" || x.Name == "AdminReparacion" || x.Name == "AdminGasto" || x.Name == "ConsultaVenta" || x.Name == "ConsultaReparacion" || x.Name == "ConsultaGasto" || x.Name == "ConsultaProducto" || x.Name == "Estadisticas").ToArray();
                foreach (Form openForm in formsList)
                {
                    openForm.Close();
                }
            }
        }

        //Permite que el menu lateral se despliegue y contraiga.
        //private void pictureBoxMenu_Click(object sender, EventArgs e)
        //{
        //    if (MenuVertical.Width == 220)
        //    {
        //        MenuVertical.Width = 69;
        //    }
        //    else
        //        MenuVertical.Width = 220;
        //}

        private void pictureBoxLogIn_Click(object sender, EventArgs e)
        {
            CerrarFormsHijos();
            Login fm = new Login();
            fm.Show();
            this.Hide();

            FormPrincipal form = new FormPrincipal();
            form.Hide();
            form.Close();
        }

        private void pictureBoxLogout_Click(object sender, EventArgs e)
        {
            //this.Close();
            //Login FPrincipal = new Login();
            //FPrincipal.Show();
            CerrarFormsHijos();
            AbrirFormHijo(new InicioApp());

            buttonMenu4.Visible = false;
            buttonMenu5.Visible = false;
            buttonMenu6.Visible = false;
            panelSubMenu5.Visible = false;
            panelSubMenu6.Visible = false;
            buttonMenu7.Visible = false;

            pictureBoxLogIn.Visible = true;
            pictureBoxLogout.Visible = false;
            labelAdmin.Visible = false;

            //InicioApp estadisticas = new InicioApp();
            //estadisticas.lblFechaInicio.Visible = false;
            //estadisticas.lblFechaFin.Visible = false;
            //estadisticas.lblTotalVentas.Visible = false;
            //estadisticas.lbl1.Visible = false;
            //estadisticas.lblTotalReparaciones.Visible = false;
            //estadisticas.lbl2.Visible = false;
            //estadisticas.lblTotalGastos.Visible = false;
            //estadisticas.lbl3.Visible = false;
        }

        //Colorea el botón del formulario que se encuentra abierto.
        //Si el formulario no está abierto lo deja con el color default.
        private void EffectColorButtons(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["FormVenta"] == null)
                buttonMenu1.BackColor = Color.FromArgb(26, 32, 40);

            if (Application.OpenForms["FormEquipo"] == null)
                buttonMenu2.BackColor = Color.FromArgb(26, 32, 40);

            if (Application.OpenForms["FormGasto"] == null)
                buttonMenu3.BackColor = Color.FromArgb(26, 32, 40);

            if (Application.OpenForms["ConsultaProducto"] == null)
                buttonMenu4.BackColor = Color.FromArgb(26, 32, 40);

            //SubMenu5
            if (Application.OpenForms["AdminVenta"] == null)
                buttonMenu5.BackColor = Color.FromArgb(26, 32, 40);
            panel1SubMenu5.BackColor = Color.FromArgb(26, 32, 40);

            if (Application.OpenForms["AdminReparacion"] == null)
                buttonMenu5.BackColor = Color.FromArgb(26, 32, 40);
            panel2SubMenu5.BackColor = Color.FromArgb(26, 32, 40);

            if (Application.OpenForms["AdminGasto"] == null)
                buttonMenu5.BackColor = Color.FromArgb(26, 32, 40);
            panel3SubMenu5.BackColor = Color.FromArgb(26, 32, 40);

            //SubMenu6
            if (Application.OpenForms["ConsultaVenta"] == null)
                buttonMenu6.BackColor = Color.FromArgb(26, 32, 40);
            panel1SubMenu6.BackColor = Color.FromArgb(26, 32, 40);

            if (Application.OpenForms["ConsultaReparacion"] == null)
                buttonMenu6.BackColor = Color.FromArgb(26, 32, 40);
            panel2SubMenu6.BackColor = Color.FromArgb(26, 32, 40);

            if (Application.OpenForms["ConsultaGasto"] == null)
                buttonMenu6.BackColor = Color.FromArgb(26, 32, 40);
            panel3SubMenu6.BackColor = Color.FromArgb(26, 32, 40);

            //Menu7
            if (Application.OpenForms["Estadisticas"] == null)
                buttonMenu7.BackColor = Color.FromArgb(26, 32, 40);
        }

    }
}
