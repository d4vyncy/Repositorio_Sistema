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

public class clsMoneda : clsMonedaDA
{
public clsMoneda()
{
this.IdMoneda = 0;
this.NombreMoneda = string.Empty;
}

public clsMoneda(int IdMoneda)
{
}


public clsMoneda clsMonedaPorIdMoneda()
{
using (IDataReader dr = ObtieneMoneda(this))
{
if (dr.Read())
{
this.IdMoneda = Convert.ToInt32(dr["IdMoneda"]);
this.NombreMoneda = Convert.ToString(dr["NombreMoneda"]);
}
}
return this;
}

public int AgregaMoneda()
{
clsMonedaDA ad = new clsMonedaDA();
return ad.AgregaMoneda(this);
}

public int ModificaMoneda()
{
clsMonedaDA ad = new clsMonedaDA();
return ad.ModificaMoneda(this);
}

public int EliminaMoneda()
{
clsMonedaDA ad = new clsMonedaDA();
return ad.EliminaMoneda(this);
}

}
}
