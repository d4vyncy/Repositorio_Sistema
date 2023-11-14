<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CU_UsuarioPassword.ascx.cs"
    Inherits="rwebSeguridad.ControlesUsuario.GestionUsuario.CU_UsuarioPassword" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<style type="text/css">
    .style1
    {
    }
    .style2
    {
        width: 291px;
    }
</style>
<p>
    <table style="width: 100%;">
        <tr>
            <td class="style1">
                &nbsp;
            </td>
            <td class="style2">
                <label id="Label6" runat="server">
                    <strong>*CAMBIAR CONTRASEÑA</strong><b> :</b></label>
            </td>
        </tr>
        <tr>
            <td class="style1">
                <label id="lblCertificacion" runat="server">
                    <strong>Contraseña Actual</strong> :</label>
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
                    <strong>Nueva Contraseña</strong> :</label>
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
                    <strong>Repita la Contraseña</strong> :</label>
            </td>
            <td class="style2">
                <telerik:RadTextBox ID="rtxtNuevoPasswordDuplicado" runat="server" TextMode="Password"
                    TabIndex="1" Width="200px">
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
                <telerik:RadButton ID="btnModificar" runat="server" CausesValidation="true" CommandName="Update"
                    HoveredCssClass="goButtonClassHov" Text="Modificar" ValidationGroup="FormValidationGroup"
                    Visible="<%# !(DataItem is Telerik.Web.UI.GridInsertionObject) %>" OnClick="btnModificar_Click">
                    <Icon PrimaryIconHeight="15px" PrimaryIconLeft="3px" PrimaryIconTop="4px" PrimaryIconUrl="~/img/IconSeleccionar.png"
                        PrimaryIconWidth="15px" />
                </telerik:RadButton>
                <cc1:ConfirmButtonExtender ID="btnGrabar_ConfirmButtonExtender" runat="server" ConfirmText="Desea grabar?"
                    Enabled="True" TargetControlID="btnModificar">
                </cc1:ConfirmButtonExtender>
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
