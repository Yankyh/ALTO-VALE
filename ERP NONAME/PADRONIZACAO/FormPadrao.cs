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

      

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F11:
                    TN_TECNOLOGIA.EditorSQL.Tela editor = new TN_TECNOLOGIA.EditorSQL.Tela();
                    editor.ShowDialog();
                    return true;
                case Keys.Escape:
                    this.Close();
                    return true;
            }
            return base.ProcessDialogKey(keyData);
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
