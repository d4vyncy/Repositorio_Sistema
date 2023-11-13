<%@ Page Title="" Language="C#" MasterPageFile="~/MPConectado.Master" AutoEventWireup="true" CodeBehind="wfSistema.aspx.cs" Inherits="rwebSeguridad.Formularios.wfSistema" %>
<%@ Register src="../ControlesUsuario/GestionSistema/CU_Sistema.ascx" tagname="CU_Sistema" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:CU_Sistema ID="CU_Sistema1" runat="server" />
</asp:Content>
