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
    public partial class FormBusquedasME : Form
    {
        public FormBusquedasME()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            //this.FormBorderStyle = None;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
