<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CUP_Registro.ascx.cs"
    Inherits="rwebSeguridad.ControlesUsuario.CUP_Registro" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<head>
    <link href="./Estilo/ssEstilo.css" rel="stylesheet" type="text/css" />
</head>
<body class="fondo">
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
    <div align="center">
        <table class="TablaFormulario">
            <tr>
                <td>
                    <label id="Label1" runat="server">
                        <strong>*Código</strong> :</label>
                </td>
                <td>
                    <asp:TextBox ID="txtCodigo" runat="server" Enabled="false" ></asp:TextBox>
                </td>
                <td>
                    <label id="Label2" runat="server">
                        <strong>*Fecha</strong> :</label>
                </td>
                <td>
                    <telerik:RadDatePicker ID="txtFecha" runat="server" TabIndex="3">
                        <DateInput DisplayDateFormat="dd/MM/yyyy" DateFormat="dd/MM/yyyy" LabelWidth="40%"
                            TabIndex="3">
                        </DateInput>
                    </telerik:RadDatePicker>
                </td>
                <td>
                    <telerik:RadButton ID="btnCargar" runat="server" Text="Ver Marcajes" HoveredCssClass="goButtonClassHov"
                        CausesValidation="true" ValidationGroup="FormValidationGroup" OnClick="btnVer_Click1"
                        Style="width: 96px">
                        <Icon PrimaryIconUrl="~/img/IconSeleccionar.png" PrimaryIconWidth="15px" PrimaryIconHeight="15px"
                            PrimaryIconTop="4px" PrimaryIconLeft="3px" />
                    </telerik:RadButton>
                </td>
            </tr>
            <tr>
                <td>
                    <telerik:RadButton ID="btnVolver" runat="server" Text="Volver" HoveredCssClass="goButtonClassHov"
                        CausesValidation="true" ValidationGroup="FormValidationGroup" OnClick="btnVolver_Click1"
                        Style="width: 96px">
                        <Icon PrimaryIconUrl="~/img/IconSeleccionar.png" PrimaryIconWidth="15px" PrimaryIconHeight="15px"
                            PrimaryIconTop="4px" PrimaryIconLeft="3px" />
                    </telerik:RadButton>
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    <asp:CheckBox ID="chkMes" runat="server" Text="[Mes]" OnCheckedChanged="chkMes_CheckedChanged"
                        AutoPostBack="true" />
                </td>
                <td>
                    <telerik:RadComboBox ID="rddlMes" runat="server" Culture="es-ES" Width="200px"  AutoPostBack="true"
                        Enabled="false" onselectedindexchanged="rddlMes_SelectedIndexChanged">
                        <Items>
                            <telerik:RadComboBoxItem runat="server" Text="ENERO" Value="1" />
                            <telerik:RadComboBoxItem runat="server" Text="FEBRERO" Value="2" />
                            <telerik:RadComboBoxItem runat="server" Text="MARZO" Value="3" />
                            <telerik:RadComboBoxItem runat="server" Text="ABRIL" Value="4" />
                            <telerik:RadComboBoxItem runat="server" Text="MAYO" Value="5" />
                            <telerik:RadComboBoxItem runat="server" Text="JUNIO" Value="6" />
                            <telerik:RadComboBoxItem runat="server" Text="JULIO" Value="7" />
                            <telerik:RadComboBoxItem runat="server" Text="AGOSTO" Value="8" />
                            <telerik:RadComboBoxItem runat="server" Text="SEPTIEMBRE" Value="9" />
                            <telerik:RadComboBoxItem runat="server" Text="OCTUBRE" Value="10" />
                            <telerik:RadComboBoxItem runat="server" Text="NOVIEMBRE" Value="11" />
                            <telerik:RadComboBoxItem runat="server" Text="DICIEMBRE" Value="12" />
                        </Items>
                    </telerik:RadComboBox>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    Año</td>
                <td>
                    <telerik:RadComboBox ID="rddlAnio" runat="server" Culture="es-ES" 
                        Width="200px"  AutoPostBack="True"
                        Enabled="False" onselectedindexchanged="rddlMes_SelectedIndexChanged">
                        <Items>
                            <telerik:RadComboBoxItem runat="server"  Owner="rddlAnio" Text="2023" Value="2023" />
                            <telerik:RadComboBoxItem runat="server" Text="2022" Value="2022" />
                            <telerik:RadComboBoxItem runat="server" Text="2021" Value="2021" />
                        </Items>
                    </telerik:RadComboBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="5">
                    <asp:Label ID="lblMensaje" Font-Bold="True" runat="server" Font-Names="Courier New"
                        Font-Italic="True" Font-Size="Small">Detalle </asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="5">
                    <telerik:RadGrid ID="gvLecturaReloj" runat="server" AllowFilteringByColumn="true"
                        AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CssClass="RadGrid"
                        GridLines="None" OnNeedDataSource="RGVFormulario_NeedDataSource" PageSize="31"
                        ShowStatusBar="true" OnDetailTableDataBind="gvLecturaReloj_DetailTableDataBind">
                        <PagerStyle Mode="NextPrevAndNumeric" />
                        <GroupingSettings CaseSensitive="False" />
                        <MasterTableView TableLayout="Auto" Width="100%" DataKeyNames="Fecha" >
                            <CommandItemSettings ExportToPdfText="Export to PDF" RefreshText="Actualizar" />
                            <DetailTables>
                                <telerik:GridTableView DataKeyNames="IdMarcasBSS" Name="Marcas" Width="100%" CommandItemDisplay="None"
                                    runat="server"   AllowFilteringByColumn="false">                                    
                                    <Columns>
                                        <telerik:GridBoundColumn SortExpression="IdMarcasBSS" HeaderText="Nro" HeaderButtonType="TextButton"
                                            DataField="IdMarcasBSS" UniqueName="IdMarcasBSS" ShowFilterIcon="false" Visible="false">
                                        </telerik:GridBoundColumn>                                        
                                        <telerik:GridBoundColumn SortExpression="Hora" HeaderText="Fecha y Hora" HeaderButtonType="TextButton"
                                            DataField="Hora" ShowFilterIcon="false"  AllowFiltering="false">
                                        </telerik:GridBoundColumn>
                                    </Columns>
                                </telerik:GridTableView>
                            </DetailTables>
                            <Columns>
                                <telerik:GridBoundColumn AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                                    DataField="Fecha" HeaderText="Fecha" ShowFilterIcon="false" UniqueName="Fecha" 
                                    DataFormatString="{0:D}">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                                    DataField="HoraIngresoM" HeaderText="Ingreso M" ShowFilterIcon="false" UniqueName="HoraIngresoM"
                                    DataFormatString="{0:HH:mm:ss}">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                                    DataField="HoraSalidaM" HeaderText="Salida M" ShowFilterIcon="false" UniqueName="HoraSalidaM"
                                    DataFormatString="{0:HH:mm:ss}">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                                    DataField="HoraIngresoT" HeaderText="Ingreso T" ShowFilterIcon="false" UniqueName="HoraIngresoT"
                                    DataFormatString="{0:HH:mm:ss}">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                                    DataField="HoraSalidaT" HeaderText="Salida T" ShowFilterIcon="false" UniqueName="HoraSalidaT"
                                    DataFormatString="{0:HH:mm:ss}">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                                    DataField="TotalMinutosAtraso" HeaderText="Minutos de Atraso" ShowFilterIcon="false" UniqueName="TotalMinutosAtraso">
                                </telerik:GridBoundColumn>
                                
                            </Columns>
                        </MasterTableView>
                        <PagerStyle PageSizeControlType="RadComboBox" />
                        <FilterMenu EnableImageSprites="False">
                        </FilterMenu>
                    </telerik:RadGrid>
                </td>
            </tr>
            <tr>
                <td colspan="5">
                    <asp:Label ID="lblMinutosAtraso" Font-Bold="True" runat="server" Font-Names="Courier New"
                        Font-Italic="True" Font-Size="Small">---</asp:Label>
                </td>
            </tr>
        </table>
    </div>
</body>
