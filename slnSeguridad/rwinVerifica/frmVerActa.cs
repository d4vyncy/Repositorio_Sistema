using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace rwinVerifica
{
    public partial class frmVerActa : Telerik.WinControls.UI.RadForm
    {
        public frmVerActa()
        {
            InitializeComponent();
            db = DatabaseFactory.CreateDatabase("Con");
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            DataTable dt = ObtieneDatos();            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //if(i!=0)
                //{
                //    if (dt.Rows[i-1]["CodigoMesa"].ToString() != dt.Rows[i]["CodigoMesa"].ToString())
                //    {
                        byte[] imageBuffer = (byte[])dt.Rows[0]["ImagenActa"];
                        System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);
                        Image.FromStream(ms).Save("C:\\img\\" + dt.Rows[i]["IdActaImagen"]);
                        ms.Dispose();
                        ms.Close();
                //    }
                //}
                //pictureBox1.Image = Image.FromStream(ms);
                //pictureBox1.Image.Save("C:\\img\\" + dt.Rows[0]["CodigoMesa"]);
            }
            radGridView1.DataSource = dt;
        }
        Database db = null;
        public DataTable ObtieneDatos()
        {
            DbCommand cmd = db.GetSqlStringCommand("SELECT *  FROM vActaImagen where CodigoMesa>=75505 and CodigoMesa<=75514 order by CodigoMesa ");
            return db.ExecuteDataSet(cmd).Tables[0];
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hola buenos dias " + textBox1.Text);
        }
    }
}
