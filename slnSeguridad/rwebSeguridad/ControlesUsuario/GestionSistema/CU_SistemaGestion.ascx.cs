using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace rwebSeguridad.ControlesUsuario.GestionSistema
{
    public partial class CU_SistemaGestion : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private object _dataItem = null;
        public object DataItem
        {
            get { return this._dataItem; }
            set { this._dataItem = value; }
        }
        protected void ObjetivoGestion_DataBinding(object sender, System.EventArgs e)
        {
            
        }

        void CargarImagenDefecto()
        {
            string path = HttpContext.Current.Server.MapPath("~/Imagenes/ImgPrueba.jpg");
            byte[] imagenDefecto = File.ReadAllBytes(path);
            Session.Add("sImagenSistema", imagenDefecto);
        }
        protected void btnSubirImagenSistema_Click(object sender, EventArgs e)
        {
            string sFile = string.Empty;
            if ((fuImagenSistema.PostedFile != null) && (fuImagenSistema.PostedFile.ContentLength > 0))
            {
                HttpPostedFile ImgFile = fuImagenSistema.PostedFile;
                Byte[] byteImage = new Byte[fuImagenSistema.PostedFile.ContentLength];
                ImgFile.InputStream.Read(byteImage, 0, fuImagenSistema.PostedFile.ContentLength);
                rbiImagenSistema.DataValue = byteImage;
                Session.Add("sImagenSistema", byteImage);
            }
        }

      
    }
}