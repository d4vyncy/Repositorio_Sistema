<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CU_PersonaGestion.ascx.cs" Inherits="rwebSeguridad.ControlesUsuario.GestionarPersona.CU_PersonaGestion" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<style type="text/css">
    .style1
    {
        font-weight: bold;
    }
</style>
<div style="padding: 10px; ">
    <table id="TablaPrincipal" class="TablaPrincipal" cellspacing="2" cellpadding="1"
        width="100%" rules="none" style="border-collapse: collapse">
        <tr class="EditFormHeader">
            <td colspan="2">
                <b>Detalle registro actual</b>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <table id="TablaDetalle" class="TablaDetalle" cellspacing="1" cellpadding="1" width="100%"
                    border="0">
                    <tr>
                        <td>
                        </td>
                        <td>
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                            <label id="rlblPaterno" runat="server">
                                <strong>*</strong><b>Paterno :</b></label><b> </b>
                        </td>
                        <td>
                            <telerik:RadTextBox Width="200px" ID="rtxtPaterno" runat="server" Text='<%# DataBinder.Eval( Container, "DataItem.Paterno" ) %>'
                                TabIndex="1">
                            </telerik:RadTextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                            <label id="rlblMaterno" runat="server" class="" >
                                <strong>*</strong><b>Materno :</b></label><b> </b>
                        </td>
                        <td>
                            <telerik:RadTextBox Width="200px" ID="rtxtMaterno" runat="server" Text='<%# DataBinder.Eval( Container, "DataItem.Materno" ) %>'
                                TabIndex="2">
                            </telerik:RadTextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                            <label id="rlblApEsposo" runat="server">
                                <strong>*</strong><b>Ap. Esposo :</b></label><b> </b>
                        </td>
                        <td>
                            <telerik:RadTextBox Width="200px" ID="rtxtApEsposo" runat="server" Text='<%# DataBinder.Eval( Container, "DataItem.ApEsposo" ) %>'
                                TabIndex="3">
                            </telerik:RadTextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                            <label id="rlblNombres" runat="server">
                                <strong>*</strong><b>Nombres :</b></label><b> </b>
                        </td>
                        <td>
                            <telerik:RadTextBox Width="200px" ID="rtxtNombres" runat="server" Text='<%# DataBinder.Eval( Container, "DataItem.Nombres" ) %>'
                                TabIndex="4">
                            </telerik:RadTextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                            <label id="rlblDocIdentidad" runat="server">
                                <strong>*</strong><b>Doc Identidad :</b></label><b> </b>
                        </td>
                        <td>
                            <telerik:RadTextBox Width="200px" ID="rtxtDocIdentidad" runat="server" Text='<%# DataBinder.Eval( Container, "DataItem.DocIdentidad" ) %>'
                                TabIndex="5">
                            </telerik:RadTextBox>
                            <telerik:RadButton ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click"
                                TabIndex="4" Visible="False">
                                <Icon PrimaryIconUrl="~/img/IconSeleccionar.png" PrimaryIconWidth="15px" PrimaryIconHeight="15px"
                                    PrimaryIconTop="4px" PrimaryIconLeft="3px" />
                            </telerik:RadButton>
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                            <label id="rlblLugarExpedicion" runat="server">
                                <strong>*</strong><b>Lugar Expedicion :</b></label><b> </b>
                        </td>
                        <td>
                            <%--<telerik:RadTextBox Width="50px" ID="rtxtLugarExpedicion" runat="server" Text='<%# DataBinder.Eval( Container, "DataItem.LugarExpedicion" ) %>'
                                TabIndex="6" LabelWidth="80px" MaxLength="3">
                            </telerik:RadTextBox>--%>
                            <telerik:RadComboBox ID="rddlLugarExpedicion" runat="server" Culture="es-ES" Width="150px">
                                <Items>
                                    <telerik:RadComboBoxItem runat="server" Text="LPZ" Value="LPZ" />
                                    <telerik:RadComboBoxItem runat="server" Text="CHQ" Value="CHQ" />
                                    <telerik:RadComboBoxItem runat="server" Text="CBA" Value="CBA" />
                                    <telerik:RadComboBoxItem runat="server" Text="ORU" Value="ORU" />
                                    <telerik:RadComboBoxItem runat="server" Text="PTS" Value="PTS" />
                                    <telerik:RadComboBoxItem runat="server" Text="TJA" Value="TJA" />
                                    <telerik:RadComboBoxItem runat="server" Text="SCZ" Value="SCZ" />
                                    <telerik:RadComboBoxItem runat="server" Text="BEN" Value="BEN" />
                                    <telerik:RadComboBoxItem runat="server" Text="PND" Value="PND" />
                                </Items>
                            </telerik:RadComboBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                            <label id="rlblCelular" runat="server">
                                <strong>*</strong><b>Celular :</b></label><b> </b>
                        </td>
                        <td>
                            <telerik:RadTextBox Width="200px" ID="rtxtCelular" runat="server" Text='<%# DataBinder.Eval( Container, "DataItem.Celular" ) %>'
                                TabIndex="7">
                            </telerik:RadTextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                            <label id="rlblCorreoElectronico" runat="server">
                                <strong>*</strong><b>Correo Electronico :</b></label><b> </b>
                        </td>
                        <td>
                            <telerik:RadTextBox Width="200px" ID="rtxtCorreoElectronico" runat="server" Text='<%# DataBinder.Eval( Container, "DataItem.CorreoElectronico" ) %>'
                                TabIndex="8">
                            </telerik:RadTextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                            <label id="Label1" runat="server">
                                <strong>*</strong><b>Tipo Persona :</b></label><b> </b>
                        </td>
                        <td>
                            <telerik:RadComboBox ID="rddlTipoPersona" runat="server" Culture="es-ES" Width="200px">
                                <Items>
                                </Items>
                            </telerik:RadComboBox>
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
                    Text="Guardar" HoveredCssClass="goButtonClassHov" CausesValidation="true" 
                    ValidationGroup="FormValidationGroup" onclick="btnInsertar_Click">
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
