using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Medicamentos
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.EIgnacioMarzamEntities context= new DL.EIgnacioMarzamEntities())
                {
                    var query = context.MedicamentoGetAll().ToList();
                    result.Objects = new List<object>();

                    if (query!= null)
                    {
                        foreach (var obj in query)
                        {
                            ML.Medicamentos medicamentos = new ML.Medicamentos();

                            medicamentos.IdMedicamentos = obj.IdMedicamento;
                            medicamentos.Skun=obj.Skun;
                            medicamentos.Nombre = obj.NombreMedicamento;
                            medicamentos.Precio = (decimal)obj.PrecioMedicamento;
                            medicamentos.Imagen = obj.Imagen;
                            medicamentos.Cantidad = (int)obj.Cantidad;
                            result.Objects.Add(medicamentos);
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


        public static ML.Result GetById(int IdMedicamento)
        {
            ML.Result result= new ML.Result();

            try
            {
                using (DL.EIgnacioMarzamEntities context= new DL.EIgnacioMarzamEntities())
                {
                    var query=context.MedicamentoGetById(IdMedicamento).SingleOrDefault();
                    result.Objects = new List<object>();

                    if (query!=null)
                    {
                        ML.Medicamentos medicamentos = new ML.Medicamentos();

                        medicamentos.IdMedicamentos = query.IdMedicamento;
                        medicamentos.Skun= query.Skun;
                        medicamentos.Nombre = query.NombreMedicamento;
                        medicamentos.Precio = (decimal)query.PrecioMedicamento;
                        medicamentos.Imagen = query.Imagen;

                        result.Object  = medicamentos;
                    }
                }
                result.Correct = true;
            }
            catch (Exception ex)
            {

            }

            return result;
        }

        public static ML.Result Update(ML.Medicamentos medicamentos)
        {
            ML.Result result= new ML.Result();

            try
            {
                using (DL.EIgnacioMarzamEntities context= new DL.EIgnacioMarzamEntities())
                {
                    var query = context.MedicamentoUpdate(medicamentos.IdMedicamentos,medicamentos.Skun,medicamentos.Nombre,medicamentos.Precio,medicamentos.Cantidad,medicamentos.Imagen);
                    result.Objects = new List<object>();

                    if (query>0)
                    {
                        result.Message = "Se actualizaron los datos correctamente";
                    }
                }
                result.Correct=true;
            }
            catch (Exception ex)
            {

                throw;
            }

            return  result;
        }
    }
}
