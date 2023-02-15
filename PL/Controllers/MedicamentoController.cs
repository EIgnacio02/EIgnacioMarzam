using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class MedicamentoController : Controller
    {
        // GET: Medicamento
        public ActionResult GetAll()
        {
            ML.Medicamentos medicamentos = new ML.Medicamentos();
            ML.Result result=BL.Medicamentos.GetAll();

            if (result.Correct)
            {
                medicamentos.MedicamentosList = result.Objects;
                return View(medicamentos);
            }
            return View();
        }

        public ActionResult Form(int? IdMedicamento)
        {
            ML.Medicamentos medicamentos=new ML.Medicamentos();

            if (IdMedicamento==null)
            {
                return View();
            }
            else
            {
                ML.Result result = BL.Medicamentos.GetById(IdMedicamento.Value);
                if (result.Correct)
                {
                    medicamentos = (ML.Medicamentos)result.Object;
                }
                else
                {
                    ViewBag.Message = "Ocurrio un error";
                }
            }
            return View(medicamentos);
        }
        public byte[] ConvertToBytes(HttpPostedFileBase Imagen)
        {
            byte[] data = null;
            System.IO.BinaryReader reader = new System.IO.BinaryReader(Imagen.InputStream);
            data = reader.ReadBytes((int)Imagen.ContentLength);

            return data;
        }

        [HttpPost]
        public ActionResult Form(ML.Medicamentos medicamentos)
        {
            HttpPostedFileBase file = Request.Files["ImagenData"];

            if (file.ContentLength > 0)
            {
                byte[] ImagenBytes = ConvertToBytes(file);
                medicamentos.Imagen = Convert.ToBase64String(ImagenBytes);
            }

            ML.Result result = new ML.Result();

            if (medicamentos.IdMedicamentos == 0)
            {
                //result = BL.Medicamentos.Add(medicamentos);
                if (result.Correct)
                {
                    ViewBag.Message = "Se agregaron correctamente los registros";

                }
                else
                {
                    ViewBag.Message = "Ocurrio un error";

                }
            }
            else
            {
                result = BL.Medicamentos.Update(medicamentos);
                if (result.Correct)
                {
                    ViewBag.Message = "Se actualizaron correctamente los registros";

                }
                else
                {
                    ViewBag.Message = "Ocurrio un error";

                }
            }
            return View("Modal");
        }

    }
}