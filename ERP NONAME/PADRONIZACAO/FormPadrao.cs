using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALTO_VALE.PADRONIZACAO
{
    public partial class FormPadrao : Form
    {
        public FormPadrao()
        {
            InitializeComponent();
        }

        private void EscOnClick(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.F11)
            {
                TN_TECNOLOGIA.EditorSQL.Tela editor = new TN_TECNOLOGIA.EditorSQL.Tela();
                editor.ShowDialog();
            }
        }

        private void RightClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                contextMenuStripPrincipal.Enabled = true;
                contextMenuStripPrincipal.Visible = true;
            }
        }
    }
}
