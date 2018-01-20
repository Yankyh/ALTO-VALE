using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALTO_VALE.VIEW.MD_SISTEMA
{
    public partial class TelaPadrao : Form
    {
        public TelaPadrao()
        {
            InitializeComponent();
            Form1 iMenu = new Form1();
            this.Enabled = false;
            iMenu.MdiParent = this;
            iMenu.Show();
      
        }
    }
}
