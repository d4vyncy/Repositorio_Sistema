using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using rwebSeguridad.srPersonal;
using System.IO;

namespace rwebSeguridad.ControlesUsuario.GestionEntidad
{
    public partial class CU_EntidadGestion : System.Web.UI.UserControl
    {

        private object _dataItem = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarImagenDefecto();
            }
        }
        void LLenarCombos()
        {
            srPersonal.Service1Client service = new Service1Client();
            rddlEntidadReferente.DataSource = service.ObtienepavEntidad1("T", "");
            rddlEntidadReferente.DataValueField = "IdEntidad";
            rddlEntidadReferente.DataTextField = "NombreEntidad";
            rddlEntidadReferente.DataBind();

            rddlDepartamento.DataSource = service.ObtienepavDepartamento1("T", "");
            rddlDepartamento.DataValueField = "IdDepartamento";
            rddlDepartamento.DataTextField = "NombreDepartamento";
            rddlDepartamento.DataBind();

            rddlTipoEntidad.DataSource = service.ObtienepavTipoEntidad1("T", "");
            rddlTipoEntidad.DataValueField = "IdTipoEntidad";
            rddlTipoEntidad.DataTextField = "NombreTipoEntidad";
            rddlTipoEntidad.DataBind();
        }

        override protected void OnInit(EventArgs e)
        {
            if (rddlEntidadReferente.Items.Count == 0)
            {
                LLenarCombos();
            }
            base.OnInit(e);
            this.DataBinding += new System.EventHandler(this.EntidadDetalle_DataBinding);

        }

        public object DataItem
        {
            get { return this._dataItem; }
            set { this._dataItem = value; }
        }
        protected void EntidadDetalle_DataBinding(object sender, System.EventArgs e)
        {
            object IdEntidad = DataBinder.Eval(DataItem, "IdEntidad");
            if (!Convert.IsDBNull(IdEntidad))
            {
                srPersonal.Service1Client service = new Service1Client();
                clsEntidad oEntidad = service.ObtieneEntidad(Convert.ToInt32(IdEntidad));
                rtxtNombreEntidad.Text = oEntidad.NombreEntidad;
                rddlEntidadReferente.SelectedValue = oEntidad.IdEntidadPadre.ToString();
                rddlDepartamento.SelectedValue = oEntidad.IdDepartamento.ToString();
                rddlTipoEntidad.SelectedValue = oEntidad.IdTipoEntidad.ToString();
                if (!Convert.IsDBNull(oEntidad.Imagen))
                {
                    rbiImagenEntidad.DataValue = (byte[])oEntidad.Imagen;
                }

            }
            //object ImagenProductoValue = DataBinder.Eval(DataItem, "Imagen");
            //if (!Convert.IsDBNull(ImagenProductoValue))
            //{
            // rbiImagenEntidad.DataValue = (byte[])ImagenProductoValue;
            //}
        }
        void CargarImagenDefecto()
        {
            string path = HttpContext.Current.Server.MapPath("~/Imagenes/ImgPrueba.jpg");
            byte[] imagenDefecto = File.ReadAllBytes(path);
            Session.Add("sImagenEntidad", imagenDefecto);
        }
        protected void btnSubirImagenEntidad_Click(object sender, EventArgs e)
        {
            string sFile = string.Empty;
            if ((fuImagenEntidad.PostedFile != null) && (fuImagenEntidad.PostedFile.ContentLength > 0))
            {
                HttpPostedFile ImgFile = fuImagenEntidad.PostedFile;
                Byte[] byteImage = new Byte[fuImagenEntidad.PostedFile.ContentLength];
                ImgFile.InputStream.Read(byteImage, 0, fuImagenEntidad.PostedFile.ContentLength);
                rbiImagenEntidad.DataValue = byteImage;
                Session.Add("sImagenEntidad", byteImage);
            }
        }
    }
}