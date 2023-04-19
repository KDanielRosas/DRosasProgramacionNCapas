using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDepartamentoService" in both code and config file together.
    [ServiceContract]
    public interface IDepartamentoService
    {
        [OperationContract]
        bool Add(Depto obj);

        [OperationContract]
        bool Update(Depto obj);

        [OperationContract]
        bool Delete(int idDepartamento);

        [OperationContract]
        List<Depto> GetAll();

        [OperationContract]
        Depto GetById(int idDepartamento);
    }

    [DataContract]
    public class Depto
    {
        [DataMember] public int IdDepartamento;
        [DataMember] public string Nombre;
        [DataMember] public int IdArea;
        [DataMember] public string NombreArea;
    }
}
