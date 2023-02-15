using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Medicamentos
    {
        public int IdMedicamentos { get; set; }
        public string Skun { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public decimal Subtotal { get; set; }
        public string Imagen { get; set; }
        public int Cantidad { get; set; }


        public List<object> MedicamentosList { get; set; }

    }
}
