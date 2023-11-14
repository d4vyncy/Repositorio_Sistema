<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CUP_Folio.ascx.cs" Inherits="rwebSeguridad.ControlesUsuario.CUP_Folio" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<style type="text/css">
</style>
<p>
    <table style="width: 100%;">
        <tr>
            <td class="style1">
                &nbsp;
            <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
        <Scripts>
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.Core.js" />
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQuery.js" />
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQueryInclude.js" />
        </Scripts>
    </telerik:RadScriptManager>
    <telerik:RadFormDecorator ID="RadFormDecorator1" runat="server" Skin="Default" DecoratedControls="All" />
    <telerik:RadSkinManager ID="RadSkinManager1" runat="server" Skin="Default">
    </telerik:RadSkinManager>
            </td>
            <td class="style2">
                <label id="Label6" runat="server">
                    <strong>*GENERAR FOLIO</strong><b> :</b></label>
            </td>
        </tr>
        <tr>
            <td class="style1">
                <label id="lblCertificacion" runat="server">
                    <strong>Numero Inicial</strong>:</label>
            </td>
            <td class="style2">
                <telerik:RadTextBox ID="rtxtPasswordActual" runat="server" TextMode="Password" TabIndex="1"
                    Width="200px">
                </telerik:RadTextBox>
            </td>
        </tr>
        <tr>
            <td class="style1">
                <label id="Label1" runat="server">
                    <strong>Numero Final</strong> :</label>
            </td>
            <td class="style2">
                <telerik:RadTextBox ID="rtxtNuevoPassword" runat="server" TextMode="Password" TabIndex="1"
                    Width="200px">
                    <EmptyMessageStyle Resize="None" />
                    <ReadOnlyStyle Resize="None" />
                    <FocusedStyle Resize="None" />
                    <DisabledStyle Resize="None" />
                    <InvalidStyle Resize="None" />
                    <HoveredStyle Resize="None" />
                    <EnabledStyle Resize="None" />
                </telerik:RadTextBox>
            </td>
        </tr>
        <tr>
            <td class="style1">
                <label id="Label2" runat="server">
                    <strong>Posición</strong> :</label>
            </td>
            <td class="style2">
                <telerik:RadComboBox Width="200px" ID="rddlIdPagina" runat="server" TabIndex="6"
                    Culture="es-ES">
                    <Items>
                        <telerik:RadComboBoxItem runat="server" Text="Arriba Derecha" Value="1" />
                        <telerik:RadComboBoxItem runat="server" Text="Arriba Izquierda" Value="2" />
                        <telerik:RadComboBoxItem runat="server" Text="Abajo Derecha" Value="3" />
                        <telerik:RadComboBoxItem runat="server" Text="Abajo Izquierda" Value="4" />
                    </Items>
                </telerik:RadComboBox>
            </td>
        </tr>
        <tr>
            <td class="style1" colspan="2">
                &nbsp; &nbsp;
                <asp:Label ID="lblMensaje" runat="server" Text="---" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;
            </td>
            <td class="style2">
                <telerik:RadButton ID="btnGenerar" runat="server" CausesValidation="true" HoveredCssClass="goButtonClassHov"
                    Text="Generar" OnClick="btnGenerar_Click">
                    <Icon PrimaryIconHeight="15px" PrimaryIconLeft="3px" PrimaryIconTop="4px" PrimaryIconUrl="~/img/IconSeleccionar.png"
                        PrimaryIconWidth="15px" />
                </telerik:RadButton>
            </td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;
            </td>
            <td class="style2">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;
            </td>
            <td class="style2">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;
            </td>
            <td class="style2">
                &nbsp;
            </td>
        </tr>
    </table>
</p>
