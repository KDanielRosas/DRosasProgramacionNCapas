using DL;
using ML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BL
{
    public class Producto
    {
            //EF
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DRosasNetFrameworkEntities context = new DRosasNetFrameworkEntities())
                {
                    var query = context.ProductoGetAll().ToList();

                    if (query != null)
                    {
                        result.Objects = new List<object>();

                        foreach (var item in query)
                        {
                            ML.Producto producto = new ML.Producto();

                            producto.IdProducto = item.IdProducto;
                            producto.Nombre = item.Nombre;
                            producto.PrecioUnitario = item.PrecioUnitario;
                            producto.Stock = item.Stock;
                            producto.Proveedor = new ML.Proveedor();
                            producto.Proveedor.IdProveedor = item.IdProveedor.Value;
                            producto.Proveedor.Nombre = item.NombreProveedor;
                            producto.Departamento = new ML.Departamento();
                            producto.Departamento.IdDepartamento = item.IdDepartamento.Value;
                            producto.Departamento.Nombre = item.DepartamentoNombre;
                            producto.Departamento.Area = new ML.Area();
                            producto.Departamento.Area.IdArea = item.IdArea.Value;
                            producto.Departamento.Area.Nombre = item.NombreArea;
                            producto.Descripcion = item.Descripcion;
                            producto.Imagen = item.Imagen;

                            result.Objects.Add(producto);
                        }//foreach
                        result.Correct = true;
                    }//if
                }//usingContext
            }//try
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                throw;
            }//catch
            return result;
        }//GetAll

        public static ML.Result GetById(int idProducto)
        {
            ML.Result result = new ML.Result();
            ML.Producto producto= new ML.Producto();

            try
            {
                using (DRosasNetFrameworkEntities context = new DRosasNetFrameworkEntities())
                {
                    var query = context.ProductoGetById(idProducto).FirstOrDefault();

                    if (query != null)
                    {
                        result.Object = new object();
                        result.Correct = true;

                        producto.IdProducto = query.IdProducto;
                        producto.Nombre = query.Nombre;
                        producto.PrecioUnitario = query.PrecioUnitario;
                        producto.Stock = query.Stock;
                        producto.Proveedor = new ML.Proveedor();
                        producto.Proveedor.IdProveedor = query.IdProveedor.Value;
                        producto.Proveedor.Nombre = query.NombreProveedor;
                        producto.Departamento = new ML.Departamento();
                        producto.Departamento.IdDepartamento = query.IdDepartamento.Value;
                        producto.Departamento.Nombre = query.DepartamentoNombre;
                        producto.Departamento.Area = new ML.Area();
                        producto.Departamento.Area.IdArea = query.IdArea.Value;
                        producto.Departamento.Area.Nombre = query.NombreArea;
                        producto.Descripcion = query.Descripcion;
                        producto.Imagen = query.Imagen;

                        result.Object = producto;
                    }//if
                }//usingContext
            }//try
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                throw;
            }//catch
            return result;
        }//GetById

        public static ML.Result Add(ML.Producto producto)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DRosasNetFrameworkEntities context = new DRosasNetFrameworkEntities())
                {
                    int query = context.ProductoAdd(producto.Nombre, producto.PrecioUnitario, producto.Stock,
                        producto.Proveedor.IdProveedor, producto.Departamento.IdDepartamento, producto.Descripcion, producto.Imagen);

                    if (query > 0)
                    {
                        result.Correct = true;
                    }//if
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error al agregar";
                    }//else
                }//usingContext
            }//try
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                throw;
            }//catch
            return result;
        }//Add

        public static ML.Result Update(ML.Producto producto)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DRosasNetFrameworkEntities context = new DRosasNetFrameworkEntities())
                {
                    int query = context.ProductoUpdate(producto.IdProducto, producto.Nombre, producto.PrecioUnitario,
                        producto.Stock, producto.Proveedor.IdProveedor, producto.Departamento.IdDepartamento,
                        producto.Descripcion,producto.Imagen);

                    if (query > 0)
                    {
                        result.Correct = true;
                    }//if
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error al actualizar el registro";
                    }//else
                }//usingContext
            }//try
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                throw;
            }//catch
            return result;
        }//Update

        public static ML.Result Delete(int idProducto)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DRosasNetFrameworkEntities context = new DRosasNetFrameworkEntities())
                {
                    int query = context.ProductoDelete(idProducto);

                    if (query > 0)
                    {
                        result.Correct = true;
                    }//if
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error al eliminar";
                    }
                }//using
            }//try
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                throw;
            }//catch
            return result;
        }//Delete

        //LINQ

        public static ML.Result AddLINQ(ML.Producto producto)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DRosasNetFrameworkEntities context = new DRosasNetFrameworkEntities())
                {
                    DL.Producto productoDL = new DL.Producto
                    {
                        Nombre = producto.Nombre, 
                        PrecioUnitario = producto.PrecioUnitario, 
                        Stock = producto.Stock,
                        IdProveedor = producto.Proveedor.IdProveedor, 
                        IdDepartamento = producto.Departamento.IdDepartamento, 
                        Descripcion = producto.Descripcion, 
                        Imagen = producto.Imagen

                    };

                    context.Productoes.Add(productoDL);
                    context.SaveChanges();

                    result.Correct = true;

                }//usingContext
            }//try
            catch (Exception ex)
            {
                result.Ex = ex;
                result.ErrorMessage = "Ocurrio un error al registrar el producto!";
                result.Correct = false;
                throw;
            }//catch

            return result;

        }//AddLINQ

        public static ML.Result UpdateLINQ(ML.Producto producto)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DRosasNetFrameworkEntities context = new DRosasNetFrameworkEntities())
                {
                    var query = (from product in context.Productoes
                                 where product.IdProducto == producto.IdProducto
                                 select product).FirstOrDefault();

                    if (query != null)
                    {
                        query.IdProducto = producto.IdProducto;
                        query.Nombre = producto.Nombre;
                        query.PrecioUnitario = producto.PrecioUnitario;
                        query.IdProveedor = producto.Proveedor.IdProveedor;
                        query.IdDepartamento = producto.Departamento.IdDepartamento;
                        query.Descripcion = producto.Descripcion;
                        query.Imagen = producto.Imagen;

                        context.SaveChanges();
                        result.Correct = true;

                    }//if
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error al actualizar!!";
                    }//else
                }//usingContext
            }//try
            catch (Exception ex)
            {
                result.Correct = false;
                result.Ex = ex;
                result.ErrorMessage = "Error 101";
                throw;
            }//catch

            return result;
        }//UpdateLINQ

        public static ML.Result DeleteLINQ(int IdProducto)
        {
            ML.Result result = new Result();

            try
            {
                using (DRosasNetFrameworkEntities context = new DRosasNetFrameworkEntities())
                {
                    var query = (from product in context.Productoes
                                 where product.IdDepartamento == IdProducto
                                 select product).First();
                    context.Productoes.Remove(query);
                    context.SaveChanges();
                    result.Correct = true;
                }//usingContext
            }//try
            catch (Exception ex)
            {
                result.Ex = ex;
                result.Correct = false;
                result.ErrorMessage = "Error al eliminar!";
                throw;
            }//catch
            return result;
        }//DeleteLINQ

        public static ML.Result GetAllLINQ()
        {
            ML.Result result = new Result();

            try
            {
                using (DRosasNetFrameworkEntities context = new DRosasNetFrameworkEntities())
                {
                    var query = from product in context.Productoes
                                join proveedor in context.Proveedors
                                on product.IdProveedor equals proveedor.IdProveedor
                                join depto in context.Departamentoes
                                on product.IdDepartamento equals depto.IdDepartamento
                                join area in context.Areas
                                on depto.IdArea equals area.IdArea
                                select new
                                {
                                    product.IdProducto,
                                    product.Nombre,
                                    product.PrecioUnitario,
                                    product.Stock,
                                    product.Proveedor.IdProveedor,
                                    product.Departamento.IdDepartamento,
                                    product.Descripcion,
                                    product.Imagen
                                };
                    if (query != null)
                    {
                        result.Objects = new List<object>();

                        foreach (var item in query)
                        {
                            ML.Producto producto = new ML.Producto();

                            producto.IdProducto = item.IdProducto;
                            producto.Nombre = item.Nombre;
                            producto.PrecioUnitario = item.PrecioUnitario;
                            producto.Stock = item.Stock;
                            producto.Proveedor = new ML.Proveedor();
                            producto.Proveedor.IdProveedor = item.IdProveedor;
                            producto.Departamento = new ML.Departamento();
                            producto.Departamento.IdDepartamento = item.IdDepartamento;
                            producto.Descripcion = item.Descripcion;

                            result.Objects.Add(producto);
                        }//foreach
                        result.Correct = true;
                    }//if
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error 101";
                    }//else
                }//usingContext
            }//try
            catch (Exception ex)
            {
                result.ErrorMessage = "Error 202";
                result.Correct = false;
                result.Ex = ex;
                throw;
            }//catch

            return result;
        }//GetAllLINQ

        public static ML.Result GetByIdLINQ(int IdProducto)
        {
            ML.Result result = new ML.Result();
            ML.Producto producto = new ML.Producto();

            try
            {
                using (DRosasNetFrameworkEntities context = new DRosasNetFrameworkEntities())
                {
                    var query = from product in context.Productoes
                                join proveedor in context.Proveedors
                                on product.IdProveedor equals proveedor.IdProveedor
                                join depto in context.Departamentoes
                                on product.IdDepartamento equals depto.IdDepartamento
                                join area in context.Areas
                                on depto.IdArea equals area.IdArea
                                select new
                                {
                                    product.IdProducto,
                                    product.Nombre,
                                    product.PrecioUnitario,
                                    product.Stock,
                                    product.Proveedor.IdProveedor,
                                    product.Departamento.IdDepartamento,
                                    product.Descripcion,
                                    product.Imagen
                                };
                    if (query != null)
                    {
                        result.Object = new object();
                        result.Correct = true;

                        foreach (var item in query)
                        {
                            producto.IdProducto = item.IdProducto;
                            producto.Nombre = item.Nombre;
                            producto.PrecioUnitario = item.PrecioUnitario;
                            producto.Stock = item.Stock;
                            producto.Proveedor = new ML.Proveedor();
                            producto.Proveedor.IdProveedor = item.IdProveedor;
                            producto.Departamento = new ML.Departamento();
                            producto.Departamento.IdDepartamento = item.IdDepartamento;

                            result.Object = producto;

                        }//foreach
                    }//if
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error 101";
                    }//else                    
                }//usingContext
                return result;
            }//try
            catch (Exception ex)
            {
                result.Correct = false;
                result.Ex = ex;
                result.ErrorMessage = "Error 202";
                throw;
            }//catch           
        }//GetByIdLINQ
    }//ClassProducto
}//NS
