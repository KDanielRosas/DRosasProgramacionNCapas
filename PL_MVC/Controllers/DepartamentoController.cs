using DL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebGrease.Css.Extensions;

namespace PL_MVC.Controllers
{
    public class DepartamentoController : Controller
    {
        //GET: Departamento
       [HttpGet]
        public ActionResult GetAll()
        {
            var serv = new DepartamentoService.DepartamentoServiceClient();

            var list = serv.GetAll();

            ML.Departamento departamento = new ML.Departamento();
            var obj = new ML.Departamento();
            departamento.Departamentos = new List<object>();

            foreach (var item in list)
            {
                obj = new ML.Departamento(); 
                obj.IdDepartamento = item.IdDepartamento;
                obj.Nombre = item.Nombre;
                obj.Area = new ML.Area();
                obj.Area.IdArea = item.IdArea;
                obj.Area.Nombre = item.NombreArea;

                departamento.Departamentos.Add(obj);
            }
             
            return View(departamento);
            
        }//GetAll

        public ML.Departamento GetById(int idDepto)
        {
            //Sin Servicios
            /* 
            ML.Result result = BL.Departamento.GetByIdLINQ(idDepto);
            //ML.Departamento departamento = new ML.Departamento();
            if (result.Correct)
            {
                return View(result.Object);
            }
            else
            {
                return View(result.Object);
            }
            */
            var serv = new DepartamentoService.DepartamentoServiceClient();

            var obj = serv.GetById(idDepto);

            ML.Departamento departamento = new ML.Departamento();
            
            departamento.Area = new ML.Area();
            departamento.Departamentos = new List<object>();

            departamento.IdDepartamento = obj.IdDepartamento;
            departamento.Nombre = obj.Nombre; 
            departamento.Area.IdArea = obj.IdArea; 
            departamento.Area.Nombre = obj.NombreArea; 

            departamento.Departamentos.Add(obj);
            
            return departamento;
        }//GetById

        [HttpGet]
        public ActionResult Form(int? idDepartamento)
        {
            ML.Result resultArea = BL.Area.GetAll();
            ML.Departamento departamento = new ML.Departamento();
            departamento.Area = new ML.Area();

            if (resultArea.Correct)
            {
                departamento.Area.Areas = resultArea.Objects;
            }//if

            if (idDepartamento == null)
            {
                //Add FormVacio
                return View(departamento);
            }//if
            else
            {
                //GetById
                //ML.Result result = BL.Departamento.GetByIdLINQ(idDepartamento.Value);

                ML.Result result = new ML.Result();
                result.Object = GetById(idDepartamento.Value);
                if (result.Object != null)
                {
                    result.Correct = true;
                }

                if (result.Correct)
                {
                    departamento = (ML.Departamento)result.Object;
                    departamento.Area.Areas = resultArea.Objects;

                    //Update
                    return View(departamento);
                }//if
                else
                {
                    ViewBag.Message = "Error al mostrar la información.";
                    return View("Modal");
                }//else                
            }//else
        }//Form

        [HttpPost]
        public ActionResult Form(ML.Departamento departamento)
        {
            ML.Result result = new ML.Result();
            if (departamento.IdDepartamento == 0)
            {
                //Add
                //result = BL.Departamento.AddLINQ(departamento);

                //Add Servicio

                var obj = new SL.Depto
                {                    
                    Nombre = departamento.Nombre,
                    IdArea = departamento.Area.IdArea
                };

                var serv = new DepartamentoService.DepartamentoServiceClient();
                var resultado = serv.Add(obj);                

                if (resultado)
                {
                    ViewBag.Message = "Se registró correctamente!";
                }
                else
                {
                    ViewBag.Message = "Error!";
                }
                return View("Modal");
            }
            else
            {
                //Update
                //result = BL.Departamento.UpdateLINQ(departamento);

                var obj = new SL.Depto
                {
                    IdDepartamento = departamento.IdDepartamento,
                    Nombre = departamento.Nombre,
                    IdArea = departamento.Area.IdArea
                };

                var serv = new DepartamentoService.DepartamentoServiceClient();
                var resultado = serv.Update(obj);

                if (resultado)
                {
                    ViewBag.Message = "Se actualiizó correctamente el registro!";
                }
                else
                {
                    ViewBag.Message = "Error al actualizar el registro...";
                }
                return View("Modal");
            }
        }//Form

        [HttpGet]
        public ActionResult Delete(int idDepartamento)
        {
            //Delete sin WCF
            //ML.Result result = BL.Departamento.DeleteLINQ(idDepartamento);

            //Delete con WCF
            var serv = new DepartamentoService.DepartamentoServiceClient();
            var resultado = serv.Delete(idDepartamento);

            if (resultado)
            {
                ViewBag.Message = "Registro eliminado correctamente";
            }
            else
            {
                ViewBag.Message = "Error al eliminar el registro.";
            }
            return View("Modal");
        }//Delete
        
    }//ClassController
}//NS