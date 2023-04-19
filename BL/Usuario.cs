using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using DL;
using System.Linq;
using ML;
using System.Runtime.InteropServices.WindowsRuntime;

namespace BL
{
    public class Usuario
    {
        
        //SQLCLIENT
        //public static ML.Result Add(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            string query = "INSERT INTO Usuario(Nombre,ApellidoPaterno,ApellidoMaterno,Contraseña,Rol) " +
        //                "VALUES (@Nombre,@ApellidoPaterno,@ApellidoMaterno,@Contraseña,@Rol)";

        //            using (SqlCommand cmd = new SqlCommand()) 
        //            {
        //                cmd.Connection= context;
        //                cmd.CommandText= query;

        //                SqlParameter[] collection = new SqlParameter[5];

        //                collection[0] = new SqlParameter("Nombre", SqlDbType.VarChar);
        //                collection[0].Value = usuario.Nombre;

        //                collection[1] = new SqlParameter("ApellidoPaterno", SqlDbType.VarChar);
        //                collection[1].Value = usuario.ApellidoPaterno;

        //                collection[2] = new SqlParameter("ApellidoMaterno", SqlDbType.VarChar);
        //                collection[2].Value = usuario.ApellidoMaterno;

        //                collection[3] = new SqlParameter("Contraseña", SqlDbType.VarChar);
        //                collection[3].Value = usuario.Contraseña;

        //                collection[4] = new SqlParameter("Rol", SqlDbType.VarChar);
        //                collection[4].Value = (byte)usuario.Rol.IdRol;

        //                cmd.Parameters.AddRange(collection);
        //                cmd.Connection.Open();

        //                int rowsAffected = cmd.ExecuteNonQuery();

        //                //Validar si hay filas afectadas
        //                if (rowsAffected > 0)
        //                {
        //                    result.Correct = true;
        //                }//if
        //            }//using SQL Command
        //        }//using SQL Connection
        //    }//try

        //    catch (Exception ex)
        //    {
        //        result.Ex = ex;
        //        result.Correct = false;
        //        result.ErrorMessage = "Ocurrio un error al registrar el usuario";
        //        throw;
        //    }
        //    return result;
        //}//Add

        //public static ML.Result Update(ML.Usuario usuario)
        //{
            
        //    ML.Result result = new ML.Result();
            
        //    try
        //    {
        //        using (SqlConnection conn = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            string queryUpdate = "UPDATE Usuario SET Nombre =@Nombre, ApellidoPaterno=@ApellidoPaterno, " +
        //                "ApellidoMaterno=@ApellidoMaterno,Contraseña=@Contraseña,Rol=@Rol WHERE IdUsuario=@IdUsuario";
                    
        //            using (SqlCommand cmd = new SqlCommand())
        //            {
        //                cmd.Connection= conn;
        //                cmd.CommandText= queryUpdate;

        //                SqlParameter[] collection = new SqlParameter[6];

        //                collection[0] = new SqlParameter("IdUsuario", SqlDbType.Int);
        //                collection[0].Value = usuario.IdUsuario;

        //                collection[1] = new SqlParameter("Nombre", SqlDbType.VarChar);
        //                collection[1].Value = usuario.Nombre;

        //                collection[2] = new SqlParameter("ApellidoPaterno", SqlDbType.VarChar);
        //                collection[2].Value = usuario.ApellidoPaterno;

        //                collection[3] = new SqlParameter("ApellidoMaterno", SqlDbType.VarChar);
        //                collection[3].Value = usuario.ApellidoMaterno;

        //                collection[4] = new SqlParameter("Contraseña", SqlDbType.VarChar);
        //                collection[4].Value = usuario.Contraseña;

        //                collection[5] = new SqlParameter("Rol", SqlDbType.VarChar);
        //                collection[5].Value = usuario.Rol.IdRol;

        //                cmd.Parameters.AddRange(collection);
        //                cmd.Connection.Open();

        //                int rowsAffected = cmd.ExecuteNonQuery();

