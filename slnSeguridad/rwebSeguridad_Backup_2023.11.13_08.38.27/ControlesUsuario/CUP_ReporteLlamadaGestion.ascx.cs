using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace rwebSeguridad.ControlesUsuario
{
    public partial class CUP_ReporteLlamadaGestion : System.Web.UI.UserControl
    {
        private object _dataItem = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        void LLenarCombos()
        {
         
        }

        override protected void OnInit(EventArgs e)
        {
            LLenarCombos();
            base.OnInit(e);
            this.DataBinding += new System.EventHandler(this.RolDetalle_DataBinding);
        }

        public object DataItem
        {
            get { return this._dataItem; }
            set { this._dataItem = value; }
        }
        protected void RolDetalle_DataBinding(object sender, System.EventArgs e)
        {
            object IdReporteLlamada = DataBinder.Eval(DataItem, "IdReporteLlamada");
            if (!Convert.IsDBNull(IdReporteLlamada))
            {
                srPersonal.Service1Client service = new srPersonal.Service1Client();
                
            }
        }  
    }
}