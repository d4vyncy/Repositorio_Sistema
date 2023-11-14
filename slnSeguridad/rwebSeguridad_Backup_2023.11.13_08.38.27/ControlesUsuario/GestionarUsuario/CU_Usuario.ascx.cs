using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using rwebSeguridad.srSeguridad;
using System.Security.Cryptography;
using System.Web.Security;
using Telerik.Web.UI;
using System.Data;

namespace rwebSeguridad.ControlesUsuario.GestionarUsuario
{
    public partial class CU_Usuario : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Variables de Inicio
                
            }
        }

        public void CargarListaUsuario()
        {
            rwebSeguridad.srSeguridad.Service1Client oService = new Service1Client();
            RGVUsuario.DataSource = oService.ObtienepavUsuario1("T", "");
        }
        private string CreaSalt(int Tamano)
        {
            Byte[] bytSalt = new Byte[5];
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            rng.GetBytes(bytSalt);
            return Convert.ToBase64String(bytSalt);
        }
        private string CreaPasswordHash(string pPassword, string pSalt)
        {
            string cUnion, cPassHashSalt;
            cUnion = string.Concat(pPassword, pSalt);
            cPassHashSalt = FormsAuthentication.HashPasswordForStoringInConfigFile(cUnion, "SHA1");
            return cPassHashSalt;
        }
        protected void RGVUsuario_InsertCommand(object sender, GridCommandEventArgs e)
        {
            GridEditableItem editedItem = e.Item as GridEditableItem;
            UserControl userControl = (UserControl)e.Item.FindControl(GridEditFormItem.EditFormUserControlID);
            rwebSeguridad.srSeguridad.Service1Client oService = new Service1Client();
            if (oService.ObtienepavUsuario1("LNombreUsuario", (userControl.FindControl("rtxtNombreUsuario") as RadTextBox).Text).Tables[0].Rows.Count > 0)
            {

            }
            else
            {
                if ((userControl.FindControl("rtxtNombreUsuario") as RadTextBox).Text.Length > 0 && (userControl.FindControl("rtxtClave") as RadTextBox).Text.Length > 0
             && ((userControl.FindControl("rtxtPIN") as RadTextBox).Text.Length > 0 ))
                {
                    clsUsuario oUsuario = new clsUsuario();

                    oUsuario.IdPersona = Convert.ToInt32((userControl.FindControl("rddlIdPersona") as RadComboBox).SelectedValue);
                    oUsuario.NombreUsuario = (userControl.FindControl("rtxtNombreUsuario") as RadTextBox).Text;

                    string cSalt = CreaSalt(4);
                    string cClave = CreaPasswordHash((userControl.FindControl("rtxtClave") as RadTextBox).Text, cSalt);

                    oUsuario.Clave = cClave;
                    oUsuario.Salt = cSalt;

                    oUsuario.Pin = Convert.ToInt32((userControl.FindControl("rtxtPIN") as RadTextBox).Text);
                    oUsuario.IdEstadoUsuario = Convert.ToInt32((userControl.FindControl("rddlIdEstadoUsuario") as RadComboBox).SelectedValue);
                    oUsuario.IdTipoUsuario = Convert.ToInt32((userControl.FindControl("rddlIdTipoUsuario") as RadComboBox).SelectedValue);
                    oUsuario.IdUsuario = oUsuario.IdPersona;
                    oService.AgregaUsuario(oUsuario);
                }else{

                    
                }
                
            }
        }
   

        protected void RGVUsuario_UpdateCommand(object sender, GridCommandEventArgs e)
        {
            rwebSeguridad.srSeguridad.Service1Client oService = new Service1Client();
            GridEditableItem editedItem = e.Item as GridEditableItem;
            UserControl userControl = (UserControl)e.Item.FindControl(GridEditFormItem.EditFormUserControlID);
            int Id = Convert.ToInt32(editedItem.OwnerTableView.DataKeyValues[editedItem.ItemIndex]["IdUsuario"].ToString());
            clsUsuario oUsuario = oService.ObtieneUsuario(Id);
            oUsuario.IdPersona = Convert.ToInt32((userControl.FindControl("rddlIdPersona") as RadComboBox).SelectedValue);
            oUsuario.NombreUsuario = (userControl.FindControl("rtxtNombreUsuario") as RadTextBox).Text;
           // oUsuario.Clave = (userControl.FindControl("rtxtClave") as RadTextBox).Text;
           // oUsuario.Salt = (userControl.FindControl("rtxtSalt") as RadTextBox).Text;
            oUsuario.Pin = Convert.ToInt32((userControl.FindControl("rtxtPIN") as RadTextBox).Text);
            oUsuario.IdEstadoUsuario = Convert.ToInt32((userControl.FindControl("rddlIdEstadoUsuario") as RadComboBox).SelectedValue);
            oUsuario.IdTipoUsuario = Convert.ToInt32((userControl.FindControl("rddlIdTipoUsuario") as RadComboBox).SelectedValue);
            oService.ModificaUsuario(oUsuario);
        }
        protected void RGVUsuario_NeedDataSource(object sender, GridNeedDataSourceEventArgs e)
        {
            CargarListaUsuario();
        }
        protected void RGVUsuario_PreRender(object sender, EventArgs e)
        {
        }
    }
}