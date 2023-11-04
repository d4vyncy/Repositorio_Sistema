using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Configuration;

namespace GeneradorCodigoControladoras.Entidades
{
    public class EImportarSQL
    {
        // Fields
        public ArrayList Colum = new ArrayList();
        public string NombreTabla = string.Empty;
        public ArrayList TypoColum = new ArrayList();

        // Methods
        public void CargarColumnas(string CadenaConexion, string Tabla)
        {
            SqlConnection MiConexion = new SqlConnection(CadenaConexion);
            string Sql = "Select top 1 * From " + Tabla;
            SqlDataAdapter MiDataAdapter = new SqlDataAdapter();
            MiConexion.Open();
            SqlCommand MiCommand = new SqlCommand(Sql, MiConexion)
            {
                CommandType = CommandType.Text
            };
            MiDataAdapter.SelectCommand = MiCommand;
            DataSet ds = new DataSet(Tabla);
            MiDataAdapter.Fill(ds);
            MiConexion.Close();
            DataColumn dc = new DataColumn();
            int j = ds.Tables["table"].Columns.Count - 1;
            EBaseDatos eBaseDatos = new EBaseDatos();
            for (int i = 0; i <= j; i++)
            {
                dc = ds.Tables["table"].Columns[i];
                if ((dc.ColumnName.ToString() != "EstadoRegistro") && (dc.ColumnName.ToString() != "FechaRegistro"))
                {
                    this.ColumnasI.Add(dc.ColumnName);
                    this.TypoColumnasI.Add(dc.DataType.ToString().Substring(7));
                }
            }
        }

        public ArrayList CargarGroupTabla(string CadenaConexion, string tabla, string Campo, bool Agrupar)
        {
            string Sql;
            ArrayList Datos = new ArrayList();
            if (Agrupar)
            {
                Sql = "SELECT " + Campo + " FROM " + tabla + " GROUP BY " + Campo;
            }
            else
            {
                Sql = "SELECT " + Campo + " FROM " + tabla;
            }
            SqlConnection MiConexion = new SqlConnection(CadenaConexion);
            SqlDataAdapter MiDataAdapter = new SqlDataAdapter();
            MiConexion.Open();
            SqlCommand MiCommand = new SqlCommand(Sql, MiConexion)
            {
                CommandType = CommandType.Text
            };
            MiDataAdapter.SelectCommand = MiCommand;
            DataSet ds = new DataSet(tabla);
            MiDataAdapter.Fill(ds);
            MiConexion.Close();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Datos.Add(ds.Tables[0].Rows[i][0].ToString());
            }
            return Datos;
        }

        public DataSet LlenarDatos(string CadenaConexion, string tabla, ArrayList Columnas)
        {
            string Sql = "SELECT " + Columnas[0].ToString();
            for (int i = 1; i <= (Columnas.Count - 1); i++)
            {
                Sql = Sql + "," + Columnas[i];
            }
            Sql = Sql + " FROM " + tabla;
            SqlConnection MiConexion = new SqlConnection(CadenaConexion);
            SqlDataAdapter MiDataAdapter = new SqlDataAdapter();
            MiConexion.Open();
            SqlCommand MiCommand = new SqlCommand(Sql, MiConexion)
            {
                CommandType = CommandType.Text
            };
            MiDataAdapter.SelectCommand = MiCommand;
            DataSet ds = new DataSet(tabla);
            MiDataAdapter.Fill(ds);
            MiConexion.Close();
            return ds;
        }

        public DataSet TablasSqlServer(string CadenaConexion)
        {
            SqlConnection MiConexion = new SqlConnection(CadenaConexion);
            string Sql = string.Concat(new object[] { "SELECT ", '\n', "TABLE_SCHEMA, TABLE_NAME FROM INFORMATION_SCHEMA.TABLES ", '\n', "WHERE ", '\n', "TABLE_TYPE = 'BASE TABLE' AND TABLE_NAME<>'dtproperties' AND TABLE_NAME<>'sysdiagrams' and TABLE_NAME not like 'trnTemp%' ", '\n' });
            SqlDataAdapter MiDataAdapter = new SqlDataAdapter();
            MiConexion.Open();
            SqlCommand MiCommand = new SqlCommand(Sql, MiConexion)
            {
                CommandType = CommandType.Text
            };
            MiDataAdapter.SelectCommand = MiCommand;
            DataSet ds = new DataSet("Tabla");
            MiDataAdapter.Fill(ds);
            MiConexion.Close();
            return ds;
        }

        // Properties
        public ArrayList ColumnasI
        {
            get
            {
                return this.Colum;
            }
            set
            {
                this.Colum.Add(value);
            }
        }

        public string tablaNombre
        {
            get
            {
                return this.NombreTabla;
            }
            set
            {
                this.NombreTabla = value;
            }
        }

        public ArrayList TypoColumnasI
        {
            get
            {
                return this.TypoColum;
            }
            set
            {
                this.TypoColum.Add(value);
            }
        }
    }




}
