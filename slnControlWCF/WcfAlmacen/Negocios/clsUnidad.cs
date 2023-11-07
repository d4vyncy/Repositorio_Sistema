using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using Wcfsisdav.Entidades;
using Wcfsisdav.Datos;

namespace Wcfsisdav.Negocios 
{

public class clsUnidad : clsUnidadDA
{
public clsUnidad()
{
this.IdUnidad = 0;
this.NombreUnidad = string.Empty;
this.CodigoUnidad = string.Empty;
this.IdPadreUnidad = 0;
this.Orden = 0;
this.IdEntidad = 0;
}

public clsUnidad(int IdUnidad)
{
}


public clsUnidad clsUnidadPorIdUnidad()
{
using (IDataReader dr = ObtieneUnidad(this))
{
if (dr.Read())
{
this.IdUnidad = Convert.ToInt32(dr["IdUnidad"]);
this.NombreUnidad = Convert.ToString(dr["NombreUnidad"]);
this.CodigoUnidad = Convert.ToString(dr["CodigoUnidad"]);
this.IdPadreUnidad = Convert.ToInt32(dr["IdPadreUnidad"]);
this.Orden = Convert.ToInt32(dr["Orden"]);
this.IdEntidad = Convert.ToInt32(dr["IdEntidad"]);
}
}
return this;
}

public int AgregaUnidad()
{
clsUnidadDA ad = new clsUnidadDA();
return ad.AgregaUnidad(this);
}

public int ModificaUnidad()
{
clsUnidadDA ad = new clsUnidadDA();
return ad.ModificaUnidad(this);
}

public int EliminaUnidad()
{
clsUnidadDA ad = new clsUnidadDA();
return ad.EliminaUnidad(this);
}

}
}
