using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_Notas.CamadaDados
{
    class ClassBD
    {
        //Propriedades


        //Metodos
        private SqlConnection AbreBD()
        {
            //string connection
            //a string está armazenda no app.config (Properties)
            // Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =| DataDirectory |\BD\DBnotas.mdf; Integrated Security = True; Connect Timeout = 30
            string StringConn = Properties.Settings.Default.StringConexao;

            //definir objeto para ligar à BD
            SqlConnection sqlConnection = new SqlConnection(StringConn);

            //abrir bd com os parametros
            try
            {
                sqlConnection.Open();
            }
            catch (Exception)
            {
                return null;   
            }

            return sqlConnection;
        }// AbreBD

        public bool ProcuraEstudante(string NumeroEstudante)
        {

            //1. Abrir BD
            SqlConnection sqlConnection = AbreBD();
            //verificar sucesso da abertura
            if (sqlConnection == null)
            {
                return false;
            }

            //2. Criar comando SQL SELECT para submeter à BD
            string SQL;
            SQL = "SELECT * FROM Estudantes WHERE Estudantes.Numero=@CampoNumero";

            SqlCommand sqlCommand = new SqlCommand(SQL, sqlConnection);
            sqlCommand.Parameters.AddWithValue("CampoNumero", NumeroEstudante);
            //ojeto para armazenar o que o resultado do comando (SQL, SELECT....)
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            //verificar se tem linhas o resultado (sqlDataReader)
            if (sqlDataReader.HasRows)
            {
                //tem linhas (registos)
                //se quisermos ler o primeiro registo temos que fazer
               // sqlDataReader.Read();

            }

            //ou...podemos verificar se tem linhas e posiconar-se logo no 1º registo
            if (sqlDataReader.Read())
            {
                //tem linhas (registos) e está no 1º registo
                //estudante existe na tabela
                return true;
            }

            return false;

        }// ProcuraEstudante
    }// ClassBD
}// namespace
