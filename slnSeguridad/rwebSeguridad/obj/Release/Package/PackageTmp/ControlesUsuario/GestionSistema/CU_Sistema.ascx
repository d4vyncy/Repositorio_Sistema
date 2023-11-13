<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CU_Sistema.ascx.cs" Inherits="rwebSeguridad.ControlesUsuario.GestionSistema.CU_Sistema" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>

<div id="GestionObjetivo" class="CDiv">
    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" runat="server" />
    <telerik:RadGrid ID="RGVSistema" runat="server" GridLines="None" AllowPaging="True"
        CssClass="RadGrid" PageSize="14" OnInsertCommand="RGVSistema_InsertCommand"
        AllowFilteringByColumn="True" AllowSorting="True" AutoGenerateColumns="False"
        ShowStatusBar="True" OnUpdateCommand="RGVSistema_UpdateCommand" OnNeedDataSource="RGVSistema_NeedDataSource"
        OnPreRender="RGVSistema_PreRender" CellSpacing="0" Culture="es-ES">
        <PagerStyle Mode="NextPrevAndNumeric" />
        <GroupingSettings CaseSensitive="False"></GroupingSettings>

<ExportSettings>
<Pdf>
<PageHeader>
<LeftCell Text=""></LeftCell>

<MiddleCell Text=""></MiddleCell>

<RightCell Text=""></RightCell>
</PageHeader>

<PageFooter>
<LeftCell Text=""></LeftCell>

<MiddleCell Text=""></MiddleCell>

<RightCell Text=""></RightCell>
</PageFooter>
</Pdf>
</ExportSettings>

        <MasterTableView CommandItemDisplay="Top" CommandItemSettings-AddNewRecordText="Nuevo Sistema"
            CommandItemSettings-RefreshText="Actualizar" DataKeyNames="IdSistema" TableLayout="Fixed"
            Width="100%" CommandItemSettings-ExportToPdfText="Export to PDF">
            <CommandItemSettings RefreshText="Actualizar" ExportToPdfText="Export to PDF"></CommandItemSettings>
            <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
            </RowIndicatorColumn>

<ExpandCollapseColumn Visible="True" FilterControlAltText="Filter ExpandColumn column"></ExpandCollapseColumn>
            <Columns>
                <telerik:GridButtonColumn Text="&gt;&gt;" CommandName="Select" />
                <telerik:GridBoundColumn CurrentFilterFunction="Contains" DataField="NombreSistema"
                    HeaderText="Nombre Sistema" AllowFiltering="false" ShowFilterIcon="false" 
                    UniqueName="NombreSistema" FilterControlAltText="Filter NombreSistema column">
                    <HeaderStyle Width="90px"></HeaderStyle>
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                    DataField="IpServer" HeaderText="IpServer" ShowFilterIcon="false" 
                    UniqueName="IpServer" FilterControlAltText="Filter IpServer column">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="HostNameServer" 
                    FilterControlAltText="Filter HostNameServer column" HeaderText="HostNameServer" 
                    UniqueName="HostNameServer">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="Direccion Url" 
                    FilterControlAltText="Filter Url column" HeaderText="Url" 
                    UniqueName="Url">
                </telerik:GridBoundColumn>

                <telerik:GridBoundColumn DataField="Detalle" 
                    FilterControlAltText="Filter Detalle column" HeaderText="Detalle" 
                    UniqueName="Detalle">
                </telerik:GridBoundColumn>
                <telerik:GridEditCommandColumn UniqueName="EditCommandColumn" EditText="«Editar»"
                    HeaderStyle-Width="60">
                    <HeaderStyle Width="60px"></HeaderStyle>
                </telerik:GridEditCommandColumn>
            </Columns>
            <EditFormSettings UserControlName="../ControlesUsuario//GestionSistema//CU_SistemaGestion.ascx"
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

