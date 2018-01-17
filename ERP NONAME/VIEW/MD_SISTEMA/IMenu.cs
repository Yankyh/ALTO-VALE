using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ALTO_VALE.VIEW.MD_SISTEMA;
using ALTO_VALE.VIEW.PS_PESSOA;

namespace ALTO_VALE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void enderecoButtonOnClick(object sender, EventArgs e)
        {
            IPessoaEndereco iPessoaEndereco = new IPessoaEndereco();
            iPessoaEndereco.ShowDialog();
        }

        private void pessoaButtonOnClick(object sender, EventArgs e)
        {
            GPessoa gPessoa = new GPessoa();
            gPessoa.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GCep gCep = new GCep();
            gCep.ShowDialog();
        }

        private void TESTE(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start(@"C:\ALTO_VALE\Documentos\teste.jpg");
        }
    }
}
