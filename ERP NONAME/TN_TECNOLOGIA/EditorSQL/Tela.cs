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

        }

        private void textSQL_KeyDown(object sender, KeyEventArgs e)
        {
            String sQuery;
            if (e.KeyCode == Keys.F5)
            {
                if (String.IsNullOrEmpty(textSQL.Text))
                {
                    MessageBox.Show("pesquisa incorreta");
                }
                else if ( String.IsNullOrEmpty(textSQL.SelectedText))
                {
                    sQuery = textSQL.Text;
                    DAL.Connection conexao = new DAL.Connection();
                    conexao.Conectar();
                    BindingSource bind = new BindingSource();
                    bind.DataSource = conexao.DataTable(sQuery);
                    gridSQL.AutoGenerateColumns = true;
                    gridSQL.DataSource = bind.DataSource;
                }
                else
                {
                    sQuery = textSQL.SelectedText;
                    DAL.Connection conexao = new DAL.Connection();
                    conexao.Conectar();
                    BindingSource bind = new BindingSource();
                    bind.DataSource = conexao.DataTable(sQuery);
                    gridSQL.AutoGenerateColumns = true;
                    gridSQL.DataSource = bind.DataSource;
                }

                
            }
        }

        private void Tela_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
