<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CU_Rol.ascx.cs" Inherits="rwebSeguridad.ControlesUsuario.GestionarRol.CU_Rol" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<div id="GestionRol">

<telerik:RadGrid ID="RGVRol" runat="server" GridLines="None" AllowPaging="True"
        CssClass="RadGrid" PageSize="14" OnInsertCommand="RGVRol_InsertCommand"
        AllowFilteringByColumn="true" AllowSorting="True" AutoGenerateColumns="False"
        ShowStatusBar="true" OnUpdateCommand="RGVRol_UpdateCommand" OnNeedDataSource="RGVRol_NeedDataSource"
        OnPreRender="RGVRol_PreRender"  >
        <PagerStyle Mode="NextPrevAndNumeric" />
        <GroupingSettings CaseSensitive="False"></GroupingSettings>
        <MasterTableView CommandItemDisplay="Top" CommandItemSettings-AddNewRecordText="Nuevo Rol"
            CommandItemSettings-RefreshText="Actualizar" DataKeyNames="IdRol" TableLayout="Fixed" Width="100%"
            CommandItemSettings-ExportToPdfText="Export to PDF">
            <CommandItemSettings RefreshText="Actualizar" ExportToPdfText="Export to PDF"></CommandItemSettings>
            <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
            </RowIndicatorColumn>
            <Columns>
                
                <telerik:GridBoundColumn CurrentFilterFunction="Contains" DataField="IdRol" HeaderText="ID"
                    AllowFiltering="false" ShowFilterIcon="false" UniqueName="IdRol" Visible="false">
                    <HeaderStyle Width="90px"></HeaderStyle>
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn AutoPostBackOnFilter="true" CurrentFilterFunction="Contains" 
                    DataField="NombreRol" HeaderText="Rol" ShowFilterIcon="false" UniqueName="NombreRol">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                    DataField="NombreSistema" HeaderText="Sistema" ShowFilterIcon="false" UniqueName="NombreSistema">
                </telerik:GridBoundColumn>
                <telerik:GridEditCommandColumn UniqueName="EditCommandColumn" EditText="«Editar»"
                    HeaderStyle-Width="60">
                    <HeaderStyle Width="60px"></HeaderStyle>
                </telerik:GridEditCommandColumn>
            </Columns>
            <EditFormSettings UserControlName="../ControlesUsuario//GestionarRol//CU_RolGestion.ascx"
                EditFormType="webUserControl">
                <EditColumn UniqueName="EditCommandColumn1">
                </EditColumn>
            </EditFormSettings>
        </MasterTableView>
        <FilterMenu EnableImageSprites="False">
        </FilterMenu>
        <HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default">
        </HeaderContextMenu>
    </telerik:RadGrid>
</div>
