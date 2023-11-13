<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CU_UsuarioGestion.ascx.cs" Inherits="rwebSeguridad.ControlesUsuario.GestionarUsuario.CU_UsuarioGestion" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<div style="padding: 10px">
    <table id="TablaPrincipal" class="TablaPrincipal" cellspacing="2" cellpadding="1"
        width="100%" rules="none" style="border-collapse: collapse">
        <tr class="EditFormHeader">
            <td colspan="2">
                <b>Detalle del Usuario...</b>
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
                        <td class="font-blue">
                            <label id="rlblIdPersona" runat="server">
                                <strong>*</strong>Persona :</label>
                        </td>
                        <td>
                            <telerik:RadComboBox RenderMode="Lightweight" runat="server" ID="rddlIdPersona" Height="190px"
                                Width="460px" MarkFirstMatch="true" EnableLoadOnDemand="true" HighlightTemplatedItems="true"
                                OnItemDataBound="rddlIdPersona_ItemDataBound" OnItemsRequested="rddlIdPersona_ItemsRequested"
                                DropDownCssClass="exampleRadComboBox" OnDataBound="rddlIdPersona_DataBound">
                                <HeaderTemplate>
                                    <ul>
                                        <li class="col1">ID</li>
                                        <li class="col2">Persona</li>
                                    </ul>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <ul>
                                        <li class="col1">
                                            <%# DataBinder.Eval(Container.DataItem, "IdPersona")%></li>
                                        <li class="col2">
                                            <%# DataBinder.Eval(Container.DataItem, "NombrePersona")%></li>
                                    </ul>
                                </ItemTemplate>
                            </telerik:RadComboBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="font-blue">
                            <label id="rlblNombreUsuario" runat="server">
                                <strong>*</strong>Nombre Usuario :</label>
                        </td>
                        <td>
                            <telerik:RadTextBox Width="200px" ID="rtxtNombreUsuario" runat="server" Text='<%# DataBinder.Eval( Container, "DataItem.NombreUsuario" ) %>'
                                TabIndex="2">
                            </telerik:RadTextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="font-blue">
                            <label id="rlblClave" runat="server">
                                <strong>*</strong>Clave :</label>
                        </td>
                        <td>
                            <telerik:RadTextBox Width="200px" ID="rtxtClave" runat="server" Text='<%# DataBinder.Eval( Container, "DataItem.Clave" ) %>'
                                TabIndex="3" TextMode="Password">
                            </telerik:RadTextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="font-blue">
                            <label id="rlblPIN" runat="server">
                                <strong>*</strong>PIN :</label>
                        </td>
                        <td>
                            <telerik:RadTextBox Width="200px" ID="rtxtPIN" runat="server" Text='<%# DataBinder.Eval( Container, "DataItem.Pin" ) %>'
                                TabIndex="5">
                            </telerik:RadTextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="font-blue">
                            <label id="rlblIdEstadoUsuario" runat="server">
                                <strong>*</strong>Estado Usuario :</label>
                        </td>
                        <td>
                            <telerik:RadComboBox Width="200px" ID="rddlIdEstadoUsuario" runat="server" TabIndex="6">
                            </telerik:RadComboBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="font-blue">
                            <label id="rlblIdTipoUsuario" runat="server">
                                <strong>*</strong>Tipo Usuario :</label>
                        </td>
                        <td>
                            <telerik:RadComboBox Width="200px" ID="rddlIdTipoUsuario" runat="server" TabIndex="7">
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
            <telerik:TargetInput ControlID="rtxtIdPersona" />
            <telerik:TargetInput ControlID="rtxtNombreUsuario" />
            <telerik:TargetInput ControlID="rtxtClave" />
            <telerik:TargetInput ControlID="rtxtSalt" />
            <telerik:TargetInput ControlID="rtxtPIN" />
            <telerik:TargetInput ControlID="rtxtIdEstadoUsuario" />
            <telerik:TargetInput ControlID="rtxtIdTipoUsuario" />
        </TargetControls>
    </telerik:TextBoxSetting>
</telerik:RadInputManager>