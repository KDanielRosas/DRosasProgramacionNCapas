using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProductoService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProductoService.svc or ProductoService.svc.cs at the Solution Explorer and start debugging.
    public class ProductoService : IProductoService
    {
        public bool Add(Producto obj)
        {            
            ML.Producto producto = new ML.Producto();
            producto.Nombre = obj.Nombre;
            producto.Stock = obj.Stock;
            producto.PrecioUnitario = obj.PrecioUnitario;
            producto.Departamento = new ML.Departamento();
            producto.Departamento.IdDepartamento = obj.IdDepartamento;
            producto.Proveedor = new ML.Proveedor();
            producto.Proveedor.IdProveedor = obj.IdProveedor;
            producto.Descripcion = obj.Descripcion;
            ML.Result result = BL.Producto.Add(producto);
            if (result.Correct)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Update(Producto obj)
        {
            ML.Producto producto = new ML.Producto();
            producto.IdProducto = obj.IdProducto;
            producto.Nombre = obj.Nombre;
            producto.Stock = obj.Stock;
            producto.PrecioUnitario = obj.PrecioUnitario;
            producto.Departamento = new ML.Departamento();
            producto.Departamento.IdDepartamento = obj.IdDepartamento;
            producto.Proveedor = new ML.Proveedor();
            producto.Proveedor.IdProveedor = obj.IdProveedor;
            producto.Descripcion = obj.Descripcion;
            ML.Result result = BL.Producto.Update(producto);
            if (result.Correct)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Delete(int idProducto)
        {
            ML.Result result = BL.Producto.Delete(idProducto);
            if (result.Correct)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Producto> GetAll()
        {
            ML.Result result = BL.Producto.GetAllLINQ();
            List<Producto> list = new List<Producto>();
            foreach (ML.Producto producto in result.Objects.Cast<ML.Producto>())
            {
                var item = new Producto { IdProducto = producto.IdProducto, Nombre = producto.Nombre, 
                    PrecioUnitario = producto.PrecioUnitario, Stock = producto.Stock, IdProveedor = producto.Proveedor.IdProveedor,
                    IdDepartamento = producto.Departamento.IdDepartamento, Descripcion = producto.Descripcion };
                list.Add(item);
            }
            
            return list;
        }

        public Producto GetById(int idProducto)
        {
            ML.Result result = BL.Producto.GetById(idProducto);
            var item = (ML.Producto)result.Object;
            var product = new Producto
            {
                IdProducto = item.IdProducto,
                Nombre = item.Nombre,
                PrecioUnitario = item.PrecioUnitario,
                Stock = item.Stock,
                IdProveedor = item.Proveedor.IdProveedor,
                IdDepartamento = item.Departamento.IdDepartamento,
                Descripcion = item.Descripcion
            };                             

            return product;
        }
    }
}
