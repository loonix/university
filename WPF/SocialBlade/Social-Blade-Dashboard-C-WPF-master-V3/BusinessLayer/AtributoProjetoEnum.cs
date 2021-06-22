using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    [Flags]
    public enum AtributoProjetoEnum
    {
        Nada = 0,
        Pago = 1,
        Finalizado = 2,
        ComFinanciamento = 4
    }

    // 1 = 2 ^ 0
    // 2 = 2 ^ 1
    // 4 = 2 ^ 2
    // 8 = 2 ^ 3
}
