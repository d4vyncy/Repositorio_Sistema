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

public class clsAreaTrabajo : clsAreaTrabajoDA
{
public clsAreaTrabajo()
{
this.IdAreaTrabajo = 0;
this.NombreAreaTrabajo = string.Empty;
}

public clsAreaTrabajo(int IdAreaTrabajo)
{
}


public clsAreaTrabajo clsAreaTrabajoPorIdAreaTrabajo()
{
using (IDataReader dr = ObtieneAreaTrabajo(this))
{
if (dr.Read())
{
this.IdAreaTrabajo = Convert.ToInt32(dr["IdAreaTrabajo"]);
this.NombreAreaTrabajo = Convert.ToString(dr["NombreAreaTrabajo"]);
}
}
return this;
}

public int AgregaAreaTrabajo()
{
clsAreaTrabajoDA ad = new clsAreaTrabajoDA();
return ad.AgregaAreaTrabajo(this);
}

public int ModificaAreaTrabajo()
{
clsAreaTrabajoDA ad = new clsAreaTrabajoDA();
return ad.ModificaAreaTrabajo(this);
}

public int EliminaAreaTrabajo()
{
clsAreaTrabajoDA ad = new clsAreaTrabajoDA();
return ad.EliminaAreaTrabajo(this);
}

}
}
