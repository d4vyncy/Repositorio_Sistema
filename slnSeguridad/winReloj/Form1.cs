using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using winReloj.srPersonal;

namespace winReloj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }
        
        private void btnImportar_Click(object sender, EventArgs e)
        {
            GuardarMarcajes();
            listBox1.Items.Add("EXPORTACION MANUAL");
            GenerarHorario();
        }

        void GuardarMarcajes()
        {
            zkemkeeper.CZKEM axCZKEM1 = new zkemkeeper.CZKEM();
            bool bIsConnected = false;//the boolean value identifies whether the device is connected
            int iMachineNumber = 1;//the serial number of the device.After connecting the device ,this value will be changed.
            string conexion = "F";
            string conclusion = "", sdwEnrollNumber = "";
            int cont = 0, idwVerifyMode = 0, idwInOutMode = 0;
            int idwYear = 0, idwMonth = 0, idwDay = 0, idwHour = 0, idwMinute = 0, idwSecond = 0, idwWorkcode = 0;
            int idwErrorCode = 0;
            int marcados = 0;
            srPersonal.Service1Client oService = new srPersonal.Service1Client();
            clsMarcasBSS oMarcasBSS = new clsMarcasBSS();
            oMarcasBSS.IdMarcasBSS = 7000001;
            clsBitacoraReloj oBitacoraReloj = new clsBitacoraReloj();
            DataTable dtReloj = oService.ObtienepavReloj1("NIdEstadoReloj", "1").Tables[0];
            string ip;
            string cerrar = "";
            string descarga = "", final = "";
            for (int i = 0; i < dtReloj.Rows.Count; i++)
            {
                ip = dtReloj.Rows[i]["IPReloj"].ToString();
                ip = ip.TrimEnd();
                oMarcasBSS.IdOrigen = Convert.ToInt32(dtReloj.Rows[i]["IdReloj"].ToString());
                bIsConnected = axCZKEM1.Connect_Net(ip, 4370);
                if (bIsConnected == true)
                {
                    conexion = "T"; cont = 0; iMachineNumber = 1;
                    axCZKEM1.RegEvent(iMachineNumber, 65535);
                    axCZKEM1.EnableDevice(iMachineNumber, false);
                    axCZKEM1.GetDeviceStatus(iMachineNumber, 6, ref marcados);
                    if (axCZKEM1.ReadGeneralLogData(iMachineNumber))//read all the attendance records to the memory
                    {
                        //Codigo para guardar a la BD Personal
                        oMarcasBSS.IdTipoHorario = 1;
                        oMarcasBSS.Origen = dtReloj.Rows[i]["NombreReloj"].ToString() + " - " + dtReloj.Rows[i]["IPReloj"].ToString();
                        //Codigo para ver marcajes
                        while (axCZKEM1.SSR_GetGeneralLogData(iMachineNumber, out sdwEnrollNumber, out idwVerifyMode, out idwInOutMode, out idwYear, out idwMonth, out idwDay, out idwHour, out idwMinute, out idwSecond, ref idwWorkcode))//get records from the memory
                        {
                            oMarcasBSS.Codigo = Convert.ToInt32(sdwEnrollNumber);
                            oMarcasBSS.IdTipoHorario = 1;
                            oMarcasBSS.Origen = dtReloj.Rows[i]["NombreReloj"].ToString() + " - " + dtReloj.Rows[i]["IPReloj"].ToString();
                            //Codigo para ver marcajes
                            while (axCZKEM1.SSR_GetGeneralLogData(iMachineNumber, out sdwEnrollNumber, out idwVerifyMode, out idwInOutMode, out idwYear, out idwMonth, out idwDay, out idwHour, out idwMinute, out idwSecond, ref idwWorkcode))//get records from the memory
                            {
                                //if ((idwYear == 2023) && (idwMonth == DateTime.Now.Month))
                                if ((idwYear == 2023) && (idwMonth == 9) && (idwDay >= 27))
                                {
                                    oMarcasBSS.Codigo = Convert.ToInt32(sdwEnrollNumber);
                                    oMarcasBSS.Fecha = Convert.ToDateTime(idwDay.ToString() + "/" + idwMonth.ToString() + "/" + idwYear.ToString());
                                    oMarcasBSS.Hora = Convert.ToDateTime(idwDay.ToString() + "/" + idwMonth.ToString() + "/" + idwYear.ToString() + " " + idwHour.ToString() + ":" + idwMinute.ToString() + ":" + idwSecond.ToString());
                                    oMarcasBSS.IdTipoMarcajeReloj = idwInOutMode;
                                    //items.Add(oMarcasBSS);
                                    oService.AgregaMarcasBSS(oMarcasBSS);
                                    //oService.ProcedureParametro("paPMarcasBSS", oMarcasBSS);
                                    //@IdMarcasBSS as INT = null, @IdOrigen as INT = null, @IdTipoHorario as INT = null, @Codigo as INT = null, @Hora as DATETIME = null, @IdTipoMarcajeReloj as INT = null, @Fecha as DATETIME = null, @Origen as NVARCHAR(255) = null
                                    cont++;
                                }
                            }
                            descarga = "T";
                            //clave com 0
                            //            //descarga = "T";
                            //            //if (axCZKEM1.ClearGLog(iMachineNumber))
                            //            //{
                            //            //    axCZKEM1.RefreshData(iMachineNumber);//the data in the device should be refreshed
                            //            //}
                        }
                    }
                    else
                    {
                        axCZKEM1.GetLastError(ref idwErrorCode);
                        if (idwErrorCode != 0)
                        {
                            descarga = "F-" + "ErrorCode: " + idwErrorCode.ToString();
                        }
                        else
                        {
                            descarga = "N";
                        }
                    }
                    axCZKEM1.SetDeviceTime(iMachineNumber);
                    axCZKEM1.RefreshData(iMachineNumber);
                    axCZKEM1.EnableDevice(iMachineNumber, true);//enable the device
                    axCZKEM1.Disconnect();
                    cerrar = "T";
                    bIsConnected = false;
                }
                else
                {
                    conexion = "F";
                    conclusion = "Falla - Error en Conexion";
                }
                //bitacora
                if (conexion == "T")
                {
                    if (descarga == "T")
                    {
                        if (cerrar == "T")
                        {
                            conclusion = "Exito en todas las Operaciones";
                            final = "T";
                        }
                        else
                        {
                            conclusion = "Falla - Error al desconectar";
                        }
                    }
                    else
                    {
                        if (descarga == "N")
                        {
                            conclusion = "Exito - No existe datos para Descargar";
                            final = "T";
                        }
                        else
                        {
                            conclusion = "Falla - Error en la Descarga de datos";
                        }
                    }
                }
                listBox1.Items.Add("IP:" + ip + "-C:" + conclusion + "-Fecha:" + DateTime.Now.ToString());
                oBitacoraReloj.IdBitacoraReloj = 7000001;
                oBitacoraReloj.Fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                oBitacoraReloj.Hora = DateTime.Now;
                oBitacoraReloj.NombreReloj = dtReloj.Rows[i]["NombreReloj"].ToString();
                oBitacoraReloj.EstadoComAbrir = conexion;
                oBitacoraReloj.EstadoExpArchivo = descarga;
                oBitacoraReloj.MarcasDescargadas = cont;
                oBitacoraReloj.MarcasLeidas = marcados;
                oBitacoraReloj.EstadoComCerrar = cerrar;
                oBitacoraReloj.EstadoExito = final;
                oBitacoraReloj.Observaciones = conclusion;
                oService.AgregaBitacoraReloj(oBitacoraReloj);
            }
        }

        void GenerarHorario()
        {
            try
            {
                srPersonal.Service1Client oService = new srPersonal.Service1Client();
                DateTime Fecha = DateTime.Now;
                if (DateTime.Now.Hour == 1)
                    Fecha = Fecha.AddDays(-1);

                oService.EjecutaConsulta("exec pauReporteAsistenciaPersonalPlanta " + Fecha.Year.ToString() + "," + Fecha.Month.ToString() + "," + Fecha.Day.ToString());
                listBox1.Items.Add("correcta generacion de horario");
            }
            catch { listBox1.Items.Add("error al generar horario"); }
        }
        Int16 Contador = 0;
        int Dia1 = 0, Dia2 = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Dia1 = DateTime.Now.Day;
            ////en la noche
            if ((DateTime.Now.Hour > 22) && (Dia1 != Dia2) && Contador == 0)
            {
                Contador = 1;
                Dia2 = DateTime.Now.Day;
                GuardarMarcajes();
                listBox1.Items.Add("EXPORTACION AUTOMATICA:1:");
                GenerarHorario();
                Contador = 0;
            }
            //// en la mñna
            //if ((DateTime.Now.Hour == 1) && (Contador == 0))
            //{
            //    Contador++;
            //    GuardarMarcajes();
            //    listBox1.Items.Add("EXPORTACION AUTOMATICA:2:" + DateTime.Now.ToString());
            //    GenerarHorario();
            //}
            //// en la mñna
            //if ((DateTime.Now.Hour == 9) && (Contador == 1))
            //{
            //    Contador++;
            //    GuardarMarcajes();
            //    listBox1.Items.Add("EXPORTACION AUTOMATICA:2:" + DateTime.Now.ToString());
            //    GenerarHorario();                
            //}
            //// a medio dia
            //if ((DateTime.Now.Hour == 15) && (Contador == 2))
            //{
            //    Contador++;
            //    GuardarMarcajes();
            //    listBox1.Items.Add("EXPORTACION AUTOMATICA:3:" + DateTime.Now.ToString());
            //    GenerarHorario();                
            //}
            //    //// a noche
            //    if ((DateTime.Now.Hour == 22) && (Contador == 3))
            //{
            //    Contador++;
            //    GuardarMarcajes();
            //    listBox1.Items.Add("EXPORTACION AUTOMATICA:4:" + DateTime.Now.ToString());
            //    GenerarHorario();
            //}
            lblHora.Text = DateTime.Now.ToShortTimeString();
        }
    }
}
