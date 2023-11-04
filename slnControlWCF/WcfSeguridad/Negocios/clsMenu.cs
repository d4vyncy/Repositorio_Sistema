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

public class clsMenu : clsMenuDA
{
public clsMenu()
{
this.IdMenu = 0;
this.NombreMenu = string.Empty;
this.NombreFormulario = string.Empty;
this.NumeroDeOrden = 0;
this.IdSistema = 0;
this.IdMenuPadre = 0;
}

public clsMenu(int IdMenu)
{
}


public clsMenu clsMenuPorIdMenu()
{
using (IDataReader dr = ObtieneMenu(this))
{
if (dr.Read())
{
this.IdMenu = Convert.ToInt32(dr["IdMenu"]);
this.NombreMenu = Convert.ToString(dr["NombreMenu"]);
this.NombreFormulario = Convert.ToString(dr["NombreFormulario"]);
this.NumeroDeOrden = Convert.ToInt32(dr["NumeroDeOrden"]);
this.IdSistema = Convert.ToInt32(dr["IdSistema"]);
this.IdMenuPadre = Convert.ToInt32(dr["IdMenuPadre"]);
}
}
return this;
}

public int AgregaMenu()
{
clsMenuDA ad = new clsMenuDA();
return ad.AgregaMenu(this);
}

public int ModificaMenu()
{
clsMenuDA ad = new clsMenuDA();
return ad.ModificaMenu(this);
}

public int EliminaMenu()
{
clsMenuDA ad = new clsMenuDA();
return ad.EliminaMenu(this);
}

}
}
