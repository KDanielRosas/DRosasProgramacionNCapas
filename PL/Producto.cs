using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Producto
    {
        public static void Add() {                   

            ML.Producto producto = new ML.Producto();
            //producto.Departamento = new ML.Rol();

            Console.WriteLine("Ingrese los datos por favor: ");

            Console.Write("\nNombre: ");
            producto.Nombre = Console.ReadLine();

            Console.Write("\nPrecio unitario: ");
            producto.PrecioUnitario = decimal.Parse(Console.ReadLine());

            Console.Write("\nStock: ");
            producto.Stock = int.Parse(Console.ReadLine());

            Console.Write("\nIdProveedor: ");
            producto.Proveedor.IdProveedor = int.Parse(Console.ReadLine());

            Console.Write("\nIdDepartamento: ");
            producto.Departamento.IdDepartamento = int.Parse(Console.ReadLine());

            Console.Write("\nDescripcion: ");
            producto.Descripcion = Console.ReadLine();

            producto.Imagen = null;

            ML.Result result = BL.Producto.Add(producto); //Por EF

            //Validar el resultado (true/false)
            if (result.Correct)
            {
                Console.WriteLine("\n\t-----Se registró el producto correctamente!-----");
            }
            else
            {
                Console.WriteLine("Error al registrar el producto.");
            }
        }//Add()

        public static void Update() {
            ML.Producto producto = new ML.Producto();

            Console.WriteLine("Ingrese el ID del registro que desea actualizar: ");
            producto.IdProducto = Int16.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese los datos por favor: ");

            Console.Write("\nNombre: ");
            producto.Nombre = Console.ReadLine();

            Console.Write("\nPrecio unitario: ");
            producto.PrecioUnitario = decimal.Parse(Console.ReadLine());

            Console.Write("\nStock: ");
            producto.Stock = int.Parse(Console.ReadLine());

            Console.Write("\nIdProveedor: ");
            producto.Proveedor.IdProveedor = int.Parse(Console.ReadLine());

            Console.Write("\nIdDepartamento: ");
            producto.Departamento.IdDepartamento = int.Parse(Console.ReadLine());

            Console.Write("\nDescripcion: ");
            producto.Descripcion = Console.ReadLine();

            producto.Imagen = null;

            ML.Result result = BL.Producto.Update(producto); //Por EF

            //Validar el resultado (true/false)
            if (result.Correct)
            {
                Console.WriteLine("\n\t------Registro actualizado correctamente!-----");
            }

            else
            {
                Console.WriteLine("\n\t------Error al actualizar el registro-----");
            }

        }//Update()

        public static void Delete() {
            ML.Producto producto = new ML.Producto();

            Console.WriteLine("Ingrese el ID del registro que desea eliminar: ");
            int IdUsuario = Int16.Parse(Console.ReadLine());

            ML.Result result = BL.Producto.Delete(IdUsuario); //Por EF

            //En caso de que no se encuentre el registro para borrar, pedir de nuevo el Id
            while (!result.Correct)
            {
                Console.Write("\n\tError al eliminar al producto. Intente de nuevo: ");
                IdUsuario = Int16.Parse(Console.ReadLine());

                result = BL.Producto.Delete(IdUsuario);
            }

            //Validar el resultado (true/false)
            if (result.Correct)
            {
                Console.WriteLine("\n\t-----Producto eliminado correctamente!-----");
            }
        }//Delete()

        public static void GetAll() {

            Console.WriteLine("\n\t-----Registros en la tabla Producto-----\n");

            ML.Result result = BL.Producto.GetAll(); //EF

            //Validar el resultado (true/false)
            if (result.Correct)
            {
                foreach (ML.Producto producto in result.Objects)
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("IdProducto: " + producto.IdProducto);
                    Console.WriteLine("Nombre: " + producto.Nombre);
                    Console.WriteLine("Precio: " + producto.PrecioUnitario);
                    Console.WriteLine("Stock: " + producto.Stock);
                    Console.WriteLine("IdProveedor: " + producto.Proveedor.IdProveedor);
                    Console.WriteLine("IdDepartamento: " + producto.Departamento.IdDepartamento);
                    Console.WriteLine("Descripción: " + producto.Descripcion);                    
                    Console.WriteLine("------------------------------------");

                }//foreach
            }//if
        }//GetAll()

        public static void GetById() {
            

            Console.WriteLine("Ingrese el ID del registro que desea consultar: ");
            int IdProducto = Int16.Parse(Console.ReadLine());

            ML.Result result = BL.Producto.GetById(IdProducto); //EF
            //ML.Result result = BL.Producto.GetByIdLINQ(IdUsuario); //LINQ

            ML.Producto producto = result.Object as ML.Producto;
            

            if (result.Correct) {

                Console.WriteLine("------------------------------------");
                Console.WriteLine("IdProducto: " + producto.IdProducto);
                Console.WriteLine("Nombre: " + producto.Nombre);
                Console.WriteLine("Precio: " + producto.PrecioUnitario);
                Console.WriteLine("Stock: " + producto.Stock);
                Console.WriteLine("IdProveedor: " + producto.Proveedor.IdProveedor);
                Console.WriteLine("IdDepartamento: " + producto.Departamento.IdDepartamento);
                Console.WriteLine("Descripción: " + producto.Descripcion);
                Console.WriteLine("------------------------------------");
            }

            //En caso de no encontrar registros, repetir la peticion del Id al producto.
            else
            {
                Console.Write("\n\t----No se encontró un registro con ese Id----\n\n");
                GetById();
            }
        }//GetById()

    }
}
