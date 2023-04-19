using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DepartamentoService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select DepartamentoService.svc or DepartamentoService.svc.cs at the Solution Explorer and start debugging.
    public class DepartamentoService : IDepartamentoService
    {
        public bool Add(Depto obj)
        {
            ML.Departamento departamento = new ML.Departamento();
            departamento.Nombre = obj.Nombre;
            departamento.Area = new ML.Area();
            departamento.Area.IdArea = obj.IdArea;
            ML.Result result = BL.Departamento.AddLINQ(departamento);
            if (result.Correct)
            {
                return true;
            }
            else
            {
                return false;
            }            
        }//Add

        public bool Delete(int idDepartamento)
        {
            ML.Result result = BL.Departamento.DeleteLINQ(idDepartamento);
            if (result.Correct)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Update(Depto obj)
        {
            ML.Departamento departamento = new ML.Departamento();
            departamento.IdDepartamento = obj.IdDepartamento;
            departamento.Nombre = obj.Nombre;
            departamento.Area = new ML.Area();
            departamento.Area.IdArea = obj.IdArea;
            ML.Result result = BL.Departamento.UpdateLINQ(departamento);
            if (result.Correct)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Depto> GetAll()
        {
            ML.Result result = BL.Departamento.GetAllLINQ();
            List<Depto> list = new List<Depto>();
            foreach (ML.Departamento departamento in result.Objects.Cast<ML.Departamento>())
            {
                var item = new Depto
                {
                    IdDepartamento = departamento.IdDepartamento,
                    Nombre = departamento.Nombre,
                    IdArea = departamento.Area.IdArea,
                    NombreArea = departamento.Area.Nombre
                };
                list.Add(item);
            }
            return list;
        }

        public Depto GetById(int idDepartamento) 
        {
            ML.Result result = BL.Departamento.GetByIdLINQ(idDepartamento);
            var item = (ML.Departamento)result.Object;
            Depto depto = new Depto
            {
                IdDepartamento = item.IdDepartamento,
                Nombre = item.Nombre,
                IdArea = item.Area.IdArea,
                NombreArea = item.Area.Nombre
            };

            return depto;
        }
    }
}
