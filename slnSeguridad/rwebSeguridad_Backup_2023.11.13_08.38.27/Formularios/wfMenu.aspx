<%@ Page Title="" Language="C#" MasterPageFile="~/MPConectado.Master" AutoEventWireup="true" CodeBehind="wfMenu.aspx.cs" Inherits="rwebSeguridad.Formularios.wfMenu" %>
<%@ Register src="../ControlesUsuario/GestionarMenu/CU_Menu.ascx" tagname="CU_Menu" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:CU_Menu ID="CU_Menu1" runat="server" />
</asp:Content>
