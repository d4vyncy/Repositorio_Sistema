using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using rwinVerifica.srSeguridad;
using System.IO;

namespace rwinVerifica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //DateTime Edad = new DateTime(1982,9,23);
            //DateDifference d = new DateDifference(Edad,DateTime.Now);
            //MessageBox.Show(d.ToString());

            //codigo para ver equipos encendidos
            //Inicio = 19;
            //timer1.Start();

            // comprimir los ficheros de la lista en el zip indicado
            
            string[] files = new string[1];
            //
            this.Cursor = Cursors.WaitCursor;

            files[0] = @"C:\gen\test.bak";
            
            zUtil.Comprimir(files, @"c:\gen\bk.zip", false);
            
            
        }
        private ZipUtil zUtil = new ZipUtil();
        srSeguridad.Service1Client sroSeguridad = new srSeguridad.Service1Client();
        DataTable dtEquipo;
        clsEquipoDetalle oEquipoDetalle = new clsEquipoDetalle();
        int Inicio;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.Hour == Inicio)
            {
                Inicio++;
                IniciaPing();
                if (Inicio > 7)
                    Inicio = 0;
            }
        }

        void IniciaPing()
        {
            listBox1.Items.Add("exportacion iniciada hora : " + DateTime.Now.Hour.ToString());
            dtEquipo = sroSeguridad.ObtienepavEquipo1("EIpEquipo", "").Tables[0];
            bool Respuesta;
            for (int i = 0; i < dtEquipo.Rows.Count; i++)
            {
                Respuesta = HacerPing(dtEquipo.Rows[i]["IpEquipo"].ToString());
                oEquipoDetalle.IdEquipoDetalle = 700000001;
                oEquipoDetalle.IdEquipo = Convert.ToInt32(dtEquipo.Rows[i]["IdEquipo"].ToString());
                oEquipoDetalle.Descripcion = "ping de prueba";
                oEquipoDetalle.FechaConsulta = DateTime.Now;
                oEquipoDetalle.Respuesta = Respuesta;
                sroSeguridad.AgregaEquipoDetalle(oEquipoDetalle);
            }
        }

        bool HacerPing(string IpEquipo)
        {
            try
            {
                Ping Pings = new Ping();
                int timeout = 10;

                if (Pings.Send(IpEquipo, timeout).Status == IPStatus.Success)
                {
                    return true;
                    
                }
                else
                {
                    return false;
                    //listBox1.Items.Add("Error");
                }
            }
            catch
            { return false; }
        }
    }
}
