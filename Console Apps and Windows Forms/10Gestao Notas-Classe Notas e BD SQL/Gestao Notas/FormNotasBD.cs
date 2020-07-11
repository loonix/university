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

namespace Gestao_Notas
{
    public partial class FormNotasBD : Form
    {
        //Coleção de dados para armazenar todos os estudantes
        List<ClassNotas> listaNotas = new List<ClassNotas>();

        bool clickGrid = false;

        public FormNotasBD()
        {
            InitializeComponent();
        }

        private void FormNotasBD_Load(object sender, EventArgs e)
        {

            FormataGrid();

            PreencheColecaoDados();

        }

        void FormataGrid()
        {
            //Formatar Grid
            //Definir colunas da GRID
            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();

            col1.HeaderText = "Numero";
            col2.HeaderText = "Nome";
            col3.HeaderText = "Nota Teste";
            col4.HeaderText = "Nota Trabalho";

            col1.Width = 100;
            col1.Width = 100;
            col2.Width = 200;
            col3.Width = 100;
            col4.Width = 100;

            dataGridViewEstudantes.Columns.Clear();

            dataGridViewEstudantes.Columns.Add(col1);
            dataGridViewEstudantes.Columns.Add(col2);
            dataGridViewEstudantes.Columns.Add(col3);
            dataGridViewEstudantes.Columns.Add(col4);

            dataGridViewEstudantes.AllowUserToAddRows = false;
            dataGridViewEstudantes.AllowUserToDeleteRows = false;
            dataGridViewEstudantes.ReadOnly = true;
            dataGridViewEstudantes.AutoGenerateColumns = false;

        }

        void PreencheColecaoDados()
        {

            //Preenche a listaNotas com os registos existentes na tabela Estudantes

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
            SqlDataReader datareader; //objeto para armazenar o resultado do SELECT

            string comandoSQL;
            comandoSQL = "SELECT* FROM Estudantes";
            comando = new SqlCommand(comandoSQL, Conexao);
            datareader = comando.ExecuteReader(); //submete o comando SQL e guardar o resultado

            //percorrer todos os registos
            listaNotas.Clear();
            while (datareader.Read())
            {
                //1. Criar um objeto da classe e preencher os campos
                ClassNotas objEstudante = new ClassNotas();
                objEstudante.Numero = datareader["Numero"].ToString();
                objEstudante.Nome = datareader["Nome"].ToString();
                objEstudante.NotaTeste = double.Parse(datareader["Nota teste"].ToString());
                objEstudante.NotaTrabalho = double.Parse(datareader["Nota trabalho"].ToString());

                //2. Adicionar o objeto à coleção
                listaNotas.Add(objEstudante);
            }

            PreencheGrid();
        }

        void PreencheGrid()
        {

            dataGridViewEstudantes.Rows.Clear();
            //percorrer toda a coleçaõ criada na função PreencheColecaoDados
            int linha = 0;
            foreach (ClassNotas registo in listaNotas)
            {
                dataGridViewEstudantes.Rows.Add();
                dataGridViewEstudantes.Rows[linha].Cells[0].Value = registo.Numero.ToString();
                dataGridViewEstudantes.Rows[linha].Cells[1].Value = registo.Nome.ToString();
                dataGridViewEstudantes.Rows[linha].Cells[2].Value = registo.NotaTeste.ToString();
                dataGridViewEstudantes.Rows[linha].Cells[3].Value = registo.NotaTrabalho.ToString();
                linha++;
            }

        }

        private void ButtonNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void ButtonInserir_Click(object sender, EventArgs e)
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
                clickGrid = false;
                //
                //Verificar se o numero já existe na BD
                //

                //
                //1. Abrir BD 
                string strConn; //parametros de ligação

                //strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\BD_Notas.mdb"; //ACCESS
                //strConn = Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =| DataDirectory |\DBnotas.mdf; Integrated Security = True; Connect Timeout = 30 //SQL service