        //                //Validar si hay filas afectadas
        //                if (rowsAffected > 0)
        //                {
        //                    result.Correct = true;
                            
        //                }//if
        //            }//using SqlCommand
        //        }//using SqlConnection
        //    }//try

        //    catch (Exception ex)
        //    {
        //        result.Ex = ex; 
        //        result.Correct = false;
        //        result.ErrorMessage = "Error al actualizar el usuario.";
        //        throw;
        //    }//catch
            
        //    return result;
        //}//Update

        //public static ML.Result Delete(int IdUsuario)
        //{
        //    ML.Result result = new ML.Result();

        //    try
        //    {
        //        using (var conn = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            string queryDelete = "DELETE FROM Usuario WHERE IdUsuario=@IdUsuario";

        //            using (SqlCommand cmd = new SqlCommand())
        //            {
        //                cmd.Connection = conn;
        //                cmd.CommandText = queryDelete;

        //                SqlParameter[] collection = new SqlParameter[1];

        //                collection[0] = new SqlParameter("IdUsuario", SqlDbType.Int);
        //                collection[0].Value = IdUsuario;

        //                cmd.Parameters.AddRange(collection);
        //                cmd.Connection.Open();

        //                int rowsAffected = cmd.ExecuteNonQuery();

        //                //Validar si hay filas afectadas
        //                if (rowsAffected > 0)
        //                {
        //                    result.Correct = true;
                            
        //                }//if
        //            }//using SqlCommand
        //        }//using SqlConnection
        //    }//try

        //    catch (Exception ex)
        //    {
        //        result.Ex = ex;
        //        result.Correct = false;
        //        result.ErrorMessage = "Ocurrio un error al eliminar el usuario";
        //        throw;
        //    }//catch
        //    return result;
        //}//Delete

        //SP

        //public static ML.Result GetAll()
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            string query = "UsuarioGetAll";
                    
        //            using (SqlCommand cmd = new SqlCommand()) 
        //            { 
        //                cmd.Connection = context;
        //                cmd.CommandText = query;
        //                cmd.CommandType = CommandType.StoredProcedure;

        //                DataTable Usuariodt = new DataTable();
        //                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

        //                adapter.Fill(Usuariodt);

        //                //Validar si reader tiene filas
        //                if (Usuariodt.Rows.Count > 0)
        //                {
        //                    //result.Correct = true;
        //                    result.Objects = new List<object>();

        //                    foreach (DataRow row in Usuariodt.Rows)
        //                    {
        //                        ML.Usuario usuario = new ML.Usuario();
        //                        usuario.IdUsuario = (int)row[0];
        //                        usuario.Nombre = row[1].ToString();
        //                        usuario.ApellidoPaterno = row[2].ToString();
        //                        usuario.ApellidoMaterno = row[3].ToString();
        //                        usuario.Contraseña = row[4].ToString();
        //                        usuario.Rol.IdRol = (byte)row[5];

        //                        result.Objects.Add(usuario);

        //                    }//foreach
        //                }//if
        //                result.Correct = true;
        //            }//using SqlCommand
        //        }//using
        //    }//try

        //    catch (Exception ex)
        //    {
        //        result.Ex = ex;
        //        result.Correct = false;
        //        result.ErrorMessage = "Error al consultar los registros.";
        //        throw;
        //    }//catch
        //    return result;     
        //}//GetAll

        //public static ML.Result GetById(int IdUsuario)
        //{
        //    ML.Result result = new ML.Result();
        //    ML.Usuario usuario = new ML.Usuario();
        //    try
        //    {
        //        using (SqlConnection conn = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            string query = "UsuarioGetById";
                    
        //            using (SqlCommand cmd = conn.CreateCommand()) 
        //            {
        //                cmd.Connection = conn;
        //                cmd.CommandText = query;
        //                cmd.CommandType = CommandType.StoredProcedure;

        //                SqlParameter[] collection = new SqlParameter[1];

        //                collection[0] = new SqlParameter("IdUsuario", SqlDbType.Int);
        //                collection[0].Value = IdUsuario;

        //                cmd.Parameters.AddRange(collection);

