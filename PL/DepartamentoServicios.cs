using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class DepartamentoServicios
    {
        public static void Add()
        {
            try
            {
                var serv = new DepartamentoService.DepartamentoServiceClient();
                var item = new DepartamentoService.Depto();

                Console.WriteLine("Ingrese los datos por favor: ");

                Console.Write("\nNombre: ");
                item.Nombre = Console.ReadLine();

                Console.Write("\nPrecio unitario: ");
                item.IdArea = int.Parse(Console.ReadLine());

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
                var serv = new DepartamentoService.DepartamentoServiceClient();
                var item = new DepartamentoService.Depto();

                Console.WriteLine("Ingrese el ID del registro que desea actualizar: ");
                item.IdDepartamento = short.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese los datos por favor: ");

                Console.Write("Nombre: ");
                item.Nombre = Console.ReadLine();

                Console.Write("Precio unitario: ");
                item.IdArea = short.Parse(Console.ReadLine());               

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
                int idDepartamento = Int16.Parse(Console.ReadLine());

                var serv = new DepartamentoService.DepartamentoServiceClient();

                var item = serv.Delete(idDepartamento);

                Console.WriteLine("\n\t-----Departamento eliminado correctamente!-----");
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
                Console.WriteLine("\n\t-----Registros en la tabla Departamento-----\n");

                var serv = new DepartamentoService.DepartamentoServiceClient();

                var list = serv.GetAll();

                foreach (var depto in list)
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("IdProducto: " + depto.IdDepartamento);
                    Console.WriteLine("Nombre: " + depto.Nombre);
                    Console.WriteLine("Precio: " + depto.IdArea);
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
                int idDepartamento = short.Parse(Console.ReadLine());
                Console.WriteLine("\n\t-----Registros en la tabla Departamento-----\n");

                var serv = new DepartamentoService.DepartamentoServiceClient();

                var item = serv.GetById(idDepartamento);

                Console.WriteLine("------------------------------------");
                Console.WriteLine("IdProducto: " + item.IdDepartamento);
                Console.WriteLine("Nombre: " + item.Nombre);
                Console.WriteLine("Precio: " + item.IdArea);
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
