using DL;
using ML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace BL
{
    public class Departamento
    {
        //EF
        //    public static ML.Result AddEF(ML.Departamento departamento)
        //    {
        //        ML.Result result = new ML.Result();
        //        try
        //        {
        //            using (DRosasProgramacionNCapasEntities1 context = new DRosasProgramacionNCapasEntities1())
        //            {
        //                int query = context.DepartamentoAdd(departamento.Nombre, departamento.Area.IdArea);

        //                //Validar si hay filas afectadas
        //                if (query > 0) 
        //                {
        //                    result.Correct = true;
        //                }//if
        //                else
        //                {
        //                    result.Correct = false;
        //                    result.ErrorMessage = "Error al registrar el departamento!";
        //                }
        //            }//usingContext
        //        }//try
        //        catch (Exception ex)
        //        {
        //            result.Ex = ex;
        //            result.ErrorMessage = "Ocurrio un error al registrar el departamento!";
        //            result.Correct = false;
        //            throw;
        //        }//catch

        //        return result;

        //    }//AddEF

        //    public static ML.Result UpdateEF(ML.Departamento departamento)
        //    {
        //        ML.Result result = new ML.Result();

        //        try
        //        {
        //            using (DRosasProgramacionNCapasEntities1 context = new DRosasProgramacionNCapasEntities1())
        //            {
        //                int query = context.DepartamentoUpdate(departamento.IdDepartamento, departamento.Nombre, departamento.Area.IdArea);

        //                if (query > 0)
        //                {
        //                    result.Correct = true;
        //                }//if
        //                else
        //                {
        //                    result.Correct = false;
        //                    result.ErrorMessage = "Error al actualizar el registro!";
        //                }//else
        //            }//usingContext
        //        }//try
        //        catch (Exception ex)
        //        {
        //            result.Ex = ex;
        //            result.Correct = false;
        //            result.ErrorMessage = "Ocurrio un error!";
        //            throw;
        //        }//catch

        //        return result;

        //    }//UpdateEF

        //    public static ML.Result DeleteEF(int IdDepartamento)
        //    {
        //        ML.Result result = new Result();

        //        try
        //        {
        //            using (DRosasProgramacionNCapasEntities1 context = new DRosasProgramacionNCapasEntities1())
        //            {
        //                int query = context.DepartamentoDelete(IdDepartamento);

        //                if (query > 0)
        //                {
        //                    result.Correct = true;
        //                }//if
        //                else
        //                {
        //                    result.Correct = false;
        //                }//else
        //            }//usingContext
        //        }//try
        //        catch (Exception ex)
        //        {
        //            result.Ex=ex;
        //            result.Correct = false;
        //            result.ErrorMessage = "Error al eliminar el usuario!";
        //            throw;
        //        }//catch

        //        return result;

        //    }//DeleteEf

        public static ML.Result GetAllEF()
        {
            ML.Result result = new Result();

            try
            {
                using (DRosasNetFrameworkEntities context = new DRosasNetFrameworkEntities())
                {
                    var query = context.DepartamentoGetAll().ToList();

                    if (query != null)
                    {
                        result.Objects = new List<object>();

                        foreach (var item in query)
                        {
                            ML.Departamento departamento = new ML.Departamento();

                            departamento.IdDepartamento = item.IdDepartamento;
                            departamento.Nombre = item.Nombre;
                            departamento.Area = new ML.Area();
                            departamento.Area.IdArea = item.IdArea.Value;
                            departamento.Area.Nombre = item.NombreArea;

                            result.Objects.Add(departamento);
                        }//foreach
                        result.Correct = true;
                    }//if
                }//usingContext
            }//try
            catch (Exception ex)
            {
                result.Ex = ex;
                result.Correct = false;
                result.ErrorMessage = "Error al mostrar los registros!";
                throw;
                throw;
            }//catch
            return result;
        }//GetAllEF

        /*
        public static ML.Result GetByIdEF(int IdDepartamento)
        {
            ML.Result result = new ML.Result();
            ML.Departamento departamento = new ML.Departamento();

            try
            {
                using (DRosasNetFrameworkEntities context = new DRosasNetFrameworkEntities())
                {
                    var query = context.DepartamentoGetById(IdDepartamento).FirstOrDefault();

                    if (query != null)
                    {

                        result.Object = new object();
                        result.Correct = true;

                        departamento.IdDepartamento = query.IdDepartamento;
                        departamento.Nombre = query.Nombre;
                        departamento.Area = new ML.Area();
                        departamento.Area.IdArea = query.IdArea.Value;
                        departamento.Area.Nombre = query.NombreArea;

                        result.Object = departamento;

                    }//if
                }//usingContext
            }//try
            catch (Exception ex)
            {
                result.Correct = false;
                result.Ex = ex;
                result.ErrorMessage = "No existe un registro con ese ID.";
                throw;
                throw;
            }//catch

            return result;
        }//GetByIdEF
        */
        public static ML.Result GetByIdArea(int idArea)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DRosasNetFrameworkEntities context = new DRosasNetFrameworkEntities())
                {
                    var query = context.DepartamentoGetByIdArea(idArea).ToList();

                    if (query != null)
                    {
                        result.Objects = new List<object>();
                        foreach (var item in query)
                        {
                            ML.Departamento departamento = new ML.Departamento();

                            departamento.IdDepartamento = item.IdDepartamento;
                            departamento.Nombre = item.Nombre;
                            departamento.Area = new ML.Area();
                            departamento.Area.IdArea = item.IdArea.Value;

                            result.Objects.Add(departamento);
                        }//foreach
                        result.Correct = true;
                    }//else
                }//using
            }//try
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                throw;
            }//catch
            return result;
        }//GetByIdArea

        //LINQ

        public static ML.Result AddLINQ(ML.Departamento departamento)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DRosasNetFrameworkEntities context = new DRosasNetFrameworkEntities())
                {
                    DL.Departamento departamentoDL = new DL.Departamento
                    {
                        Nombre = departamento.Nombre,
                        IdArea = departamento.Area.IdArea                        
                    };

                    context.Departamentoes.Add(departamentoDL);
                    context.SaveChanges();

                    result.Correct = true;

                }//usingContext
            }//try
            catch (Exception ex)
            {
                result.Ex = ex;
                result.ErrorMessage = "Ocurrio un error al registrar el departamento!";
                result.Correct = false;
                throw;
            }//catch

            return result;

        }//AddLINQ

        public static ML.Result UpdateLINQ(ML.Departamento departamento)
        {
            ML.Result result = new Result();

            try
            {
                using (DRosasNetFrameworkEntities context = new DRosasNetFrameworkEntities())
                {
                    var query = (from depto in context.Departamentoes
                                 where depto.IdDepartamento == departamento.IdDepartamento
                                 select depto).FirstOrDefault();

                    if (query != null)
                    {
                        query.IdDepartamento = departamento.IdDepartamento;
                        query.Nombre = departamento.Nombre;
                        query.IdArea = departamento.Area.IdArea;

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

        public static ML.Result DeleteLINQ(int IdDepartamento)
        {
            ML.Result result = new Result();

            try
            {
                using (DRosasNetFrameworkEntities context = new DRosasNetFrameworkEntities())
                {
                    var query = (from depto in context.Departamentoes
                                 where depto.IdDepartamento == IdDepartamento
                                 select depto).First();
                    context.Departamentoes.Remove(query);
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
                    var query = from depto in context.Departamentoes
                                join area in context.Areas
                                on depto.IdArea equals area.IdArea
                                select new
                                {
                                    depto.IdDepartamento,
                                    depto.Nombre,
                                    depto.IdArea,
                                    NombreArea = area.Nombre,
                                };
                    if (query != null)
                    {
                        result.Objects = new List<object>();

                        foreach (var item in query)
                        {
                            ML.Departamento departamento = new ML.Departamento();

                            departamento.IdDepartamento = item.IdDepartamento;
                            departamento.Nombre = item.Nombre;
                            departamento.Area = new ML.Area();
                            departamento.Area.IdArea = item.IdArea.Value;
                            departamento.Area.Nombre = item.NombreArea;

                            result.Objects.Add(departamento);
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

        public static ML.Result GetByIdLINQ(int IdDepartamento)
        {
            ML.Result result = new ML.Result();
            ML.Departamento departamento = new ML.Departamento();

            try
            {
                using (DRosasNetFrameworkEntities context = new DRosasNetFrameworkEntities())
                {
                    var query = from depto in context.Departamentoes
                                join area in context.Areas
                                on depto.IdArea equals area.IdArea
                                where depto.IdDepartamento == IdDepartamento
                                select new
                                {
                                    depto.IdDepartamento,
                                    depto.Nombre,
                                    depto.Area.IdArea,
                                    NombreArea = area.Nombre
                                };
                    if (query != null)
                    {
                        result.Object = new object();
                        result.Correct = true;

                        foreach (var item in query)
                        {
                            departamento.IdDepartamento = item.IdDepartamento;
                            departamento.Nombre = item.Nombre;
                            departamento.Area = new ML.Area();
                            departamento.Area.IdArea = item.IdArea;
                            departamento.Area.Nombre = item.NombreArea;

                            result.Object = departamento;

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

    }//ClassDepartamento
}//NS BL