        //                cmd.Connection.Open();

        //                DataTable Usuariodt = new DataTable();
        //                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //                adapter.Fill(Usuariodt);

        //                if (Usuariodt.Rows.Count > 0)
        //                {
        //                    //result.Objects = new List<object>();
        //                    result.Object = new object();
        //                    result.Correct = true;

        //                    DataRow row = Usuariodt.Rows[0];

        //                        usuario.IdUsuario = (int)row[0];
        //                        usuario.Nombre = row[1].ToString();
        //                        usuario.ApellidoPaterno = row[2].ToString();
        //                        usuario.ApellidoMaterno = row[3].ToString();
        //                        usuario.Contraseña = row[4].ToString();
        //                        usuario.Rol.IdRol = (byte)row[5];

        //                        result.Object = usuario;
                                                      
        //                }//if                                               
        //            }//using SqlCommand                                        
        //        }//using
        //    }//try

        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.Ex = ex;
        //        result.ErrorMessage = "No existe un registro con ese ID.";
        //        throw;
        //    }//catch
        //    return result;
        //}//GetById

        //public static ML.Result AddSP(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            string query = "UsuarioAdd";

        //            using (SqlCommand cmd = new SqlCommand())
        //            {
        //                cmd.Connection = context;
        //                cmd.CommandText = query;
        //                cmd.CommandType = CommandType.StoredProcedure;

        //                SqlParameter[] collection = new SqlParameter[5];

        //                collection[0] = new SqlParameter("Nombre", SqlDbType.VarChar);
        //                collection[0].Value = usuario.Nombre;

        //                collection[1] = new SqlParameter("ApellidoPaterno", SqlDbType.VarChar);
        //                collection[1].Value = usuario.ApellidoPaterno;

        //                collection[2] = new SqlParameter("ApellidoMaterno", SqlDbType.VarChar);
        //                collection[2].Value = usuario.ApellidoMaterno;

        //                collection[3] = new SqlParameter("Contraseña", SqlDbType.VarChar);
        //                collection[3].Value = usuario.Contraseña;

        //                collection[4] = new SqlParameter("Rol", SqlDbType.VarChar);
        //                collection[4].Value = usuario.Rol.IdRol;

        //                cmd.Parameters.AddRange(collection);
        //                cmd.Connection.Open();

        //                int rowsAffected = cmd.ExecuteNonQuery();

        //                //Validar si hay filas afectadas
        //                if (rowsAffected > 0)
        //                {
        //                    result.Correct = true;
        //                }//if
        //            }//using SQL Command
        //        }//using SQL Connection
        //    }//try

        //    catch (Exception ex)
        //    {
        //        result.Ex = ex;
        //        result.Correct = false;
        //        result.ErrorMessage = "Ocurrio un error al registrar el usuario";
        //        throw;
        //    }
        //    return result;
        //}//AddSP

        //public static ML.Result DeleteSP(int IdUsuario)
        //{
        //    ML.Result result = new ML.Result();

        //    try
        //    {
        //        using (var conn = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            string queryDelete = "UsuarioDelete";

        //            using (SqlCommand cmd = new SqlCommand())
        //            {
        //                cmd.Connection = conn;
        //                cmd.CommandText = queryDelete;
        //                cmd.CommandType = CommandType.StoredProcedure;

        //                SqlParameter[] collection = new SqlParameter[1];

        //                collection[0] = new SqlParameter("IdUsuario", SqlDbType.Int);
        //                collection[0].Value = IdUsuario;

        //                cmd.Parameters.AddRange(collection);
        //                cmd.Connection.Open();

        //                int rowsAffected = cmd.ExecuteNonQuery();

        //                //Validar si hay filas afectadas
        //                if (rowsAffected > 0)
        //                {
        //                    result.Correct = true;

        //                }//if
        //            }//using SqlCommand
        //        }//using SqlConnection
        //    }//try

        //    catch (Exception ex)
        //    {
        //        result.Ex = ex;
        //        result.Correct = false;
        //        result.ErrorMessage = "Ocurrio un error al eliminar el usuario";
        //        throw;
        //    }//catch
        //    return result;
        //}//DeleteSP

