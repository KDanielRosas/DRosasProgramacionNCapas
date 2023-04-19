using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Departamento
    {
        /*
        public static void Add()
        {
            ML.Departamento departamento = new ML.Departamento();
            departamento.Area = new ML.Area();

            Console.WriteLine("Ingrese los datos del departamento: ");

            Console.Write("Nombre: ");
            departamento.Nombre = Console.ReadLine();

            Console.Write("\nIdArea: ");
            departamento.Area.IdArea = Int16.Parse(Console.ReadLine());

            //ML.Result result = BL.Departamento.AddEF(departamento); //Por EF
            ML.Result result = BL.Departamento.AddLINQ(departamento); //Por LINQ

            //Validad resultado
            if (result.Correct)
            {
                Console.WriteLine("\n\t----Departamento registrado exitosamente-----");
            }//if
            else
            {
                Console.WriteLine("Error al registrar el departamento!");
            }//else
        }//Add()

        public static void Update()
        {
            ML.Departamento departamento = new ML.Departamento();
            departamento.Area = new ML.Area();

            Console.Write("\nIngrese el ID del departamento a editar: ");
            departamento.IdDepartamento = Int16.Parse(Console.ReadLine());

            Console.WriteLine("\t----Ingrese los datos----");

            Console.Write("\nNombre: ");
            departamento.Nombre = Console.ReadLine();

            Console.Write("\nIdArea: ");
            departamento.Area.IdArea = Int16.Parse(Console.ReadLine());

            //ML.Result result = BL.Departamento.UpdateEF(departamento); //Por EF
            ML.Result result = BL.Departamento.UpdateLINQ(departamento); //Por LINQ

            //Validar resultado
            if (result.Correct)
            {
                Console.WriteLine("\n\t----Departamento actualizado correctamente!----");
            }//if
            else 
            {
                Console.WriteLine("Error al actualizar el departamento");
            }//else
        }//Update()

        public static void Delete()
        {
            
            Console.WriteLine("Ingrese el ID del departamento a eliminar: ");
            int IdDepartamento= Int16.Parse(Console.ReadLine());

            //ML.Result result = BL.Departamento.DeleteEF(IdDepartamento); //Por EF
            ML.Result result = BL.Departamento.DeleteLINQ(IdDepartamento); //Por LINQ

            //Evaluar resultado
            if (result.Correct) 
            {
                Console.WriteLine("\n\t----Departamento eliminado correctamente!----");
            }//if
            else
            {
                Console.WriteLine("Error. Intente de nuevo!\n");
                Delete();
            }//else

        }//Delete()

        public static void GetAll()
        {
            Console.WriteLine("\n\t-----Registros en la tabla Departamento----\n");

            //ML.Result result = BL.Departamento.GetAllEF(); //Por EF
            ML.Result result = BL.Departamento.GetAllLINQ(); //Por LINQ

            //Evaluar resultado
            if (result.Correct) 
            {

                foreach (ML.Departamento departamento in result.Objects)
                {
                    Console.WriteLine("IdDepartamento: " + departamento.IdDepartamento);
                    Console.WriteLine("Nombre: " + departamento.Nombre);
                    Console.WriteLine("IdArea: " + departamento.Area.IdArea);
                    Console.WriteLine("Area: " + departamento.Area.Nombre);
                    Console.WriteLine("------------------------------------");
                }//foreach
            }//if
            else
            {
                Console.WriteLine("Error al mostrar los registros!");
            }//else

        }//GetAll()

        public static void GetById() 
        {
            Console.Write("Ingrese el ID del departamento que desea consultar: ");
            int IdDepartamento = Int16.Parse(Console.ReadLine());

            //ML.Result result = BL.Departamento.GetByIdEF(IdDepartamento); //Por EF
            ML.Result result = BL.Departamento.GetByIdLINQ(IdDepartamento); //Por LINQ

            ML.Departamento departamento = result.Object as ML.Departamento;

            //Evaluar resultado
            if (result.Correct)
            { 
                Console.WriteLine("\n------------------------------------");
                Console.WriteLine("IdDepartamento: " + departamento.IdDepartamento);
                Console.WriteLine("Nombre: " + departamento.Nombre);
                Console.WriteLine("IdArea: " + departamento.Area.IdArea);
                Console.WriteLine("Area: " + departamento.Area.Nombre);
                Console.WriteLine("------------------------------------");
            }//if
            else
            {
                Console.WriteLine("\n\t-----No se encontró un reigstro con ese ID. Intente de nuevo.\n");
                GetById();
            }//else
        }//GetById()

        */
    }//ClassDepartamento
}//NS Departamento
