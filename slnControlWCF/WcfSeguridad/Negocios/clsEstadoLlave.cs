using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using WcfSeguridad.Entidades;
using WcfSeguridad.Datos;

namespace WcfSeguridad.Negocios 
{

public class clsEstadoLlave : clsEstadoLlaveDA
{
public clsEstadoLlave()
{
this.IdEstadoLlave = 0;
this.NombreEstadoLlave = string.Empty;
this.Detalle = string.Empty;
}

public clsEstadoLlave(int IdEstadoLlave)
{
}


public clsEstadoLlave clsEstadoLlavePorIdEstadoLlave()
{
using (IDataReader dr = ObtieneEstadoLlave(this))
{
if (dr.Read())
{
this.IdEstadoLlave = Convert.ToInt32(dr["IdEstadoLlave"]);
this.NombreEstadoLlave = Convert.ToString(dr["NombreEstadoLlave"]);
this.Detalle = Convert.ToString(dr["Detalle"]);
}
}
return this;
}

public int AgregaEstadoLlave()
{
clsEstadoLlaveDA ad = new clsEstadoLlaveDA();
return ad.AgregaEstadoLlave(this);
}

public int ModificaEstadoLlave()
{
clsEstadoLlaveDA ad = new clsEstadoLlaveDA();
return ad.ModificaEstadoLlave(this);
}

public int EliminaEstadoLlave()
{
clsEstadoLlaveDA ad = new clsEstadoLlaveDA();
return ad.EliminaEstadoLlave(this);
}

}
}
