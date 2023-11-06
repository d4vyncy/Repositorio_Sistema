//CODIGO GENERADO POR davidserrudo@gmail.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using WcfAlmacen.Negocios;
using WcfAlmacen.Datos;

namespace WcfAlmacen
{
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        DataSet ProcedureConParametro(string Procedimiento, object[] pParametros);
        [OperationContract]
        DataSet ProcedureParametro(string Procedimiento, string Campo, string Valor, string Campo1, string Valor1, string Campo2, string Valor2, string Campo3, string Valor3, string Campo4, string Valor4, string Campo5, string Valor5, string Campo6, string Valor6, string Campo7, string Valor7);
        [OperationContract]
        int EjecutaConsulta(string Consulta);
        #region pruebas
        [OperationContract]
        DateTime getFecha();
        #endregion
        #region Marca
        [OperationContract]
        clsMarca ObtieneMarca(int IdMarca);

        [OperationContract]
        int AgregaMarca(clsMarca oMarca);

        [OperationContract]
        int ModificaMarca(clsMarca oMarca);

        [OperationContract]
        int EliminaMarca(int IdMarca);


        [OperationContract]
        DataSet ObtienepavMarca1(string Campo, string Valor);

        [OperationContract]
        DataSet ObtienepavMarca2(string Campo, string Valor, string Campo1, string Valor1);

        [OperationContract]
        DataSet ObtienepavMarca3(string Campo, string Valor, string Campo1, string Valor1, string Campo2, string Valor2);

        [OperationContract]
        DataSet ObtienepavMarca4(string Campo, string Valor, string Campo1, string Valor1, string Campo2, string Valor2, string Campo3, string Valor3);

        [OperationContract]
        DataSet ObtienepavMarca5(string Campo, string Valor, string Campo1, string Valor1, string Campo2, string Valor2, string Campo3, string Valor3, string Campo4, string Valor4, string Campo5, string Valor5, string Campo6, string Valor6, string Campo7, string Valor7);

        #endregion

    }
}
