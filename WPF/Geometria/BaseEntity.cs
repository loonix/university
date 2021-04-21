using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class BaseEntity : DadosTelefone, IProfissao
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        //public int Telefone { get; set; }
        public DateTime DataNascimento { get; set; }

        public int ObterIdade()
        {
            return DateTime.Today.Year - this.DataNascimento.Year;
        }

        public virtual string ObterProfissao()
        {
            return "Nao Definida";
        }
    }

    public interface IProfissao
    {
        string ObterProfissao();
    }

    //public class DadosNascimento
    //{
    //    public DateTime DataNascimento { get; set; }
    //    public int ObterIdade()
    //    {
    //        return DateTime.Today.Year - this.DataNascimento.Year;
    //    }
    //}

    public class DadosTelefone
    {
        public string Telefone { get; set; }
        public string Telemovel { get; set; }
        public string TelefoneCasa { get; set; }
        public string TelefoneEmprego { get; set; }
    }
}
