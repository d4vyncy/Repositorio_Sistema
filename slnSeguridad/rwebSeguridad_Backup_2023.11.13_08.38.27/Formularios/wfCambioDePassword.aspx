<%@ Page Title="" Language="C#" MasterPageFile="~/MPConectado.Master" AutoEventWireup="true" CodeBehind="wfCambioDePassword.aspx.cs" Inherits="rwebSeguridad.Formularios.wfCambioDePassword" %>
<%@ Register src="../ControlesUsuario/GestionarUsuario/CU_UsuarioPassword.ascx" tagname="CU_UsuarioPassword" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:CU_UsuarioPassword ID="CU_UsuarioPassword1" runat="server" />
</asp:Content>
