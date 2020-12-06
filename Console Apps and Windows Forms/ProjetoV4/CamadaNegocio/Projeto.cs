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

        #region Construtor

        public Projeto()
        {
            this.idProjeto = string.Empty;
            this.descricao = string.Empty;
            this.dataInicio = DateTime.Today;
            this.dataFim = DateTime.Today;
            this.valor = 0;
            this.grau = GrauEnum.NaoDefinido;
            this.atributo = AtributoProjetoEnum.Nada;
        }

        #endregion

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

        private GrauEnum grau;
        public GrauEnum Grau
        {
            get { return grau; }
            set { grau = value; }
        }

        private AtributoProjetoEnum atributo;

        public AtributoProjetoEnum Atributo
        {
            get { return atributo; }
            set { atributo = value; }
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
            this.Grau = GrauEnum.NaoDefinido;
            this.Atributo = AtributoProjetoEnum.Nada;
        }

        public bool Gravar(out string erro)
        {
            erro = string.Empty;

            bool ok = CamadaDados.Projeto.Gravar(this.IDProjeto, this.Descricao, 
                                                 this.DataInicio, this.DataFim, this.Valor, 
                                                 (int)this.Grau, (int)this.Atributo, out erro);

            return ok;
        }

        public bool Eliminar(out string erro)
        {
            erro = string.Empty;

            bool ok = CamadaDados.Projeto.Eliminar(this.IDProjeto, out erro);

            return ok;
        }

        public static Projeto ObterProjeto(string idProjeto, out string erro)
        {
            Projeto projeto = null;
            erro = string.Empty;
            
            string descricao = string.Empty;
            DateTime dataInicio = DateTime.Today;
            DateTime dataFim = DateTime.Today;
            float valor = 0;
            int grau = 0;
            int atributo = 0;

            bool ok = CamadaDados.Projeto.ObterProjeto(idProjeto, ref descricao, ref dataInicio, ref dataFim, 
                        ref valor, ref grau, ref atributo, out erro);
            if (ok)
            {
                projeto = new Projeto();
                projeto.IDProjeto = idProjeto;
                projeto.Descricao = descricao;
                projeto.DataInicio = dataInicio;
                projeto.DataFim = dataFim;
                projeto.Valor = valor;
                projeto.Grau = (GrauEnum)grau;
                projeto.Atributo = (AtributoProjetoEnum)atributo;
            }

            return projeto;
        }

        public static ProjetoCollection ObterListaProjetos()
        {
            DataTable dataTable = CamadaDados.Projeto.ObterListaProjetos();

            ProjetoCollection projetos = new ProjetoCollection(dataTable);

            return projetos;
        }

        public bool AtributoPago()
        {
            bool ok = false;

            ok = (this.Atributo & AtributoProjetoEnum.Pago) == AtributoProjetoEnum.Pago;

            return ok;
        }

        #endregion

    }
}