        //public static ML.Result UpdateSP(ML.Usuario usuario)
        //{

        //    ML.Result result = new ML.Result();

        //    try
        //    {
        //        using (SqlConnection conn = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            string queryUpdate = "UsuarioUpdate";

        //            using (SqlCommand cmd = new SqlCommand())
        //            {
        //                cmd.Connection = conn;
        //                cmd.CommandText = queryUpdate;
        //                cmd.CommandType= CommandType.StoredProcedure;

        //                SqlParameter[] collection = new SqlParameter[6];

        //                collection[0] = new SqlParameter("IdUsuario", SqlDbType.Int);
        //                collection[0].Value = usuario.IdUsuario;

        //                collection[1] = new SqlParameter("Nombre", SqlDbType.VarChar);
        //                collection[1].Value = usuario.Nombre;

        //                collection[2] = new SqlParameter("ApellidoPaterno", SqlDbType.VarChar);
        //                collection[2].Value = usuario.ApellidoPaterno;

        //                collection[3] = new SqlParameter("ApellidoMaterno", SqlDbType.VarChar);
        //                collection[3].Value = usuario.ApellidoMaterno;

        //                collection[4] = new SqlParameter("Contraseña", SqlDbType.VarChar);
        //                collection[4].Value = usuario.Contraseña;

        //                collection[5] = new SqlParameter("Rol", SqlDbType.VarChar);
        //                collection[5].Value = usuario.Rol.IdRol;

        //                cmd.Parameters.AddRange(collection);
        //                cmd.Connection.Open();

        //                int rowsAffected = cmd.ExecuteNonQuery();

        //                //Validar si hay filas afectadas
        //                if (rowsAffected > 0)
        //                {
        //                    result.Correct = true;

        //                }//if
        //            }//using SqlCommand
        //        }//using SqlConnection
        //    }//try

        //    catch (Exception ex)
        //    {
        //        result.Ex = ex;
        //        result.Correct = false;
        //        result.ErrorMessage = "Error al actualizar el usuario.";
        //        throw;
        //    }//catch

        //    return result;
        //}//UpdateSP

