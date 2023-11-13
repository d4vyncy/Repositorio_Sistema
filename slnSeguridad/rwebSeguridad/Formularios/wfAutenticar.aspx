<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfAutenticar.aspx.cs" Inherits="rwebSeguridad.Formularios.wfAutenticar" %>



<%@ Register src="../ControlesUsuario/CUP_Autenticar.ascx" tagname="CUP_Autenticar" tagprefix="uc1" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body background="./Imagenes/fondoM2.png" >
    <form id="form1" runat="server">
    <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
		<Scripts>
			<asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.Core.js" />
			<asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQuery.js" />
			<asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQueryInclude.js" />
		</Scripts>
	</telerik:RadScriptManager>
    <div >
        
    
        
    
        <uc1:CUP_Autenticar ID="CUP_Autenticar1" runat="server" />
        
    
        
    
    </div>
    </form>
</body>
</html>
