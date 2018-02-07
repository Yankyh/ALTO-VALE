using ALTO_VALE.DAL;
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
    public partial class ComboBoxDataGridView : Form
    {
        Connection connection = new Connection();
        BindingSource Binding = new BindingSource();
        private static String valorSelecionado = "";
        public ComboBoxDataGridView()
        {
            InitializeComponent();
        }

        public String BuscarValor(String campo, String tabela)
        {
            connection.Conectar();
            String query = "";

            query = " SELECT " + campo + " FROM "+tabela+"";

            Binding.DataSource = connection.DataTable(query);
            menuDataGridView.DataSource = Binding;

            menuDataGridView.Columns[0].Width = 300;
            this.ShowDialog();

            connection.Desconectar();
            return valorSelecionado;
        }

        private void CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valorSelecionado = (menuDataGridView.CurrentRow.Cells[0].Value).ToString();
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }
    }
}
