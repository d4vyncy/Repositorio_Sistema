<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CU_PermisoGestion.ascx.cs" Inherits="rwebSeguridad.ControlesUsuario.GestionarPermiso.CU_PermisoGestion" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

    <table id="TablaPrincipal" cellspacing="2" cellpadding="1"
        width="100%" rules="none" >
        <tr >
            <td colspan="2">
                <label runat="server">GESTIONAR PERMISO</label>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <table id="TablaDetalle" cellspacing="1" cellpadding="1" width="100%"
                    border="0">
                    <tr>
                        
                        <td colspan="2">
                            <label runat="server" id="LMensaje"></label>
                        </td>
                    </tr>
                    <tr>
                        <td >
                            <label id="Label1" runat="server">*Sistema : </label>
                        </td>
                        <td>
                            <telerik:RadComboBox ID="rddlSistema" runat="server" Culture="es-ES" AutoPostBack="True"
                                Width="200px" OnSelectedIndexChanged="rddlSistema_SelectedIndexChanged">
                                <Items>
                                </Items>
                            </telerik:RadComboBox>
                        </td>
                    </tr>
                    <tr>
                        <td >
                            <label id="Label2" runat="server">*Rol :</label>
                        </td>
                        <td>
                            <telerik:RadComboBox ID="rddlRol" runat="server" Culture="es-ES" Width="200px"
                                OnSelectedIndexChanged="rddlRol_SelectedIndexChanged" AutoPostBack="true">
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
                <div id="GestionObjetivo" >
                    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" runat="server" />
                    <telerik:RadGrid ID="RGVPermisos" runat="server" GridLines="None" AllowPaging="True"
                        PageSize="20" AllowSorting="True" AutoGenerateColumns="False"
                        ShowStatusBar="True" CellSpacing="0" Culture="es-ES">
                        <PagerStyle Mode="NextPrevAndNumeric" />
                        <ClientSettings EnableRowHoverStyle="true">
                        </ClientSettings>
                        <MasterTableView Width="100%">
                            <CommandItemSettings RefreshText="Actualizar"></CommandItemSettings>
                            <RowIndicatorColumn Visible="True" FilterControlAltText="Filter RowIndicator column">
                            </RowIndicatorColumn>
                            <ExpandCollapseColumn Visible="True" FilterControlAltText="Filter ExpandColumn column">
                            </ExpandCollapseColumn>
                            <Columns>
                                <telerik:GridBoundColumn AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                                    DataField="IdMenu" HeaderText="ID" ShowFilterIcon="false" UniqueName="IdMenu">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                                    DataField="NombreMenu" HeaderText="Menu" ShowFilterIcon="false" UniqueName="NombreMenu">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                                    DataField="NombreFormulario" HeaderText="Formulario" ShowFilterIcon="false" UniqueName="NombreFormulario">
                                </telerik:GridBoundColumn>
                                <telerik:GridTemplateColumn UniqueName="ControlTotal" DataField="ControlTotal" HeaderText="Control Total">
                                    <ItemTemplate>
                                        <asp:CheckBox ID="ControlTotal" runat="server" Checked='<%# Convert.ToBoolean(Eval("ControlTotal")) %>'/>
                                    </ItemTemplate>
                                </telerik:GridTemplateColumn>
                                <telerik:GridTemplateColumn DataField="Modificacion" HeaderText="Modificacion">
                                    <ItemTemplate>
                                        <asp:CheckBox ID="Modificacion" runat="server" Checked='<%# Convert.ToBoolean(Eval("Modificacion")) %>'/>
                                    </ItemTemplate>
                                </telerik:GridTemplateColumn>
                                <telerik:GridTemplateColumn DataField="Consulta" HeaderText="Consulta">
                                    <ItemTemplate>
                                        <asp:CheckBox ID="Consulta" runat="server" Checked='<%# Convert.ToBoolean(Eval("Consulta")) %>'/>
                                    </ItemTemplate>
                                </telerik:GridTemplateColumn>
                            </Columns>
                            <PagerStyle PageSizeControlType="RadComboBox"></PagerStyle>
                        </MasterTableView>
                        <FilterMenu EnableImageSprites="False">
                        </FilterMenu>
                        <HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default">
                        </HeaderContextMenu>
                    </telerik:RadGrid>
                </div>
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
            <td align="center" colspan="2" >
                <telerik:RadButton ID="btnInsertar" runat="server" Text="Guardar" HoveredCssClass="goButtonClassHov"
                    CausesValidation="true" ValidationGroup="FormValidationGroup" OnClick="btnInsertar_Click">
                    <Icon PrimaryIconUrl="~/img/IconSeleccionar.png" PrimaryIconWidth="15px" PrimaryIconHeight="15px"
                        PrimaryIconTop="4px" PrimaryIconLeft="3px" />
                </telerik:RadButton>
                <cc1:ConfirmButtonExtender ID="ConfirmButtonExtender1" runat="server" ConfirmText="Desea grabar?"
                    Enabled="True" TargetControlID="btnInsertar">
                </cc1:ConfirmButtonExtender>
                <%--&nbsp;
                <telerik:RadButton ID="btnCancelar" runat="server" CausesValidation="false" HoveredCssClass="goButtonClassHov"
                    Text="Cancelar">
                    <Icon PrimaryIconUrl="~/img/IconEliminar.png" PrimaryIconWidth="15px" PrimaryIconHeight="15px"
                        PrimaryIconTop="4px" PrimaryIconLeft="3px" />
                </telerik:RadButton>--%>
            </td>
        </tr>
    </table>


