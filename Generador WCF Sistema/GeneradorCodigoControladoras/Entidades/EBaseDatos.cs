using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Collections;

namespace GeneradorCodigoControladoras.Entidades
{
    public class EBaseDatos
    {
        // Fields
        public static string CadenaConexion = string.Empty;
        public ArrayList Columnas;
        public bool Conectado = false;
        public string Cuenta = string.Empty;
        public ArrayList MyArray = new ArrayList();
        public string NombreBaseDatos = string.Empty;
        public string NombreServidor = string.Empty;
        public string Password = string.Empty;
        public int val;

        // Properties
        public bool _Conectado
        {
            get
            {
                return this.Conectado;
            }
            set
            {
                this.Conectado = value;
            }
        }

        public string _Cuenta
        {
            get
            {
                return this.Cuenta;
            }
            set
            {
                this.Cuenta = value;
            }
        }

        public string _NombreBaseDatos
        {
            get
            {
                return this.NombreBaseDatos;
            }
            set
            {
                this.NombreBaseDatos = value;
            }
        }

        public string _NombreServidor
        {
            get
            {
                return this.NombreServidor;
            }
            set
            {
                this.NombreServidor = value;
            }
        }

        public string _Password
        {
            get
            {
                return this.Password;
            }
            set
            {
                this.Password = value;
            }
        }

        public string ConnectionString
        {
            get
            {
                return CadenaConexion;
            }
            set
            {
                CadenaConexion = value;
            }
        }

        public ArrayList Tablas
        {
            get
            {
                return this.MyArray;
            }
            set
            {
                this.MyArray.Add(value);
            }
        }
    }



}
