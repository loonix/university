using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaNegocio
{
    public class AlunoCollection : List<Aluno>
    {

        public AlunoCollection(DataTable dataTable)
        {
            if (dataTable != null)
            {
                foreach (DataRow dataRow in dataTable.AsEnumerable())
                {
                    Aluno aluno = new Aluno();

                    aluno.CodigoAluno = dataRow.Field<int>("CodigoAluno");
                    aluno.Nome = dataRow.Field<string>("Nome"); 
                    aluno.DataNascimento = dataRow.Field<DateTime>("DataNascimento"); 
                    aluno.Telefone = dataRow.Field<string>("Telefone"); 

                    this.Add(aluno);
                }   
            }
        }

    }
}
