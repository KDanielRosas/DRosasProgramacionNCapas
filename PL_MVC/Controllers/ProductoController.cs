using SL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL_MVC.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        [HttpGet]
        public ActionResult GetAll()
        {
            //Sin Servicios
            //ML.Result result = BL.Producto.GetAll();
            //ML.Producto producto = new ML.Producto();

            //if (result.Correct)
            //{
            //    producto.Productos = result.Objects;
            //    return View(producto);
            //}
            //else
            //{
            //    return View(producto);
            //}

            //Con Servicios

            var serv = new ProductoServices.ProductoServiceClient();
            var list = serv.GetAll();

            ML.Producto producto = new ML.Producto();
            var obj = new ML.Producto();           
            
            producto.Productos = new List<object>();

            foreach (var item in list)
            {
                obj = new ML.Producto();
                obj.IdProducto = item.IdDepartamento;
                obj.Nombre = item.Nombre;
                obj.PrecioUnitario = item.PrecioUnitario;
                obj.Stock = item.Stock;
                obj.Proveedor = new ML.Proveedor();
                obj.Proveedor.IdProveedor = item.IdProveedor;
                obj.Departamento = new ML.Departamento();
                obj.Departamento.IdDepartamento = item.IdDepartamento;
                obj.Descripcion = item.Descripcion;

                producto.Productos.Add(obj);
            }

            return View(producto);
        }//GetAll

        public ML.Producto GetById(int idProducto)
        {
            var serv = new ProductoServices.ProductoServiceClient();

            var obj = serv.GetById(idProducto);

            ML.Producto producto = new ML.Producto();

            producto = new ML.Producto();
            producto.IdProducto = obj.IdDepartamento;
            producto.Nombre = obj.Nombre;
            producto.PrecioUnitario = obj.PrecioUnitario;
            producto.Stock = obj.Stock;
            producto.Proveedor = new ML.Proveedor();
            producto.Proveedor.IdProveedor = obj.IdProveedor;
            producto.Departamento = new ML.Departamento();
            producto.Departamento.IdDepartamento = obj.IdDepartamento;
            producto.Descripcion = obj.Descripcion;

            producto.Productos.Add(obj);

            return producto;
        }

        [HttpGet]
        public ActionResult Form(int? idProducto) 
        {
            ML.Result resultProveedor = BL.Proveedor.GetAll();
            ML.Result resultDepartamento = BL.Departamento.GetAllEF();
            ML.Result resultArea = BL.Area.GetAll();

            ML.Producto producto = new ML.Producto();

            producto.Departamento = new ML.Departamento();
            producto.Proveedor = new ML.Proveedor();
            producto.Departamento.Area = new ML.Area();

            if (resultProveedor.Correct && resultDepartamento.Correct)
            {
                producto.Departamento.Departamentos = resultDepartamento.Objects;
                producto.Proveedor.Proveedores = resultProveedor.Objects;
                producto.Departamento.Area.Areas = resultArea.Objects;
            }//if

            if (idProducto == null)
            {
                //Add Form Vacio
                return View(producto);

            }//if
            else
            {
                //GetById Sin Servicios
                //ML.Result result = BL.Producto.GetById(idProducto.Value);

                //GetById Con Servicios
                ML.Result result = new ML.Result();
                result.Object = GetById(idProducto.Value);
                if (result.Object != null)
                {
                    result.Correct = true;
                }

                if (result.Correct)
                {
                    producto = (ML.Producto)result.Object;

                    resultProveedor = BL.Proveedor.GetAll();
                    resultDepartamento = BL.Departamento.GetByIdArea(producto.Departamento.Area.IdArea);
                    
                    producto.Proveedor.Proveedores = resultProveedor.Objects;
                    producto.Departamento.Departamentos = resultDepartamento.Objects;
                    producto.Departamento.Area.Areas = resultArea.Objects;

                    //Update
                    return View(producto);
                }//if
                else
                {
                    ViewBag.Message = "Error al mostrar la información del producto";
                    return View("Modal");
                }//else
            }//else
        }//Form

        [HttpPost]
        public ActionResult Form(ML.Producto producto)
        {
            //ML.Result result = new ML.Result();
            HttpPostedFileBase file = Request.Files["fuImage"];

            if (file != null)
            {
                byte[] imagen = ImagenABase64(file);
                producto.Imagen = Convert.ToBase64String(imagen);
            }

            if (producto.IdProducto == 0)
            {
                //Add sin servicios
                //result = BL.Producto.Add(producto);

                //Add con servicios
                //Add Servicio

                var obj = new SL.Producto
                {
                    Nombre = producto.Nombre,
                    PrecioUnitario = producto.PrecioUnitario,
                    Stock = producto.Stock,
                    IdProveedor = producto.Proveedor.IdProveedor,
                    IdDepartamento = producto.Departamento.IdDepartamento,
                    Descripcion = producto.Descripcion,
                    Imagen = producto.Imagen
                };

                var serv = new ProductoServices.ProductoServiceClient();
                var resultado = serv.Add(obj);

                if (resultado)
                {
                    ViewBag.Message = "¡Producto registrado correctamente!";
                }
                else
                {
                    ViewBag.Message = "Error al registrar el producto...";
                }
                return View("Modal");
            }//if
            else
            {
                //Update
                //result = BL.Producto.Update(producto);

                //Update con Servicios
                var obj = new SL.Producto
                {
                    IdProducto = producto.IdProducto,
                    Nombre = producto.Nombre,
                    PrecioUnitario = producto.PrecioUnitario,
                    Stock = producto.Stock,
                    IdProveedor = producto.Proveedor.IdProveedor,
                    IdDepartamento = producto.Departamento.IdDepartamento,
                    Descripcion = producto.Descripcion,
                    Imagen = producto.Imagen
                };

                var serv = new ProductoServices.ProductoServiceClient();
                var resultado = serv.Update(obj);

                if (resultado)
                {
                    ViewBag.Message = "¡Se actualizó el registro correctamente!";
                }//if
                else
                {
                    ViewBag.Message = "Error al actualizar el registo...";
                }//else
                return View("Modal");
            }
        }//Form

        [HttpGet]
        public ActionResult Delete(int idProducto)
        {
            //ML.Result result = BL.Producto.Delete(idProducto);

            //Delete con WCF
            var serv = new ProductoServices.ProductoServiceClient();
            var resultado = serv.Delete(idProducto);

            if (resultado)
            {
                ViewBag.Message = "Registro eliminado correctamente!";
            }
            else
            {
                ViewBag.Message = "Error al eliminar el registro...";
            }
            return View("Modal");
        }//Delete

        public JsonResult DepartamentoGetByIdArea(int idArea)
        {
            ML.Result result = BL.Departamento.GetByIdArea(idArea);

            return Json(result.Objects);
        }

        public byte[] ImagenABase64(HttpPostedFileBase foto)
        {
            byte[] data = null;
            System.IO.BinaryReader reader = new System.IO.BinaryReader(foto.InputStream);
            data = reader.ReadBytes((int)foto.ContentLength);

            return data;
        }//imagenAByte
    }//Controller
}//NS