using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALTO_VALE.TN_TECNOLOGIA.EditorSQL
{
    public partial class Tela : Form
    {
        public Tela()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            String textoTeste;
            if(e.KeyChar == 13)
            {
                textoTeste = textSQL.Text;
                MessageBox.Show(textoTeste);
            }
        }
    }
}
