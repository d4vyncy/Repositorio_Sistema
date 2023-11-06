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

public class cls_tblUnidad : cls_tblUnidadDA
{
public cls_tblUnidad()
{
this.IdUnidad = 0;
this.NombreUnidad = string.Empty;
this.CodigoUnidad = string.Empty;
this.IdPadreUnidad = 0;
this.Orden = 0;
this.IdEntidad = 0;
}

public cls_tblUnidad(int Id_tblUnidad)
{
}


public cls_tblUnidad cls_tblUnidadPorId_tblUnidad()
{
using (IDataReader dr = Obtiene_tblUnidad(this))
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

public int Agrega_tblUnidad()
{
cls_tblUnidadDA ad = new cls_tblUnidadDA();
return ad.Agrega_tblUnidad(this);
}

public int Modifica_tblUnidad()
{
cls_tblUnidadDA ad = new cls_tblUnidadDA();
return ad.Modifica_tblUnidad(this);
}

public int Elimina_tblUnidad()
{
cls_tblUnidadDA ad = new cls_tblUnidadDA();
return ad.Elimina_tblUnidad(this);
}

}
}
