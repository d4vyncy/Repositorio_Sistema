<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CU_MenuGestion.ascx.cs" Inherits="rwebSeguridad.ControlesUsuario.GestionarMenu.CU_MenuGestion" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<style type="text/css">
    .style1
    {
        text-align: left;
    }
    .style2
    {
        width: 141px;
    }
</style>
<div style="padding: 10px">
    <table id="TablaPrincipal" class="TablaPrincipal" cellspacing="2" cellpadding="1"
        width="100%" rules="none" style="border-collapse: collapse">
        <tr class="EditFormHeader">
            <td colspan="2" class="style1">
                <strong>MENU</strong></td>
        </tr>
        <tr>
            <td colspan="2">
                <table id="TablaDetalle" class="TablaDetalle" cellspacing="1" cellpadding="1" width="100%"
                    border="0">
                    <tr>
                        <td class="style2">
                        </td>
                        <td>
                        </td>
                    </tr>
                    <tr>
                        <td class="style2">
                            <label id="rlblPaterno" runat="server">
                                <strong>*Nombre</strong> <strong>Menu</strong>:</label>
                        </td>
                        <td>
                            <telerik:RadTextBox Width="200px" ID="rtxtNombreMenu" runat="server" Text='<%# DataBinder.Eval( Container, "DataItem.NombreMenu" ) %>'
                                TabIndex="1">
                            </telerik:RadTextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style2">
                            <label id="rlblPaterno1" runat="server">
                                <strong>*Sistema</strong> :</label>
                        </td>
                        <td>
                            <telerik:RadComboBox ID="rddlSistema" runat="server" Culture="es-ES" 
                                Width="200px" style="margin-bottom: 0" AutoPostBack="True" 
                                onselectedindexchanged="rddlSistema_SelectedIndexChanged">
                            </telerik:RadComboBox>
                        </td>
                    </tr>
                 
                  
                    <tr>
                        <td class="style2">
                            <label id="rlblPaterno0" runat="server">
                                <strong>*Menu</strong> <strong>Padre</strong>:</label>
                        </td>
                        <td>
                            <telerik:RadComboBox ID="rddlMenuPadre" runat="server" Culture="es-ES" 
                                Width="200px" style="margin-bottom: 0" AutoPostBack="True" 
                                onselectedindexchanged="rddlMenuPadre_SelectedIndexChanged">
                            </telerik:RadComboBox>
                        </td>
                    </tr>
                  
                        <tr>
                  
                        <td class="style2">
                            &nbsp;</td>
                        <td>
                            <telerik:RadComboBox ID="rddlSubMenu" runat="server" Culture="es-ES" 
                                Width="20px" style="margin-bottom: 0" AutoPostBack="True">
                            </telerik:RadComboBox>
                        </td>
                    </tr>
                  
                        <td class="style2">
                            &nbsp;</td>
                        <td>
                            <%--<telerik:RadTextBox Width="50px" ID="rtxtLugarExpedicion" runat="server" Text='<%# DataBinder.Eval( Container, "DataItem.LugarExpedicion" ) %>'
                                TabIndex="6" LabelWidth="80px" MaxLength="3">
                            </telerik:RadTextBox>--%>
                        </td>
                    </tr>
                  
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Lcampo" runat="server">
                <span class="obligatori" style="font-size:10px; font-weight:normal; text-align:left; padding-left:5px">Los campos marcados con 
                    * son obligatorios
                    </span></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2" style="border-top-style: solid; border-width: thin">
                <telerik:RadButton ID="btnModificar" runat="server" CommandName="Update" Visible="<%# !(DataItem is Telerik.Web.UI.GridInsertionObject) %>"
                    Text="Modificar" HoveredCssClass="goButtonClassHov" CausesValidation="true" ValidationGroup="FormValidationGroup">
                    <Icon PrimaryIconUrl="~/img/IconSeleccionar.png" PrimaryIconWidth="15px" PrimaryIconHeight="15px"
                        PrimaryIconTop="4px" PrimaryIconLeft="3px" />
                </telerik:RadButton>
                <cc1:ConfirmButtonExtender ID="btnGrabar_ConfirmButtonExtender" runat="server" ConfirmText="Desea grabar?"
                    Enabled="True" TargetControlID="btnModificar">
                </cc1:ConfirmButtonExtender>
                <telerik:RadButton ID="btnInsertar" runat="server" CommandName="PerformInsert" Visible="<%# DataItem is Telerik.Web.UI.GridInsertionObject %>"
                    Text="Guardar" HoveredCssClass="goButtonClassHov" CausesValidation="true" ValidationGroup="FormValidationGroup">
                    <Icon PrimaryIconUrl="~/img/IconSeleccionar.png" PrimaryIconWidth="15px" PrimaryIconHeight="15px"
                        PrimaryIconTop="4px" PrimaryIconLeft="3px" />
                </telerik:RadButton>
                <cc1:ConfirmButtonExtender ID="ConfirmButtonExtender1" runat="server" ConfirmText="Desea grabar?"
                    Enabled="True" TargetControlID="btnInsertar">
                </cc1:ConfirmButtonExtender>
                &nbsp;
                <telerik:RadButton ID="btnCancelar" runat="server" CausesValidation="false" CommandName="Cancel"
                    HoveredCssClass="goButtonClassHov" Text="Cancelar">
                    <Icon PrimaryIconUrl="~/img/IconEliminar.png" PrimaryIconWidth="15px" PrimaryIconHeight="15px"
                        PrimaryIconTop="4px" PrimaryIconLeft="3px" />
                </telerik:RadButton>
            </td>
        </tr>
    </table>
</div>
<telerik:RadFormDecorator ID="RadFormDecorator1" runat="server" />
<telerik:RadInputManager ID="RadInputManager1" runat="server">
    <telerik:TextBoxSetting BehaviorID="TextBoxBehavior1" EmptyMessage="" Validation-IsRequired="true"
        Validation-ValidationGroup="edicion">
        <TargetControls>
            <telerik:TargetInput ControlID="rtxtPaterno" />
            <telerik:TargetInput ControlID="rtxtMaterno" />
            <telerik:TargetInput ControlID="rtxtApEsposo" />
            <telerik:TargetInput ControlID="rtxtNombres" />
            <telerik:TargetInput ControlID="rtxtDocIdentidad" />
            <%--<telerik:TargetInput ControlID="rtxtLugarExpedicion" />--%>
            <telerik:TargetInput ControlID="rtxtCelular" />
            <telerik:TargetInput ControlID="rtxtCorreoElectronico" />
        </TargetControls>
    </telerik:TextBoxSetting>
</telerik:RadInputManager>


