using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Aluno: BaseEntity
    {
        public float Propina { get; set; }
        public bool EstatutoTrabalhadorEstudante { get; set; }
        public override string ObterProfissao()
        {
            return "Aluno";
        }
    }
}
