<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fwfAutenticar.aspx.cs" Inherits="rwebSeguridad.forms.fwfAutenticar" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Autenticar</title>
    <link href="../Imagenes/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <link href="../ControlUser/CUW_Autenticar.css" rel="stylesheet" />

</head>
<body style="background-image: url('../Imagenes/img/cropped-1366-768-329050.jpg')">
    <form id="form1" runat="server">
        <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
            <Scripts>
                <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.Core.js" />
                <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQuery.js" />
                <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQueryInclude.js" />
            </Scripts>
        </telerik:RadScriptManager>
        <div class="panel-img">
            <img src="../Imagenes/img/Panel.png" />
        </div>
        <div>
            <div style="position: absolute; z-index: 1;" id="layer1">
                <div class="modal-body" style="margin: 30px 0px 0px 400px;">
                    <div class="row">
                        <div class="col-xs-12">
                            <div class="form-group">
                                <div class="input-group has-validation">
                                    <span class="input-group-text">@</span>
                                    <div class="form-floating is-invalid">
                                        <input type="text" class="form-control is-invalid" id="rtxtUsuario" placeholder="Usuario" runat="server" required>
                                        <label for="rtxtUsuario">Usuario</label>
                                    </div>
                                    <div class="invalid-feedback">
                                        Ingrese su nombre de usuario.
                                    </div>
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="input-group has-validation">
                                    <span class="input-group-text">*</span>
                                    <div class="form-floating is-invalid">
                                        <input type="text" class="form-control is-invalid" id="rtxtContrasenia" placeholder="Contraseña"  runat="server" required>
                                        <label for="rtxtContrasenia">Contraseña</label>
                                    </div>
                                    <div class="invalid-feedback">
                                        Ingrese su contraseña.
                                    </div>
                                </div>
                            </div>
                            <%--<button type="submit" class="btn btn-success btn-block" onclick="btnAutenticar_Click" runat="server">
                                Ingresar
                            </button>--%>
                        
                            <asp:Button class="btn btn-success btn-block" id="btnLogout"  runat="server" Text="Ingrsar" OnClick="btnAutenticar_Click"></asp:Button>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </form>
    <script src="../Imagenes/bootstrap/js/bootstrap.min.js"></script>
</body>
</html>
