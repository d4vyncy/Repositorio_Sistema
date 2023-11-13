using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using rwebSeguridad.srSeguridad;
using Telerik.Web.UI;
using System.Data;
using System.Collections;


namespace rwebSeguridad.ControlesUsuario.GestionarMenu
{
    public partial class CU_Menu : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                srSeguridad.Service1Client oService = new Service1Client();
                rddlSistema.DataSource = oService.ObtienepavSistema1("T", "");
                rddlSistema.DataValueField = "IdSistema";
                rddlSistema.DataTextField = "NombreSistema";
                rddlSistema.DataBind();

                cargarMenu();
            }
        }


        protected void rddlSistema_SelectedIndexChanged(object sender, RadComboBoxSelectedIndexChangedEventArgs e)
        {
            cargarMenu();
        }

        void cargarMenu()
        {
            srSeguridad.Service1Client oSeg = new Service1Client();
            DataSet dsSeg = oSeg.ObtienepavMenu1("NIdSistema", rddlSistema.SelectedValue.ToString());
            Queue cola = new Queue();
            rTrvmenu.Nodes.Clear();

            foreach (DataRow regPadre in dsSeg.Tables[0].Rows)
            {
                RadTreeNode nodo;

                if (Convert.ToInt32(regPadre["IdMenu"]) != 0 && Convert.ToInt32(regPadre["IdMenuPadre"]) == 0)
                {
                    nodo = new RadTreeNode();

                    nodo.Text = regPadre["NombreMenu"].ToString();
                    nodo.Value = regPadre["IdMenu"].ToString();
                    nodo.ImageUrl = @"\Imagenes\folder.gif";

                    cola.Enqueue(nodo);
                    rTrvmenu.Nodes.Add(nodo);
                }
            }


            while (cola.Count > 0)
            {
                RadTreeNode nodoPadre = (cola.Dequeue() as RadTreeNode);

                foreach (DataRow reg in dsSeg.Tables[0].Rows)
                {
                    RadTreeNode nodoHijo;

                    if (reg["IdMenuPadre"].ToString() == nodoPadre.Value)
                    {
                        nodoHijo = new RadTreeNode();

                        nodoHijo.Text = reg["NombreMenu"].ToString();
                        nodoHijo.Value = reg["IdMenu"].ToString();
                        nodoHijo.ImageUrl = @"\Imagenes\tasksItems.gif";

                        cola.Enqueue(nodoHijo);
                        nodoPadre.Nodes.Add(nodoHijo);
                    }
                }

            }

            rTrvmenu.ExpandAllNodes();
        }

        protected void rTrvmenu_NodeClick(object sender, RadTreeNodeEventArgs e)
        {
            rtxtNombreMenuModificar.Text = rTrvmenu.SelectedNode.Text;
         rtxtNombreMenu.Text = "";
        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            if (rtxtNombreMenu.Text.Trim() != "" && rtxtNombreFormulrio.Text.Trim() != "" && rntxtNumeroOrden.Text.Trim() != "")
            {

                srSeguridad.Service1Client oServicio = new Service1Client();
                clsMenu oMenu = new clsMenu();
                oMenu.NombreMenu = rtxtNombreMenu.Text;

                oMenu.IdSistema = Convert.ToInt32(rddlSistema.SelectedValue.ToString());
                oMenu.IdMenuPadre = Convert.ToInt32(rTrvmenu.SelectedNode.Value.ToString());
                oMenu.NombreFormulario = rtxtNombreFormulrio.Text;
                oMenu.NumeroDeOrden = Convert.ToInt32( rntxtNumeroOrden.Text );
                oServicio.AgregaMenu(oMenu);

                rntxtNumeroOrden.Text = "";
                rtxtNombreFormulrio.Text = "";
                rtxtNombreMenu.Text = "";
                cargarMenu();
            }
            else
            {
                rlblMensage.Text = "Es Necesario completar los campos!!";
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            if (rtxtNombreMenuModificar.Text.Trim() != "")
            {
               
            srSeguridad.Service1Client oServicio = new Service1Client();
            clsMenu oMenu = oServicio.ObtieneMenu(Convert.ToInt32(rTrvmenu.SelectedNode.Value.ToString()));
            oMenu.NombreMenu = rtxtNombreMenuModificar.Text;
            oServicio.ModificaMenu(oMenu);
            cargarMenu();
            }
             else
             {
                 rlblMensage.Text = "Es Necesario completar el campos!!";
             }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (rTrvmenu.SelectedNode.Nodes.Count >= 1)
                rlblMensage.Text = "No se puede eliminar porque tiene hijos";
            else
            {
                srSeguridad.Service1Client oServicio = new Service1Client();
                clsMenu oMenu = oServicio.ObtieneMenu(Convert.ToInt32(rTrvmenu.SelectedNode.Value.ToString()));
                oMenu.NombreMenu = rtxtNombreMenuModificar.Text;

                oServicio.EliminaMenu(oMenu.IdMenu);

                cargarMenu();
            }
        }

        protected void btnInsertarMenuPrincipal_Click(object sender, EventArgs e)
        {
            if (rtxtNombreMenuPadre.Text.Trim() != "")
            {
                srSeguridad.Service1Client oServicio = new Service1Client();
                clsMenu oMenu = new clsMenu();
                oMenu.NombreMenu = rtxtNombreMenuPadre.Text;
                oMenu.NombreFormulario = rtxtNombreFormulrio.Text;
                oMenu.NumeroDeOrden = Convert.ToInt32( rntxtNumeroOrden.Text);

                oMenu.IdSistema = Convert.ToInt32(rddlSistema.SelectedValue.ToString());
                oMenu.IdMenuPadre = 0;

                rntxtNumeroOrden.Text = "";
                rtxtNombreFormulrio.Text = "";
                rtxtNombreMenu.Text = "";

                oServicio.AgregaMenu(oMenu);
                cargarMenu();
            }
            else
            {
                rlblMensage.Text = "Completar el Nombre Del Menu!!";
            }
        }

    }
}