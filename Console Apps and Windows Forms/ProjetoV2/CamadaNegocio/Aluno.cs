
using System;
using System.Data;

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

        private DateTime dataNascimento;
        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }

        private string telefone;
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        #endregion

        #region Metodos

        public void Novo()
        {
            DateTime data = DateTime.Today;

            this.CodigoAluno = 0;
            this.Nome = string.Empty;
            this.DataNascimento = new DateTime(data.Year, 1, 1);
            this.Telefone = "+351 ";
        }

        public bool Gravar(out string erro)
        {
            erro = string.Empty;

            bool ok = CamadaDados.Aluno.Gravar(this.CodigoAluno, this.Nome,
                                               this.DataNascimento, this.Telefone, out erro);

            return ok;
        }

        public bool Eliminar(out string erro)
        {
            erro = string.Empty;

            bool ok = CamadaDados.Aluno.Eliminar(this.CodigoAluno, out erro);

            return ok;
        }

        public static Aluno ObterAluno(int codigoAluno)
        {
            Aluno aluno = null;

            string nome = string.Empty;
            DateTime dataNascimento = DateTime.Today;
            string telefone = string.Empty;

            bool ok = CamadaDados.Aluno.ObterAluno(codigoAluno, ref nome, ref dataNascimento, ref telefone);
            if (ok)
            {
                aluno = new Aluno();
                aluno.CodigoAluno = codigoAluno;
                aluno.Nome = nome;
                aluno.DataNascimento = dataNascimento;
                aluno.telefone = telefone;
            }

            return aluno;
        }

        public static AlunoCollection ObterListaProjetos()
        {
            DataTable dataTable = CamadaDados.Aluno.ObterListaAlunos();

            AlunoCollection alunos = new AlunoCollection(dataTable);

            return alunos;
        }

        #endregion

    }
}
