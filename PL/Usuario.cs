using BL;
using DL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PL
{
    public class Usuario
    { 
        /*
        public static void Add() {

            ML.Usuario usuario = new ML.Usuario();
            usuario.Rol = new ML.Rol();

            Console.WriteLine("Ingrese los datos por favor: ");

            Console.Write("UserName: ");
            usuario.UserName = Console.ReadLine();

            Console.Write("\nNombre: ");
            usuario.Nombre = Console.ReadLine();

            Console.Write("\nApellido Paterno: ");
            usuario.ApellidoPaterno = Console.ReadLine();

            Console.Write("\nApellido Materno: ");
            usuario.ApellidoMaterno= Console.ReadLine();

            Console.Write("\nEmail: ");
            usuario.Email = Console.ReadLine();

            Console.Write("\nPassword: ");
            usuario.Password = Console.ReadLine();

            Console.Write("\nFecha de Nacimiento: ");
            usuario.FechaNacimiento = Console.ReadLine();

            Console.Write("\nSexo: ");
            usuario.Sexo = Console.ReadLine();

            Console.Write("\nTelefono: ");
            usuario.Telefono = Console.ReadLine();

            Console.Write("\nCelular: ");
            usuario.Celular = Console.ReadLine();

            Console.Write("\nCURP: ");
            usuario.CURP = Console.ReadLine();

            usuario.Imagen = null;

            Console.Write("\nIdRol: ");
            usuario.Rol.IdRol = byte.Parse(Console.ReadLine());

            //ML.Result result = BL.Usuario.Add(usuario); //Por Query
            //ML.Result result = BL.Usuario.AddSP(usuario); //Por SP
            ML.Result result = BL.Usuario.AddEF(usuario); //Por EF
            //ML.Result result = BL.Usuario.AddLINQ(usuario); //Por LINQ

            //Validar el resultado (true/false)
            if (result.Correct)
            {
                Console.WriteLine("\n\t-----Se registró el usuario correctamente!-----");
            }
            else
            {
                Console.WriteLine("Error al registrar el usuario.");
            }
        }//Add()

        public static void Update() {
            ML.Usuario usuario = new ML.Usuario();
            usuario.Rol = new ML.Rol();

            Console.WriteLine("Ingrese el ID del registro que desea actualizar: ");
            usuario.IdUsuario = Int16.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese los datos por favor: ");

            Console.Write("UserName: ");
            usuario.UserName = Console.ReadLine();

            Console.Write("\nNombre: ");
            usuario.Nombre = Console.ReadLine();

            Console.Write("\nApellido Paterno: ");
            usuario.ApellidoPaterno = Console.ReadLine();

            Console.Write("\nApellido Materno: ");
            usuario.ApellidoMaterno = Console.ReadLine();

            Console.Write("\nEmail: ");
            usuario.Email = Console.ReadLine();

            Console.Write("\nPassword: ");
            usuario.Password = Console.ReadLine();

            Console.Write("\nFecha de Nacimiento: ");
            usuario.FechaNacimiento = Console.ReadLine();

            Console.Write("\nSexo: ");
            usuario.Sexo = Console.ReadLine();

            Console.Write("\nTelefono: ");
            usuario.Telefono = Console.ReadLine();

            Console.Write("\nCelular: ");
            usuario.Celular = Console.ReadLine();

            Console.Write("\nCURP: ");
            usuario.CURP = Console.ReadLine();

            usuario.Imagen = null;

            Console.Write("\nIdRol: ");
            usuario.Rol.IdRol = byte.Parse(Console.ReadLine());

            //ML.Result result = BL.Usuario.Update(usuario); //Por Query
            //ML.Result result = BL.Usuario.UpdateSP(usuario); //Por SP
            ML.Result result = BL.Usuario.UpdateEF(usuario); //Por EF
            //ML.Result result = BL.Usuario.UpdateLINQ(usuario); //Por EF

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
            ML.Usuario usuario = new ML.Usuario();

            Console.WriteLine("Ingrese el ID del registro que desea eliminar: ");
            int IdUsuario = Int16.Parse(Console.ReadLine());

            //ML.Result result = BL.Usuario.Delete(IdUsuario); //Por Query
            //ML.Result result = BL.Usuario.DeleteSP(IdUsuario); //Por SP
            ML.Result result = BL.Usuario.DeleteEF(IdUsuario); //Por EF
            //ML.Result result = BL.Usuario.DeleteLINQ(IdUsuario); //Por LINQ

            //En caso de que no se encuentre el registro para borrar, pedir de nuevo el Id
            while (!result.Correct)
            {
                Console.Write("\n\tError al eliminar al usuario. Intente de nuevo: ");
                IdUsuario = Int16.Parse(Console.ReadLine());

                result = BL.Usuario.DeleteEF(IdUsuario);
            }

            //Validar el resultado (true/false)
            if (result.Correct)
            {
                Console.WriteLine("\n\t-----Usuario eliminado correctamente!-----");
            }
        }//Delete()

        public static void GetAll() {

            Console.WriteLine("\n\t-----Registros en la tabla Usuario-----\n");

            ML.Result result = BL.Usuario.GetAllEF(); //EF
            //ML.Result result = BL.Usuario.GetAllLINQ(); //LINQ

            //Validar el resultado (true/false)
            if (result.Correct)
            {
                foreach (ML.Usuario usuario in result.Objects)
                {
                    Console.WriteLine("IdUsuario: " + usuario.IdUsuario);
                    Console.WriteLine("UserName: " + usuario.UserName);
                    Console.WriteLine("Nombre: " + usuario.Nombre);
                    Console.WriteLine("Apellido Paterno: " + usuario.ApellidoPaterno);
                    Console.WriteLine("Apellido Materno: " + usuario.ApellidoMaterno);
                    Console.WriteLine("Email: " + usuario.Email);
                    Console.WriteLine("Password: " + usuario.Password);
                    Console.WriteLine("Fecha de Nacimiento: " + usuario.FechaNacimiento);
                    Console.WriteLine("Telefono: " + usuario.Telefono);
                    Console.WriteLine("Celular: " + usuario.Celular);
                    Console.WriteLine("CURP: " + usuario.CURP);
                    Console.WriteLine("Imagen: " + usuario.Imagen);
                    Console.WriteLine("IdRol: " + (byte)usuario.Rol.IdRol);
                    Console.WriteLine("Rol: " + usuario.Rol.Nombre);
                    Console.WriteLine("------------------------------------");

                }//foreach
            }//if
        }//GetAll()

        public static void GetById() {
            

            Console.WriteLine("Ingrese el ID del registro que desea consultar: ");
            int IdUsuario = Int16.Parse(Console.ReadLine());

            ML.Result result = BL.Usuario.GetByIdEF(IdUsuario); //EF
            //ML.Result result = BL.Usuario.GetByIdLINQ(IdUsuario); //LINQ

            ML.Usuario usuario = result.Object as ML.Usuario;
            

            if (result.Correct) {

                Console.WriteLine("------------------------------------");
                Console.WriteLine("IdUsuario: " + usuario.IdUsuario);
                Console.WriteLine("UserName: " + usuario.UserName);
                Console.WriteLine("Nombre: " + usuario.Nombre);
                Console.WriteLine("Apellido Paterno: " + usuario.ApellidoPaterno);
                Console.WriteLine("Apellido Materno: " + usuario.ApellidoMaterno);
                Console.WriteLine("Email: " + usuario.Email);
                Console.WriteLine("Password: " + usuario.Password);
                Console.WriteLine("Fecha de Nacimiento: " + usuario.FechaNacimiento);
                Console.WriteLine("Telefono: " + usuario.Telefono);
                Console.WriteLine("Celular: " + usuario.Celular);
                Console.WriteLine("CURP: " + usuario.CURP);
                Console.WriteLine("Imagen: " + usuario.Imagen);
                Console.WriteLine("IdRol: " + (byte)usuario.Rol.IdRol);
                Console.WriteLine("Rol: " + usuario.Rol.Nombre);
                Console.WriteLine("------------------------------------");
            }

            //En caso de no encontrar registros, repetir la peticion del Id al usuario.
            else
            {
                Console.Write("\n\t----No se encontró un registro con ese Id----\n\n");
                GetById();
            }
        }//GetById()

        */
    }//ClassUsuario
}//NS PL
