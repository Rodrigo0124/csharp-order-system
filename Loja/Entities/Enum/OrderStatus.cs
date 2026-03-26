using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Entities.Enum
{

    public enum OrderStatus : int
    {
        Aguardando_Pagamento,
        Processando,
        Bipado,
        Entregue
    }
}

