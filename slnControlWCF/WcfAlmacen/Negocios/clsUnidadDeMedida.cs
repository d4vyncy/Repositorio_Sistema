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

public class clsUnidadDeMedida : clsUnidadDeMedidaDA
{
public clsUnidadDeMedida()
{
this.IdUnidadDeMedida = 0;
this.NombreUnidadDeMedida = string.Empty;
this.Abreviacion = string.Empty;
}

public clsUnidadDeMedida(int IdUnidadDeMedida)
{
}


public clsUnidadDeMedida clsUnidadDeMedidaPorIdUnidadDeMedida()
{
using (IDataReader dr = ObtieneUnidadDeMedida(this))
{
if (dr.Read())
{
this.IdUnidadDeMedida = Convert.ToInt32(dr["IdUnidadDeMedida"]);
this.NombreUnidadDeMedida = Convert.ToString(dr["NombreUnidadDeMedida"]);
this.Abreviacion = Convert.ToString(dr["Abreviacion"]);
}
}
return this;
}

public int AgregaUnidadDeMedida()
{
clsUnidadDeMedidaDA ad = new clsUnidadDeMedidaDA();
return ad.AgregaUnidadDeMedida(this);
}

public int ModificaUnidadDeMedida()
{
clsUnidadDeMedidaDA ad = new clsUnidadDeMedidaDA();
return ad.ModificaUnidadDeMedida(this);
}

public int EliminaUnidadDeMedida()
{
clsUnidadDeMedidaDA ad = new clsUnidadDeMedidaDA();
return ad.EliminaUnidadDeMedida(this);
}

}
}
