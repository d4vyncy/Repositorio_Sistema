<%@ Page Title="" Language="C#" MasterPageFile="~/MPConectado.Master" AutoEventWireup="true" CodeBehind="wfRol.aspx.cs" Inherits="rwebSeguridad.Formularios.wfRol" %>
<%@ Register src="../ControlesUsuario/GestionarRol/CU_Rol.ascx" tagname="CU_Rol" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:CU_Rol ID="CU_Rol1" runat="server" />
</asp:Content>
