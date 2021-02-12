using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaNegocio
{
    public class TesteCovid19Collection : Collection<TesteCovid19>
    {

        #region Construtores

        public TesteCovid19Collection(DataTable dataTable)
        {
            foreach (DataRow dataRow in dataTable.AsEnumerable())
            {
                TesteCovid19 teste = new TesteCovid19();

                teste.CodTest = dataRow.Field<string>("CodigoTesteCovid19");
                teste.Nome = dataRow.Field<string>("Nome");
                teste.DataTeste = dataRow.Field<DateTime>("DataTeste");
                teste.IdadeCidadao = dataRow.Field<int>("IdadeCidadao");
                teste.ResultadoTeste = dataRow.Field<EnumResultado>("ResultadoTeste");
                this.Add(teste);
            }
        }

        #endregion

        #region Metodos
        public int TotalTestesPositivosEmJaneiroAnoCorrente()
        {
            DateTime today = DateTime.Today;
            int janeiro = 0;

            int count = (from teste in this
                         where (teste.DataTeste.Year == today.Year) && (teste.DataTeste.Month == janeiro)
                         select teste).Count();
            return count;
        }

        public static TesteCovid19Collection ObterListaSimples()
        {
            DataTable dataTable = CamadaDados.TesteCovid19.ObterLista();
            TesteCovid19Collection testes = new TesteCovid19Collection(dataTable);
            return testes;
        }

        #endregion

    }
}
