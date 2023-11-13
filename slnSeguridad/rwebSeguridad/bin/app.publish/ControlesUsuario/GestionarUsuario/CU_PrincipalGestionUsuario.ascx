<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CU_PrincipalGestionUsuario.ascx.cs"
    Inherits="rwebSeguridad.ControlesUsuario.GestionarUsuario.CU_PrincipalGestionUsuario" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<%@ Register Src="../GestionarPersona/CU_Persona.ascx" TagName="CU_Persona" TagPrefix="uc1" %>
<%@ Register Src="CU_Usuario.ascx" TagName="CU_Usuario" TagPrefix="uc2" %>
<%@ Register Src="../GestionRolUsuario/CU_RolUsuario.ascx" TagName="CU_RolUsuario"
    TagPrefix="uc3" %>
<div id="GestionUsuario" class="CDiv">
    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" runat="server">
    </telerik:RadAjaxLoadingPanel>
    <telerik:RadTabStrip ID="rtsNuevo" runat="server" MultiPageID="rmpServidorPage" 
        SelectedIndex="0">
        <Tabs>
            <telerik:RadTab Text="Registrar Persona" Selected="True">
            </telerik:RadTab>
            <telerik:RadTab Text="Registrar Usuario">
            </telerik:RadTab>
            <telerik:RadTab Text="Asignar Rol">
            </telerik:RadTab>
        </Tabs>
    </telerik:RadTabStrip>
    <telerik:RadMultiPage ID="rmpServidorPage" runat="server" SelectedIndex="0">
        <telerik:RadPageView ID="rpvPersonal" runat="server">
            <uc1:CU_Persona ID="CU_Persona1" runat="server" />
        </telerik:RadPageView>
        <telerik:RadPageView ID="rpvUsuario" runat="server">
            <uc2:CU_Usuario ID="CU_Usuario1" runat="server" />
        </telerik:RadPageView>
        <telerik:RadPageView ID="rpvRolUsuario" runat="server">
            <uc3:CU_RolUsuario ID="CU_RolUsuario1" runat="server" />
        </telerik:RadPageView>
    </telerik:RadMultiPage>
</div>
