using System;

namespace CamadaNegocio
{
    [Flags]
    public enum TagsEnum
    {
        NaoDefinido = 0, 
        Escola = 1,
        Compras = 2,
        Pagamentos = 4,
        Cartoes = 8
    }
}
