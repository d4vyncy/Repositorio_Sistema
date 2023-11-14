<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CUP_ReporteLlamada.ascx.cs"
    Inherits="rwebSeguridad.ControlesUsuario.CUP_ReporteLlamada" %>
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
                    <asp:TextBox ID="txtCodigo" runat="server" Enabled="false"></asp:TextBox>
                </td>
                <td>
                    <label id="Label2" runat="server">
                        <strong>*Mes</strong> :</label>
                </td>
                <td>
                    <telerik:RadComboBox ID="rddlMes" runat="server" Culture="es-ES" Width="200px" AutoPostBack="true"
                        OnSelectedIndexChanged="rddlMes_SelectedIndexChanged">
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
                    <telerik:RadButton ID="btnCargar" runat="server" Text="Ver Llamadas" HoveredCssClass="goButtonClassHov"
                        CausesValidation="true" ValidationGroup="FormValidationGroup" OnClick="btnVer_Click1"
                        Style="width: 96px">
                        <Icon PrimaryIconUrl="~/img/IconSeleccionar.png" PrimaryIconWidth="15px" PrimaryIconHeight="15px"
                            PrimaryIconTop="4px" PrimaryIconLeft="3px" />
                    </telerik:RadButton>
                </td>
            </tr>
            <tr>
                <td>
                    <label id="Label3" runat="server">
                        <strong>*Telefono</strong>:</label>
                </td>
                <td>
                    <asp:TextBox ID="txtOrigen" runat="server" Enabled="false"></asp:TextBox>
                </td>
                <td>
                    Año
                </td>
                <td>
                    <telerik:RadComboBox ID="rddlAnio" runat="server" Culture="es-ES" Width="200px" AutoPostBack="True"
                        OnSelectedIndexChanged="rddlMes_SelectedIndexChanged">
                        <Items>
                            <telerik:RadComboBoxItem runat="server" Text="2018" Value="2018" Owner="rddlAnio" />
                            <telerik:RadComboBoxItem runat="server" Text="2017" Value="2017" />
                        </Items>
                    </telerik:RadComboBox>
                </td>
                <td>
                    &nbsp;
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
                        ShowStatusBar="true" 
                        OnDetailTableDataBind="gvLecturaReloj_DetailTableDataBind" 
                        onupdatecommand="gvLecturaReloj_UpdateCommand">
                        <PagerStyle Mode="NextPrevAndNumeric" />
                        <GroupingSettings CaseSensitive="False" />
                        <MasterTableView TableLayout="Auto" Width="100%" DataKeyNames="IdReporteLlamada">
                            <CommandItemSettings ExportToPdfText="Export to PDF" RefreshText="Actualizar" />
                            <DetailTables>
                                <telerik:GridTableView DataKeyNames="IdReporteLlamada" Name="IdReporteLlamada" Width="100%" CommandItemDisplay="None"
                                    runat="server" AllowFilteringByColumn="false">
                                    <Columns>
                                        <telerik:GridBoundColumn SortExpression="Dia" HeaderText="Día" HeaderButtonType="TextButton"
                                            DataField="Dia" UniqueName="InicioLlamada" ShowFilterIcon="false" DataFormatString="{0:D}">
                                        </telerik:GridBoundColumn >                                        
                                        <telerik:GridBoundColumn SortExpression="InicioLlamada" HeaderText="Inicio Llamada" HeaderButtonType="TextButton"
                                            DataField="InicioLlamada" UniqueName="InicioLlamada" ShowFilterIcon="false" DataFormatString="{0:HH:mm:ss}">
                                        </telerik:GridBoundColumn>  
                                        <telerik:GridBoundColumn SortExpression="FinLlamada" HeaderText="Fin Llamada" HeaderButtonType="TextButton"
                                            DataField="FinLlamada" ShowFilterIcon="false"  AllowFiltering="false" DataFormatString="{0:HH:mm:ss}">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn SortExpression="DuracionSegundos" HeaderText="Segundos"
                                            HeaderButtonType="TextButton" DataField="DuracionSegundos" ShowFilterIcon="false"
                                            AllowFiltering="false">
                                        </telerik:GridBoundColumn>
                                    </Columns>
                                </telerik:GridTableView>
                            </DetailTables>
                            <Columns>
                                <telerik:GridBoundColumn AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                                    DataField="IdReporteLlamada" HeaderText="IdReporteLlamada" ShowFilterIcon="false" UniqueName="IdReporteLlamada" Visible="false">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                                    DataField="Destino" HeaderText="Destino" ShowFilterIcon="false" UniqueName="Destino">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                                    DataField="Cantidad" HeaderText="Cantidad" ShowFilterIcon="false" UniqueName="Cantidad">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                                    DataField="DuracionMinutos" HeaderText="Total Minutos" ShowFilterIcon="false"
                                    UniqueName="DuracionMinutos">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                                    DataField="DuracionSegundos" HeaderText="Total Segundos" ShowFilterIcon="false"
                                    UniqueName="DuracionSegundos">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                                    DataField="CostoSegundo" HeaderText="CostoSegundo" ShowFilterIcon="false" UniqueName="CostoSegundo">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                                    DataField="CostoTotal" HeaderText="CostoTotal" ShowFilterIcon="false" UniqueName="CostoTotal">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                                    DataField="Propiedad" HeaderText="Propiedad" ShowFilterIcon="false" UniqueName="Propiedad">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                                    DataField="Asunto" HeaderText="Asunto" ShowFilterIcon="false" UniqueName="Asunto">
                                </telerik:GridBoundColumn>
                                <telerik:GridEditCommandColumn UniqueName="EditCommandColumn" EditText="«Registrar»"
                                    HeaderStyle-Width="60">
                                    <HeaderStyle Width="60px"></HeaderStyle>
                                </telerik:GridEditCommandColumn>
                            </Columns>
                            <EditFormSettings UserControlName="../ControlesUsuario//CUP_ReporteLlamadaGestion.ascx"
                                EditFormType="webUserControl">
                                <EditColumn UniqueName="EditCommandColumn1">
                                </EditColumn>
                            </EditFormSettings>
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
