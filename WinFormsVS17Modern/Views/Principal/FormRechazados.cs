using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsVS17Modern.Views.Principal
{
    public partial class FormRechazados : Form
    {
        public FormRechazados()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
