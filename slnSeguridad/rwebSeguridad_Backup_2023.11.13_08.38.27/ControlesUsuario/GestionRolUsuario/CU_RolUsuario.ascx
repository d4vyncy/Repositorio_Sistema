<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CU_RolUsuario.ascx.cs"
    Inherits="rwebSeguridad.ControlesUsuario.GestionRolUsuario.CU_RolUsuario" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<div id="GestionObjetivo" class="CDiv">
    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" runat="server" />
    <telerik:RadGrid ID="RGVRolUsuario" runat="server" GridLines="None" AllowPaging="True"
        CssClass="RadGrid" PageSize="14" OnInsertCommand="RGVRolUsuario_InsertCommand"
        AllowFilteringByColumn="True" AllowSorting="True" AutoGenerateColumns="False"
        ShowStatusBar="True" OnUpdateCommand="RGVRolUsuario_UpdateCommand" OnNeedDataSource="RGVRolUsuario_NeedDataSource"
        OnPreRender="RGVRolUsuario_PreRender" CellSpacing="0" Culture="es-ES">
        <PagerStyle Mode="NextPrevAndNumeric" />
        <GroupingSettings CaseSensitive="False"></GroupingSettings>
        <MasterTableView CommandItemDisplay="Top" CommandItemSettings-AddNewRecordText="Asignar Rol a Usuario"
            CommandItemSettings-RefreshText="Actualizar" DataKeyNames="IdRolUsuario" TableLayout="Fixed"
            Width="100%" CommandItemSettings-ExportToPdfText="Export to PDF" display="false">
            <CommandItemSettings RefreshText="Actualizar" ExportToPdfText="Export to PDF"></CommandItemSettings>
            <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
            </RowIndicatorColumn>
            <ExpandCollapseColumn Visible="True" FilterControlAltText="Filter ExpandColumn column">
            </ExpandCollapseColumn>
            <Columns>
                <telerik:GridBoundColumn AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                    DataField="NombreSistema" HeaderText="Sistema" ShowFilterIcon="false" UniqueName="NombreSistema"
                    FilterControlAltText="Filter NombreSistema column">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                    DataField="NombreRol" HeaderText="Rol" ShowFilterIcon="false" UniqueName="NombreRol"
                    FilterControlAltText="Filter NombreRol column">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                    DataField="NombreUsuario" HeaderText="Usuario" ShowFilterIcon="false" UniqueName="NombreUsuario"
                    FilterControlAltText="Filter NombreUsuario column">
                </telerik:GridBoundColumn>
                <telerik:GridEditCommandColumn UniqueName="EditCommandColumn" EditText="«Editar»"
                    HeaderStyle-Width="60">
                    <HeaderStyle Width="60px"></HeaderStyle>
                </telerik:GridEditCommandColumn>
            </Columns>
            <EditFormSettings UserControlName="../ControlesUsuario//GestionRolUsuario//CU_RolUsuarioGestion.ascx"
                EditFormType="webUserControl">
                <EditColumn UniqueName="EditCommandColumn1">
                </EditColumn>
            </EditFormSettings>
            <BatchEditingSettings EditType="Cell"></BatchEditingSettings>
            <PagerStyle PageSizeControlType="RadComboBox"></PagerStyle>
        </MasterTableView>
        <PagerStyle PageSizeControlType="RadComboBox"></PagerStyle>
        <FilterMenu EnableImageSprites="False">
        </FilterMenu>
    </telerik:RadGrid>
</div>
