<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="mCU_Acceder.ascx.cs"
    Inherits="rwebSeguridad.ControlesUsuario.mCU_Acceder" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<%@ Register Src="GestionarUsuario/CU_UsuarioPassword.ascx" TagName="CU_UsuarioPassword"
    TagPrefix="uc1" %>
<head>
    <link href="./Estilo/ssEstilo.css" rel="stylesheet" type="text/css" />
</head>
<body class="fondo">
    <div id="GestionarAcceder" class="CDiv" align="center">
        <label id="lblCertificacion" runat="server" style="background-color: #C0C0C0">
            <strong>Seleccione el rol de ingreso al sistema</strong> :</label>
        <br />
        <telerik:RadGrid ID="RGVAcceder" runat="server" GridLines="None" AllowPaging="True"
            CssClass="RadGrid" PageSize="10" AllowSorting="True" AutoGenerateColumns="False"
            ShowStatusBar="true" Width="50%">
            <PagerStyle Mode="NextPrevAndNumeric" />
            <GroupingSettings CaseSensitive="False"></GroupingSettings>
            <GroupingSettings CaseSensitive="false" />
            <ClientSettings EnableRowHoverStyle="true">
            </ClientSettings>
            <MasterTableView DataKeyNames="IdRolUsuario" Width="100%">
                <CommandItemSettings RefreshText="Actualizar"></CommandItemSettings>
                <Columns>
                    <telerik:GridButtonColumn Text="Seleccionar" CommandName="Select">
                    </telerik:GridButtonColumn>
                    <telerik:GridBoundColumn CurrentFilterFunction="Contains" DataField="IdRol" HeaderText="#"
                        AllowFiltering="false" ShowFilterIcon="false" UniqueName="IdRol" Display="false">
                        <HeaderStyle Width="45px"></HeaderStyle>
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                        DataField="NombreSistema" HeaderText="Sistema" ShowFilterIcon="false" UniqueName="NombreSistema">
                        <HeaderStyle Width="180px"></HeaderStyle>
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                        DataField="NombreRol" HeaderText="Rol" ShowFilterIcon="false" UniqueName="NombreRol">
                        <HeaderStyle Width="180px"></HeaderStyle>
                    </telerik:GridBoundColumn>
                </Columns>
            </MasterTableView>
            <FilterMenu EnableImageSprites="False">
            </FilterMenu>
            <HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default">
            </HeaderContextMenu>
        </telerik:RadGrid>
    </div>
    <table align="center">
        <tr>
            <td>
                <label id="rlblEstilo" runat="server">
                    Estilo:</label>
            </td>
            <td>
                <telerik:RadComboBox ID="rddlEstilo" runat="server" Culture="es-ES" Width="200px"
                    OnSelectedIndexChanged="rddlEstilo_SelectedIndexChanged" AutoPostBack="true">
                    <Items>
                    </Items>
                </telerik:RadComboBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblMensaje" runat="server" Text="---" ForeColor="Red"></asp:Label></td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center">
                <telerik:RadButton ID="btnInsertar" runat="server" Text="Ingresar" HoveredCssClass="goButtonClassHov"
                    CausesValidation="true" ValidationGroup="FormValidationGroup" OnClick="btnInsertar_Click"
                    Style="width: 96px">
                    <Icon PrimaryIconUrl="~/img/IconSeleccionar.png" PrimaryIconWidth="15px" PrimaryIconHeight="15px"
                        PrimaryIconTop="4px" PrimaryIconLeft="3px" />
                </telerik:RadButton>
                &nbsp;
                <telerik:RadButton ID="btnCancelar" runat="server" CausesValidation="false" HoveredCssClass="goButtonClassHov"
                    Text="Cancelar" OnClick="btnCancelar_Click">
                    <Icon PrimaryIconUrl="~/img/IconEliminar.png" PrimaryIconWidth="15px" PrimaryIconHeight="15px"
                        PrimaryIconTop="4px" PrimaryIconLeft="3px" />
                </telerik:RadButton>
            &nbsp;
                <telerik:RadButton ID="btnVerMarcajes" runat="server" Text="Ver Asistencia" HoveredCssClass="goButtonClassHov"
                    CausesValidation="true" ValidationGroup="FormValidationGroup" OnClick="btnVerMarcajes_Click" >
                    <Icon PrimaryIconUrl="~/img/IconSeleccionar.png" PrimaryIconWidth="15px" PrimaryIconHeight="15px"
                        PrimaryIconTop="4px" PrimaryIconLeft="3px" />
                </telerik:RadButton>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <uc1:CU_UsuarioPassword ID="CU_UsuarioPassword1" runat="server" />
            </td>
        </tr>
    </table>
    <div align="center">
        <table>
            <tr>
                <td>
                    <label id="lblIP" runat="server" visible="False">
                        IP:</label>
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
                    <label id="lblHostname" runat="server" visible="False">
                        Hostname:</label>
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
                    <label id="lblOtro" runat="server" visible="False">
                        Hostname:</label>
                </td>
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
        </table>
    </div>
</body>
