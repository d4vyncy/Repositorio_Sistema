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

public class clsEquipo : clsEquipoDA
{
public clsEquipo()
{
this.IdEquipo = 0;
this.Hostname = string.Empty;
this.IpEquipo = string.Empty;
this.Descripcion = string.Empty;
}

public clsEquipo(int IdEquipo)
{
}


public clsEquipo clsEquipoPorIdEquipo()
{
using (IDataReader dr = ObtieneEquipo(this))
{
if (dr.Read())
{
this.IdEquipo = Convert.ToInt32(dr["IdEquipo"]);
this.Hostname = Convert.ToString(dr["Hostname"]);
this.IpEquipo = Convert.ToString(dr["IpEquipo"]);
this.Descripcion = Convert.ToString(dr["Descripcion"]);
}
}
return this;
}

public int AgregaEquipo()
{
clsEquipoDA ad = new clsEquipoDA();
return ad.AgregaEquipo(this);
}

public int ModificaEquipo()
{
clsEquipoDA ad = new clsEquipoDA();
return ad.ModificaEquipo(this);
}

public int EliminaEquipo()
{
clsEquipoDA ad = new clsEquipoDA();
return ad.EliminaEquipo(this);
}

}
}
