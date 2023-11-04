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

public class clsColor : clsColorDA
{
public clsColor()
{
this.IdColor = 0;
this.NombreColor = string.Empty;
}

public clsColor(int IdColor)
{
}


public clsColor clsColorPorIdColor()
{
using (IDataReader dr = ObtieneColor(this))
{
if (dr.Read())
{
this.IdColor = Convert.ToInt32(dr["IdColor"]);
this.NombreColor = Convert.ToString(dr["NombreColor"]);
}
}
return this;
}

public int AgregaColor()
{
clsColorDA ad = new clsColorDA();
return ad.AgregaColor(this);
}

public int ModificaColor()
{
clsColorDA ad = new clsColorDA();
return ad.ModificaColor(this);
}

public int EliminaColor()
{
clsColorDA ad = new clsColorDA();
return ad.EliminaColor(this);
}

}
}
