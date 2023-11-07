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

public class cls_tblInstitucion : cls_tblInstitucionDA
{
public cls_tblInstitucion()
{
this.IdInstitucion = 0;
this.IdInstitucionPadre = 0;
this.NombreInstitucion = string.Empty;
this.IdTipoInstitucion = 0;
}

public cls_tblInstitucion(int Id_tblInstitucion)
{
}


public cls_tblInstitucion cls_tblInstitucionPorId_tblInstitucion()
{
using (IDataReader dr = Obtiene_tblInstitucion(this))
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

public int Agrega_tblInstitucion()
{
cls_tblInstitucionDA ad = new cls_tblInstitucionDA();
return ad.Agrega_tblInstitucion(this);
}

public int Modifica_tblInstitucion()
{
cls_tblInstitucionDA ad = new cls_tblInstitucionDA();
return ad.Modifica_tblInstitucion(this);
}

public int Elimina_tblInstitucion()
{
cls_tblInstitucionDA ad = new cls_tblInstitucionDA();
return ad.Elimina_tblInstitucion(this);
}

}
}
