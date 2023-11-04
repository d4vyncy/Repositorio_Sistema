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

public class clsMarca : clsMarcaDA
{
public clsMarca()
{
this.IdMarca = 0;
this.NombreMarca = string.Empty;
}

public clsMarca(int IdMarca)
{
}


public clsMarca clsMarcaPorIdMarca()
{
using (IDataReader dr = ObtieneMarca(this))
{
if (dr.Read())
{
this.IdMarca = Convert.ToInt32(dr["IdMarca"]);
this.NombreMarca = Convert.ToString(dr["NombreMarca"]);
}
}
return this;
}

public int AgregaMarca()
{
clsMarcaDA ad = new clsMarcaDA();
return ad.AgregaMarca(this);
}

public int ModificaMarca()
{
clsMarcaDA ad = new clsMarcaDA();
return ad.ModificaMarca(this);
}

public int EliminaMarca()
{
clsMarcaDA ad = new clsMarcaDA();
return ad.EliminaMarca(this);
}

}
}
