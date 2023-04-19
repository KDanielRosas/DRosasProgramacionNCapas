using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PL
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido! ¿Con que desea trabajar?");
            MenuTablas();
            Console.ReadKey();
        }

        public static void MenuTablas()
        {
            Console.WriteLine("\n 1. Producto\n 2. Servicios Operaciones Matematicas\n 3. Producto(Servicios)\n 4. Departamento(Servicios)");
            Console.Write("\nSu opcion: ");

            try
            {
                int op = Int16.Parse(Console.ReadLine());
                
                switch (op) 
                {
                    case 1:
                        //Producto
                        MenuProducto();
                        break;

                    case 2:
                        //Servicios
                        MenuServicios();
                        break;

                    case 3:
                        //Producto(Servicios)
                        MenuProductoServicios();
                        break;

                    case 4:
                        //Departamento(Servicios)
                        MenuDeptoServicios();
                        break;
                    
                }//switchMenuTablas
            }//tryMenuTablas
            catch (Exception)
            {
                Console.WriteLine("Error. Intente de nuevo: ");
                MenuTablas();
                throw;
            }//catchMenuTablas            
        }//MenuTablas()

        public static void MenuProducto()
        {
            Console.WriteLine("\n\t----Producto----\n");
            Console.WriteLine("¿Que desea realizar?" + 
                "\n1. Ingresar\n2. Eliminar\n3. Actualizar\n4. Consulta general\n5. Consulta por ID\n6. Salir");
            Console.Write("\nSu opcion: ");

            try
            {
                int op = short.Parse(Console.ReadLine());
                Console.WriteLine("\n");

                if (op != 6)
                {
                    switch (op)
                    {
                        case 1:
                            //Insertar
                            PL.Producto.Add();
                            MenuProducto();
                            break;

                        case 2:
                            //Eliminar
                            PL.Producto.Delete();
                            MenuProducto();
                            break;

                        case 3:
                            //Actualizar
                            PL.Producto.Update();
                            MenuProducto();
                            break;

                        case 4:
                            //Consulta general
                            PL.Producto.GetAll();
                            MenuProducto();
                            break;

                        case 5:
                            //Consulta por Id
                            PL.Producto.GetById();
                            MenuProducto();
                            break;

                        default:
                            Console.WriteLine("Error, opcion invalida. Intente de nuevo.");
                            MenuProducto();
                            break;
                    }//switch
                }//if
                else if(op == 6) 
                {
                    Console.WriteLine("Adios!. Presione cualquier tecla para salir.");
                    Console.ReadKey();
                }//else
                
            }//try
            catch (Exception)
            {
                Console.WriteLine("Error. Intente de nuevo: ");
                MenuProducto();
            }//catch
        }//MenuProducto

        public static void MenuServicios()
        {
            Console.WriteLine("\n\t----Servicios(Operaciones Matematicas)----\n");
            Console.WriteLine("¿Que desea realizar?" +
                "\n1. Sumar\n2. Restar\n3. Multiplicar\n4. Dividir\n5. Salir");
            Console.Write("\nSu opcion: ");

            try
            {
                int op = short.Parse(Console.ReadLine());
                Console.WriteLine("\n");

                if (op != 5)
                {
                    switch (op)
                    {
                        case 1:
                            //Sumar
                            PL.OpsServicios.Suma();
                            MenuServicios();
                            break;

                        case 2:
                            //Restar
                            PL.OpsServicios.Resta();
                            MenuServicios();
                            break;

                        case 3:
                            //Multiplicar
                            PL.OpsServicios.Multiplicacion();
                            MenuServicios();
                            break;

                        case 4:
                            //Dividir
                            PL.OpsServicios.Division();
                            MenuServicios();
                            break;                        

                        default:
                            Console.WriteLine("Error, opcion invalida. Intente de nuevo.");
                            MenuProducto();
                            break;
                    }//switch
                }//if
                else if (op == 5)
                {
                    Console.WriteLine("Adios!. Presione cualquier tecla para salir.");
                    Console.ReadKey();
                }//else

            }//try
            catch (Exception)
            {
                Console.WriteLine("Error. Intente de nuevo: ");
                MenuServicios();
            }//catch
        }//MenuServicios

        public static void MenuProductoServicios()
        {
            Console.WriteLine("\n\t----Producto(Servicios)----\n");
            Console.WriteLine("¿Que desea realizar?" +
                "\n1. Ingresar\n2. Eliminar\n3. Actualizar\n4. Consulta general\n5. Consulta por ID\n6. Salir");
            Console.Write("\nSu opcion: ");

            try
            {
                int op = short.Parse(Console.ReadLine());
                Console.WriteLine("\n");

                if (op != 6)
                {
                    switch (op)
                    {
                        case 1:
                            //Insertar
                            PL.ProductoServicios.Add();
                            MenuProductoServicios();
                            break;

                        case 2:
                            //Eliminar
                            PL.ProductoServicios.Delete();
                            MenuProductoServicios();
                            break;

                        case 3:
                            //Actualizar
                            PL.ProductoServicios.Update();
                            MenuProductoServicios();
                            break;

                        case 4:
                            //Consulta general
                            PL.ProductoServicios.GetAll();
                            MenuProductoServicios();
                            break;

                        case 5:
                            //Consulta por Id
                            PL.ProductoServicios.GetById();
                            MenuProductoServicios();
                            break;

                        default:
                            Console.WriteLine("Error, opcion invalida. Intente de nuevo.");
                            MenuProductoServicios();
                            break;
                    }//switch
                }//if
                else if (op == 6)
                {
                    Console.WriteLine("Adios!. Presione cualquier tecla para salir.");
                    Console.ReadKey();
                }//else

            }//try
            catch (Exception)
            {
                Console.WriteLine("Error. Intente de nuevo: ");
                MenuProductoServicios();
            }//catch
        }//MenuProductoServicios

        public static void MenuDeptoServicios()
        {
            Console.WriteLine("\n\t----Departamento(Servicios)----\n");
            Console.WriteLine("¿Que desea realizar?" +
                "\n1. Ingresar\n2. Eliminar\n3. Actualizar\n4. Consulta general\n5. Consulta por ID\n6. Salir");
            Console.Write("\nSu opcion: ");

            try
            {
                int op = short.Parse(Console.ReadLine());
                Console.WriteLine("\n");

                if (op != 6)
                {
                    switch (op)
                    {
                        case 1:
                            //Insertar
                            PL.DepartamentoServicios.Add();
                            MenuDeptoServicios();
                            break;

                        case 2:
                            //Eliminar
                            PL.DepartamentoServicios.Delete();
                            MenuDeptoServicios();
                            break;

                        case 3:
                            //Actualizar
                            PL.DepartamentoServicios.Update();
                            MenuDeptoServicios();
                            break;

                        case 4:
                            //Consulta general
                            PL.DepartamentoServicios.GetAll();
                            MenuDeptoServicios();
                            break;

                        case 5:
                            //Consulta por Id
                            PL.DepartamentoServicios.GetById();
                            MenuDeptoServicios();
                            break;

                        default:
                            Console.WriteLine("Error, opcion invalida. Intente de nuevo.");
                            MenuDeptoServicios();
                            break;
                    }//switch
                }//if
                else if (op == 6)
                {
                    Console.WriteLine("Adios!. Presione cualquier tecla para salir.");                    
                }//else

            }//try
            catch (Exception)
            {
                Console.WriteLine("Error. Intente de nuevo: ");
                MenuProductoServicios();
            }//catch
        }//MenuProductoServicios

        /*
        public static void MenuDepartamento()
        {
            Console.WriteLine("\n\t----Departamento----");
            Console.WriteLine("¿Que desea realizar?\n" +
                "1. Ingresar\n2. Eliminar\n3. Actualizar\n4. Consulta general\n5. Consulta por ID\n6. Salir");
            Console.Write("\nSu opcion: ");

            try
            {
                int op = Int16.Parse(Console.ReadLine());
                Console.WriteLine("\n");
                if (op != 6)
                {
                    switch (op)
                    {
                        case 1:
                            //Insertar
                            PL.Departamento.Add();
                            MenuDepartamento();
                            break;

                        case 2:
                            //Eliminar
                            PL.Departamento.Delete();
                            MenuDepartamento();
                            break;

                        case 3:
                            //Actualizar
                            PL.Departamento.Update();
                            MenuDepartamento();
                            break;

                        case 4:
                            //Consulta general
                            PL.Departamento.GetAll();
                            MenuDepartamento();
                            break;

                        case 5:
                            //Consulta por Id
                            PL.Departamento.GetById();
                            MenuDepartamento();
                            break;

                        default:
                            Console.WriteLine("Error, opcion invalida. Intente de nuevo.");
                            MenuDepartamento();
                            break;
                    }//switch
                }//if
                else if(op == 6)
                {
                    Console.WriteLine("Adios!!");
                    Console.ReadKey();
                }
                
            }//try
            catch (Exception)
            {
                Console.WriteLine("Error. Intente de nuevo: ");
                MenuDepartamento();
            }//catch
        }//MenuDepartamento
        */
    }//Program
}//NS PL
