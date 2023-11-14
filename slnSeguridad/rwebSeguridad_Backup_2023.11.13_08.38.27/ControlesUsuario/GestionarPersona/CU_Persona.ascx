<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CU_Persona.ascx.cs" Inherits="rwebSeguridad.ControlesUsuario.GestionarPersona.CU_Persona" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<div id="GestionPersona"class="CDiv">
<%--<telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
  <script type="text/javascript">
      var popUp;
      function PopUpShowing(sender, eventArgs) {
          popUp = eventArgs.get_popUp();
          var gridWidth = sender.get_element().offsetWidth;
          var gridHeight = sender.get_element().offsetHeight;
          var popUpWidth = popUp.style.width.substr(0, popUp.style.width.indexOf("px"));
          var popUpHeight = popUp.style.height.substr(0, popUp.style.height.indexOf("px"));
          popUp.style.left = ((gridWidth - popUpWidth) / 2 + sender.get_element().offsetLeft).toString() + "px";
          popUp.style.top = ((gridHeight - popUpHeight) / 2 + sender.get_element().offsetTop).toString() + "px";
      }
  </script>
</telerik:RadCodeBlock>--%>
<telerik:RadGrid ID="RGVPersona" runat="server" GridLines="None" AllowPaging="True"
        CssClass="RadGrid" PageSize="14" OnInsertCommand="RGVPersona_InsertCommand"
        AllowFilteringByColumn="true" AllowSorting="True" AutoGenerateColumns="False"
        ShowStatusBar="true" OnUpdateCommand="RGVPersona_UpdateCommand" OnNeedDataSource="RGVPersona_NeedDataSource"
        OnPreRender="RGVPersona_PreRender">
        <PagerStyle Mode="NextPrevAndNumeric" />
        <GroupingSettings CaseSensitive="False"></GroupingSettings>
        <MasterTableView CommandItemDisplay="Top" CommandItemSettings-AddNewRecordText="Nueva Persona"
            CommandItemSettings-RefreshText="Actualizar" DataKeyNames="IdPersona" TableLayout="Fixed" Width="100%"
            CommandItemSettings-ExportToPdfText="Export to PDF">
            <CommandItemSettings RefreshText="Actualizar" ExportToPdfText="Export to PDF"></CommandItemSettings>
            <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
            </RowIndicatorColumn>
            <Columns>
                
                <telerik:GridBoundColumn CurrentFilterFunction="Contains" DataField="IdPersona" HeaderText="ID"
                    AllowFiltering="false" ShowFilterIcon="false" UniqueName="IdPersona" Display="false">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                    DataField="NombrePersona" HeaderText="Nombre Completo" ShowFilterIcon="false" UniqueName="NombrePersona">
                    
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                    DataField="CI" HeaderText="Cédula de Identidad" ShowFilterIcon="false" UniqueName="CI" >
                </telerik:GridBoundColumn>                
                <telerik:GridBoundColumn AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                    DataField="Celular" HeaderText="Celular" ShowFilterIcon="false" UniqueName="Celular">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn AutoPostBackOnFilter="true" CurrentFilterFunction="Contains"
                    DataField="CorreoElectronico" HeaderText="Correo Electrónico" ShowFilterIcon="false" UniqueName="CorreoElectronico">
                    
                </telerik:GridBoundColumn>
                <telerik:GridEditCommandColumn UniqueName="EditCommandColumn" EditText="  «Editar»  "
                    HeaderStyle-Width="60" ItemStyle-VerticalAlign="NotSet">
                    
                </telerik:GridEditCommandColumn>
            </Columns>
            <EditFormSettings UserControlName="../ControlesUsuario//GestionarPersona//CU_PersonaGestion.ascx" 
                EditFormType="webUserControl"  >
               
                <EditColumn UniqueName="EditCommandColumn1">
                </EditColumn>
            </EditFormSettings>
        </MasterTableView>
        <%--<ClientSettings>
            <ClientEvents OnPopUpShowing="PopUpShowing" />
            <Selecting AllowRowSelect="true" />
        </ClientSettings>--%>
        <FilterMenu EnableImageSprites="False">
        </FilterMenu>
        <HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default">
        </HeaderContextMenu>
    </telerik:RadGrid>
</div>
