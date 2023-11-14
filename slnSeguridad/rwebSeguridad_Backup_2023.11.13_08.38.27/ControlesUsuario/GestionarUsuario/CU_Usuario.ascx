<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CU_Usuario.ascx.cs" Inherits="rwebSeguridad.ControlesUsuario.GestionarUsuario.CU_Usuario" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<div id="GestionUsuario" class="CDiv">
    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" runat="server" />
    <telerik:RadGrid ID="RGVUsuario" runat="server" GridLines="None" AllowPaging="True"
        CssClass="RadGrid" PageSize="14" OnInsertCommand="RGVUsuario_InsertCommand" AllowFilteringByColumn="true"
        AllowSorting="True" AutoGenerateColumns="False" ShowStatusBar="true" OnUpdateCommand="RGVUsuario_UpdateCommand" 
        OnNeedDataSource="RGVUsuario_NeedDataSource" OnPreRender="RGVUsuario_PreRender">
        <pagerstyle mode="NextPrevAndNumeric" />
        <groupingsettings casesensitive="False"></groupingsettings>
        <mastertableview commanditemdisplay="Top" commanditemsettings-addnewrecordtext="Nuevo Usuario"
            commanditemsettings-refreshtext="Actualizar" datakeynames="IdUsuario" tablelayout="Fixed"
            width="100%" commanditemsettings-exporttopdftext="Export to PDF">
            <CommandItemSettings RefreshText="Actualizar" ExportToPdfText="Export to PDF"></CommandItemSettings>
            <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
            </RowIndicatorColumn>
            <Columns>
                
                <telerik:GridBoundColumn CurrentFilterFunction="Contains" DataField="IdUsuario" HeaderText="ID"
                    AllowFiltering="false" ShowFilterIcon="false" UniqueName="IdUsuario" Display="false">
                    <HeaderStyle Width="90px"></HeaderStyle>
                </telerik:GridBoundColumn>                
                <telerik:GridBoundColumn AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                    DataField="NombreUsuario" HeaderText="Usuario" ShowFilterIcon="false" UniqueName="NombreUsuario">
                    <HeaderStyle Width="50%"></HeaderStyle>                            
                </telerik:GridBoundColumn>                
                <telerik:GridBoundColumn AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                    DataField="NombreTipoUsuario" HeaderText="Tipo de Usuario" ShowFilterIcon="false" UniqueName="NombreTipoUsuario">
                    <HeaderStyle Width="25%"></HeaderStyle>                            
                </telerik:GridBoundColumn>
                <telerik:GridEditCommandColumn UniqueName="EditCommandColumn" EditText="«Editar»"
                    HeaderStyle-Width="60">
                    <HeaderStyle Width="60px"></HeaderStyle>
                </telerik:GridEditCommandColumn>
            </Columns>
            <EditFormSettings UserControlName="../ControlesUsuario//GestionarUsuario//CU_UsuarioGestion.ascx" 
                EditFormType="webUserControl">
                <EditColumn UniqueName="EditCommandColumn1">
                </EditColumn>
            </EditFormSettings>

        </mastertableview>
        <filtermenu enableimagesprites="False">
        </filtermenu>
        <headercontextmenu cssclass="GridContextMenu GridContextMenu_Default">
        </headercontextmenu>
    </telerik:RadGrid>
</div>