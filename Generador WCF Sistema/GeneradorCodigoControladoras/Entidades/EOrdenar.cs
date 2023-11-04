using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Configuration;

namespace GeneradorCodigoControladoras.Entidades
{
    public class EOrdenar
    {
        // Fields
        public ArrayList Lista = new ArrayList();

        // Methods
        public ArrayList CargarLista(ArrayList MyArray)
        {
            return MyArray;
        }

        public ArrayList EliminarDobles(ArrayList MyArray)
        {
            for (int i = 0; i < (MyArray.Count - 1); i++)
            {
                string a = MyArray[i].ToString().Replace(" ", "").Trim();
                if (a.Replace(" ", "") == "")
                {
                    MyArray[i] = "?";
                    a = "?";
                }
                for (int j = i + 1; j < MyArray.Count; j++)
                {
                    string b = MyArray[j].ToString().Replace(" ", "").Trim();
                    if (a.Replace(" ", "") == b.Replace(" ", ""))
                    {
                        MyArray.Remove(MyArray[i]);
                        j = MyArray.Count + 1;
                        i = -1;
                    }
                }
            }
            return MyArray;
        }

        public ArrayList EliminarEspExtremos(ArrayList MyArray)
        {
            for (int i = 0; i < MyArray.Count; i++)
            {
                string a = MyArray[i].ToString();
                if ((a.Replace(" ", "") == "") || (a.ToString() == "?"))
                {
                    MyArray[i] = "?";
                    a = "?";
                }
                MyArray[i] = a.Trim().ToString();
            }
            return MyArray;
        }

        public ArrayList RemplazarValoresArray(ArrayList MyArray, string parametro)
        {
            for (int i = 0; i < (MyArray.Count - 1); i++)
            {
                if (MyArray[i].ToString().Replace(" ", "").Trim().Replace(" ", "") == parametro.Replace(" ", ""))
                {
                    MyArray[i] = parametro;
                }
            }
            return MyArray;
        }
    }


}



