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

public class clsInstitucion : clsInstitucionDA
{
public clsInstitucion()
{
this.IdInstitucion = 0;
this.IdInstitucionPadre = 0;
this.NombreInstitucion = string.Empty;
this.IdTipoInstitucion = 0;
}

public clsInstitucion(int IdInstitucion)
{
}


public clsInstitucion clsInstitucionPorIdInstitucion()
{
using (IDataReader dr = ObtieneInstitucion(this))
{
if (dr.Read())
{
this.IdInstitucion = Convert.ToInt32(dr["IdInstitucion"]);
this.IdInstitucionPadre = Convert.ToInt32(dr["IdInstitucionPadre"]);
this.NombreInstitucion = Convert.ToString(dr["NombreInstitucion"]);
this.IdTipoInstitucion = Convert.ToInt32(dr["IdTipoInstitucion"]);
}
}
return this;
}

public int AgregaInstitucion()
{
clsInstitucionDA ad = new clsInstitucionDA();
return ad.AgregaInstitucion(this);
}

public int ModificaInstitucion()
{
clsInstitucionDA ad = new clsInstitucionDA();
return ad.ModificaInstitucion(this);
}

public int EliminaInstitucion()
{
clsInstitucionDA ad = new clsInstitucionDA();
return ad.EliminaInstitucion(this);
}

}
}
