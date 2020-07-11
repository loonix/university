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
using Gestao_Notas.CamadaDados;

namespace Gestao_Notas
{
    public partial class FormNotas_ClassBD : Form
    {
        public FormNotas_ClassBD()
        {
            InitializeComponent();
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
                //clickGrid = false;
                //
                //Verificar se o numero já existe na BD
                //
                //
                //1. Abrir BD              
                //
                //2. Criar o comando SQL SELECT a submeter à base de dados
                //
                ClassBD classBD = new ClassBD();
                bool existe = classBD.ProcuraEstudante(TextBoxNumero.Text);

                if (existe == true)
                {
                    //já xiste o numero na BD
                    MessageBox.Show("Numero de estudante já existe!",
                            "Gestao Notas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //não existe estudante
                    //podemos inserir
                    //datareader.Close();

                    //comandoSQL = "INSERT INTO Estudantes (Numero, Nome, [Nota teste], [Nota trabalho]) " +
                    //             "VALUES (@numeroEst, @nomeEst, @notaTeste, @notaTrab)";

                    //comando = new SqlCommand(comandoSQL, Conexao);
                    //comando.Parameters.AddWithValue("numeroEst", TextBoxNumero.Text);
                    //comando.Parameters.AddWithValue("nomeEst", TextBoxNome.Text);
                    //comando.Parameters.AddWithValue("notaTeste", TextBoxNotaTeste.Text);
                    //comando.Parameters.AddWithValue("notaTrab", TextBoxNotaTrabalho.Text);

                    //submeter o comando à bd
                    //comando.ExecuteNonQuery();
                    //Conexao.Close();

                    //TextBoxNumero.Text = "";
                    //TextBoxNome.Text = "";
                    //TextBoxNotaTeste.Text = "";
                    //TextBoxNotaTrabalho.Text = "";

                    //Novo();

                    //PreencheColecaoDados();

                    MessageBox.Show("Estudante inserido com sucesso!",
                           "Gestao Notas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
        }

        private void ButtonAlterar_Click(object sender, EventArgs e)
        {

            //Verificar se o numero já existe na BD
            ClassBD classBD = new ClassBD();
            bool existe = classBD.ProcuraEstudante(TextBoxNumero.Text);

            if (existe == false)
            {
                //já xiste o numero na BD
                MessageBox.Show("Numero de estudante não existe!",
                        "Gestao Notas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
