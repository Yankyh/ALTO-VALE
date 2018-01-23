using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALTO_VALE.Pasta
{
    public partial class Formprincipal : Form
    {
        public Formprincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void EscOnClick(object sender, KeyEventArgs e)
        {
            if  (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
