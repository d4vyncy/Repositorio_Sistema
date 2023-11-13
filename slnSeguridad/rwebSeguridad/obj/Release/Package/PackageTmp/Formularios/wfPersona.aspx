<%@ Page Title="" Language="C#" MasterPageFile="~/MPConectado.Master" AutoEventWireup="true" CodeBehind="wfPersona.aspx.cs" Inherits="rwebSeguridad.Formularios.wfPersona" %>
<%@ Register src="../ControlesUsuario/GestionarPersona/CU_Persona.ascx" tagname="CU_Persona" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:CU_Persona ID="CU_Persona1" runat="server" />
</asp:Content>
