<%@ Page Title="" Language="C#" MasterPageFile="~/MPConectado.Master" AutoEventWireup="true" CodeBehind="wfEntidad.aspx.cs" Inherits="rwebSeguridad.Formularios.wfEntidad" %>
<%@ Register src="../ControlesUsuario/GestionEntidad/CU_Entidad.ascx" tagname="CU_Entidad" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:CU_Entidad ID="CU_Entidad1" runat="server" />
</asp:Content>