        /*
        public static ML.Result AddEF(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DRosasProgramacionNCapasEntities1 context = new DRosasProgramacionNCapasEntities1())
                {
                    int query = context.UsuarioAdd(usuario.UserName,usuario.Nombre,usuario.ApellidoPaterno,
                        usuario.ApellidoMaterno,usuario.Email,usuario.Password,usuario.FechaNacimiento,
                        usuario.Sexo,usuario.Telefono,usuario.Celular,usuario.CURP,usuario.Imagen,
                        (byte)usuario.Rol.IdRol,usuario.Direccion.Calle, usuario.Direccion.NumeroInterior, 
                        usuario.Direccion.NumeroExterior,usuario.Direccion.Colonia.IdColonia);

                    //Validar si hay filas afectadas
                    if (query > 0)
                    {
                        result.Correct = true;
                    }//if
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error al registrar el alumno.";
                    }//else                  
                }//using SQL Connection
            }//try

            catch (Exception ex)
            {
                result.Ex = ex;
                result.Correct = false;
                result.ErrorMessage = "Ocurrio un error al registrar el usuario";
                throw;
            }//catch
            return result;
        }//AddEF

        public static ML.Result UpdateEF(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();            
            try
            {
                using (DRosasProgramacionNCapasEntities1 context = new DRosasProgramacionNCapasEntities1())
                {
                    int queryUpdate = context.UsuarioUpdate(usuario.IdUsuario.Value, usuario.UserName, usuario.Nombre, usuario.ApellidoPaterno,
                        usuario.ApellidoMaterno, usuario.Email, usuario.Password, usuario.FechaNacimiento.ToString(),
                        usuario.Sexo, usuario.Telefono, usuario.Celular, usuario.CURP,usuario.Imagen,(byte)usuario.Rol.IdRol,
                        usuario.Direccion.Calle,usuario.Direccion.NumeroInterior,usuario.Direccion.NumeroExterior,
                        usuario.Direccion.Colonia.IdColonia);

                    //Validar si hay filas afectadas
                    if (queryUpdate > 0)
                    {
                        result.Correct = true;

                    }//if
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error al actualizar el registro";
                    }//else

                }//using
            }//try

            catch (Exception ex)
            {
                result.Ex = ex;
                result.Correct = false;
                result.ErrorMessage = "Error al actualizar el usuario.";
                throw;
            }//catch
            return result;
        }//UpdateEF

        public static ML.Result DeleteEF(int IdUsuario)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DRosasProgramacionNCapasEntities1 context = new DRosasProgramacionNCapasEntities1())
                {
                    int queryDelete = context.UsuarioDelete(IdUsuario);

                    //Validar si hay filas afectadas
                    if (queryDelete > 0)
                    {
                        result.Correct = true;
                    }//if
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error al eliminar el registro";
                    }//else
                }//using DRosas...
            }//try

            catch (Exception ex)
            {
                result.Ex = ex;
                result.Correct = false;
                result.ErrorMessage = "Ocurrio un error al eliminar el usuario";
                throw;
            }//catch
            return result;
        }//DeleteEF

        public static ML.Result GetAllEF()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DRosasProgramacionNCapasEntities1 context = new DRosasProgramacionNCapasEntities1())
                {
                    var queryGetAll = context.UsuarioGetAll().ToList();

                    if (queryGetAll != null)
                    {
                        result.Objects = new List<object>();

                        foreach (var item in queryGetAll)
                        {
                            ML.Usuario usuario = new ML.Usuario();

                            usuario.IdUsuario = item.IdUsuario;
                            usuario.UserName = item.UserName;
                            usuario.Nombre = item.Nombre;
                            usuario.ApellidoPaterno = item.ApellidoPaterno;
                            usuario.ApellidoMaterno = item.ApellidoMaterno;
                            usuario.Email = item.Email;
                            usuario.Password = item.Password;
                            usuario.FechaNacimiento = item.FechaNacimiento.ToString();
                            usuario.Sexo = item.Sexo;
                            usuario.Telefono= item.Telefono;
                            usuario.Celular= item.Celular;
                            usuario.CURP = item.CURP;
                            usuario.Imagen = item.Imagen;
                            usuario.Rol = new ML.Rol();
                            usuario.Rol.IdRol = (byte)item.IdRol;
                            usuario.Rol.Nombre = item.NombreRol;
                            usuario.Direccion = new ML.Direccion();
                            usuario.Direccion.IdDireccion = item.IdDireccion;
                            usuario.Direccion.Calle = item.Calle;
                            usuario.Direccion.NumeroInterior = item.NumeroInterior;
                            usuario.Direccion.NumeroExterior = item.NumeroExterior;
                            usuario.Direccion.Colonia= new ML.Colonia();
                            usuario.Direccion.Colonia.IdColonia = item.IdColonia;
                            usuario.Direccion.Colonia.Nombre = item.NombreColonia;
                            usuario.Direccion.Colonia.Municipio = new ML.Municipio();
                            usuario.Direccion.Colonia.Municipio.IdMunicipio = item.IdMunicipio;
                            usuario.Direccion.Colonia.Municipio.Nombre = item.NombreMunicipio;
                            usuario.Direccion.Colonia.Municipio.Estado = new ML.Estado();
                            usuario.Direccion.Colonia.Municipio.Estado.IdEstado = item.IdEstado;
                            usuario.Direccion.Colonia.Municipio.Estado.Nombre = item.NombreEstado;
                            usuario.Direccion.Colonia.Municipio.Estado.Pais = new ML.Pais();
                            usuario.Direccion.Colonia.Municipio.Estado.Pais.IdPais = item.IdPais;
                            usuario.Direccion.Colonia.Municipio.Estado.Pais.Nombre = item.NombrePais;

                            result.Objects.Add(usuario);
                        }//foreach
                        result.Correct = true;
                    }//if                                                   
                }//using context
            }//try
            catch (Exception ex)
            {
                result.Ex = ex;
                result.Correct = false;
                result.ErrorMessage = "Error al mostrar los registros!";
                throw;
            }
            return result;
        }//GetAllEF

        public static ML.Result GetByIdEF(int IdUsuario)
        {
            ML.Result result = new ML.Result();
            ML.Usuario usuario = new ML.Usuario();
            try
            {
                using (DRosasProgramacionNCapasEntities1 context = new DRosasProgramacionNCapasEntities1())
                {
                    var queryGetById = context.UsuarioGetById(IdUsuario).FirstOrDefault();                   

                    if (queryGetById != null)
                    {
                        result.Object = new object();
                        result.Correct = true;

                            usuario.IdUsuario = queryGetById.IdUsuario;
                            usuario.UserName = queryGetById.UserName;
                            usuario.Nombre = queryGetById.Nombre;
                            usuario.ApellidoPaterno = queryGetById.ApellidoPaterno;
                            usuario.ApellidoMaterno = queryGetById.ApellidoMaterno;
                            usuario.Email = queryGetById.Email;
                            usuario.Password = queryGetById.Password;
                            usuario.FechaNacimiento = queryGetById.FechaNacimiento.ToString();
                            usuario.Sexo = queryGetById.Sexo;
                            usuario.Telefono = queryGetById.Telefono;
                            usuario.Celular = queryGetById.Celular;
                            usuario.CURP = queryGetById.CURP;
                            usuario.Imagen = queryGetById.Imagen;
                            usuario.Rol = new ML.Rol();
                            usuario.Rol.IdRol = (byte)queryGetById.IdRol;
                            usuario.Rol.Nombre = queryGetById.NombreRol;
                            usuario.Direccion = new ML.Direccion();
                            usuario.Direccion.IdDireccion = queryGetById.IdDireccion;
                            usuario.Direccion.Calle = queryGetById.Calle;
                            usuario.Direccion.NumeroInterior = queryGetById.NumeroInterior;
                            usuario.Direccion.NumeroExterior = queryGetById.NumeroExterior;
                            usuario.Direccion.Colonia = new ML.Colonia();
                            usuario.Direccion.Colonia.IdColonia = queryGetById.IdColonia;
                            usuario.Direccion.Colonia.Nombre = queryGetById.NombreColonia;
                            usuario.Direccion.Colonia.Municipio = new ML.Municipio();
                            usuario.Direccion.Colonia.Municipio.IdMunicipio = queryGetById.IdMunicipio;
                            usuario.Direccion.Colonia.Municipio.Nombre = queryGetById.NombreMunicipio;
                            usuario.Direccion.Colonia.Municipio.Estado = new ML.Estado();
                            usuario.Direccion.Colonia.Municipio.Estado.IdEstado = queryGetById.IdEstado;
                            usuario.Direccion.Colonia.Municipio.Estado.Nombre = queryGetById.NombreEstado;
                            usuario.Direccion.Colonia.Municipio.Estado.Pais = new ML.Pais();
                            usuario.Direccion.Colonia.Municipio.Estado.Pais.IdPais = queryGetById.IdPais;
                            usuario.Direccion.Colonia.Municipio.Estado.Pais.Nombre = queryGetById.NombrePais;

                            result.Object = usuario;
                    }//if                                                                                    
                }//using
            }//try

            catch (Exception ex)
            {
                result.Correct = false;
                result.Ex = ex;
                result.ErrorMessage = "No existe un registro con ese ID.";
                throw;
            }//catch
            return result;
        }//GetById

        //EF LINQ

        //public static ML.Result AddLINQ(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();

        //    try
        //    {
        //        using (DRosasProgramacionNCapasEntities1 context = new DRosasProgramacionNCapasEntities1())
        //        {
        //            DL.Usuario usuarioDL = new DL.Usuario
        //            {
        //                UserName = usuario.UserName,
        //                Nombre = usuario.Nombre,
        //                ApellidoPaterno = usuario.ApellidoPaterno,
        //                ApellidoMaterno = usuario.ApellidoMaterno,
        //                Email = usuario.Email,
        //                Password = usuario.Password,
        //                FechaNacimiento = usuario.FechaNacimiento,
        //                Sexo = usuario.Sexo,
        //                Telefono = usuario.Telefono,
        //                Celular = usuario.Celular,
        //                CURP = usuario.CURP,
        //                Imagen = usuario.Imagen,
        //                IdRol = (byte)usuario.Rol.IdRol
        //            };

        //            context.Usuarios.Add(usuarioDL);
        //            context.SaveChanges();

        //            result.Correct = true;
        //        }//using context
        //    }//try
        //    catch (Exception)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = "Error al registrar el usuario!";
        //        throw;
        //    }//catch
        //    return result;
        //}//AddLINQ

        //public static ML.Result UpdateLINQ(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();

        //    try
        //    {
        //        using (DRosasProgramacionNCapasEntities1 context = new DRosasProgramacionNCapasEntities1())
        //        {
        //            var query = (from usr in context.Usuarios
        //                         where usr.IdUsuario == usuario.IdUsuario
        //                         select usr).FirstOrDefault();

        //            if (query != null) 
        //            {
        //                query.IdUsuario = usuario.IdUsuario.Value;
        //                query.UserName = usuario.UserName;
        //                query.Nombre = usuario.Nombre;
        //                query.ApellidoPaterno = usuario.ApellidoPaterno;
        //                query.ApellidoMaterno = usuario.ApellidoMaterno;
        //                query.Email = usuario.Email;
        //                query.Password = usuario.Password;
        //                query.FechaNacimiento = usuario.FechaNacimiento;
        //                query.Sexo = usuario.Sexo;
        //                query.Telefono = usuario.Telefono;
        //                query.Celular = usuario.Celular;
        //                query.CURP = usuario.CURP;
        //                query.Imagen = usuario.Imagen;
        //                query.IdRol = (byte)usuario.Rol.IdRol;

        //                context.SaveChanges();
        //                result.Correct = true;

        //            }//if
        //            else
        //            {
        //                result.Correct = false;
        //                result.ErrorMessage = "Error al actualizar!!";
        //            }//else
        //        }//using context
        //    }//try
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.ToString();
        //        throw;
        //    }//catch
        //    return result;
        //}//UpdateLINQ

        //public static ML.Result DeleteLINQ(int IdUsuario)
        //{
        //    ML.Result result = new ML.Result();

        //    try
        //    {
        //        using (DRosasProgramacionNCapasEntities1 context = new DRosasProgramacionNCapasEntities1())
        //        {
        //            var query = (from usr in context.Usuarios
        //                        where usr.IdUsuario == IdUsuario
        //                        select usr).First();
        //            context.Usuarios.Remove(query);
        //            context.SaveChanges();
        //            result.Correct = true;
        //        }
        //    }//try
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = "Error al eliminar el registro!" + ex.ToString();
        //        throw;
        //    }//catch

        //    return result;
        //}//DeleteLINQ

        //public static ML.Result GetAllLINQ()
        //{
        //    ML.Result result = new ML.Result();
            
        //    try
        //    {
        //        using (DRosasProgramacionNCapasEntities1 context = new DRosasProgramacionNCapasEntities1())
        //        {
        //            //LinQ con JOIN
        //            var query = from usr in context.Usuarios join rol in context.Rols 
        //                        on usr.IdRol equals rol.IdRol 
        //                        select new 
        //                        {
        //                            usr.IdUsuario,
        //                            usr.UserName,
        //                            usr.Nombre,
        //                            usr.ApellidoPaterno,
        //                            usr.ApellidoMaterno,
        //                            usr.Email,
        //                            usr.Password,
        //                            usr.FechaNacimiento,
        //                            usr.Sexo,
        //                            usr.Telefono,
        //                            usr.Celular,
        //                            usr.CURP,
        //                            usr.Imagen,
        //                            usr.IdRol,
        //                            Rol = rol.Nombre
        //                        };

        //            if (query != null)
        //            {
        //                result.Objects = new List<object>();

        //                foreach (var item in query)
        //                {
        //                    ML.Usuario usuario = new ML.Usuario();

        //                    usuario.IdUsuario = item.IdUsuario;
        //                    usuario.UserName = item.UserName;
        //                    usuario.Nombre = item.Nombre;
        //                    usuario.ApellidoPaterno = item.ApellidoPaterno;
        //                    usuario.ApellidoMaterno = item.ApellidoMaterno;
        //                    usuario.Email = item.Email;
        //                    usuario.Password = item.Password;
        //                    usuario.FechaNacimiento = item.FechaNacimiento;
        //                    usuario.Sexo = item.Sexo;
        //                    usuario.Telefono = item.Telefono;
        //                    usuario.Celular = item.Celular;
        //                    usuario.CURP = item.CURP;
        //                    usuario.Imagen = item.Imagen;
        //                    usuario.Rol = new ML.Rol();
        //                    usuario.Rol.IdRol = (byte)item.IdRol;
        //                    usuario.Rol.Nombre = item.Rol.ToString(); 

        //                    result.Objects.Add(usuario);

        //                }//foreach
        //                result.Correct = true;
        //            }//if
        //            else
        //            {
        //                result.Correct = false;
        //                result.ErrorMessage = "Error";
        //            }//else
        //        }//using context
        //    }//try
        //    catch (Exception)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = "Error!";
        //        throw;
        //    }//catch
                
        //    return result;
        //}//GetAllLINQ

        //public static ML.Result GetByIdLINQ(int IdUsuario)
        //{
        //    ML.Result result = new ML.Result();
        //    ML.Usuario usuario = new ML.Usuario();
        //    using (DRosasProgramacionNCapasEntities1 context = new DRosasProgramacionNCapasEntities1())
        //    {
        //        //LINQ con WHERE
        //        var query = from usr in context.Usuarios
        //                    join rol in context.Rols
        //                        on usr.IdRol equals rol.IdRol
        //                    where usr.IdUsuario == IdUsuario
        //                    select new
        //                    {
        //                        usr.IdUsuario,
        //                        usr.UserName,
        //                        usr.Nombre,
        //                        usr.ApellidoPaterno,
        //                        usr.ApellidoMaterno,
        //                        usr.Email,
        //                        usr.Password,
        //                        usr.FechaNacimiento,
        //                        usr.Sexo,
        //                        usr.Telefono,
        //                        usr.Celular,
        //                        usr.CURP,
        //                        usr.Imagen,
        //                        usr.IdRol,
        //                        Rol = rol.Nombre
        //                    };
                
        //        if (query != null)
        //        {
        //            result.Object = new object();
        //            result.Correct = true;

        //            foreach (var item in query)
        //            {
        //                usuario.IdUsuario = item.IdUsuario;
        //                usuario.UserName = item.UserName;
        //                usuario.Nombre = item.Nombre;
        //                usuario.ApellidoPaterno = item.ApellidoPaterno;
        //                usuario.ApellidoMaterno = item.ApellidoMaterno;
        //                usuario.Email = item.Email;
        //                usuario.Password = item.Password;
        //                usuario.FechaNacimiento = item.FechaNacimiento;
        //                usuario.Sexo = item.Sexo;
        //                usuario.Telefono = item.Telefono;
        //                usuario.Celular = item.Celular;
        //                usuario.CURP = item.CURP;

        //                usuario.Imagen = item.Imagen;
                        
        //                usuario.Rol = new ML.Rol();
        //                usuario.Rol.IdRol = (byte)item.IdRol;
        //                usuario.Rol.Nombre = item.Rol.ToString();

        //                result.Object = usuario;
        //            }//foreach
        //        }//if
        //        else
        //        {
        //            result.Correct = false;
        //            result.ErrorMessage = "Error!!";
        //        }//else
        //    }//using context
        //    return result;
        //}//GetByIdLINQ

        */

    }//Class Usuario
}//NS BL
