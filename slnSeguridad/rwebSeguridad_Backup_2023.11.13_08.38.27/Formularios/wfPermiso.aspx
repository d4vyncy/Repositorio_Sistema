<%@ Page Title="" Language="C#" MasterPageFile="~/MPConectado.Master" AutoEventWireup="true" CodeBehind="wfPermiso.aspx.cs" Inherits="rwebSeguridad.Formularios.wfPermiso" %>
<%@ Register src="../ControlesUsuario/GestionarPermiso/CU_PermisoGestion.ascx" tagname="CU_PermisoGestion" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:CU_PermisoGestion ID="CU_PermisoGestion1" runat="server" />
</asp:Content>
