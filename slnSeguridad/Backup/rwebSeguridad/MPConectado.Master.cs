using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using rwebSeguridad.srSeguridad;
using System.Data;
using System.Collections;
using Telerik.Web.UI;

namespace rwebSeguridad
{
    public partial class MPConectado : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Usuario"] == null)
                {
                    try
                    {
                        string IdUsuarioLogueado = "";
                        string Llave = "";
                        //Codigo para comentar
                        IdUsuarioLogueado = "700000654";
                        Llave = "DBA6DB06630FA3C4B46B8B97851AE11B87D853CA";

                        //Codigo
                        rwebSeguridad.srSeguridad.Service1Client oSeguridad = new Service1Client();
                        Llave = base.Request["Llave"].ToString();
                        IdUsuarioLogueado = base.Request["IdUsuarioLogueado"].ToString();

                        if (oSeguridad.ObtienepavUsuarioLogueado2("LLlave", Llave, "NIdEstadoLlave", "1").Tables[0].Rows.Count == 1)
                        {
                            clsUsuarioLogueado oUsuarioLogueado = oSeguridad.ObtieneUsuarioLogueado(Convert.ToInt32(IdUsuarioLogueado));
                            clsUsuario oUsuario = oSeguridad.ObtieneUsuario(oUsuarioLogueado.IdUsuario);
                            clsRolUsuario oRolUsuario = oSeguridad.ObtieneRolUsuario(oUsuarioLogueado.IdRolUsuario);
                            clsRol oRol = oSeguridad.ObtieneRol(oRolUsuario.IdRol);
                            Session.Add("UsuarioLogueado", oUsuarioLogueado);
                            Session.Add("Usuario", oUsuario);
                            Session.Add("RolUsuario", oRolUsuario);
                            Session.Add("Rol", oRol);
                            oUsuario = oSeguridad.ObtieneUsuario(((clsUsuario)Session["Usuario"]).IdUsuario);
                            Session.Add("Estilo", oUsuario.Estilo.ToString());
                            rwebSeguridad.srPersonal.Service1Client oPersonal = new rwebSeguridad.srPersonal.Service1Client();
                            Session.Add("IdUnidad", oPersonal.ObtienepavItemInstitucion1("NIdPersona", oUsuario.IdPersona.ToString()).Tables[0].Rows[0]["IdUnidad"].ToString());
                        }
                        else
                        {
                            clsSistema oSistema = oSeguridad.ObtieneSistema(1);
                            Response.Redirect(oSistema.Url + "/Default.aspx");
                        }
                    }
                    catch
                    {
                        rwebSeguridad.srSeguridad.Service1Client oSeguridad = new Service1Client();
                        clsSistema oSistema = oSeguridad.ObtieneSistema(1);
                        Response.Redirect(oSistema.Url + "/Default.aspx");
                    }
                }
                cargarMenu(((clsRol)Session["Rol"]).IdSistema, ((clsRol)Session["Rol"]).IdRol);
                rlblUsuarioNombre.InnerText = ((clsUsuario)Session["Usuario"]).NombreUsuario;
            }
            if (Session["Estilo"] == null)
            {
                srSeguridad.Service1Client oSeguridad = new Service1Client();
                clsSistema oSistema = oSeguridad.ObtieneSistema(1);
                Response.Redirect(oSistema.Url + "/Default.aspx");
            }
            RadFormDecorator1.Skin = Session["Estilo"].ToString();
            rmPrincipal.Skin = Session["Estilo"].ToString();
            RadSkinManager1.Skin = Session["Estilo"].ToString();
        }

        void cargarMenu(int IdSistema, int IdRol)
        {
            rwebSeguridad.srSeguridad.Service1Client oSeguridad = new Service1Client();
            DataSet dsSeg = oSeguridad.ObtienepavPermiso3("NIdSistema", IdSistema.ToString(), "NIdRol", IdRol.ToString(), "ONumeroDeOrden", "asc");
            //DataSet dsSeg = oSeguridad.ObtienepavPermiso2("NIdSistema", "1", "NIdRol", "700000002");
            Queue cola = new Queue();
            rmPrincipal.Items.Clear();

            foreach (DataRow regPadre in dsSeg.Tables[0].Rows)
            {
                RadMenuItem nodo;

                if (Convert.ToInt32(regPadre["IdMenu"]) != 0 && Convert.ToInt32(regPadre["IdMenuPadre"]) == 0)
                {
                    nodo = new RadMenuItem();

                    nodo.Text = regPadre["NombreMenu"].ToString();
                    nodo.Value = regPadre["IdMenu"].ToString();
                    nodo.ImageUrl = @"\Imagenes\folder.gif";
                    nodo.NavigateUrl = "~/Formularios/" + regPadre["NombreFormulario"].ToString() + ".aspx";
                    cola.Enqueue(nodo);
                    rmPrincipal.Items.Add(nodo);
                }
            }


            while (cola.Count > 0)
            {
                RadMenuItem nodoPadre = (cola.Dequeue() as RadMenuItem);

                foreach (DataRow reg in dsSeg.Tables[0].Rows)
                {
                    RadMenuItem nodoHijo;

                    if (reg["IdMenuPadre"].ToString() == nodoPadre.Value)
                    {
                        nodoHijo = new RadMenuItem();

                        nodoHijo.Text = reg["NombreMenu"].ToString();
                        nodoHijo.Value = reg["IdMenu"].ToString();
                        nodoHijo.ImageUrl = @"\Imagenes\tasksItems.gif";

                        cola.Enqueue(nodoHijo);
                        nodoPadre.Items.Add(nodoHijo);
                    }
                }

            }
        }

        protected void lblCerrarSession_Click(object sender, EventArgs e)
        {
            try
            {
                clsUsuario oUsuario = (clsUsuario)Session["Usuario"];
                Service1Client oService = new Service1Client();
                clsUsuarioLogueado oUsuarioLogueado = (clsUsuarioLogueado)Session["UsuarioLogueado"];
                oUsuarioLogueado.IdEstadoLlave = 2;
                oService.ModificaUsuarioLogueado(oUsuarioLogueado);

                Session["Usuario"] = null;
                Session["UsuarioLogueado"] = null;
                Session["RolUsuario"] = null;
                Session["Rol"] = null;
                rwebSeguridad.srSeguridad.Service1Client oSeguridad = new Service1Client();
                clsSistema oSistema = oSeguridad.ObtieneSistema(1);
                Response.Redirect(oSistema.Url + "/Default.aspx");
            }
            catch
            {
                rwebSeguridad.srSeguridad.Service1Client oSeguridad = new Service1Client();
                clsSistema oSistema = oSeguridad.ObtieneSistema(1);
                Response.Redirect(oSistema.Url + "/Default.aspx");
            }
        }
    }
}