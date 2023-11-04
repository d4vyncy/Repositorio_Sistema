using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using WcfAlmacen.Entidades;
using WcfAlmacen.Datos;

namespace WcfAlmacen.Negocios 
{

public class clsAlmacen : clsAlmacenDA
{
public clsAlmacen()
{
this.IdAlmacen = 0;
this.NombreAlmacen = string.Empty;
this.IdEntidad = 0;
}

public clsAlmacen(int IdAlmacen)
{
}


public clsAlmacen clsAlmacenPorIdAlmacen()
{
using (IDataReader dr = ObtieneAlmacen(this))
{
if (dr.Read())
{
this.IdAlmacen = Convert.ToInt32(dr["IdAlmacen"]);
this.NombreAlmacen = Convert.ToString(dr["NombreAlmacen"]);
this.IdEntidad = Convert.ToInt32(dr["IdEntidad"]);
}
}
return this;
}

public int AgregaAlmacen()
{
clsAlmacenDA ad = new clsAlmacenDA();
return ad.AgregaAlmacen(this);
}

public int ModificaAlmacen()
{
clsAlmacenDA ad = new clsAlmacenDA();
return ad.ModificaAlmacen(this);
}

public int EliminaAlmacen()
{
clsAlmacenDA ad = new clsAlmacenDA();
return ad.EliminaAlmacen(this);
}

}
}
