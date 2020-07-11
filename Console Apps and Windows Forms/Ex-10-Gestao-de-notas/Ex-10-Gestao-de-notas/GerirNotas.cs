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

namespace Ex_10_Gestao_de_notas
{
    public partial class GerirNotas : Form
    {
        public GerirNotas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Verificar se os textboxs tem valores
            if (TextBoxNumero.Text == "" || TextBoxNome.Text == "" || TextBoxNotaTeste.Text == "")
            {
                MessageBox.Show("Deve introduzir todos os dados!",
                "Gestao Notas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string strConn;
                strConn = Properties.Settings.Default.StringConexao;
                //Definir a concexao à BD
                SqlConnection Conexao = new SqlConnection(strConn);

                try
                {
                    Conexao.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString(), "Gestao Notas",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //
                //2. Criar o comando SQL SELECT a submeter à base de dados
                //
                SqlCommand comando = new SqlCommand();
                SqlDataReader datareader;
                string comandoSQL;
                comandoSQL = "SELECT * FROM Estudantes WHERE Numero = @numero";
                comando = new SqlCommand(comandoSQL, Conexao);
                comando.Parameters.AddWithValue("Numero", TextBoxNumero.Text);
                datareader = comando.ExecuteReader(); //submete o comando SQL e guardar o resultado

                //verificar se retornou alguma linha
                if (datareader.HasRows)
                {
                    //já existe o numero na BD
                    MessageBox.Show("Numero de estudante já existe!",
                     "Gestao Notas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //não existe estudante
                    //podemos inserir
                    datareader.Close();
                    comandoSQL = "INSERT INTO Estudantes (Numero, Nome, NotaTeste, NotaTrabalho) " +
                    "VALUES (@numero, @nome, @notaTeste, @notaTrabalho)";
                    comando = new SqlCommand(comandoSQL, Conexao);
                    comando.Parameters.AddWithValue("Numero", TextBoxNumero.Text);
                    comando.Parameters.AddWithValue("Nome", TextBoxNome.Text);
                    comando.Parameters.AddWithValue("NotaTeste", TextBoxNotaTeste.Text);
                    comando.Parameters.AddWithValue("NotaTrabalho", TextBoxNotaTrabalho.Text);
                    //submeter o comando à bd
                    comando.ExecuteNonQuery();
                    Conexao.Close();
                    TextBoxNumero.Text = "";
                    TextBoxNome.Text = "";
                    TextBoxNotaTeste.Text = "";
                    TextBoxNotaTrabalho.Text = "";
                    MessageBox.Show("Estudante inserido com sucesso!",
                    "Gestao Notas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            refreshDB();
        }

        private void GerirNotas_Load(object sender, EventArgs e)
        {
            this.estudantesTableAdapter.Fill(this.notasDBDataSet.Estudantes);
        }

        private void refreshDB() {
            this.estudantesTableAdapter.Fill(this.notasDBDataSet.Estudantes);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Verificar se os textboxs tem valores
            if (TextBoxNumero.Text == "")
            {
                MessageBox.Show("Deve introduzir o numero de estudante!",
                "Gestao Notas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                //
                //1. Abrir BD
                string strConn; //parametros de ligação
                strConn = Properties.Settings.Default.StringConexao;
                //Definir a concexao à BD
                SqlConnection Conexao = new SqlConnection(strConn);
                //Abrir DB
                try
                {
                    Conexao.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString(), "Gestao Notas",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //2. Criar o comando SQL UPDATE a submeter à base de dados
                //
                SqlCommand comando = new SqlCommand();
                string comandoSQL;
                comandoSQL = "UPDATE Estudantes " +
                "SET Nome = @nome, " +
                "NotaTeste = @notaTeste " +
                "WHERE Numero = @Numero;";
                comando = new SqlCommand(comandoSQL, Conexao);
                comando.Parameters.AddWithValue("Nome", TextBoxNome.Text);
                comando.Parameters.AddWithValue("NotaTeste", double.Parse(TextBoxNotaTeste.Text));
                comando.Parameters.AddWithValue("Numero", TextBoxNumero.Text);
                //submeter o comando à bd
                int rowsAffected = comando.ExecuteNonQuery();
                Conexao.Close();
                if (rowsAffected > 0)
                    MessageBox.Show("Estudante alterado com sucesso!",
                    "Gestao Notas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TextBoxNumero.Text = "";
                TextBoxNome.Text = "";
                TextBoxNotaTeste.Text = "";
                TextBoxNotaTrabalho.Text = "";
            }
            refreshDB();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Verificar se os textboxs tem valores
            if (TextBoxNumero.Text == "")
            {
                MessageBox.Show("Deve introduzir o numero de estudante!",
                "Gestao Notas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                //
                //1. Abrir BD
                string strConn; //parametros de ligação
                strConn = Properties.Settings.Default.StringConexao;
                //Definir a concexao à BD
                SqlConnection Conexao = new SqlConnection(strConn);
                //Abrir DB
                try
                {
                    Conexao.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString(), "Gestao Notas",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //2. Criar o comando SQL DELETE a submeter à base de dados
                //
                SqlCommand comando = new SqlCommand();
                string comandoSQL;
                comandoSQL = "DELETE FROM Estudantes WHERE Numero = @numero";
                comando = new SqlCommand(comandoSQL, Conexao);
                comando.Parameters.AddWithValue("Numero", TextBoxNumero.Text);
                //submeter o comando à bd
                comando.ExecuteNonQuery();
                Conexao.Close();
                MessageBox.Show("Estudante eliminado com sucesso!",
                "Gestao Notas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TextBoxNumero.Text = "";
                TextBoxNome.Text = "";
                TextBoxNotaTeste.Text = "";
                TextBoxNotaTrabalho.Text = "";
            }
            refreshDB();
        }

        private void TextBoxNumero_Leave(object sender, EventArgs e)
        {
            //Ao sair do Numero, procurar o numero na BD
            //Verificar se os textboxs tem valores
            if (TextBoxNumero.Text == "")
            {
                return; //aborta
            }
            //
            //Verificar se o numero existe na BD
            //
            //
            //1. Abrir BD
            string strConn; //parametros de ligação
            strConn = Properties.Settings.Default.StringConexao;
            //Definir a concexao à BD
            SqlConnection Conexao;//BD SQL
            Conexao = new SqlConnection(strConn);
            //Abrir DB
            try
            {
                Conexao.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString(), "Gestao Notas",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //
            //2. Criar o comando SQL SELECT a submeter à base de dados
            //
            SqlCommand comando = new SqlCommand();
            SqlDataReader datareader;
            string comandoSQL;
            comandoSQL = "SELECT * FROM Estudantes WHERE Numero = @numero";
            comando = new SqlCommand(comandoSQL, Conexao);
            comando.Parameters.AddWithValue("Numero", TextBoxNumero.Text);
            datareader = comando.ExecuteReader(); //submete o comando SQL e guardar o resultado
                                                  //verificar se retornou alguma linha, mostra os dados nos textboxs
            if (datareader.Read())
            {
                TextBoxNumero.Text = datareader["Numero"].ToString();
                TextBoxNome.Text = datareader["Nome"].ToString();
                TextBoxNotaTeste.Text = datareader["NotaTeste"].ToString();
                TextBoxNotaTrabalho.Text = datareader["NotaTrabalho"].ToString();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