                //Em vez usar o connection string aqui no codigo, vamos buscar ao ficheiro de configuração
                strConn = Properties.Settings.Default.StringConexao;

                //Definir a concexao à BD 
                SqlConnection Conexao;//BD SQL  
                Conexao = new SqlConnection(strConn);
                //ou.. 
                //SqlConnection Conexao2 = new SqlConnection(strConn); 
                //para BD SQL 
                //OleDbConnection Conexao;

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
                comandoSQL = "SELECT * FROM Estudantes WHERE numero = @numeroEstudante";
                comando = new SqlCommand(comandoSQL, Conexao);
                comando.Parameters.AddWithValue("numeroEstudante", TextBoxNumero.Text);

                datareader = comando.ExecuteReader(); //submete o comando SQL e guardar o resultado

                //verificar se retornou alguma linha
                if (datareader.HasRows)
                {
                    //já xiste o numero na BD
                    MessageBox.Show("Numero de estudante já existe!",
                            "Gestao Notas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //não existe estudante
                    //podemos inserir
                    datareader.Close();

                    comandoSQL = "INSERT INTO Estudantes (Numero, Nome, [Nota teste], [Nota trabalho]) " +
                                 "VALUES (@numeroEst, @nomeEst, @notaTeste, @notaTrab)";

                    comando = new SqlCommand(comandoSQL, Conexao);
                    comando.Parameters.AddWithValue("numeroEst", TextBoxNumero.Text);
                    comando.Parameters.AddWithValue("nomeEst", TextBoxNome.Text);
                    comando.Parameters.AddWithValue("notaTeste", TextBoxNotaTeste.Text);
                    comando.Parameters.AddWithValue("notaTrab", TextBoxNotaTrabalho.Text);

                    //submeter o comando à bd
                    comando.ExecuteNonQuery();
                    Conexao.Close();

                    //TextBoxNumero.Text = "";
                    //TextBoxNome.Text = "";
                    //TextBoxNotaTeste.Text = "";
                    //TextBoxNotaTrabalho.Text = "";

                    Novo();

                    PreencheColecaoDados();

                    MessageBox.Show("Estudante inserido com sucesso!",
                           "Gestao Notas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
        }


        private void ButtonAlterar_Click(object sender, EventArgs e)
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
                clickGrid = false;
                //
                //Verificar se o numero existe na BD
                //

                //
                //1. Abrir BD 
                string strConn; //parametros de ligação

                strConn = Properties.Settings.Default.StringConexao;

                //Definir a concexao à BD 
                SqlConnection Conexao;//BD Access 
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
                comandoSQL = "SELECT * FROM Estudantes WHERE numero = @numeroEstudante";
                comando = new SqlCommand(comandoSQL, Conexao);
                comando.Parameters.AddWithValue("numeroEstudante", TextBoxNumero.Text);

                datareader = comando.ExecuteReader(); //submete o comando SQL e guardar o resultado

                //verificar se retornou alguma linha
                if (datareader.HasRows == false)
                {
                    //já xiste o numero na BD
                    MessageBox.Show("Numero de estudante não existe!",
                            "Gestao Notas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //existe estudante
                    //podemos alterar      
                    datareader.Close();

                    comandoSQL = "UPDATE Estudantes " +
                                 "SET Nome = @nomeEst, " +
                                 "[Nota teste] = @notaEst " +
                                 "WHERE Numero = @numeroEst;";

                    comando = new SqlCommand(comandoSQL, Conexao);
                    comando.Parameters.AddWithValue("nomeEst", TextBoxNome.Text);
                    comando.Parameters.AddWithValue("notaEst", double.Parse(TextBoxNotaTeste.Text));
                    comando.Parameters.AddWithValue("numeroEst", TextBoxNumero.Text);

                    //submeter o comando à bd                    
                    int rowsAffected = comando.ExecuteNonQuery();
                    Conexao.Close();
                    if (rowsAffected > 0)
                        MessageBox.Show("Estudante alterado com sucesso!",
                                        "Gestao Notas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    PreencheColecaoDados();

                    Novo();
                }

            }
        }

        private void ButtonEliminar_Click(object sender, EventArgs e)
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
                clickGrid = false;
                //
                //Verificar se o numero existe na BD
                //

                //
                //1. Abrir BD 
                string strConn; //parametros de ligação

                strConn = Properties.Settings.Default.StringConexao;

                //Definir a concexao à BD 
                SqlConnection Conexao;//BD Access 
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
                comandoSQL = "SELECT * FROM Estudantes WHERE numero = @numeroEstudante";
                comando = new SqlCommand(comandoSQL, Conexao);
                comando.Parameters.AddWithValue("numeroEstudante", TextBoxNumero.Text);

                datareader = comando.ExecuteReader(); //submete o comando SQL e guardar o resultado

                //verificar se retornou alguma linha
                if (datareader.HasRows == false)
                {
                    //já xiste o numero na BD
                    MessageBox.Show("Numero de estudante não existe!",
                            "Gestao Notas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //existe estudante
                    //podemos eliminar
                    datareader.Close();

                    comandoSQL = "DELETE FROM Estudantes WHERE Numero = @numeroEst";

                    comando = new SqlCommand(comandoSQL, Conexao);
                    comando.Parameters.AddWithValue("numeroEst", TextBoxNumero.Text);

                    //submeter o comando à bd
                    comando.ExecuteNonQuery();
                    Conexao.Close();

                    MessageBox.Show("Estudante eliminado com sucesso!",
                           "Gestao Notas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    PreencheColecaoDados();

                    Novo();

                }
            }
        }


        void Novo()
        {
            TextBoxNumero.Text = "";
            TextBoxNome.Text = "";
            TextBoxNotaTeste.Text = "";
            TextBoxNotaTrabalho.Text = "";

            TextBoxNumero.Focus();
        }

        private void ButtonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridViewEstudantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            clickGrid = true;
        }

        private void dataGridViewEstudantes_Enter(object sender, EventArgs e)
        {
            clickGrid = true;
        }

        private void dataGridViewEstudantes_SelectionChanged(object sender, EventArgs e)
        {
            //int rowIndex = e.RowIndex;

            if (clickGrid == false)
                return; //aborta

            try
            {
                if (dataGridViewEstudantes.CurrentRow != null)
                {
                    int rowIndex = dataGridViewEstudantes.CurrentRow.Index;
                    DataGridViewRow row = dataGridViewEstudantes.Rows[rowIndex];

                    //if (row.Cells.Count > 2)
                    //{
                        TextBoxNumero.Text = row.Cells[0].Value.ToString();
                        TextBoxNome.Text = row.Cells[1].Value.ToString();
                        TextBoxNotaTeste.Text = row.Cells[2].Value.ToString();
                        TextBoxNotaTrabalho.Text = row.Cells[3].Value.ToString();
                    //}
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro" + erro.Message);
            }

        }

        private void TextBoxNumero_TextChanged(object sender, EventArgs e)
        {

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
            comandoSQL = "SELECT * FROM Estudantes WHERE numero = @numeroEstudante";
            comando = new SqlCommand(comandoSQL, Conexao);
            comando.Parameters.AddWithValue("numeroEstudante", TextBoxNumero.Text);

            datareader = comando.ExecuteReader(); //submete o comando SQL e guardar o resultado

            //verificar se retornou alguma linha, mostra os dados nos textboxs
            if (datareader.Read())
            {
                TextBoxNumero.Text = datareader["Numero"].ToString();
                TextBoxNome.Text = datareader["Nome"].ToString();
                TextBoxNotaTeste.Text = datareader["Nota teste"].ToString();
                TextBoxNotaTrabalho.Text = datareader["Nota trabalho"].ToString();
            }

        }


    }//form
}//namespace
