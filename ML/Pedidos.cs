
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Pedidos
    {
        public int IdPedido { get; set; }
        public int IdUsuario { get; set; }
        public int IdMedicamento { get; set; }
        public int CantidadPedido { get; set; }
        public decimal PrecioTotal { get; set; }

        public List<object> PedidosList { get; set; }

        public ML.Usuario Usuario { get; set; }
        public ML.Medicamentos Medicamento { get; set; }
    }
}
