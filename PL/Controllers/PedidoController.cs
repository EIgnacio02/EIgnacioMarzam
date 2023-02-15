using BL;
using ML;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class PedidoController : Controller
    {
        // GET: Pedido
        public ActionResult GetAll()
        {
            ML.Medicamentos medicamentos= new ML.Medicamentos();
            ML.Result result = BL.Medicamentos.GetAll();

            if (result.Correct)
            {
                medicamentos.MedicamentosList = result.Objects;
            }
            return View(medicamentos);
        }

        [HttpGet]
        public  ActionResult AgregarCarrito(ML.Medicamentos medicamentos)
        {
            bool existe = false;

            ML.Pedidos pedidos = new ML.Pedidos();
            pedidos.PedidosList = new List<object>();


            if (Session["Carrito"] == null)
            {
                //Inicia sesion para agregar producto al carrito 
                medicamentos.Cantidad = medicamentos.Cantidad-1;
                medicamentos.Subtotal = medicamentos.Precio * medicamentos.Cantidad;
                pedidos.PedidosList.Add(medicamentos);

                Session["Carrito"] = pedidos.PedidosList;

                var session = Session["Carrito"];
            }

            else
            {
                GetCarrito(pedidos);
                foreach (ML.Medicamentos venta in pedidos.PedidosList.ToList())
                {
                    if (medicamentos.IdMedicamentos == venta.IdMedicamentos)
                    {
                        venta.Cantidad = venta.Cantidad + 1;  
                        venta.Subtotal = venta.Precio * venta.Cantidad;
                        existe = true;
                    }
                    else
                    {
                        existe = false;
                    }
                    if (existe == true)
                    {
                        break;
                    }
                }
                if (existe == false)
                {
                    medicamentos.Cantidad = medicamentos.Cantidad = 1;
                    medicamentos.Subtotal = medicamentos.Cantidad * medicamentos.Precio;
                    pedidos.PedidosList.Add(medicamentos);

                }
                Session["Carrito"] = pedidos.PedidosList;

            }
            if (Session["Carrito"] != null)
            {
                ViewBag.Message = "Se ha agregado el medicamento";
                return PartialView("Modal");
            }
            else
            {
                ViewBag.Message = "No se pudo agregar tu producto";
                return PartialView("Modal");
            }
        }


        [HttpGet]
        public ActionResult Carrito(ML.Pedidos ventaProducto)
        {
            decimal costoTotal = 0;
            if (Session["Carrito"] == null)
            {
                return View();
            }
            else
            {
                ventaProducto.PedidosList = new List<object>();
                GetCarrito(ventaProducto);
                ventaProducto.PrecioTotal = costoTotal;
            }

            return View(ventaProducto);

        }


        public ML.Pedidos GetCarrito(ML.Pedidos pedidos)
        {
            var session = Session["Carrito"].ToString();
            foreach (var obj in session)
            {
                ML.Medicamentos objMedicamento = ;
                pedidos.PedidosList.Add(objMedicamento);
            }
            return pedidos;
        }
    }
}