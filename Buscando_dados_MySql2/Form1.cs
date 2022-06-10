using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buscando_dados_MySql2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtPesquisar_Click(object sender, EventArgs e)
        {
            string conexao = "Server=localhost;Database=produtoscadastrados;Uid=root;Pwd=bruce@#2022;";

            string query = $@"select * from produtos where nome like '{txtCampo.Text}'";



            MySqlConnection mysql = new MySqlConnection(conexao);
            DataTable tabela_Produto = new DataTable();

            try
            {
                mysql.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, mysql);
                adapter.Fill(tabela_Produto);
                dgvTelaBusca.DataSource = tabela_Produto;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao conectar com com banco de dados: {ex.Message}");
            }
            finally
            {
                mysql.Close();
            }

        }

        private void bntBuscarTodos_Click(object sender, EventArgs e)
        {
            string conexao = "Server=localhost;Database=produtoscadastrados;Uid=root;Pwd=bruce@#2022;";

            string query = $@"select * from produtos";



            MySqlConnection mysql = new MySqlConnection(conexao);
            DataTable tabela_Produto = new DataTable();

            try
            {
                mysql.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, mysql);
                adapter.Fill(tabela_Produto);
                dgvTelaBusca.DataSource = tabela_Produto;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao conectar com com banco de dados: {ex.Message}");
            }
            finally
            {
                mysql.Close();
            }

        }

        private void bntFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
