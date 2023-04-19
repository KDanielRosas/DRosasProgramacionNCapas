using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class ProductoServicios
    {
        public static void Add()
        {
            try
            {
                var serv = new ProductoService.ProductoServiceClient();
                var item = new ProductoService.Producto();

                Console.WriteLine("Ingrese los datos por favor: ");

                Console.Write("\nNombre: ");
                item.Nombre = Console.ReadLine();

                Console.Write("\nPrecio unitario: ");
                item.PrecioUnitario = decimal.Parse(Console.ReadLine());

                Console.Write("\nStock: ");
                item.Stock = int.Parse(Console.ReadLine());

                Console.Write("\nIdProveedor: ");
                item.IdProveedor = int.Parse(Console.ReadLine());

                Console.Write("\nIdDepartamento: ");
                item.IdDepartamento = int.Parse(Console.ReadLine());

                Console.Write("\nDescripcion: ");
                item.Descripcion = Console.ReadLine();

                serv.Add(item);

                Console.WriteLine("Registro almacenado correctamente.");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ingresar el registro." + ex);
                throw;
            }
            
        }//Add

        public static void Update()
        {
            try
            {
                var serv = new ProductoService.ProductoServiceClient();
                var item = new ProductoService.Producto();

                Console.WriteLine("Ingrese el ID del registro que desea actualizar: ");
                item.IdProducto = Int16.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese los datos por favor: ");

                Console.Write("Nombre: ");
                item.Nombre = Console.ReadLine();

                Console.Write("Precio unitario: ");
                item.PrecioUnitario = decimal.Parse(Console.ReadLine());

                Console.Write("Stock: ");
                item.Stock = int.Parse(Console.ReadLine());

                Console.Write("IdProveedor: ");
                item.IdProveedor = int.Parse(Console.ReadLine());

                Console.Write("IdDepartamento: ");
                item.IdDepartamento = int.Parse(Console.ReadLine());

                Console.Write("Descripcion: ");
                item.Descripcion = Console.ReadLine();

                serv.Update(item);

                Console.WriteLine("\n\t-----Registro actualizado correctamente-----");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar: " + ex);
                throw;
            }
            
        }//Update

        public static void Delete()
        {
            try
            {
                Console.WriteLine("Ingrese el ID del registro que desea eliminar: ");
                int idProducto = Int16.Parse(Console.ReadLine());

                var serv = new ProductoService.ProductoServiceClient();

                var item = serv.Delete(idProducto);

                Console.WriteLine("\n\t-----Producto eliminado correctamente!-----");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar. " + ex);
                throw;
            }           
            
        }//Delete()

        public static void GetAll()
        {
            try
            {
                Console.WriteLine("\n\t-----Registros en la tabla Producto-----\n");

                var serv = new ProductoService.ProductoServiceClient();

                var list = serv.GetAll();

                foreach (var producto in list)
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("IdProducto: " + producto.IdProducto);
                    Console.WriteLine("Nombre: " + producto.Nombre);
                    Console.WriteLine("Precio: " + producto.PrecioUnitario);
                    Console.WriteLine("Stock: " + producto.Stock);
                    Console.WriteLine("IdProveedor: " + producto.IdProveedor);
                    Console.WriteLine("IdDepartamento: " + producto.IdDepartamento);
                    Console.WriteLine("Descripción: " + producto.Descripcion);
                    Console.WriteLine("------------------------------------");
                }//foreach
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al mostrar los registros. " + ex);
                throw;
            }            
        }//GetAll

        public static void GetById()
        {
            try 
            { 
                Console.WriteLine("Ingrese el ID del registro que desea consultar: ");
                int idProducto = Int16.Parse(Console.ReadLine());
                Console.WriteLine("\n\t-----Registros en la tabla Producto-----\n");

                var serv = new ProductoService.ProductoServiceClient();

                var item = serv.GetById(idProducto);

                Console.WriteLine("------------------------------------");
                Console.WriteLine("IdProducto: " + item.IdProducto);
                Console.WriteLine("Nombre: " + item.Nombre);
                Console.WriteLine("Precio: " + item.PrecioUnitario);
                Console.WriteLine("Stock: " + item.Stock);
                Console.WriteLine("IdProveedor: " + item.IdProveedor);
                Console.WriteLine("IdDepartamento: " + item.IdDepartamento);
                Console.WriteLine("Descripción: " + item.Descripcion);
                Console.WriteLine("------------------------------------");           
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al mostrar los registros. " + ex);
                throw;
            }
        }//GetById
    }
}
