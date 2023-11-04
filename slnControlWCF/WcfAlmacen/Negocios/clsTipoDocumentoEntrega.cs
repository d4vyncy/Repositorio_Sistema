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

public class clsTipoDocumentoEntrega : clsTipoDocumentoEntregaDA
{
public clsTipoDocumentoEntrega()
{
this.IdTipoDocumentoEntrega = 0;
this.NombreTipoDocumentoEntrega = string.Empty;
}

public clsTipoDocumentoEntrega(int IdTipoDocumentoEntrega)
{
}


public clsTipoDocumentoEntrega clsTipoDocumentoEntregaPorIdTipoDocumentoEntrega()
{
using (IDataReader dr = ObtieneTipoDocumentoEntrega(this))
{
if (dr.Read())
{
this.IdTipoDocumentoEntrega = Convert.ToInt32(dr["IdTipoDocumentoEntrega"]);
this.NombreTipoDocumentoEntrega = Convert.ToString(dr["NombreTipoDocumentoEntrega"]);
}
}
return this;
}

public int AgregaTipoDocumentoEntrega()
{
clsTipoDocumentoEntregaDA ad = new clsTipoDocumentoEntregaDA();
return ad.AgregaTipoDocumentoEntrega(this);
}

public int ModificaTipoDocumentoEntrega()
{
clsTipoDocumentoEntregaDA ad = new clsTipoDocumentoEntregaDA();
return ad.ModificaTipoDocumentoEntrega(this);
}

public int EliminaTipoDocumentoEntrega()
{
clsTipoDocumentoEntregaDA ad = new clsTipoDocumentoEntregaDA();
return ad.EliminaTipoDocumentoEntrega(this);
}

}
}
