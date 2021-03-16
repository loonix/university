using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaNegocio
{
    public class Aluno
    {
        #region Propriedades

        private int codigoAluno;

        public int CodigoAluno
        {
            get { return codigoAluno; }
            set { codigoAluno = value; }
        }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }



        #endregion

        #region Metodos
        public void Gravar()
        {
            
        }


        #endregion
    }
}
