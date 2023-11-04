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

public class clsProveedor : clsProveedorDA
{
public clsProveedor()
{
this.IdProveedor = 0;
this.IdPersona = 0;
this.Representante = string.Empty;
this.NombreProveedor = string.Empty;
this.Direccion = string.Empty;
this.Telefono = string.Empty;
this.NitProveedor = string.Empty;
this.ServiciosGenerales = string.Empty;
this.Celular = string.Empty;
this.Correo = string.Empty;
this.IdAreaTrabajo = 0;
}

public clsProveedor(int IdProveedor)
{
}


public clsProveedor clsProveedorPorIdProveedor()
{
using (IDataReader dr = ObtieneProveedor(this))
{
if (dr.Read())
{
this.IdProveedor = Convert.ToInt32(dr["IdProveedor"]);
this.IdPersona = Convert.ToInt32(dr["IdPersona"]);
this.Representante = Convert.ToString(dr["Representante"]);
this.NombreProveedor = Convert.ToString(dr["NombreProveedor"]);
this.Direccion = Convert.ToString(dr["Direccion"]);
this.Telefono = Convert.ToString(dr["Telefono"]);
this.NitProveedor = Convert.ToString(dr["NitProveedor"]);
this.ServiciosGenerales = Convert.ToString(dr["ServiciosGenerales"]);
this.Celular = Convert.ToString(dr["Celular"]);
this.Correo = Convert.ToString(dr["Correo"]);
this.IdAreaTrabajo = Convert.ToInt32(dr["IdAreaTrabajo"]);
}
}
return this;
}

public int AgregaProveedor()
{
clsProveedorDA ad = new clsProveedorDA();
return ad.AgregaProveedor(this);
}

public int ModificaProveedor()
{
clsProveedorDA ad = new clsProveedorDA();
return ad.ModificaProveedor(this);
}

public int EliminaProveedor()
{
clsProveedorDA ad = new clsProveedorDA();
return ad.EliminaProveedor(this);
}

}
}
