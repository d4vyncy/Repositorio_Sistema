<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CU_Entidad.ascx.cs" Inherits="rwebSeguridad.ControlesUsuario.GestionEntidad.CU_Entidad" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>

<div id="GestionEntidad" class="CDiv">
    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" runat="server" />
    <telerik:RadGrid ID="RGVEntidad" runat="server" GridLines="None" AllowPaging="True"
        CssClass="RadGrid" PageSize="14" OnInsertCommand="RGVEntidad_InsertCommand"
        AllowFilteringByColumn="True" AllowSorting="True" AutoGenerateColumns="False"
        ShowStatusBar="True" OnUpdateCommand="RGVEntidad_UpdateCommand" OnNeedDataSource="RGVEntidad_NeedDataSource"
        OnPreRender="RGVEntidad_PreRender" CellSpacing="0" Culture="es-ES">
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

        <MasterTableView CommandItemDisplay="Top" CommandItemSettings-AddNewRecordText="Nuevo Entidad"
            CommandItemSettings-RefreshText="Actualizar" DataKeyNames="IdEntidad" TableLayout="Fixed"
            Width="100%" CommandItemSettings-ExportToPdfText="Export to PDF">
            <CommandItemSettings RefreshText="Actualizar" ExportToPdfText="Export to PDF"></CommandItemSettings>
            <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
            </RowIndicatorColumn>

<ExpandCollapseColumn Visible="True" FilterControlAltText="Filter ExpandColumn column"></ExpandCollapseColumn>
            <Columns>
                <telerik:GridButtonColumn Text="&gt;&gt;" CommandName="Select" />
                <telerik:GridBoundColumn CurrentFilterFunction="Contains" DataField="EntidadPadre"
                    HeaderText="Entidad Procedente" AllowFiltering="false" ShowFilterIcon="false" 
                    UniqueName="EntidadPadre" FilterControlAltText="Filter IdEntidadPadre column">
                    <HeaderStyle Width="90px"></HeaderStyle>
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                    DataField="NombreDepartamento" HeaderText="Departamento" ShowFilterIcon="false" 
                    UniqueName="NombreDepartamento" FilterControlAltText="Filter IdDepartamento column">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="NombreEntidad" 
                    FilterControlAltText="Filter NombreEntidad column" HeaderText="Nombre Entidad" 
                    UniqueName="NombreEntidad">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="NombreTipoEntidad" 
                    FilterControlAltText="Filter Url column" HeaderText="Tipo Entidad" 
                    UniqueName="NombreTipoEntidad">
                </telerik:GridBoundColumn>

                <%--<telerik:GridBoundColumn DataField="Imagen" 
                    FilterControlAltText="Filter Imagen column" HeaderText="Imagen" 
                    UniqueName="Imagen">
                </telerik:GridBoundColumn>--%>
                <telerik:GridEditCommandColumn UniqueName="EditCommandColumn" EditText="«Editar»"
                    HeaderStyle-Width="60">
                    <HeaderStyle Width="60px"></HeaderStyle>
                </telerik:GridEditCommandColumn>
            </Columns>
            <EditFormSettings UserControlName="../ControlesUsuario//GestionEntidad//CU_EntidadGestion.ascx"
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


