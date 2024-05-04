using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ProjetoLojaABC
{
    public partial class frmPesquisar : Form
    {
        public frmPesquisar()
        {
            InitializeComponent();
            desabilitaCampos();
        }
        public void desabilitaCampos()
        {
            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
            txtDescricao.Focus();
        }

        public void buscaPorCodigo(int codigo)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select codFunc+1 from tbfuncionario WHERE codFunc = @codFunc;";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            comm.Parameters.Clear();
            comm.Parameters.Add("@cod", MySqlDbType.Int32, 11).Value = codigo;
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            lstPesquisar.Items.Add(DR.GetInt32(0));


            Conexao.fecharConexao();
        }

        public void buscaPorNome(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select codFunc+1 from tbfuncionario WHERE nome like '@nome';";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            comm.Parameters.Clear();

            comm.Parameters.Add("@cod", MySqlDbType.String, 100).Value = nome;
            
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            while (DR.Read())
            {
                lstPesquisar.Items.Add(DR.GetString(0));
            }
            lstPesquisar.Items.Add(DR.GetInt32(0));


            Conexao.fecharConexao();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (rdbCodigo.Checked == false || rdbNome.Checked == false)
            {
                MessageBox.Show("selecionar pesquisa");
            }
            else
            {


                if (rdbCodigo.Checked)
                {
                    if (txtDescricao.Text.Equals(""))
                    {
                        MessageBox.Show("Não posso pesquisar");
                    }
                    else
                    {
                        //busca por codigo
                        buscaPorNome(Convert.ToString(txtDescricao.Text));
                    }
                }
                else
                {
                    MessageBox.Show("selecionar pesquisa");

                }

                if (rdbNome.Checked)
                {
                    if (txtDescricao.Text.Equals(""))
                    {
                        MessageBox.Show("Não posso pesquisar");
                    }
                    else
                    {
                        //busca por codigo

                    }
                }
                else
                {

                }
            }
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            //lstPesquisar.Items.Clear();
            lstPesquisar.Items.Add(txtDescricao.Text);


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lstPesquisar.Items.Clear();
        }

        private void lstPesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int i = lstPesquisar.SelectedIndex;
            string nome = lstPesquisar.SelectedItem.ToString();
            //MessageBox.Show("o número da linha "+ i + "- "+ nome);
            frmFuncionarios abrir = new frmFuncionarios(nome);
            abrir.Show();
            this.Hide();

        }

        private void txtDescricao_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                lstPesquisar.Items.Add(txtDescricao.Text);
                txtDescricao.Clear();
                txtDescricao.Focus();
            }

        }
    }
}
