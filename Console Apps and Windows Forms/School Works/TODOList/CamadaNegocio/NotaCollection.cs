using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CamadaNegocio
{
    public class NotaCollection : List<Nota>
    {
        #region Construtor
        public NotaCollection(DataTable dataTable)
        {
            if (dataTable != null)
            {
                foreach (DataRow dataRow in dataTable.AsEnumerable())
                {
                    Nota nota = new Nota();

                    nota.IDNota = dataRow.Field<string>("IDNota");
                    nota.Titulo = dataRow.Field<string>("Titulo");
                    nota.DataCriacao = dataRow.Field<DateTime>("DataCriacao");
                    nota.DataExpiracao = dataRow.Field<DateTime>("DataExpiracao");
                    nota.Tags = dataRow.Field<TagsEnum>("Tags");
                    nota.Conteudo = dataRow.Field<string>("Conteudo");
                    nota.Destaque = dataRow.Field<Boolean>("Destaque");
                    this.Add(nota);
                }
            }
        }
        #endregion

        #region Metodos
        public float ObterTotalNotas()
        {
            float totalNotas = 0;

            foreach (Nota nota in this)
            {
                totalNotas += 1;
            }
            return totalNotas;
        }

        public float ObterTotalNotasEmDestaque()
        {
            IEnumerable<Nota> totalNotasEmDestaque = from nota in this
                                       where nota.Destaque == true
                                       select nota;

            return totalNotasEmDestaque.ToList().Count();
        }

        public List<Nota> ObterNotasEmDestaque()
        {
            IEnumerable<Nota> totalNotasEmDestaque = from nota in this
                                                     where nota.Destaque == true && nota.DataExpiracao >= DateTime.Today
                                                     select nota;
            return totalNotasEmDestaque.ToList();
        }

        public List<Nota> ObterNotas(bool destaque = true, bool expirados = true, String pesquisa = null)
        {
            IEnumerable<Nota> totalNotasEmDestaque = from nota in this
                                                     where 
                                                         (destaque ? true : nota.Destaque == destaque) && 
                                                         (expirados ? true : nota.DataExpiracao >= DateTime.Today) &&
                                                         (pesquisa != null ? nota.Titulo.ToLower().Contains(pesquisa.ToLower()) || nota.Conteudo.ToLower().Contains(pesquisa.ToLower()) : true)
                                                     select nota;
            return totalNotasEmDestaque.ToList();
        }
        #endregion

    }
}
