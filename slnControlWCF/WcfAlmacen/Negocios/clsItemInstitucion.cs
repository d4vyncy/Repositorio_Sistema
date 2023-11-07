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

public class clsItemInstitucion : clsItemInstitucionDA
{
public clsItemInstitucion()
{
this.IdItemInstitucion = 0;
this.NroItem = 0;
this.IdEntidad = 0;
this.IdUnidad = 0;
this.IdPuesto = 0;
}

public clsItemInstitucion(int IdItemInstitucion)
{
}


public clsItemInstitucion clsItemInstitucionPorIdItemInstitucion()
{
using (IDataReader dr = ObtieneItemInstitucion(this))
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

public int AgregaItemInstitucion()
{
clsItemInstitucionDA ad = new clsItemInstitucionDA();
return ad.AgregaItemInstitucion(this);
}

public int ModificaItemInstitucion()
{
clsItemInstitucionDA ad = new clsItemInstitucionDA();
return ad.ModificaItemInstitucion(this);
}

public int EliminaItemInstitucion()
{
clsItemInstitucionDA ad = new clsItemInstitucionDA();
return ad.EliminaItemInstitucion(this);
}

}
}
