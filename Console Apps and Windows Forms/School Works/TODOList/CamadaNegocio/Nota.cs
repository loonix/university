using System;
using System.Data;

namespace CamadaNegocio
{
    public class Nota
    {
        #region Construtor
        public Nota()
        {
            this.idNota = Guid.NewGuid().ToString();
            this.titulo = string.Empty;
            this.dataCriacao = DateTime.Today;
            this.dataExpiracao = DateTime.Today.AddDays(7);
            this.tags = TagsEnum.NaoDefinido;
            this.conteudo = string.Empty;
            this.destaque = false;
        }

        #endregion

        #region Propriedades

        private string idNota;
        public string IDNota { get => idNota; set => idNota = value; }

        private string titulo;
        public string Titulo { get => titulo; set => titulo = value; }

        private DateTime dataCriacao;
        public DateTime DataCriacao { get => dataCriacao; set => dataCriacao = value; }

        private DateTime dataExpiracao;
        public DateTime DataExpiracao { get => dataExpiracao; set => dataExpiracao = value; }

        private TagsEnum tags;
        public TagsEnum Tags { get => tags; set => tags = value; }

        private string conteudo;
        public string Conteudo { get => conteudo; set => conteudo = value; }

        private bool destaque;
        public bool Destaque { get => destaque; set => destaque = value; }

        #endregion

        #region Metodos

        /// <summary>
        /// Cria uma nova nota com valores por defeito
        /// </summary>
        public void Nova()
        {
            DateTime data = DateTime.Today;

            this.IDNota = Guid.NewGuid().ToString();
            this.titulo = string.Empty;
            this.DataCriacao = DateTime.Today;
            this.DataExpiracao = DateTime.Today.AddDays(7);
            this.Tags = TagsEnum.NaoDefinido;
            this.Conteudo = string.Empty;
            this.Destaque = false;
        }

        /// <summary>
        /// Funcao que guarda os valores
        /// </summary>
        /// <param name="erro"></param>
        /// <returns></returns>
        public bool Gravar(out string erro)
        {
            erro = string.Empty;
            bool ok = CamadaDados.Nota.Gravar((string)this.IDNota, (string)this.Titulo, (DateTime)this.DataCriacao,
                                              (DateTime)this.DataExpiracao, (Int32)this.Tags, (string)this.Conteudo,
                                              (Boolean)this.Destaque, out erro);
            return ok;
        }

        /// <summary>
        /// Funcao que elimina a nota
        /// </summary>
        /// <param name="erro"></param>
        /// <returns></returns>
        public bool Eliminar(out string erro)
        {
            erro = string.Empty;
            bool ok = CamadaDados.Nota.Eliminar(this.IDNota, out erro);
            return ok;
        }

        /// <summary>
        /// Obtem uma nota especifica
        /// </summary>
        /// <param name="idNota"></param>
        /// <param name="erro"></param>
        /// <returns></returns>
        public static Nota ObterNota(string idNota, out string erro)
        {
            Nota nota = null;
            erro = string.Empty;

            string titulo = string.Empty;
            DateTime dataCriacao = DateTime.Today;
            DateTime dataExpiracao = DateTime.Today.AddDays(7);
            int tags = 0;
            string conteudo = string.Empty;
            Boolean destaque = false;

            bool ok = CamadaDados.Nota.Obter(idNota, ref titulo, ref dataCriacao, ref dataExpiracao, ref tags, ref conteudo, ref destaque, out erro);
            if (ok)
            {
                nota = new Nota();
                nota.Titulo = titulo;
                nota.DataCriacao = dataCriacao;
                nota.DataExpiracao = dataExpiracao;
                nota.Tags = (TagsEnum)tags;
                nota.Conteudo = conteudo;
                nota.Destaque = destaque;
            }
            return nota;
        }

        /// <summary>
        /// Funcao que obtem a lista total ou parcial de notas (Todas/Em Destaque/Sem Destaque)
        /// </summary>
        /// <param name="destaque">Este parametro mostra ou esconde as notas destacadas, no caso de ser null ou undefined ele vai retornar a lista completa</param>
        /// <returns></returns>
        public static NotaCollection ObterListaNotas()
        {
            DataTable dataTable = CamadaDados.Nota.ObterLista();
            NotaCollection notas = new NotaCollection(dataTable);
            return notas;
        }
        #endregion

    }
}
