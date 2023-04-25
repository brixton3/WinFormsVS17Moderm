using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using WinFormsVS17Modern.Views.Bandejas;
using WinFormsVS17Modern.Views.Configuracion;
using WinFormsVS17Modern.Views.NewExpediente;
using WinFormsVS17Modern.Views.Pruebas;
using Application = System.Windows.Forms.Application;

namespace WinFormsVS17Modern.Views.Principal
{
    public partial class NewPrincipalModerno : Form
    {
        public NewPrincipalModerno()
        {
            InitializeComponent();
        }

        private void NewPrincipalModerno_Load(object sender, EventArgs e)
        {

        }
        //drag forms
        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWind, int wMsg, int wParam, int lParam);

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void tableLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iBtnMaximizar_Click(object sender, EventArgs e)
        {
            //if (WindowState == FormWindowState.Maximized)
            //    WindowState = FormWindowState.Normal;
            //else
            //    WindowState = FormWindowState.Maximized;
        }

        private void iBtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iBtnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewPrincipalModerno_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iBtnBusquedaME_Click(object sender, EventArgs e)
        {
            brixPanel2.Controls.Clear();
            Frm_BandejaME form_busqueda = new Frm_BandejaME();
            form_busqueda.TopLevel = false;
            brixPanel2.Controls.Add(form_busqueda);
            form_busqueda.Show();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            brixPanel2.Controls.Clear();
            FormNewExpediente frm = new FormNewExpediente();
            frm.TopLevel = false;
            brixPanel2.Controls.Add(frm);
            frm.Show();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            brixPanel2.Controls.Clear();
            FormBusquedasME frm = new FormBusquedasME();
            frm.TopLevel = false;
            brixPanel2.Controls.Add(frm);
            frm.Show();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            brixPanel2.Controls.Clear();
            FormRechazados frm = new FormRechazados();
            frm.TopLevel = false;
            brixPanel2.Controls.Add(frm);
            frm.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            brixPanel2.Controls.Clear();
            Frm_BandejaRE form_busqueda = new Frm_BandejaRE();
            form_busqueda.TopLevel = false;
            brixPanel2.Controls.Add(form_busqueda);
            form_busqueda.Show();
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            brixPanel2.Controls.Clear();
            FormBusquedasRE frm = new FormBusquedasRE();
            frm.TopLevel = false;
            brixPanel2.Controls.Add(frm);
            frm.Show();
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            brixPanel2.Controls.Clear();
            Frm_Conf frm = new Frm_Conf();
            frm.TopLevel = false;
            brixPanel2.Controls.Add(frm);
            frm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            brixPanel2.Controls.Clear();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            brixPanel2.Controls.Clear();
        }
    }
}
