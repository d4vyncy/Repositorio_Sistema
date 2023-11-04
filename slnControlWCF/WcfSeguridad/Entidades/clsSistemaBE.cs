using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfSeguridad.Entidades 
{

public class clsSistemaBE
{
public int IdSistema { get; set; }
public string NombreSistema { get; set; }
public string IpServer { get; set; }
public string HostNameServer { get; set; }
public string Url { get; set; }
public Byte[] Imagen { get; set; }
public string Detalle { get; set; }
}
}