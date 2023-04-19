using BL;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace PL_MVC.Controllers
{
    //public class UsuarioController : Controller
    //{
    //    // GET: Usuario
    //    [HttpGet]
    //    public ActionResult GetAll()
    //    {
    //        ML.Result result = BL.Usuario.GetAllEF();
    //        ML.Usuario usuario= new ML.Usuario();

    //        if (result.Correct)
    //        {
    //            usuario.Usuarios = result.Objects;
    //            return View(usuario);
    //        }
    //        else
    //        {
    //            return View(usuario);
    //        }          
    //    }//GetAll

    //    [HttpGet]
    //    public ActionResult Form(int? idUsuario)
    //    {
    //        ML.Result resultRol = BL.Rol.GetAll();
    //        ML.Result resultPais = BL.Pais.GetAll();
            
    //        ML.Usuario usuario = new ML.Usuario();

    //        usuario.Rol = new ML.Rol();
    //        usuario.Direccion = new ML.Direccion();
    //        usuario.Direccion.Colonia = new ML.Colonia();
    //        usuario.Direccion.Colonia.Municipio = new ML.Municipio();
    //        usuario.Direccion.Colonia.Municipio.Estado = new ML.Estado();
    //        usuario.Direccion.Colonia.Municipio.Estado.Pais = new ML.Pais();

    //        if (resultRol.Correct && resultPais.Correct)
    //        {
    //            usuario.Rol.Roles = resultRol.Objects;
    //            usuario.Direccion.Colonia.Municipio.Estado.Pais.Paises = resultPais.Objects;
                
    //        }//if

    //        if (idUsuario == null)
    //        {
    //            //Add FormVacio
    //            return View(usuario);
    //        }//if
    //        else
    //        {
    //            //GetById
    //            ML.Result result = BL.Usuario.GetByIdEF(idUsuario.Value);

    //            if (result.Correct)
    //            {
    //                usuario = (ML.Usuario)result.Object;

    //                ML.Result resultEstado = BL.Estado.GetByIdPais(usuario.Direccion.Colonia.Municipio.Estado.Pais.IdPais);
    //                ML.Result resultMunicipio = BL.Municipio.GetByIdEstado(usuario.Direccion.Colonia.Municipio.Estado.IdEstado);
    //                ML.Result resultColonia = BL.Colonia.GetByIdMunicipio(usuario.Direccion.Colonia.Municipio.IdMunicipio);
                    
    //                usuario.Rol.Roles = resultRol.Objects;
    //                usuario.Direccion.Colonia.Colonias = resultColonia.Objects;
    //                usuario.Direccion.Colonia.Municipio.Municipios = resultMunicipio.Objects;
    //                usuario.Direccion.Colonia.Municipio.Estado.Estados = resultEstado.Objects;
    //                usuario.Direccion.Colonia.Municipio.Estado.Pais.Paises = resultPais.Objects;

    //                //Update
    //                return View(usuario);
    //            }//if
    //            else
    //            {
    //                ViewBag.Message = "Error al mostrar la información del usuario!";
    //                return View("Modal");
    //            }//else
    //        }//else
    //    }//Form

    //    [HttpPost]
    //    public ActionResult Form(ML.Usuario usuario) 
    //    {
    //        ML.Result result = new ML.Result();
    //        HttpPostedFileBase file = Request.Files["fuImage"];

    //        if (file != null)
    //        {
    //            byte[] imagen = ImagenABase64(file);
    //            usuario.Imagen = Convert.ToBase64String(imagen);
    //        }

    //        if (usuario.IdUsuario == 0)
    //        {
    //            //Add
                
    //            result = BL.Usuario.AddEF(usuario);
                
    //            if (result.Correct)
    //            {
    //                ViewBag.Message = "Usuario registrado correctamente!";
    //            }//if
    //            else
    //            {
    //                ViewBag.Message = "Error al registrar al usuario...";
    //            }//else
    //            return View("Modal");
    //        }//if
    //        else
    //        {
    //            //Update
    //            result = BL.Usuario.UpdateEF(usuario);
    //            if (result.Correct) 
    //            {
    //                ViewBag.Message = "Se actualizó el registro correctamente!";
    //            }//if
    //            else
    //            {
    //                ViewBag.Message = "Error al actualizar el registro...";
    //            }//else
    //            return View("Modal");
    //        }//else
    //    }//Form

    //    [HttpGet] 
    //    public ActionResult Delete(int idUsuario) 
    //    { 
    //        ML.Result result = BL.Usuario.DeleteEF(idUsuario);
    //        if (result.Correct)
    //        {
    //            ViewBag.Message = "Registro eliminado correctamente!";
    //        }
    //        else
    //        {
    //            ViewBag.Message = "Error al eliminar el registro...";
    //        }
    //        return View("Modal");
    //    }//Delete

    //    [HttpPost]
    //    public JsonResult EstadoGetByIdPais(int idPais)
    //    {
    //        ML.Result result = BL.Estado.GetByIdPais(idPais);

    //        return Json(result.Objects);
    //    }//EstadoGetByIdPais

    //    [HttpPost]
    //    public JsonResult MunicipioGetByIdEstado(int idEstado)
    //    {
    //        ML.Result result = BL.Municipio.GetByIdEstado(idEstado);

    //        return Json(result.Objects);
    //    }//MunicipioGetByIdEstado

    //    [HttpPost]
    //    public JsonResult ColoniaGetByIdMunicipio(int idMunicipio)
    //    {
    //        ML.Result result = BL.Colonia.GetByIdMunicipio(idMunicipio);

    //        return Json(result.Objects);
    //    }//ColoniaGetByIdMunicipio

    //    public byte[] ImagenABase64(HttpPostedFileBase foto)
    //    {
    //        byte[] data = null;
    //        BinaryReader reader = new BinaryReader(foto.InputStream);
    //        data = reader.ReadBytes((int)foto.ContentLength);

    //        return data;
    //    }//imagenAByte
                
    //}//ClassController
}//NS