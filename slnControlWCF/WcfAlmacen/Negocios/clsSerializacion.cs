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

public class clsSerializacion : clsSerializacionDA
{
public clsSerializacion()
{
this.IdSerializacion = 0;
this.EstadoSerializacion = string.Empty;
}

public clsSerializacion(int IdSerializacion)
{
}


public clsSerializacion clsSerializacionPorIdSerializacion()
{
using (IDataReader dr = ObtieneSerializacion(this))
{
if (dr.Read())
{
this.IdSerializacion = Convert.ToInt32(dr["IdSerializacion"]);
this.EstadoSerializacion = Convert.ToString(dr["EstadoSerializacion"]);
}
}
return this;
}

public int AgregaSerializacion()
{
clsSerializacionDA ad = new clsSerializacionDA();
return ad.AgregaSerializacion(this);
}

public int ModificaSerializacion()
{
clsSerializacionDA ad = new clsSerializacionDA();
return ad.ModificaSerializacion(this);
}

public int EliminaSerializacion()
{
clsSerializacionDA ad = new clsSerializacionDA();
return ad.EliminaSerializacion(this);
}

}
}
