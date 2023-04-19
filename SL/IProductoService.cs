using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProductoService" in both code and config file together.
    [ServiceContract]
    public interface IProductoService
    {
        [OperationContract]
        bool Add(Producto obj);

        [OperationContract]
        bool Update(Producto obj);

        [OperationContract]
        bool Delete(int idProducto);

        [OperationContract]
        List<Producto> GetAll();

        [OperationContract]
        Producto GetById(int idProducto);
    }

    [DataContract]
    public class Producto
    {
        [DataMember] public int IdProducto;
        [DataMember] public string Nombre;
        [DataMember] public decimal PrecioUnitario;
        [DataMember] public int Stock;
        [DataMember] public int IdProveedor;
        [DataMember] public int IdDepartamento;
        [DataMember] public string Descripcion;
        [DataMember] public string Imagen;

    }
}
