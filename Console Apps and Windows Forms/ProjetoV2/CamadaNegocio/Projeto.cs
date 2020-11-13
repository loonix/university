using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaNegocio
{
    public class Projeto
    {

        #region Propriedades

        private string idProjeto;

        public string IDProjeto
        {
            get { return idProjeto; }
            set { idProjeto = value; }
        }

        private string descricao;

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        private DateTime dataInicio;

        public DateTime DataInicio
        {
            get { return dataInicio; }
            set { dataInicio = value; }
        }

        private DateTime dataFim;

        public DateTime DataFim
        {
            get { return dataFim; }
            set { dataFim = value; }
        }

        private float valor;

        public float Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        #endregion

        #region Metodos

        public void Novo()
        {
            DateTime data = DateTime.Today;

            this.IDProjeto = string.Empty;
            this.Descricao = string.Empty;
            this.DataInicio = new DateTime(data.Year, data.Month, 1);
            this.DataFim = this.DataInicio.AddMonths(1).AddDays(-1);
            this.Valor = 0;
        }

        public bool Gravar(out string erro)
        {
            erro = string.Empty;

            bool ok = CamadaDados.Projeto.Gravar(this.IDProjeto, this.Descricao, 
                                                 this.DataInicio, this.DataFim, this.Valor, out erro);

            return ok;
        }

        public bool Eliminar(out string erro)
        {
            erro = string.Empty;

            bool ok = CamadaDados.Projeto.Eliminar(this.IDProjeto, out erro);

            return ok;
        }

        public static Projeto ObterProjeto(string idProjeto)
        {
            Projeto projeto = null;

            string descricao = string.Empty;
            DateTime dataInicio = DateTime.Today;
            DateTime dataFim = DateTime.Today;
            float valor = 0;

            bool ok = CamadaDados.Projeto.ObterProjeto(idProjeto, ref descricao, ref dataInicio, ref dataFim, ref valor);
            if (ok)
            {
                projeto = new Projeto();
                projeto.IDProjeto = idProjeto;
                projeto.Descricao = descricao;
                projeto.DataInicio = dataInicio;
                projeto.DataFim = dataFim;
                projeto.Valor = valor;
            }

            return projeto;
        }

        public static ProjetoCollection ObterListaProjetos()
        {
            DataTable dataTable = CamadaDados.Projeto.ObterListaProjetos();

            ProjetoCollection projetos = new ProjetoCollection(dataTable);

            return projetos;
        }

        #endregion

    }
}
