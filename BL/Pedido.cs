using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Pedido
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.EIgnacioMarzamEntities context = new DL.EIgnacioMarzamEntities())
                {
                    var query = context.PedidoGetAll().ToList();
                    result.Objects = new List<object>();

                    if (query != null)
                    {
                        foreach (var obj in query)
                        {
                            ML.Pedidos pedidos = new ML.Pedidos();

                            pedidos.IdPedido = obj.IdPedido;
                            pedidos.CantidadPedido = (int)obj.CantidadPedido;
                            pedidos.PrecioTotal = (decimal)obj.PrecioTotalPedido;

                            pedidos.Usuario = new ML.Usuario();
                            pedidos.Usuario.IdUsuario = (int)obj.IdUsuario;
                            pedidos.Usuario.Nombre = obj.Nombre; 
                            pedidos.Usuario.ApellidoPaterno= obj.ApellidoPaterno;
                            pedidos.Usuario.ApellidoMaterno= obj.ApellidoMaterno;
                            pedidos.Usuario.Password= obj.Password;

                            pedidos.Medicamento = new ML.Medicamentos();
                            pedidos.Medicamento.IdMedicamentos = (int)obj.IdMedicamento;
                            pedidos.Medicamento.Skun = obj.Skun;
                            pedidos.Medicamento.Nombre = obj.NombreMedicamento;
                            pedidos.Medicamento.Precio = (decimal)obj.PrecioMedicamento;
                            pedidos.Medicamento.Imagen = obj.Imagen;

                            result.Objects.Add(pedidos);
                        }
                    }
                }
                result.Correct = true;
            }
            catch (Exception ex)
            {

                throw;
            }

            return result;
        }
    }
}
