using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALTO_VALE.TN_TECNOLOGIA
{
    public partial class FormTecnologia : Form
    {
        public FormTecnologia()
        {
            InitializeComponent();
        }

        private void EscOnClick(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void EditorSqlOnClcik(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F11)
            {
                TN_TECNOLOGIA.EditorSQL.Tela editor = new EditorSQL.Tela();
                editor.ShowDialog();
            }
        }

        private void RightClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStripPadrao.Enabled = true;
                contextMenuStripPadrao.Visible = true;
            }
        }
    }
}
