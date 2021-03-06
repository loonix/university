﻿using CodrApp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codr.Core
{
    public class ClassBD
    {

        public class ClassSnippet
        {
            public string id { get; set; }
            public string titulo { get; set; }
            public string descricao { get; set; }
            public int id_categoria { get; set; }
            public string path { get; set; }
        }

        public static SqlConnection AbreBD()
        {
            // Le a connection string a partir das settings do projecto
            string StringConn = Properties.Settings.Default.DB_CodrConnectionString;
            // define objeto para ligar à BD
            SqlConnection sqlConnection = new SqlConnection(StringConn);
            // abre bd com os parametros
            try
            {
                sqlConnection.Open();
            }
            catch (Exception)
            {
                return null;
            }
            return sqlConnection;
        }

        public static DataTable ObterDados(string sql)
        {
            // Abre conexao
            SqlConnection conexao = AbreBD();

            // criacao do comandoSQL
            string comandoSQL = sql;

            // preparar commando
            SqlCommand comando = new SqlCommand();
            comando = new SqlCommand(comandoSQL, conexao);

            DataTable table = new DataTable();
            table.Load(comando.ExecuteReader()); // Carrega os dados para a datatable

            return table;
        }

       
    }
}
