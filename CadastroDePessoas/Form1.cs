using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Autor: Karine Miranda
 * Elaborado em: 10/02/2019
 * Úlima alteração em: 17/02/2019
 */

namespace CadastroDePessoas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if (validacaoDosDados())
            {
                adicionaPessoaNoBD();
                MessageBox.Show("Pessoa adicionada com sucesso!", "Cadastro");
                exibePessoasCadastradasNoBD();
                limpaTela();
            }          
        }

        private void buttonExibir_Click(object sender, EventArgs e)
        {
            exibePessoasCadastradasNoBD();
        }


        /*
         * Método que retorna o caractere do gênero selecionado na view.
         */
        private Char generoSelecionado()
        {
            Char genero;
            if (radioButtonFeminino.Checked)
            {
                genero = 'F';
            }
            else
            {
                genero = 'M';
            }
            return genero;
        }


        /*
         * Método que limpa os dados preenchidos pelo usuário na view, após efetuar um cadastro no banco.
         */
        public void limpaTela()
        {
            textBoxNome.Clear();
            dateTimeNascimento.ResetText();
            radioButtonFeminino.Checked = false;
            radioButtonMasculino.Checked = false;
            textBoxLogradouro.Clear();
            textBoxCidade.Clear();
            textBoxEstado.Clear();
            dateTimeCadastro.ResetText();
            richTextBoxObservacao.Clear();
        }

   
        /*
         * Método que realiza teste condicional para verificar se o nome da pessoa foi informado na view.
         */
        private bool validacaoDosDados()
        {
            if(textBoxNome.Text == "")
            {
                MessageBox.Show("Você não informou o nome a ser cadastrado.");
                return false;
            }
            else
            {
                return true;
            }
        }


        /*
         * Método que efetua a conexão com o banco e exibe todas as pessoas cadastradas na tabela pessoa.
         */
        private void exibePessoasCadastradasNoBD()
        {
            //Cria a conexão com o banco de dados.
            String bancoDeDados = "Data Source=MIRANDINHA-PC\\SQLEXPRESS;Initial Catalog=cadastroDePessoa;Integrated Security=True";
            SqlConnection conexao = new SqlConnection(bancoDeDados);

            try
            {
                conexao.Open();

                //Consulta o banco de dados para exibir os dados cadastrados para a tabela pessoa.
                SqlCommand exibeDadosPessoas = new SqlCommand("SELECT * FROM pessoa", conexao);
                SqlDataAdapter consulta = new SqlDataAdapter(exibeDadosPessoas);
                DataTable dadosNaTabela = new DataTable();
                consulta.Fill(dadosNaTabela);
                dataGridViewPessoa.DataSource = dadosNaTabela;
                conexao.Close();
            }
            catch (Exception excecao)
            {
                MessageBox.Show("Erro ao acessar o banco de dados! " + excecao);
            }     
        }


        /*
         * Método que efetua a conexão com o BD e adiciona uma nova pessoa na tabela pessoa.
         */
        private void adicionaPessoaNoBD()
        {
            //Cria a conexão com o banco de dados.
            String bancoDeDados = "Data Source=MIRANDINHA-PC\\SQLEXPRESS;Initial Catalog=cadastroDePessoa;Integrated Security=True";
            SqlConnection conexao = new SqlConnection(bancoDeDados);

            try
            {
                conexao.Open();

                SqlCommand inserePessoa = new SqlCommand("INSERT INTO pessoa VALUES (@nomePessoa, @dataCadastro, " +
                    "@dataNascimento, @endereco, @cidade, @estado, @observacao, @genero)", conexao);
            
                inserePessoa.Parameters.AddWithValue("@nomePessoa", textBoxNome.Text);
                inserePessoa.Parameters.AddWithValue("@dataCadastro", DateTime.Parse(dateTimeCadastro.Text));
                inserePessoa.Parameters.AddWithValue("@dataNascimento", DateTime.Parse(dateTimeNascimento.Text));
                inserePessoa.Parameters.AddWithValue("@endereco", textBoxLogradouro.Text);
                inserePessoa.Parameters.AddWithValue("@cidade", textBoxCidade.Text);
                inserePessoa.Parameters.AddWithValue("@estado", textBoxEstado.Text);
                inserePessoa.Parameters.AddWithValue("@observacao", richTextBoxObservacao.Text);
                inserePessoa.Parameters.AddWithValue("@genero", generoSelecionado());
                inserePessoa.ExecuteNonQuery();

                conexao.Close();
            }
            catch (Exception excecao)
            {
                MessageBox.Show("Erro ao cadastrar no Banco de dados! " + excecao);
            }
        }
    }
}
