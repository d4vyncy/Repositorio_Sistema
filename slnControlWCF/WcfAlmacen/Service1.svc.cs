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
    public class Service1 : IService1
    {
        // con n parametros
        public DataSet ProcedureConParametro(string Procedimiento, object[] pParametros)
        {
            clspAlmacen ad = new clspAlmacen();
            return ad.ProcedureParametro(Procedimiento, pParametros);
        }
        // con 8 parametros
        public DataSet ProcedureParametro(string Procedimiento, string Campo, string Valor, string Campo1, string Valor1, string Campo2, string Valor2, string Campo3, string Valor3, string Campo4, string Valor4, string Campo5, string Valor5, string Campo6, string Valor6, string Campo7, string Valor7)
        {
            object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            pParametros[0] = Campo;
            pParametros[1] = Valor;
            pParametros[2] = Campo1;
            pParametros[3] = Valor1;
            pParametros[4] = Campo2;
            pParametros[5] = Valor2;
            pParametros[6] = Campo3;
            pParametros[7] = Valor3;
            pParametros[8] = Campo4;
            pParametros[9] = Valor4;
            pParametros[10] = Campo5;
            pParametros[11] = Valor5;
            pParametros[12] = Campo6;
            pParametros[13] = Valor6;
            pParametros[14] = Campo7;
            pParametros[15] = Valor7;
            clspAlmacen ad = new clspAlmacen();
            return ad.ProcedureParametro(Procedimiento, pParametros);
        }
        public int EjecutaConsulta(string Consulta)
        {
            clspAlmacen ad = new clspAlmacen();
            return ad.EjecutaConsulta(Consulta);
        }
        #region pruebas
        public DateTime getFecha()
        {
            return DateTime.Now;
        }
        #endregion
        #region Marca
        public clsMarca ObtieneMarca(int IdMarca)
        {
            clsMarca oMarca = new clsMarca();
            oMarca.IdMarca = IdMarca;
            return oMarca.clsMarcaPorIdMarca();
        }



        public int AgregaMarca(clsMarca oMarca)
        { return oMarca.AgregaMarca(); }

        public int ModificaMarca(clsMarca oMarca)
        { return oMarca.ModificaMarca(); }

        public int EliminaMarca(int IdMarca)
        {
            clsMarca oMarca = new clsMarca();
            oMarca.IdMarca = IdMarca;
            return oMarca.EliminaMarca();
        }

        //seleccion con parametros
        public DataSet ObtienepavMarca1(string Campo, string Valor)
        {
            object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            pParametros[0] = Campo;
            pParametros[1] = Valor;
            pParametros[2] = "T";
            pParametros[3] = "";
            pParametros[4] = "T";
            pParametros[5] = "";
            pParametros[6] = "T";
            pParametros[7] = "";
            pParametros[8] = "T";
            pParametros[9] = "";
            pParametros[10] = "T";
            pParametros[11] = "";
            pParametros[12] = "T";
            pParametros[13] = "";
            pParametros[14] = "T";
            pParametros[15] = "";
            clsMarcaDA ad = new clsMarcaDA();
            return ad.ObtienepavMarca(pParametros);
        }
        public DataSet ObtienepavMarca2(string Campo, string Valor, string Campo1, string Valor1)
        {
            object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            pParametros[0] = Campo;
            pParametros[1] = Valor;
            pParametros[2] = Campo1;
            pParametros[3] = Valor1;
            pParametros[4] = "T";
            pParametros[5] = "";
            pParametros[6] = "T";
            pParametros[7] = "";
            pParametros[8] = "T";
            pParametros[9] = "";
            pParametros[10] = "T";
            pParametros[11] = "";
            pParametros[12] = "T";
            pParametros[13] = "";
            pParametros[14] = "T";
            pParametros[15] = "";
            clsMarcaDA ad = new clsMarcaDA();
            return ad.ObtienepavMarca(pParametros);
        }
        public DataSet ObtienepavMarca3(string Campo, string Valor, string Campo1, string Valor1, string Campo2, string Valor2)
        {
            object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            pParametros[0] = Campo;
            pParametros[1] = Valor;
            pParametros[2] = Campo1;
            pParametros[3] = Valor1;
            pParametros[4] = Campo2;
            pParametros[5] = Valor2;
            pParametros[6] = "T";
            pParametros[7] = "";
            pParametros[8] = "T";
            pParametros[9] = "";
            pParametros[10] = "T";
            pParametros[11] = "";
            pParametros[12] = "T";
            pParametros[13] = "";
            pParametros[14] = "T";
            pParametros[15] = "";
            clsMarcaDA ad = new clsMarcaDA();
            return ad.ObtienepavMarca(pParametros);
        }
        public DataSet ObtienepavMarca4(string Campo, string Valor, string Campo1, string Valor1, string Campo2, string Valor2, string Campo3, string Valor3)
        {
            object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            pParametros[0] = Campo;
            pParametros[1] = Valor;
            pParametros[2] = Campo1;
            pParametros[3] = Valor1;
            pParametros[4] = Campo2;
            pParametros[5] = Valor2;
            pParametros[6] = Campo3;
            pParametros[7] = Valor3;
            pParametros[8] = "T";
            pParametros[9] = "";
            pParametros[10] = "T";
            pParametros[11] = "";
            pParametros[12] = "T";
            pParametros[13] = "";
            pParametros[14] = "T";
            pParametros[15] = "";
            clsMarcaDA ad = new clsMarcaDA();
            return ad.ObtienepavMarca(pParametros);
        }
        public DataSet ObtienepavMarca5(string Campo, string Valor, string Campo1, string Valor1, string Campo2, string Valor2, string Campo3, string Valor3, string Campo4, string Valor4, string Campo5, string Valor5, string Campo6, string Valor6, string Campo7, string Valor7)
        {
            object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            pParametros[0] = Campo;
            pParametros[1] = Valor;
            pParametros[2] = Campo1;
            pParametros[3] = Valor1;
            pParametros[4] = Campo2;
            pParametros[5] = Valor2;
            pParametros[6] = Campo3;
            pParametros[7] = Valor3;
            pParametros[8] = Campo4;
            pParametros[9] = Valor4;
            pParametros[10] = Campo5;
            pParametros[11] = Valor5;
            pParametros[12] = Campo6;
            pParametros[13] = Valor6;
            pParametros[14] = Campo7;
            pParametros[15] = Valor7;
            clsMarcaDA ad = new clsMarcaDA();
            return ad.ObtienepavMarca(pParametros);
        }
        #endregion

    }
}
