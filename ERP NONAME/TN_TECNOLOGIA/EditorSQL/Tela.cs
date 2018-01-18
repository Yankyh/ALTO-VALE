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
            String query;
            DAL.Connection conexao = new DAL.Connection();

            if (e.KeyChar == 13)
            {
                query = textSQL.Text;
                conexao.Conectar();
                BindingSource bind = new BindingSource();

                gridSQL.AutoGenerateColumns = true;
            
                    bind.DataSource = conexao.DataTable(query);
                    gridSQL.DataSource = bind;
                    gridSQL.AllowUserToResizeRows = true;
             




            }
        }
    }
}
