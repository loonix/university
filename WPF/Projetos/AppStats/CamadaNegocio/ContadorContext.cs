using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaNegocio
{
    public class ContadorContext
    {
        public ContadorContext(string titulo, string valor) {
            this.titulo = titulo;
            this.valor = valor;
        }

        private string titulo;

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        private string valor;

        public string Valor
        {
            get { return valor; }
            set { valor = value; }
        }
    }
}
