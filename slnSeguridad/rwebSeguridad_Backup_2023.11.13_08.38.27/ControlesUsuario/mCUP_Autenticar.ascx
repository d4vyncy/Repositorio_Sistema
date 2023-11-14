<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="mCUP_Autenticar.ascx.cs"
    Inherits="rwebSeguridad.ControlesUsuario.mCUP_Autenticar" %>
<style type="text/css">
    .style1
    {
        width: 100%;
    }
    .RadInput_Default
    {
        font: 12px "segoe ui" ,arial,sans-serif;
    }
    .RadInput
    {
        vertical-align: middle;
    }
    .RadInput .riTextBox
    {
        height: 17px;
    }
    .style2
    {
        width: 50%;
    }
</style>
<body background="./Imagenes/fondoM2.png">
    <div>
        <table style="background-position: 100%; background-color: #FCB316; background-repeat: no-repeat;
            background-attachment: fixed; top: 0px; position: absolute; z-index: auto; width: 942px;">
            <td>
                &nbsp;
            </td>
            <td>
            </td>
            <td>
            </td>
        </table>
    </div>
    <div style="text-align: center">
        <asp:Image ID="Image1" runat="server" Height="358px" ImageUrl="~/Imagenes/logoo.png"
            Style="text-align: center" Width="349px" />
    </div>
    <div style="background-position: center; position: relative; top: 50%; background-image: url('./Imagenes/fon10.png');
        background-repeat: no-repeat; background-color: #343638;" align="center">
        <table class="style1">
            <tr>
                <td rowspan="5" align="right" class="style2">
                    <asp:Image ID="Image2" runat="server" Height="289px" ImageUrl="~/Imagenes/user0.png"
                        Style="text-align: center" Width="283px" />
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                </td>
                <td>
                    <telerik:RadTextBox ID="rtxtUsuario" runat="server" EmptyMessage="Usuario" TabIndex="1"
                        ToolTip="Usuario" BorderColor="#ffffff" BorderStyle="Double" BackColor="#ffffff"
                        BorderWidth="2px">
                        <EmptyMessageStyle Resize="None"></EmptyMessageStyle>
                        <ReadOnlyStyle Resize="None"></ReadOnlyStyle>
                        <FocusedStyle Resize="None" BackColor="#FDB714"></FocusedStyle>
                        <DisabledStyle Resize="None"></DisabledStyle>
                        <InvalidStyle Resize="None"></InvalidStyle>
                        <HoveredStyle Resize="None"></HoveredStyle>
                        <EnabledStyle Resize="None"></EnabledStyle>
                    </telerik:RadTextBox>
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                </td>
                <td>
                    <telerik:RadTextBox ID="rtxtContrasenia" runat="server" TextMode="Password" TabIndex="2"
                        ToolTip="Contraseña" BorderColor="#ffffff" BorderStyle="Double" BackColor="#ffffff"
                        BorderWidth="2px" EmptyMessage="********">
                        <EmptyMessageStyle Resize="None" BorderStyle="Double"></EmptyMessageStyle>
                        <ReadOnlyStyle Resize="None"></ReadOnlyStyle>
                        <FocusedStyle Resize="None" BackColor="#FDB714"></FocusedStyle>
                        <DisabledStyle Resize="None"></DisabledStyle>
                        <InvalidStyle Resize="None"></InvalidStyle>
                        <HoveredStyle Resize="None"></HoveredStyle>
                        <EnabledStyle Resize="None"></EnabledStyle>
                    </telerik:RadTextBox>
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                </td>
                <td>
                    <telerik:RadButton ID="btnAutenticar" runat="server" Text="Ingresar" OnClick="btnAutenticar_Click">
                    </telerik:RadButton>
                    <telerik:RadButton ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click">
                    </telerik:RadButton>
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td colspan="4" style="text-align: center">
                    <asp:Label ID="lblMensajeError" runat="server" Text="-" ForeColor="Red"></asp:Label>
                </td>
                <td style="text-align: center">
                    &nbsp;
                </td>
                <td style="text-align: center">
                    &nbsp;
                </td>
                <td style="text-align: center">
                    &nbsp;
                </td>
            </tr>
        </table>
    </div>
</body>
