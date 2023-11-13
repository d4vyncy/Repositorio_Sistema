<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CU_RolUsuarioGestion.ascx.cs"
    Inherits="rwebSeguridad.ControlesUsuario.GestionRolUsuario.CU_RolUsuarioGestion" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<table id="TablaPrincipal" class="TablaPrincipal" cellspacing="2" cellpadding="1"
    width="100%" rules="none" style="border-collapse: collapse">
    <tr class="EditFormHeader">
        <td class="style1">
            &nbsp;
        </td>
        <td class="style2">
            ROL USUARIO GESTION GESTION
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
            SISTEMA:
        </td>
        <td class="style2">
            <telerik:RadComboBox ID="rddlSistema" runat="server" Culture="es-ES" AutoPostBack="true"
                Width="200px" OnSelectedIndexChanged="rddlSistema_SelectedIndexChanged">
            </telerik:RadComboBox>
        </td>
    </tr>
    <tr>
        <td class="style1">
            ROL:
        </td>
        <td class="style2">
            <telerik:RadComboBox ID="rddlIRol" runat="server" Culture="es-ES" Width="200px">
            </telerik:RadComboBox>
        </td>
    </tr>
    <tr>
        <td class="style1">
            USUARIO:
        </td>
        <td class="style2">
            <telerik:RadComboBox ID="rddlUsuario" runat="server" Culture="es-ES" Width="200px">
            </telerik:RadComboBox>
        </td>
    </tr>
    <tr>
        <td class="style1">
            FECHA BAJA:
        </td>
        <td class="style2">
            <telerik:RadDatePicker ID="rdtFechaBaja" runat="server" TabIndex="2" MinDate="1900-01-01">
                <Calendar UseColumnHeadersAsSelectors="False" UseRowHeadersAsSelectors="False">
                </Calendar>
                <DateInput DateFormat="dd/MM/yyyy" DisplayDateFormat="dd/MM/yyyy" LabelWidth="40%"
                    TabIndex="2">
                    <EmptyMessageStyle Resize="None" />
                    <ReadOnlyStyle Resize="None" />
                    <FocusedStyle Resize="None" />
                    <DisabledStyle Resize="None" />
                    <InvalidStyle Resize="None" />
                    <HoveredStyle Resize="None" />
                    <EnabledStyle Resize="None" />
                </DateInput>
                <DatePopupButton HoverImageUrl="" ImageUrl="" TabIndex="2" />
            </telerik:RadDatePicker>
        </td>
    </tr>
    <tr>
        <td class="style1">
            &nbsp;ESTADO:
        </td>
        <td class="style2">
            &nbsp;<telerik:RadComboBox ID="rddlEstadoUsuario" runat="server" Culture="es-ES" 
                Width="200px">
            </telerik:RadComboBox>
        </td>
    </tr>
    <tr>
        <td class="style1">
            <telerik:RadButton ID="btnInsertar" runat="server" CommandName="PerformInsert" Visible="<%# DataItem is Telerik.Web.UI.GridInsertionObject %>"
                Text="Guardar" HoveredCssClass="goButtonClassHov" CausesValidation="true" ValidationGroup="FormValidationGroup">
                <Icon PrimaryIconUrl="~/img/IconSeleccionar.png" PrimaryIconWidth="15px" PrimaryIconHeight="15px"
                    PrimaryIconTop="4px" PrimaryIconLeft="3px" />
            </telerik:RadButton>
            <cc1:ConfirmButtonExtender ID="ConfirmButtonExtender1" runat="server" ConfirmText="Desea grabar?"
                Enabled="True" TargetControlID="btnInsertar">
            </cc1:ConfirmButtonExtender>
        </td>
        <td class="style2">
            <telerik:RadButton ID="btnModificar" runat="server" CausesValidation="true" CommandName="Update"
                HoveredCssClass="goButtonClassHov" Text="Modificar" ValidationGroup="FormValidationGroup"
                Visible="<%# !(DataItem is Telerik.Web.UI.GridInsertionObject) %>">
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
