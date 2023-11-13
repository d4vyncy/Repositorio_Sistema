using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using winReloj.srProcesoElectoral;

namespace winReloj
{
    public partial class frmLeeArchivos : Form
    {
        public frmLeeArchivos()
        {
            InitializeComponent();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            DirectoryInfo folder = new DirectoryInfo(@"E:\Proyectos\ProcesoElectoral\slnProcesoElectoral\rwebProcesoElectoral\pdf\");
            srProcesoElectoral.Service1Client oService = new Service1Client();
            clsIntegranteArchivo oIntegranteArchivo = new clsIntegranteArchivo();
            oIntegranteArchivo.IdIntegranteArchivo = 70000001;
            oIntegranteArchivo.IdIntegrante = 0;
            oIntegranteArchivo.NombreNuevoArchivo = "";
            oIntegranteArchivo.EstadoAsignacion = false;
            oIntegranteArchivo.IdUsuarioRegistra = 0;
            foreach (FileInfo file in folder.GetFiles())
            {
                //ListBox1.Items.Add(file.Name);
                oIntegranteArchivo.NombreArchivo = file.Name;
                oService.AgregaIntegranteArchivo(oIntegranteArchivo);
            }
        }
    }
}
