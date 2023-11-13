<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CU_Menu.ascx.cs" Inherits="rwebSeguridad.ControlesUsuario.GestionarMenu.CU_Menu" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<div id="GestionObjetivo" class="CDiv">
    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" runat="server" />
</div>
<table>
    <tr>
        <td>
            <label id="Label2" runat="server">
                <strong>*Sistema</strong> :</label>
        </td>
        <td>
            <telerik:RadComboBox ID="rddlSistema" runat="server" Culture="es-ES" Width="200px"
                Style="margin-bottom: 0" AutoPostBack="True" OnSelectedIndexChanged="rddlSistema_SelectedIndexChanged">
            </telerik:RadComboBox>
        </td>
        <td>
            &nbsp;
        </td>
        <td>
            <label id="Label1" runat="server">
                <strong>*Nombre Menu</strong> :</label>
        </td>
        <td>
            <telerik:RadTextBox Width="200px" ID="rtxtNombreMenu" runat="server" TabIndex="1">
            </telerik:RadTextBox>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            <label id="Label5" runat="server">
                <strong>*Formulrio</strong>:</label></td>
        <td>
            <telerik:RadTextBox Width="200px" ID="rtxtNombreFormulrio" runat="server" 
                TabIndex="1">
            </telerik:RadTextBox>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            <label id="Label6" runat="server">
                <strong>*Numero&nbsp; Orden</strong>:</label></td>
        <td>
            <telerik:RadNumericTextBox ID="rntxtNumeroOrden" Runat="server">
            </telerik:RadNumericTextBox>
        </td>
    </tr>
    <tr>
        <td colspan="2" rowspan="9" valign="top">
            <telerik:RadTreeView ID="rTrvmenu" runat="server" OnNodeClick="rTrvmenu_NodeClick">
            </telerik:RadTreeView>
        </td>
        <td>
            &nbsp;
        </td>
        <td>
            &nbsp;
        </td>
        <td>
            &nbsp;
            <telerik:RadButton ID="btnInsertar" runat="server" Text="Agregar Menu" OnClick="btnInsertar_Click">
            </telerik:RadButton>
            &nbsp;&nbsp;&nbsp;
            <telerik:RadButton ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click">
            </telerik:RadButton>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;
        </td>
        <td>
            &nbsp;
        </td>
        <td>
            &nbsp;
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;
        </td>
        <td>
            <label id="Label3" runat="server">
                <strong>*Modificar Menu</strong> :</label>
        </td>
        <td>
            <telerik:RadTextBox Width="200px" ID="rtxtNombreMenuModificar" runat="server" TabIndex="1">
            </telerik:RadTextBox>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;
        </td>
        <td>
            &nbsp;
        </td>
        <td>
            <telerik:RadButton ID="btnModificar" runat="server" Text="Modificar" OnClick="btnModificar_Click">
            </telerik:RadButton>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;
        </td>
        <td>
            &nbsp;
        </td>
        <td>
            &nbsp;
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;
        </td>
        <td>
            <label id="Label4" runat="server">
                <strong>*Menu Principal</strong> :</label>
        </td>
        <td>
            <telerik:RadTextBox Width="200px" ID="rtxtNombreMenuPadre" runat="server" TabIndex="1">
            </telerik:RadTextBox>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;
        </td>
        <td>
            &nbsp;
        </td>
        <td>
            <telerik:RadButton ID="btnInsertarMenuPrincipal" runat="server" Text="Agregar Menu Principal"
                OnClick="btnInsertarMenuPrincipal_Click">
            </telerik:RadButton>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td colspan="2">
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td colspan="2">
            <asp:Label ID="rlblMensage" runat="server" Text="Estado" 
                style="font-weight: 700"></asp:Label>
        </td>
    </tr>
</table>
