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

public class cls_tblItemInstitucion : cls_tblItemInstitucionDA
{
public cls_tblItemInstitucion()
{
this.IdItemInstitucion = 0;
this.NroItem = 0;
this.IdEntidad = 0;
this.IdUnidad = 0;
this.IdPuesto = 0;
}

public cls_tblItemInstitucion(int Id_tblItemInstitucion)
{
}


public cls_tblItemInstitucion cls_tblItemInstitucionPorId_tblItemInstitucion()
{
using (IDataReader dr = Obtiene_tblItemInstitucion(this))
{
if (dr.Read())
{
this.IdItemInstitucion = Convert.ToInt32(dr["IdItemInstitucion"]);
this.NroItem = Convert.ToInt32(dr["NroItem"]);
this.IdEntidad = Convert.ToInt32(dr["IdEntidad"]);
this.IdUnidad = Convert.ToInt32(dr["IdUnidad"]);
this.IdPuesto = Convert.ToInt32(dr["IdPuesto"]);
}
}
return this;
}

public int Agrega_tblItemInstitucion()
{
cls_tblItemInstitucionDA ad = new cls_tblItemInstitucionDA();
return ad.Agrega_tblItemInstitucion(this);
}

public int Modifica_tblItemInstitucion()
{
cls_tblItemInstitucionDA ad = new cls_tblItemInstitucionDA();
return ad.Modifica_tblItemInstitucion(this);
}

public int Elimina_tblItemInstitucion()
{
cls_tblItemInstitucionDA ad = new cls_tblItemInstitucionDA();
return ad.Elimina_tblItemInstitucion(this);
}

}
}
