using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Globalization;
using GeneradorCodigoControladoras.Entidades;

namespace GeneradorCodigoControladoras
{
    public partial class Form1 : Form
    {
        public EBaseDatos BaseDatos;
        public EImportarSQL ImportarSQL;

        // Methods
        public Form1()
        {
            this.InitializeComponent();
            BaseDatos = new EBaseDatos();
            ImportarSQL = new EImportarSQL();
            if (DateTime.Now > Convert.ToDateTime("01/01/2024"))
            {
                base.Dispose();
            }
        }

        private void BTGenerarAutomaticamente_Click(object sender, EventArgs e)
        {
            int tab;
            string conect;
            int i;
            this.BaseDatos._NombreBaseDatos = this.LBBaseDatos.SelectedValue.ToString();
            this.BaseDatos.ConnectionString = "data source=" + this.BaseDatos.NombreServidor + ";initial catalog=" + this.BaseDatos.NombreBaseDatos + ";persist security info=False;user id=" + this.BaseDatos.Cuenta + ";workstation id=" + this.BaseDatos.NombreServidor + ";password =" + this.BaseDatos.Password + "; packet size=4096";
            this.TXTWebservices.Text = this.BaseDatos.NombreBaseDatos;
            this.Error2.Text = "data source=" + this.BaseDatos.NombreServidor + ";initial catalog=" + this.BaseDatos.NombreBaseDatos + ";persist security info=False;user id=" + this.BaseDatos.Cuenta + ";workstation id=" + this.BaseDatos.NombreServidor + ";password =" + this.BaseDatos.Password + "; packet size=4096";
            this.LBTablas.Items.Clear();
            this.LBTablas.Refresh();
            try
            {
                DataSet ds = new DataSet("Tabla");
                ds = this.ImportarSQL.TablasSqlServer(this.BaseDatos.ConnectionString);
                this.dataGrid1.DataSource = ds.Tables["table"];
                this.dataGrid1.Refresh();
                this.LBTablas.DataSource = ds.Tables["table"];
                this.LBTablas.DisplayMember = "TABLE_NAME";
                this.LBTablas.ValueMember = "TABLE_NAME";
                this.LBTablas.Refresh();
                this.Error1.Text = "Conexion Exitosa... Puede continuar";
                this.Error1.ForeColor = Color.Blue;
                this.BaseDatos._Conectado = true;
            }
            catch
            {
                this.Error1.Text = "La conexi\x00f3n ha fallado...";
                this.Error1.ForeColor = Color.Red;
                this.BaseDatos.Conectado = false;
            }
            string directorio = this.TXTRutaArchivo.Text;
            this.BaseDatos.NombreBaseDatos = this.BaseDatos.NombreBaseDatos.ToString();
            if (Directory.Exists(directorio))
            {
                directorio = directorio + @"\cls" + this.BaseDatos.NombreBaseDatos.ToString();
                Directory.CreateDirectory(directorio + @"\Datos");
                Directory.CreateDirectory(directorio + @"\Entidades");
                Directory.CreateDirectory(directorio + @"\Negocios");
            }
            else
            {
                MessageBox.Show("Ingrese un directorio valido para guardar las clases");
            }
            this.BTNGenerarCodigo.Enabled = true;
            this.BTNGenerarCodigo.Enabled = true;
            for (tab = 0; tab < this.LBTablas.Items.Count; tab++)
            {
                this.LBTablas.SelectedIndex = tab;
                this.BaseDatos.Tablas.Clear();
                this.BaseDatos.Tablas.Add(this.LBTablas.SelectedValue);
                conect = this.Error2.Text;
                this.ImportarSQL.ColumnasI.Clear();
                this.ImportarSQL.TypoColumnasI.Clear();
                this.ImportarSQL.CargarColumnas(conect, this.BaseDatos.Tablas[0].ToString());
                this.LBCampos.Items.Clear();
                if (this.LBTablas.SelectedValue.ToString().Substring(0, 2) == "cl")
                {
                    this.ImportarSQL.tablaNombre = this.LBTablas.SelectedValue.ToString().Substring(2);
                }
                else
                {
                    this.ImportarSQL.tablaNombre = this.LBTablas.SelectedValue.ToString().Substring(3);
                }
                i = 0;
                while (i <= (this.ImportarSQL.ColumnasI.Count - 1))
                {
                    this.LBCampos.Items.Add(this.ImportarSQL.ColumnasI[i]);
                    this.LBCampos.Items.Add(this.ImportarSQL.TypoColumnasI[i]);
                    i++;
                }
                this.RTBCodigoGenerado.Text = "";
                this.CrearLasEntidades();
                if (this.ImportarSQL.tablaNombre.ToString() != "dtproperties")
                {
                    this.RTBCodigoGenerado.SaveFile(directorio + @"\Entidades\cls" + this.ImportarSQL.tablaNombre.ToString() + "BE.cs", RichTextBoxStreamType.PlainText);
                    this.RTBCodigoGenerado.SaveFile(directorio + @"\Entidades\cls" + this.ImportarSQL.tablaNombre.ToString() + "BE.cs", RichTextBoxStreamType.PlainText);
                }
            }
            for (tab = 0; tab < this.LBTablas.Items.Count; tab++)
            {
                this.LBTablas.SelectedIndex = tab;
                this.BaseDatos.Tablas.Clear();
                this.BaseDatos.Tablas.Add(this.LBTablas.SelectedValue);
                conect = this.Error2.Text;
                this.ImportarSQL.ColumnasI.Clear();
                this.ImportarSQL.TypoColumnasI.Clear();
                this.ImportarSQL.CargarColumnas(conect, this.BaseDatos.Tablas[0].ToString());
                this.LBCampos.Items.Clear();
                if (this.LBTablas.SelectedValue.ToString().Substring(0, 2) == "cl")
                {
                    this.ImportarSQL.tablaNombre = this.LBTablas.SelectedValue.ToString().Substring(2);
                }
                else
                {
                    this.ImportarSQL.tablaNombre = this.LBTablas.SelectedValue.ToString().Substring(3);
                }
                i = 0;
                while (i <= (this.ImportarSQL.ColumnasI.Count - 1))
                {
                    this.LBCampos.Items.Add(this.ImportarSQL.ColumnasI[i]);
                    this.LBCampos.Items.Add(this.ImportarSQL.TypoColumnasI[i]);
                    i++;
                }
                this.RTBCodigoGenerado.Text = "";
                this.CrearLasControladoras();
                if (this.ImportarSQL.tablaNombre.ToString() != "dtproperties")
                {
                    this.RTBCodigoGenerado.SaveFile(directorio + @"\Datos\cls" + this.ImportarSQL.tablaNombre.ToString() + "DA.cs", RichTextBoxStreamType.PlainText);
                    this.RTBCodigoGenerado.SaveFile(directorio + @"\Datos\cls" + this.ImportarSQL.tablaNombre.ToString() + "DA.cs", RichTextBoxStreamType.PlainText);
                }
            }
            for (tab = 0; tab < this.LBTablas.Items.Count; tab++)
            {
                this.LBTablas.SelectedIndex = tab;
                this.BaseDatos.Tablas.Clear();
                this.BaseDatos.Tablas.Add(this.LBTablas.SelectedValue);
                conect = this.Error2.Text;
                this.ImportarSQL.ColumnasI.Clear();
                this.ImportarSQL.TypoColumnasI.Clear();
                this.ImportarSQL.CargarColumnas(conect, this.BaseDatos.Tablas[0].ToString());
                this.LBCampos.Items.Clear();
                if (this.LBTablas.SelectedValue.ToString().Substring(0, 2) == "cl")
                {
                    this.ImportarSQL.tablaNombre = this.LBTablas.SelectedValue.ToString().Substring(2);
                }
                else
                {
                    this.ImportarSQL.tablaNombre = this.LBTablas.SelectedValue.ToString().Substring(3);
                }
                for (i = 0; i <= (this.ImportarSQL.ColumnasI.Count - 1); i++)
                {
                    this.LBCampos.Items.Add(this.ImportarSQL.ColumnasI[i]);
                    this.LBCampos.Items.Add(this.ImportarSQL.TypoColumnasI[i]);
                }
                this.RTBCodigoGenerado.Text = "";
                this.CrearElNegocio();
                if (this.ImportarSQL.tablaNombre.ToString() != "dtproperties")
                {
                    this.RTBCodigoGenerado.SaveFile(directorio + @"\Negocios\cls" + this.ImportarSQL.tablaNombre.ToString() + ".cs", RichTextBoxStreamType.PlainText);
                    this.RTBCodigoGenerado.SaveFile(directorio + @"\Negocios\cls" + this.ImportarSQL.tablaNombre.ToString() + ".cs", RichTextBoxStreamType.PlainText);
                }
            }
            this.CrearWCF();
            this.CrearWCFInterface();
            this.CrearPersonalizado();
            this.NOTA();
            MessageBox.Show("Creacion realizada correctamente");
            base.Dispose();
        }

        private void BTNAutenticar_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(DateTime.Today.Day.ToString()) * Convert.ToInt32(DateTime.Today.Month.ToString());
            int num1 = Convert.ToInt32(DateTime.Today.Year.ToString());
            if ((num % 2) == 0)
            {
                num1 += num;
            }
            else
            {
                num1 -= num;
            }
            string use = num.ToString();
            string pass = num1.ToString();
            if ((this.TXTContrasena.Text == pass) && (this.TXTUsuario.Text == use))
            {
                this.BTNConectarBaseDeDatos.Enabled = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog1.ShowDialog();
            this.TXTRutaArchivo.Text = this.folderBrowserDialog1.SelectedPath;
        }

        private void BTNCargarCampos_Click(object sender, EventArgs e)
        {
        }

        private void BTNConectarBaseDeDatos_Click(object sender, EventArgs e)
        {
            this.BaseDatos._NombreBaseDatos = this.LBBaseDatos.SelectedValue.ToString();
            this.BaseDatos.ConnectionString = "data source=" + this.BaseDatos.NombreServidor + ";initial catalog=" + this.BaseDatos.NombreBaseDatos + ";persist security info=False;user id=" + this.BaseDatos.Cuenta + ";workstation id=" + this.BaseDatos.NombreServidor + ";password =" + this.BaseDatos.Password + "; packet size=4096";
            this.TXTWebservices.Text = this.BaseDatos.NombreBaseDatos;
            this.Error2.Text = "data source=" + this.BaseDatos.NombreServidor + ";initial catalog=" + this.BaseDatos.NombreBaseDatos + ";persist security info=False;user id=" + this.BaseDatos.Cuenta + ";workstation id=" + this.BaseDatos.NombreServidor + ";password =" + this.BaseDatos.Password + "; packet size=4096";
            this.LBTablas.Items.Clear();
            this.LBTablas.Refresh();
            try
            {
                DataSet ds = new DataSet("Tabla");
                ds = this.ImportarSQL.TablasSqlServer(this.BaseDatos.ConnectionString);
                this.dataGrid1.DataSource = ds.Tables["table"];
                this.dataGrid1.Refresh();
                this.LBTablas.DataSource = ds.Tables["table"];
                this.LBTablas.DisplayMember = "TABLE_NAME";
                this.LBTablas.ValueMember = "TABLE_NAME";
                this.LBTablas.Refresh();
                this.Error1.Text = "Conexion Exitosa... Puede continuar";
                this.Error1.ForeColor = Color.Blue;
                this.BaseDatos._Conectado = true;
            }
            catch
            {
                this.Error1.Text = "La conexi\x00f3n ha fallado...";
                this.Error1.ForeColor = Color.Red;
                this.BaseDatos.Conectado = false;
            }
        }

        private void BTNConectarServidor_Click(object sender, EventArgs e)
        {
            this.Error1.Text = "Conectando a la Base de datos...";
            this.Error1.ForeColor = Color.Blue;
            this.BaseDatos._Cuenta = this.TXTUser.Text;
            this.BaseDatos._NombreBaseDatos = "master";
            this.BaseDatos._NombreServidor = this.TXTSever.Text;
            this.BaseDatos._Password = this.TXTPass.Text;
            this.Error2.Text = "data source=" + this.BaseDatos.NombreServidor + ";initial catalog=" + this.BaseDatos.NombreBaseDatos + ";persist security info=False;user id=" + this.BaseDatos.Cuenta + ";workstation id=" + this.BaseDatos.NombreServidor + ";password =" + this.BaseDatos.Password + "; packet size=4096";
            this.BaseDatos.ConnectionString = "data source=" + this.BaseDatos.NombreServidor + ";initial catalog=" + this.BaseDatos.NombreBaseDatos + ";persist security info=False;user id=" + this.BaseDatos.Cuenta + ";workstation id=" + this.BaseDatos.NombreServidor + ";password =" + this.BaseDatos.Password + "; packet size=4096";
            try
            {
                DataSet dsResultados = new DataSet();
                SqlConnection MiConexion = new SqlConnection(this.BaseDatos.ConnectionString);
                SqlDataAdapter MiDataAdapter = new SqlDataAdapter();
                MiConexion.Open();
                string Sql = "sp_databases";
                SqlCommand MiCommand = new SqlCommand(Sql, MiConexion)
                {
                    CommandType = CommandType.Text
                };
                MiDataAdapter.SelectCommand = MiCommand;
                DataSet ds = new DataSet("Tabla");
                MiDataAdapter.Fill(ds);
                MiConexion.Close();
                this.LBBaseDatos.DataSource = ds.Tables["table"];
                this.LBBaseDatos.DisplayMember = "DATABASE_NAME";
                this.LBBaseDatos.ValueMember = "DATABASE_NAME";
                this.LBBaseDatos.Refresh();
                this.Error1.Text = "Conexion Exitosa... Puede continuar";
                this.Error1.ForeColor = Color.Blue;
                this.BaseDatos._Conectado = true;
            }
            catch
            {
                this.Error1.Text = "La conexi\x00f3n ha fallado...";
                this.Error1.ForeColor = Color.Red;
                this.BaseDatos.Conectado = false;
            }
        }

        private void CargarCampos_Click(object sender, EventArgs e)
        {
            this.RTBCodigoGenerado.Text = "//CODIGO D4VYNCY CONSULTAR CORREO D4VYNCY@HOTMAIL.COM";
            this.BTNGenerarCodigo.Enabled = false;
            string comillasIgual = "\" = '\"".ToString() + "\"".Substring(1);
            if (this.CLBSeleccionCodigo.SelectedItem.ToString() == "Entidades")
            {
                this.CrearLasEntidades();
            }
            if (this.CLBSeleccionCodigo.SelectedItem.ToString() == "Controladoras")
            {
                this.CrearLasControladoras();
            }
            if (this.CLBSeleccionCodigo.SelectedItem.ToString() == "WebMetodos")
            {
                this.CrearWCF();
            }
            this.RTBCodigoGenerado.Focus();
            this.RTBCodigoGenerado.SelectAll();
        }

        private string CrearDTO(string nombre, string ruta)
        {
            DataSet ds = new DataSet();
            ds.Tables.Add(nombre);
            new SqlDataAdapter("SELECT * FROM " + nombre, this.Error2.Text.ToString()).FillSchema(ds, SchemaType.Mapped, nombre);
            ds.WriteXmlSchema(ruta + "DTO" + nombre + ".xsd");
            return nombre;
        }

        public void CrearElNegocio()
        {
            int i;
            string comillasIgual = "\" = '\"".ToString() + "\"".Substring(1);
            string varT = this.comi + "T" + this.comi;
            string tipoDato = "";
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "using System;" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "using System.Collections.Generic;" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "using System.Linq;" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "using System.Text;" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "using System.Data;" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "using System.Data.Common;" + Environment.NewLine;
            string strCadena1 = this.RTBCodigoGenerado.Text;
            this.RTBCodigoGenerado.Text = strCadena1 + "using Wcf" + this.BaseDatos.NombreBaseDatos.ToString() + ".Entidades;" + Environment.NewLine;
            strCadena1 = this.RTBCodigoGenerado.Text;
            this.RTBCodigoGenerado.Text = strCadena1 + "using Wcf" + this.BaseDatos.NombreBaseDatos.ToString() + ".Datos;" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + Environment.NewLine;
            strCadena1 = this.RTBCodigoGenerado.Text;
            this.RTBCodigoGenerado.Text = strCadena1 + "namespace Wcf" + this.BaseDatos.NombreBaseDatos.ToString() + ".Negocios " + Environment.NewLine + "{" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + Environment.NewLine;
            strCadena1 = this.RTBCodigoGenerado.Text;
            this.RTBCodigoGenerado.Text = strCadena1 + "public class cls" + this.ImportarSQL.tablaNombre + " : cls" + this.ImportarSQL.tablaNombre + "DA" + Environment.NewLine + "{" + Environment.NewLine;
            strCadena1 = this.RTBCodigoGenerado.Text;
            this.RTBCodigoGenerado.Text = strCadena1 + "public cls" + this.ImportarSQL.tablaNombre + "()" + Environment.NewLine + "{" + Environment.NewLine;
            for (i = 0; i <= (this.ImportarSQL.ColumnasI.Count - 1); i++)
            {
                tipoDato = this.ImportarSQL.TypoColumnasI[i].ToString();
                if (tipoDato != "Byte[]")
                {
                    strCadena1 = this.RTBCodigoGenerado.Text;
                    this.RTBCodigoGenerado.Text = strCadena1 + "this." + this.ImportarSQL.ColumnasI[i].ToString() + " = " + this.valorInicialDato(tipoDato) + ";" + Environment.NewLine;
                }
            }
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "}" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + Environment.NewLine;
            strCadena1 = this.RTBCodigoGenerado.Text;
            this.RTBCodigoGenerado.Text = strCadena1 + "public cls" + this.ImportarSQL.tablaNombre + "(int Id" + this.ImportarSQL.tablaNombre + ")" + Environment.NewLine + "{" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "}" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + Environment.NewLine;
            strCadena1 = this.RTBCodigoGenerado.Text;
            this.RTBCodigoGenerado.Text = strCadena1 + "public cls" + this.ImportarSQL.tablaNombre + " cls" + this.ImportarSQL.tablaNombre + "PorId" + this.ImportarSQL.tablaNombre + "()" + Environment.NewLine + "{" + Environment.NewLine;
            strCadena1 = this.RTBCodigoGenerado.Text;
            this.RTBCodigoGenerado.Text = strCadena1 + "using (IDataReader dr = Obtiene" + this.ImportarSQL.tablaNombre + "(this))" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "{" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "if (dr.Read())" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "{" + Environment.NewLine;
            for (i = 0; i <= (this.ImportarSQL.ColumnasI.Count - 1); i++)
            {
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + this.TipoDeDatoDataRowParaLaData(this.ImportarSQL.TypoColumnasI[i].ToString(), this.ImportarSQL.ColumnasI[i].ToString(), this.ImportarSQL.tablaNombre.ToString()) + Environment.NewLine;
            }
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "}" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "}" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "return this;" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "}" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + Environment.NewLine;
            strCadena1 = this.RTBCodigoGenerado.Text;
            this.RTBCodigoGenerado.Text = strCadena1 + "public int Agrega" + this.ImportarSQL.tablaNombre + "()" + Environment.NewLine + "{" + Environment.NewLine;
            strCadena1 = this.RTBCodigoGenerado.Text;
            this.RTBCodigoGenerado.Text = strCadena1 + "cls" + this.ImportarSQL.tablaNombre + "DA ad = new cls" + this.ImportarSQL.tablaNombre + "DA();" + Environment.NewLine;
            strCadena1 = this.RTBCodigoGenerado.Text;
            this.RTBCodigoGenerado.Text = strCadena1 + "return ad.Agrega" + this.ImportarSQL.tablaNombre + "(this);" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "}" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + Environment.NewLine;
            strCadena1 = this.RTBCodigoGenerado.Text;
            this.RTBCodigoGenerado.Text = strCadena1 + "public int Modifica" + this.ImportarSQL.tablaNombre + "()" + Environment.NewLine + "{" + Environment.NewLine;
            strCadena1 = this.RTBCodigoGenerado.Text;
            this.RTBCodigoGenerado.Text = strCadena1 + "cls" + this.ImportarSQL.tablaNombre + "DA ad = new cls" + this.ImportarSQL.tablaNombre + "DA();" + Environment.NewLine;
            strCadena1 = this.RTBCodigoGenerado.Text;
            this.RTBCodigoGenerado.Text = strCadena1 + "return ad.Modifica" + this.ImportarSQL.tablaNombre + "(this);" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "}" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + Environment.NewLine;
            strCadena1 = this.RTBCodigoGenerado.Text;
            this.RTBCodigoGenerado.Text = strCadena1 + "public int Elimina" + this.ImportarSQL.tablaNombre + "()" + Environment.NewLine + "{" + Environment.NewLine;
            strCadena1 = this.RTBCodigoGenerado.Text;
            this.RTBCodigoGenerado.Text = strCadena1 + "cls" + this.ImportarSQL.tablaNombre + "DA ad = new cls" + this.ImportarSQL.tablaNombre + "DA();" + Environment.NewLine;
            strCadena1 = this.RTBCodigoGenerado.Text;
            this.RTBCodigoGenerado.Text = strCadena1 + "return ad.Elimina" + this.ImportarSQL.tablaNombre + "(this);" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "}" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "}" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "}" + Environment.NewLine;
        }
        private string comi=@"""";
        public void CrearLasControladoras()
        {
            int i;
            object strCadena0002;
            string comillasIgual = "\" = '\"".ToString() + "\"".Substring(1);
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "//CODIGO GENERADO POR davidserrudo@gmail.com" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "using System;" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "using System.Data;" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "using System.Collections.Generic;" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "using System.Linq;" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "using System.Text;" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "using System.Data.Common;" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "using Microsoft.Practices.EnterpriseLibrary.Data;" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "using Microsoft.Practices.EnterpriseLibrary.Common;" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "//using Microsoft.ApplicationBlocks.Data;" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "using System.Data.SqlClient;" + Environment.NewLine;
            string strCadena1 = this.RTBCodigoGenerado.Text;
            this.RTBCodigoGenerado.Text = strCadena1 + "using Wcf" + this.BaseDatos.NombreBaseDatos.ToString() + ".Entidades;" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + Environment.NewLine;
            strCadena1 = this.RTBCodigoGenerado.Text;
            this.RTBCodigoGenerado.Text = strCadena1 + "namespace Wcf" + this.BaseDatos.NombreBaseDatos.ToString() + ".Datos " + Environment.NewLine + "{" + Environment.NewLine;
            strCadena1 = this.RTBCodigoGenerado.Text;
            this.RTBCodigoGenerado.Text = strCadena1 + "public class cls" + this.ImportarSQL.tablaNombre + "DA : cls" + this.ImportarSQL.tablaNombre + "BE" + Environment.NewLine + "{" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "Database db = null;" + Environment.NewLine;
            strCadena1 = this.RTBCodigoGenerado.Text;
            this.RTBCodigoGenerado.Text = strCadena1 + "//DataSet dto" + this.ImportarSQL.tablaNombre + ";" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + Environment.NewLine;
            strCadena1 = this.RTBCodigoGenerado.Text;
            this.RTBCodigoGenerado.Text = strCadena1 + "public cls" + this.ImportarSQL.tablaNombre + "DA()" + Environment.NewLine + "{" + Environment.NewLine;
            strCadena1 = this.RTBCodigoGenerado.Text;
            this.RTBCodigoGenerado.Text = strCadena1 + "db = DatabaseFactory.CreateDatabase(\"Con" + this.BaseDatos.NombreBaseDatos.ToString() + "\");" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "}" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + Environment.NewLine;
            strCadena1 = this.RTBCodigoGenerado.Text;
            this.RTBCodigoGenerado.Text = strCadena1 + "public IDataReader Obtiene" + this.ImportarSQL.tablaNombre + "(cls" + this.ImportarSQL.tablaNombre + "BE p" + this.ImportarSQL.tablaNombre.ToString() + ")" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "{" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "DbCommand cmd = db.GetStoredProcCommand(\"pag" + this.ImportarSQL.tablaNombre + "\",2";
            for (i = 0; i <= (this.ImportarSQL.ColumnasI.Count - 1); i++)
            {
                strCadena0002 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = string.Concat(new object[] { strCadena0002, ", p", this.ImportarSQL.tablaNombre.ToString(), ".", this.ImportarSQL.ColumnasI[i] });
            }
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + ");" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "IDataReader dr = db.ExecuteReader(cmd);" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "return dr;" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "}" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + Environment.NewLine;
            strCadena1 = this.RTBCodigoGenerado.Text;
            this.RTBCodigoGenerado.Text = strCadena1 + "public int Agrega" + this.ImportarSQL.tablaNombre + "(cls" + this.ImportarSQL.tablaNombre + "BE p" + this.ImportarSQL.tablaNombre.ToString() + ")" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "{" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "DbCommand cmd = db.GetStoredProcCommand(\"pag" + this.ImportarSQL.tablaNombre + "\",1";
            for (i = 0; i <= (this.ImportarSQL.ColumnasI.Count - 1); i++)
            {
                strCadena0002 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = string.Concat(new object[] { strCadena0002, ", p", this.ImportarSQL.tablaNombre.ToString(), ".", this.ImportarSQL.ColumnasI[i] });
            }
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + ");" + Environment.NewLine;
            strCadena1 = this.RTBCodigoGenerado.Text;
            this.RTBCodigoGenerado.Text = strCadena1 + "int nId" + this.ImportarSQL.tablaNombre + " = 0;" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "using (IDataReader dr = db.ExecuteReader(cmd))" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "{" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "if (dr.Read())" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "{" + Environment.NewLine;
            strCadena1 = this.RTBCodigoGenerado.Text;
            this.RTBCodigoGenerado.Text = strCadena1 + "nId" + this.ImportarSQL.tablaNombre + " = Convert.ToInt32(dr[" + this.comi + "Id" + this.ImportarSQL.tablaNombre + this.comi + "]);" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "}" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "}" + Environment.NewLine;
            strCadena1 = this.RTBCodigoGenerado.Text;
            this.RTBCodigoGenerado.Text = strCadena1 + "return nId" + this.ImportarSQL.tablaNombre + ";" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "}" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + Environment.NewLine;
            strCadena1 = this.RTBCodigoGenerado.Text;
            this.RTBCodigoGenerado.Text = strCadena1 + "public int Modifica" + this.ImportarSQL.tablaNombre + "(cls" + this.ImportarSQL.tablaNombre + "BE pPaq)" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "{" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "DbCommand cmd = db.GetStoredProcCommand(\"pag" + this.ImportarSQL.tablaNombre + "\",3";
            for (i = 0; i <= (this.ImportarSQL.ColumnasI.Count - 1); i++)
            {
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + ", pPaq." + this.ImportarSQL.ColumnasI[i];
            }
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + ");" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "return db.ExecuteNonQuery(cmd);" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "}" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + Environment.NewLine;
            strCadena1 = this.RTBCodigoGenerado.Text;
            this.RTBCodigoGenerado.Text = strCadena1 + "public int Elimina" + this.ImportarSQL.tablaNombre + "(cls" + this.ImportarSQL.tablaNombre + "BE p" + this.ImportarSQL.tablaNombre.ToString() + ")" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "{" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "DbCommand cmd = db.GetStoredProcCommand(\"pag" + this.ImportarSQL.tablaNombre + "\",4";
            for (i = 0; i <= (this.ImportarSQL.ColumnasI.Count - 1); i++)
            {
                strCadena0002 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = string.Concat(new object[] { strCadena0002, ", p", this.ImportarSQL.tablaNombre.ToString(), ".", this.ImportarSQL.ColumnasI[i] });
            }
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + ");" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "return db.ExecuteNonQuery(cmd);" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "}" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + Environment.NewLine;
            strCadena1 = this.RTBCodigoGenerado.Text;
            this.RTBCodigoGenerado.Text = strCadena1 + "public DataSet Obtienepav" + this.ImportarSQL.tablaNombre + "(object[] pParametros)" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "{" + Environment.NewLine;
            strCadena1 = this.RTBCodigoGenerado.Text;
            this.RTBCodigoGenerado.Text = strCadena1 + "DbCommand cmd = db.GetStoredProcCommand(" + this.comi + "pav" + this.ImportarSQL.tablaNombre + this.comi + " , pParametros);" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "return db.ExecuteDataSet(cmd);" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "}" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "}" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "}" + Environment.NewLine;
        }

        public void CrearLasEntidades()
        {
            string strCadena1 = this.RTBCodigoGenerado.Text;
            this.RTBCodigoGenerado.Text = strCadena1 + "using System;" + Environment.NewLine + "using System.Collections.Generic;" + Environment.NewLine + "using System.Linq;" + Environment.NewLine + "using System.Text;" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + Environment.NewLine;
            strCadena1 = this.RTBCodigoGenerado.Text;
            this.RTBCodigoGenerado.Text = strCadena1 + "namespace Wcf" + this.BaseDatos.NombreBaseDatos.ToString() + ".Entidades " + Environment.NewLine + "{" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + Environment.NewLine;
            strCadena1 = this.RTBCodigoGenerado.Text;
            this.RTBCodigoGenerado.Text = strCadena1 + "public class cls" + this.ImportarSQL.tablaNombre + "BE" + Environment.NewLine + "{" + Environment.NewLine;
            for (int i = 0; i <= (this.ImportarSQL.ColumnasI.Count - 1); i++)
            {
                string tipoDato = this.validarDato(this.ImportarSQL.TypoColumnasI[i].ToString());
                object strCadena0002 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = string.Concat(new object[] { strCadena0002, "public ", tipoDato, " ", this.ImportarSQL.ColumnasI[i], " { get; set; }", Environment.NewLine });
            }
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "}" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "}";
        }

        public void CrearPersonalizado()
        {
            this.RTBCodigoGenerado.Text = "//CODIGO GENERADO POR davidserrudo@gmail.com" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "using System;" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "using System.Collections.Generic;" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "using System.Linq;" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "using System.Web;" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "using Microsoft.Practices.EnterpriseLibrary.Data;" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "using System.Data;" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "using System.Data.Common;" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "namespace Wcf" + this.BaseDatos.NombreBaseDatos.ToString() + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "{" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "public class clsp" + this.BaseDatos.NombreBaseDatos.ToString() + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "{" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "Database db = null;" + Environment.NewLine;
            string strCadena1 = this.RTBCodigoGenerado.Text;
            this.RTBCodigoGenerado.Text = strCadena1 + "public clsp" + this.BaseDatos.NombreBaseDatos.ToString() + "()" + Environment.NewLine;
            strCadena1 = this.RTBCodigoGenerado.Text;
            this.RTBCodigoGenerado.Text = strCadena1 + "{ db = DatabaseFactory.CreateDatabase(\"Con" + this.BaseDatos.NombreBaseDatos.ToString() + "\"); }" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "public DataSet ProcedureParametro(string Procedimiento, params object[] pParametros)" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "{" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "DbCommand cmd = db.GetStoredProcCommand(Procedimiento, pParametros);" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "return db.ExecuteDataSet(cmd);" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "}" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "public int EjecutaConsulta(string Consulta)" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "{" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "DbCommand cmd = db.GetSqlStringCommand(Consulta);" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "return db.ExecuteNonQuery(cmd);" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "}" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "}" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "}" + Environment.NewLine;
            string directorio = this.TXTRutaArchivo.Text + @"\cls" + this.BaseDatos.NombreBaseDatos.ToString();
            this.RTBCodigoGenerado.SaveFile(directorio + @"\clsp" + this.BaseDatos.NombreBaseDatos.ToString() + ".cs", RichTextBoxStreamType.PlainText);
            this.RTBCodigoGenerado.SaveFile(directorio + @"\clsp" + this.BaseDatos.NombreBaseDatos.ToString() + ".cs", RichTextBoxStreamType.PlainText);
        }

        public void CrearWCF()
        {
            string comillasSeguidas = "\"\"";
            this.RTBCodigoGenerado.Text = "//CODIGO GENERADO POR davidserrudo@gmail.com" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "using System;" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "using System.Collections.Generic;" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "using System.Linq;" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "using System.Runtime.Serialization;" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "using System.ServiceModel;" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "using System.ServiceModel.Web;" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "using System.Text;" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "using System.Data;" + Environment.NewLine;
            string strCadena1 = this.RTBCodigoGenerado.Text;
            this.RTBCodigoGenerado.Text = strCadena1 + "using Wcf" + this.BaseDatos.NombreBaseDatos.ToString() + ".Negocios;" + Environment.NewLine;
            strCadena1 = this.RTBCodigoGenerado.Text;
            this.RTBCodigoGenerado.Text = strCadena1 + "using Wcf" + this.BaseDatos.NombreBaseDatos.ToString() + ".Datos;" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "namespace Wcf" + this.BaseDatos.NombreBaseDatos.ToString() + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "{" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "public class Service1 : IService1" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "{" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "// con n parametros" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "public DataSet ProcedureConParametro(string Procedimiento,object[] pParametros)" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "{" + Environment.NewLine;
            strCadena1 = this.RTBCodigoGenerado.Text;
            this.RTBCodigoGenerado.Text = strCadena1 + "clsp" + this.BaseDatos.NombreBaseDatos.ToString() + " ad = new clsp" + this.BaseDatos.NombreBaseDatos.ToString() + "();" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "return ad.ProcedureParametro(Procedimiento,pParametros);" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "}" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "// con 8 parametros" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "public DataSet ProcedureParametro(string Procedimiento, string Campo, string Valor, string Campo1, string Valor1, string Campo2, string Valor2, string Campo3, string Valor3, string Campo4, string Valor4, string Campo5, string Valor5, string Campo6, string Valor6, string Campo7, string Valor7)" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "{" + Environment.NewLine;
            strCadena1 = this.RTBCodigoGenerado.Text;
            this.RTBCodigoGenerado.Text = strCadena1 + "object[] pParametros = new object[] {" + comillasSeguidas + "," + comillasSeguidas + "," + comillasSeguidas + "," + comillasSeguidas + "," + comillasSeguidas + "," + comillasSeguidas + "," + comillasSeguidas + "," + comillasSeguidas + "," + comillasSeguidas + "," + comillasSeguidas + "," + comillasSeguidas + "," + comillasSeguidas + "," + comillasSeguidas + "," + comillasSeguidas + "," + comillasSeguidas + "," + comillasSeguidas + "};" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[0] = Campo;" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[1] = Valor;" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[2] = Campo1;" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[3] = Valor1;" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[4] = Campo2;" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[5] = Valor2;" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[6] = Campo3;" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[7] = Valor3;" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[8] = Campo4;" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[9] = Valor4;" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[10] = Campo5;" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[11] = Valor5;" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[12] = Campo6;" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[13] = Valor6;" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[14] = Campo7;" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[15] = Valor7;" + Environment.NewLine;
            strCadena1 = this.RTBCodigoGenerado.Text;
            this.RTBCodigoGenerado.Text = strCadena1 + "clsp" + this.BaseDatos.NombreBaseDatos.ToString() + " ad = new clsp" + this.BaseDatos.NombreBaseDatos.ToString() + "();" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "return ad.ProcedureParametro(Procedimiento,pParametros);" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "}" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "public int EjecutaConsulta(string Consulta)" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "{" + Environment.NewLine;
            strCadena1 = this.RTBCodigoGenerado.Text;
            this.RTBCodigoGenerado.Text = strCadena1 + "clsp" + this.BaseDatos.NombreBaseDatos.ToString() + " ad = new clsp" + this.BaseDatos.NombreBaseDatos.ToString() + "();" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "return ad.EjecutaConsulta(Consulta);" + Environment.NewLine;
            this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "}" + Environment.NewLine;
            string NombreTabla = "";
            for (int tab = 0; tab < this.LBTablas.Items.Count; tab++)
            {
                this.LBTablas.SelectedIndex = tab;
                if (this.LBTablas.SelectedValue.ToString().Substring(0, 2) == "cl")
                {
                    NombreTabla = this.LBTablas.SelectedValue.ToString().Substring(2);
                }
                else
                {
                    NombreTabla = this.LBTablas.SelectedValue.ToString().Substring(3);
                }
                if (NombreTabla != "dtproperties")
                {
                    this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "#region " + NombreTabla + Environment.NewLine;
                    strCadena1 = this.RTBCodigoGenerado.Text;
                    this.RTBCodigoGenerado.Text = strCadena1 + "public cls" + NombreTabla + " Obtiene" + NombreTabla + "(int Id" + NombreTabla + ")" + Environment.NewLine;
                    this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "{" + Environment.NewLine;
                    strCadena1 = this.RTBCodigoGenerado.Text;
                    this.RTBCodigoGenerado.Text = strCadena1 + "cls" + NombreTabla + " o" + NombreTabla + " = new cls" + NombreTabla + "();" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "o" + NombreTabla + ".Id" + NombreTabla + " = Id" + NombreTabla + ";" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "return o" + NombreTabla + ".cls" + NombreTabla + "PorId" + NombreTabla + "();" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "}" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "public int Agrega" + NombreTabla + "(cls" + NombreTabla + " o" + NombreTabla + ")" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "{return o" + NombreTabla + ".Agrega" + NombreTabla + "();}" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "public int Modifica" + NombreTabla + "(cls" + NombreTabla + " o" + NombreTabla + ")" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "{return o" + NombreTabla + ".Modifica" + NombreTabla + "();}" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "public int Elimina" + NombreTabla + "(int Id" + NombreTabla + ")" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "{" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "cls" + NombreTabla + " o" + NombreTabla + " = new cls" + NombreTabla + "();" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "o" + NombreTabla + ".Id" + NombreTabla + " = Id" + NombreTabla + ";" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "return o" + NombreTabla + ".Elimina" + NombreTabla + "();}" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "//seleccion con parametros" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "public DataSet Obtienepav" + NombreTabla + "1(string Campo, string Valor)" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "{" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "object[] pParametros = new object[] { " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + " };" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[0] = Campo;" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[1] = Valor;" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "pParametros[2] = " + this.comi + "T" + this.comi + ";" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "pParametros[3] = " + comillasSeguidas + ";" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "pParametros[4] = " + this.comi + "T" + this.comi + ";" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "pParametros[5] = " + comillasSeguidas + ";" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "pParametros[6] = " + this.comi + "T" + this.comi + ";" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "pParametros[7] = " + comillasSeguidas + ";" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "pParametros[8] = " + this.comi + "T" + this.comi + ";" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "pParametros[9] = " + comillasSeguidas + ";" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "pParametros[10] = " + this.comi + "T" + this.comi + ";" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "pParametros[11] = " + comillasSeguidas + ";" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "pParametros[12] = " + this.comi + "T" + this.comi + ";" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "pParametros[13] = " + comillasSeguidas + ";" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "pParametros[14] = " + this.comi + "T" + this.comi + ";" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "pParametros[15] = " + comillasSeguidas + ";" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "cls" + NombreTabla + "DA ad = new cls" + NombreTabla + "DA();" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "return ad.Obtienepav" + NombreTabla + "(pParametros);" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "}" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "public DataSet Obtienepav" + NombreTabla + "2(string Campo, string Valor,string Campo1, string Valor1)" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "{" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "object[] pParametros = new object[] { " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + " };" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[0] = Campo;" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[1] = Valor;" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[2] = Campo1;" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[3] = Valor1;" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "pParametros[4] = " + this.comi + "T" + this.comi + ";" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "pParametros[5] = " + comillasSeguidas + ";" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "pParametros[6] = " + this.comi + "T" + this.comi + ";" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "pParametros[7] = " + comillasSeguidas + ";" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "pParametros[8] = " + this.comi + "T" + this.comi + ";" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "pParametros[9] = " + comillasSeguidas + ";" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "pParametros[10] = " + this.comi + "T" + this.comi + ";" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "pParametros[11] = " + comillasSeguidas + ";" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "pParametros[12] = " + this.comi + "T" + this.comi + ";" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "pParametros[13] = " + comillasSeguidas + ";" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "pParametros[14] = " + this.comi + "T" + this.comi + ";" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "pParametros[15] = " + comillasSeguidas + ";" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "cls" + NombreTabla + "DA ad = new cls" + NombreTabla + "DA();" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "return ad.Obtienepav" + NombreTabla + "(pParametros);" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "}" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "public DataSet Obtienepav" + NombreTabla + "3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2)" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "{" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "object[] pParametros = new object[] { " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + " };" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[0] = Campo;" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[1] = Valor;" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[2] = Campo1;" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[3] = Valor1;" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[4] = Campo2;" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[5] = Valor2;" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "pParametros[6] = " + this.comi + "T" + this.comi + ";" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "pParametros[7] = " + comillasSeguidas + ";" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "pParametros[8] = " + this.comi + "T" + this.comi + ";" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "pParametros[9] = " + comillasSeguidas + ";" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "pParametros[10] = " + this.comi + "T" + this.comi + ";" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "pParametros[11] = " + comillasSeguidas + ";" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "pParametros[12] = " + this.comi + "T" + this.comi + ";" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "pParametros[13] = " + comillasSeguidas + ";" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "pParametros[14] = " + this.comi + "T" + this.comi + ";" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "pParametros[15] = " + comillasSeguidas + ";" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "cls" + NombreTabla + "DA ad = new cls" + NombreTabla + "DA();" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "return ad.Obtienepav" + NombreTabla + "(pParametros);" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "}" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "public DataSet Obtienepav" + NombreTabla + "4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3)" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "{" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "object[] pParametros = new object[] { " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + " };" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[0] = Campo;" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[1] = Valor;" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[2] = Campo1;" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[3] = Valor1;" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[4] = Campo2;" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[5] = Valor2;" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[6] = Campo3;" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[7] = Valor3;" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "pParametros[8] = " + this.comi + "T" + this.comi + ";" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "pParametros[9] = " + comillasSeguidas + ";" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "pParametros[10] = " + this.comi + "T" + this.comi + ";" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "pParametros[11] = " + comillasSeguidas + ";" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "pParametros[12] = " + this.comi + "T" + this.comi + ";" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "pParametros[13] = " + comillasSeguidas + ";" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "pParametros[14] = " + this.comi + "T" + this.comi + ";" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "pParametros[15] = " + comillasSeguidas + ";" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "cls" + NombreTabla + "DA ad = new cls" + NombreTabla + "DA();" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "return ad.Obtienepav" + NombreTabla + "(pParametros);" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "}" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "public DataSet Obtienepav" + NombreTabla + "5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7)" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "{" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "object[] pParametros = new object[] { " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + ", " + comillasSeguidas + " };" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[0] = Campo;" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[1] = Valor;" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[2] = Campo1;" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[3] = Valor1;" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[4] = Campo2;" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[5] = Valor2;" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[6] = Campo3;" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[7] = Valor3;" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[8] = Campo4;" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[9] = Valor4;" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[10] = Campo5;" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[11] = Valor5;" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[12] = Campo6;" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[13] = Valor6;" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[14] = Campo7;" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "pParametros[15] = Valor7;" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "cls" + NombreTabla + "DA ad = new cls" + NombreTabla + "DA();" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "return ad.Obtienepav" + NombreTabla + "(pParametros);" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "}" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "#endregion " + Environment.NewLine;
            }
        }
        this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "}" + Environment.NewLine;
        this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "}" + Environment.NewLine;
        string directorio = this.TXTRutaArchivo.Text + @"\cls" + this.BaseDatos.NombreBaseDatos.ToString();
        if (NombreTabla != "dtproperties")
        {
            this.RTBCodigoGenerado.SaveFile(directorio + @"\Service1.svc.cs", RichTextBoxStreamType.PlainText);
            this.RTBCodigoGenerado.SaveFile(directorio + @"\Service1.svc.cs", RichTextBoxStreamType.PlainText);
        }
    }

    public void CrearWCFInterface()
    {
        this.RTBCodigoGenerado.Text = "//CODIGO GENERADO POR davidserrudo@gmail.com" + Environment.NewLine;
        this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "using System;" + Environment.NewLine;
        this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "using System.Collections.Generic;" + Environment.NewLine;
        this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "using System.Linq;" + Environment.NewLine;
        this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "using System.Runtime.Serialization;" + Environment.NewLine;
        this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "using System.ServiceModel;" + Environment.NewLine;
        this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "using System.ServiceModel.Web;" + Environment.NewLine;
        this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "using System.Text;" + Environment.NewLine;
        this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "using System.Data;" + Environment.NewLine;
        string strCadena1 = this.RTBCodigoGenerado.Text;
        this.RTBCodigoGenerado.Text = strCadena1 + "using Wcf" + this.BaseDatos.NombreBaseDatos.ToString() + ".Negocios;" + Environment.NewLine;
        strCadena1 = this.RTBCodigoGenerado.Text;
        this.RTBCodigoGenerado.Text = strCadena1 + "using Wcf" + this.BaseDatos.NombreBaseDatos.ToString() + ".Datos;" + Environment.NewLine;
        this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + Environment.NewLine;
        this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "namespace Wcf" + this.BaseDatos.NombreBaseDatos.ToString() + Environment.NewLine;
        this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "{" + Environment.NewLine;
        this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "[ServiceContract]" + Environment.NewLine;
        this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "public interface IService1" + Environment.NewLine;
        this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "{" + Environment.NewLine;
        this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "[OperationContract]" + Environment.NewLine;
        this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "DataSet ProcedureConParametro(string Procedimiento,object[] pParametros);" + Environment.NewLine;
        this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "[OperationContract]" + Environment.NewLine;
        this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "DataSet ProcedureParametro(string Procedimiento, string Campo, string Valor, string Campo1, string Valor1, string Campo2, string Valor2, string Campo3, string Valor3, string Campo4, string Valor4, string Campo5, string Valor5, string Campo6, string Valor6, string Campo7, string Valor7);" + Environment.NewLine;
        this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "[OperationContract]" + Environment.NewLine;
        this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "int EjecutaConsulta(string Consulta);" + Environment.NewLine;
        string NombreTabla = "";
        for (int tab = 0; tab < this.LBTablas.Items.Count; tab++)
        {
            this.LBTablas.SelectedIndex = tab;
            if (this.LBTablas.SelectedValue.ToString().Substring(0, 2) == "cl")
            {
                NombreTabla = this.LBTablas.SelectedValue.ToString().Substring(2);
            }
            else
            {
                NombreTabla = this.LBTablas.SelectedValue.ToString().Substring(3);
            }
            if (NombreTabla != "dtproperties")
            {
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "#region " + NombreTabla + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "[OperationContract]" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "cls" + NombreTabla + " Obtiene" + NombreTabla + "(int Id" + NombreTabla + ");" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "[OperationContract]" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "int Agrega" + NombreTabla + "(cls" + NombreTabla + " o" + NombreTabla + ");" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "[OperationContract]" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "int Modifica" + NombreTabla + "(cls" + NombreTabla + " o" + NombreTabla + ");" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "[OperationContract]" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "int Elimina" + NombreTabla + "(int Id" + NombreTabla + ");" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "[OperationContract]" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "DataSet Obtienepav" + NombreTabla + "1(string Campo, string Valor);" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "[OperationContract]" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "DataSet Obtienepav" + NombreTabla + "2(string Campo, string Valor,string Campo1, string Valor1);" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "[OperationContract]" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "DataSet Obtienepav" + NombreTabla + "3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "[OperationContract]" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "DataSet Obtienepav" + NombreTabla + "4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "[OperationContract]" + Environment.NewLine;
                strCadena1 = this.RTBCodigoGenerado.Text;
                this.RTBCodigoGenerado.Text = strCadena1 + "DataSet Obtienepav" + NombreTabla + "5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);" + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + Environment.NewLine;
                this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "#endregion " + Environment.NewLine;
            }
        }
        this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "}" + Environment.NewLine;
        this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "}" + Environment.NewLine;
        string directorio = this.TXTRutaArchivo.Text + @"\cls" + this.BaseDatos.NombreBaseDatos.ToString();
        if (NombreTabla != "dtproperties")
        {
            this.RTBCodigoGenerado.SaveFile(directorio + @"\IService1.cs", RichTextBoxStreamType.PlainText);
            this.RTBCodigoGenerado.SaveFile(directorio + @"\IService1.cs", RichTextBoxStreamType.PlainText);
        }
    }

    public string datoSQL(string dato)
    {
        if (dato == "text")
        {
            dato = "Text";
        }
        if (dato == "varchar")
        {
            dato = "NVarChar,50";
        }
        if (dato == "numeric")
        {
            dato = "Decimal,0";
        }
        if (dato == "Int32")
        {
            dato = "Int,0";
        }
        if (dato == "Int16")
        {
            dato = "Int,0";
        }
        if (dato == "Decimal")
        {
            dato = "Decimal,0";
        }
        if (dato == "Char")
        {
            dato = "Char";
        }
        if (dato == "String")
        {
            dato = "NVarChar,50";
        }
        if (dato == "Text")
        {
            dato = "Text";
        }
        if (dato == "DateTime")
        {
            dato = "DateTime,0";
        }
        if (dato == "Boolean")
        {
            dato = "Bit";
        }
        if (dato == "Double")
        {
            dato = "Float";
        }
        return dato;
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && (this.components != null))
        {
            this.components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void Error2_Click(object sender, EventArgs e)
    {
        try
        {
            DataSet ds = new DataSet("Tabla");
            ds = this.ImportarSQL.TablasSqlServer(this.Error2.Text.ToString());
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                MessageBox.Show(ds.Tables[0].Columns[0].Table.Rows[i].ToString());
            }
        }
        catch
        {
            this.Error1.Text = "falla al momento de cargar los datos";
        }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
    }

    private void GenerarWebServices()
    {
        this.RTBCodigoGenerado.Text = "CODIGO GENERADO POR davidserrudo@gmail.com";
        this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "using System;";
        this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "using System.Web;";
        this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "using System.Web.Services;";
        this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "using System.Web.Services.Protocols;";
        this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "[WebService(Namespace =http://tempuri.org/)] ";
        this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]";
        this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "public class Service : System.Web.Services.WebService";
        this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "{";
        this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "public Service () {";
        this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "//GENERADOR DE WEB SERVICES V 1.0";
        this.RTBCodigoGenerado.Text = this.RTBCodigoGenerado.Text + "}";
    }

    private void guardarArchivoTexto_Click(object sender, EventArgs e)
    {
        string Nombreclase = "";
        if (this.CLBSeleccionCodigo.SelectedItem.ToString() == "Entidades")
        {
            Nombreclase = "EDI" + this.LBTablas.SelectedValue;
        }
        if (this.CLBSeleccionCodigo.SelectedItem.ToString() == "Controladoras")
        {
            Nombreclase = "C" + this.LBTablas.SelectedValue;
        }
        if (this.CLBSeleccionCodigo.SelectedItem.ToString() == "WebMetodos")
        {
            Nombreclase = "WEBMETODO" + this.LBTablas.SelectedValue;
        }
        try
        {
            string nombre = this.TXTRutaArchivo.Text + @"\" + Nombreclase + ".cs";
            this.RTBCodigoGenerado.SaveFile(nombre, RichTextBoxStreamType.PlainText);
        }
        catch
        {
            MessageBox.Show("No se encontro la ruta para guardar este archivo");
        }
    }

    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Error2 = new System.Windows.Forms.Label();
            this.TPAcercaDeD4VYNCY = new System.Windows.Forms.TabControl();
            this.TPFicheros = new System.Windows.Forms.TabPage();
            this.Error1 = new System.Windows.Forms.Label();
            this.TPTablas = new System.Windows.Forms.TabPage();
            this.RTBCodigoGenerado = new System.Windows.Forms.RichTextBox();
            this.BTNCargarCampos = new System.Windows.Forms.Button();
            this.guardarArchivoTexto = new System.Windows.Forms.Button();
            this.LBCampos = new System.Windows.Forms.ListBox();
            this.BTNGenerarCodigo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LBTablas = new System.Windows.Forms.ListBox();
            this.TPGenerarCodigoPasos = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTUsuario = new System.Windows.Forms.TextBox();
            this.TXTContrasena = new System.Windows.Forms.TextBox();
            this.BTNAutenticar = new System.Windows.Forms.Button();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.LBBaseDatos = new System.Windows.Forms.ListBox();
            this.BTNConectarBaseDeDatos = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.TXTSever = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.BTNConectarServidor = new System.Windows.Forms.Button();
            this.TXTPass = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.TXTUser = new System.Windows.Forms.TextBox();
            this.TXTWebservices = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.TXTRutaArchivo = new System.Windows.Forms.TextBox();
            this.CLBSeleccionCodigo = new System.Windows.Forms.CheckedListBox();
            this.BTGenerarAutomaticamente = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TPAcercaDeD4VYNCY.SuspendLayout();
            this.TPFicheros.SuspendLayout();
            this.TPTablas.SuspendLayout();
            this.TPGenerarCodigoPasos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Error2
            // 
            this.Error2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Error2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Error2.Location = new System.Drawing.Point(23, 67);
            this.Error2.Name = "Error2";
            this.Error2.Size = new System.Drawing.Size(635, 23);
            this.Error2.TabIndex = 23;
            this.Error2.Click += new System.EventHandler(this.Error2_Click);
            // 
            // TPAcercaDeD4VYNCY
            // 
            this.TPAcercaDeD4VYNCY.Controls.Add(this.TPFicheros);
            this.TPAcercaDeD4VYNCY.Controls.Add(this.TPTablas);
            this.TPAcercaDeD4VYNCY.Controls.Add(this.TPGenerarCodigoPasos);
            this.TPAcercaDeD4VYNCY.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.TPAcercaDeD4VYNCY.Location = new System.Drawing.Point(18, 448);
            this.TPAcercaDeD4VYNCY.Name = "TPAcercaDeD4VYNCY";
            this.TPAcercaDeD4VYNCY.SelectedIndex = 0;
            this.TPAcercaDeD4VYNCY.Size = new System.Drawing.Size(640, 120);
            this.TPAcercaDeD4VYNCY.TabIndex = 22;
            // 
            // TPFicheros
            // 
            this.TPFicheros.Controls.Add(this.Error1);
            this.TPFicheros.Location = new System.Drawing.Point(4, 22);
            this.TPFicheros.Name = "TPFicheros";
            this.TPFicheros.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.TPFicheros.Size = new System.Drawing.Size(632, 94);
            this.TPFicheros.TabIndex = 4;
            this.TPFicheros.Text = "Ficheros";
            this.TPFicheros.UseVisualStyleBackColor = true;
            // 
            // Error1
            // 
            this.Error1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Error1.ForeColor = System.Drawing.Color.Red;
            this.Error1.Location = new System.Drawing.Point(30, 250);
            this.Error1.Name = "Error1";
            this.Error1.Size = new System.Drawing.Size(583, 23);
            this.Error1.TabIndex = 34;
            // 
            // TPTablas
            // 
            this.TPTablas.Controls.Add(this.RTBCodigoGenerado);
            this.TPTablas.Controls.Add(this.BTNCargarCampos);
            this.TPTablas.Controls.Add(this.guardarArchivoTexto);
            this.TPTablas.Controls.Add(this.LBCampos);
            this.TPTablas.Controls.Add(this.BTNGenerarCodigo);
            this.TPTablas.Controls.Add(this.label4);
            this.TPTablas.Controls.Add(this.label3);
            this.TPTablas.Controls.Add(this.label5);
            this.TPTablas.Controls.Add(this.LBTablas);
            this.TPTablas.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.TPTablas.Location = new System.Drawing.Point(4, 22);
            this.TPTablas.Name = "TPTablas";
            this.TPTablas.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.TPTablas.Size = new System.Drawing.Size(632, 94);
            this.TPTablas.TabIndex = 1;
            this.TPTablas.Text = "Tablas";
            this.TPTablas.UseVisualStyleBackColor = true;
            // 
            // RTBCodigoGenerado
            // 
            this.RTBCodigoGenerado.Location = new System.Drawing.Point(312, 35);
            this.RTBCodigoGenerado.Name = "RTBCodigoGenerado";
            this.RTBCodigoGenerado.Size = new System.Drawing.Size(298, 212);
            this.RTBCodigoGenerado.TabIndex = 36;
            this.RTBCodigoGenerado.Text = "";
            // 
            // BTNCargarCampos
            // 
            this.BTNCargarCampos.Location = new System.Drawing.Point(162, 254);
            this.BTNCargarCampos.Name = "BTNCargarCampos";
            this.BTNCargarCampos.Size = new System.Drawing.Size(144, 23);
            this.BTNCargarCampos.TabIndex = 35;
            this.BTNCargarCampos.Text = "Cargar Campos";
            this.BTNCargarCampos.Click += new System.EventHandler(this.BTNCargarCampos_Click);
            // 
            // guardarArchivoTexto
            // 
            this.guardarArchivoTexto.Location = new System.Drawing.Point(535, 6);
            this.guardarArchivoTexto.Name = "guardarArchivoTexto";
            this.guardarArchivoTexto.Size = new System.Drawing.Size(75, 23);
            this.guardarArchivoTexto.TabIndex = 37;
            this.guardarArchivoTexto.Text = "Guardar como";
            this.guardarArchivoTexto.UseVisualStyleBackColor = true;
            this.guardarArchivoTexto.Click += new System.EventHandler(this.guardarArchivoTexto_Click);
            // 
            // LBCampos
            // 
            this.LBCampos.Location = new System.Drawing.Point(162, 35);
            this.LBCampos.Name = "LBCampos";
            this.LBCampos.Size = new System.Drawing.Size(144, 212);
            this.LBCampos.TabIndex = 34;
            // 
            // BTNGenerarCodigo
            // 
            this.BTNGenerarCodigo.Location = new System.Drawing.Point(312, 254);
            this.BTNGenerarCodigo.Name = "BTNGenerarCodigo";
            this.BTNGenerarCodigo.Size = new System.Drawing.Size(298, 23);
            this.BTNGenerarCodigo.TabIndex = 33;
            this.BTNGenerarCodigo.Text = "GenerarCodigo";
            this.BTNGenerarCodigo.Click += new System.EventHandler(this.CargarCampos_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(381, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Controladora Generada";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(170, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Campos de la tabla";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(24, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tablas Existentes";
            // 
            // LBTablas
            // 
            this.LBTablas.Location = new System.Drawing.Point(18, 35);
            this.LBTablas.Name = "LBTablas";
            this.LBTablas.Size = new System.Drawing.Size(138, 238);
            this.LBTablas.TabIndex = 8;
            // 
            // TPGenerarCodigoPasos
            // 
            this.TPGenerarCodigoPasos.Controls.Add(this.pictureBox1);
            this.TPGenerarCodigoPasos.Controls.Add(this.label2);
            this.TPGenerarCodigoPasos.Controls.Add(this.label1);
            this.TPGenerarCodigoPasos.Controls.Add(this.TXTUsuario);
            this.TPGenerarCodigoPasos.Controls.Add(this.TXTContrasena);
            this.TPGenerarCodigoPasos.Controls.Add(this.BTNAutenticar);
            this.TPGenerarCodigoPasos.Location = new System.Drawing.Point(4, 22);
            this.TPGenerarCodigoPasos.Name = "TPGenerarCodigoPasos";
            this.TPGenerarCodigoPasos.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.TPGenerarCodigoPasos.Size = new System.Drawing.Size(632, 94);
            this.TPGenerarCodigoPasos.TabIndex = 8;
            this.TPGenerarCodigoPasos.Text = "Acerca de Autenticarse :)";
            this.TPGenerarCodigoPasos.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(340, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 600);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Usuarrio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Contraseña";
            // 
            // TXTUsuario
            // 
            this.TXTUsuario.Enabled = false;
            this.TXTUsuario.Location = new System.Drawing.Point(135, 104);
            this.TXTUsuario.Name = "TXTUsuario";
            this.TXTUsuario.PasswordChar = '1';
            this.TXTUsuario.Size = new System.Drawing.Size(181, 20);
            this.TXTUsuario.TabIndex = 22;
            // 
            // TXTContrasena
            // 
            this.TXTContrasena.Enabled = false;
            this.TXTContrasena.Location = new System.Drawing.Point(135, 132);
            this.TXTContrasena.Name = "TXTContrasena";
            this.TXTContrasena.PasswordChar = 'e';
            this.TXTContrasena.Size = new System.Drawing.Size(181, 20);
            this.TXTContrasena.TabIndex = 21;
            // 
            // BTNAutenticar
            // 
            this.BTNAutenticar.Enabled = false;
            this.BTNAutenticar.Location = new System.Drawing.Point(135, 158);
            this.BTNAutenticar.Name = "BTNAutenticar";
            this.BTNAutenticar.Size = new System.Drawing.Size(181, 24);
            this.BTNAutenticar.TabIndex = 20;
            this.BTNAutenticar.Text = "&Autenticar";
            this.BTNAutenticar.Click += new System.EventHandler(this.BTNAutenticar_Click);
            // 
            // dataGrid1
            // 
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(433, 48);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.ReadOnly = true;
            this.dataGrid1.Size = new System.Drawing.Size(171, 160);
            this.dataGrid1.TabIndex = 28;
            // 
            // LBBaseDatos
            // 
            this.LBBaseDatos.Location = new System.Drawing.Point(233, 48);
            this.LBBaseDatos.Name = "LBBaseDatos";
            this.LBBaseDatos.Size = new System.Drawing.Size(175, 160);
            this.LBBaseDatos.TabIndex = 27;
            // 
            // BTNConectarBaseDeDatos
            // 
            this.BTNConectarBaseDeDatos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTNConectarBaseDeDatos.Location = new System.Drawing.Point(130, 32);
            this.BTNConectarBaseDeDatos.Name = "BTNConectarBaseDeDatos";
            this.BTNConectarBaseDeDatos.Size = new System.Drawing.Size(64, 23);
            this.BTNConectarBaseDeDatos.TabIndex = 26;
            this.BTNConectarBaseDeDatos.Text = "&Conectar Base de Datos";
            this.BTNConectarBaseDeDatos.UseVisualStyleBackColor = true;
            this.BTNConectarBaseDeDatos.Visible = false;
            this.BTNConectarBaseDeDatos.Click += new System.EventHandler(this.BTNConectarBaseDeDatos_Click);
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(230, 29);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(232, 16);
            this.label19.TabIndex = 24;
            this.label19.Text = "Vista previa de los campos seleccionados";
            // 
            // TXTSever
            // 
            this.TXTSever.Location = new System.Drawing.Point(26, 62);
            this.TXTSever.Name = "TXTSever";
            this.TXTSever.Size = new System.Drawing.Size(184, 20);
            this.TXTSever.TabIndex = 15;
            this.TXTSever.Text = "localhost";
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(23, 29);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 16);
            this.label18.TabIndex = 21;
            this.label18.Text = "Nombre Servidor:";
            // 
            // BTNConectarServidor
            // 
            this.BTNConectarServidor.Location = new System.Drawing.Point(26, 214);
            this.BTNConectarServidor.Name = "BTNConectarServidor";
            this.BTNConectarServidor.Size = new System.Drawing.Size(184, 23);
            this.BTNConectarServidor.TabIndex = 20;
            this.BTNConectarServidor.Text = "Coneccion Servidor";
            this.BTNConectarServidor.UseVisualStyleBackColor = true;
            this.BTNConectarServidor.Click += new System.EventHandler(this.BTNConectarServidor_Click);
            // 
            // TXTPass
            // 
            this.TXTPass.Location = new System.Drawing.Point(28, 181);
            this.TXTPass.Name = "TXTPass";
            this.TXTPass.PasswordChar = '*';
            this.TXTPass.Size = new System.Drawing.Size(184, 20);
            this.TXTPass.TabIndex = 17;
            this.TXTPass.Text = "Password123$";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(25, 157);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 16);
            this.label16.TabIndex = 19;
            this.label16.Text = "Contraseña";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(25, 92);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 16);
            this.label17.TabIndex = 18;
            this.label17.Text = "Cuenta";
            // 
            // TXTUser
            // 
            this.TXTUser.Location = new System.Drawing.Point(28, 119);
            this.TXTUser.Name = "TXTUser";
            this.TXTUser.Size = new System.Drawing.Size(184, 20);
            this.TXTUser.TabIndex = 16;
            this.TXTUser.Text = "sa";
            // 
            // TXTWebservices
            // 
            this.TXTWebservices.Location = new System.Drawing.Point(26, 35);
            this.TXTWebservices.Name = "TXTWebservices";
            this.TXTWebservices.Size = new System.Drawing.Size(115, 20);
            this.TXTWebservices.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(23, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "Nombre de la Aplicacion";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.HelpRequest += new System.EventHandler(this.guardarArchivoTexto_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(156, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(258, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "Ingrese la ruta donde se va a guardar el archivo";
            // 
            // TXTRutaArchivo
            // 
            this.TXTRutaArchivo.Location = new System.Drawing.Point(159, 35);
            this.TXTRutaArchivo.Name = "TXTRutaArchivo";
            this.TXTRutaArchivo.ReadOnly = true;
            this.TXTRutaArchivo.Size = new System.Drawing.Size(255, 20);
            this.TXTRutaArchivo.TabIndex = 38;
            this.TXTRutaArchivo.Text = "C:\\gen\\";
            // 
            // CLBSeleccionCodigo
            // 
            this.CLBSeleccionCodigo.FormattingEnabled = true;
            this.CLBSeleccionCodigo.Items.AddRange(new object[] {
            "Entidades",
            "Controladoras",
            "WebMetodos"});
            this.CLBSeleccionCodigo.Location = new System.Drawing.Point(538, 6);
            this.CLBSeleccionCodigo.Name = "CLBSeleccionCodigo";
            this.CLBSeleccionCodigo.Size = new System.Drawing.Size(120, 4);
            this.CLBSeleccionCodigo.TabIndex = 40;
            // 
            // BTGenerarAutomaticamente
            // 
            this.BTGenerarAutomaticamente.Location = new System.Drawing.Point(233, 214);
            this.BTGenerarAutomaticamente.Name = "BTGenerarAutomaticamente";
            this.BTGenerarAutomaticamente.Size = new System.Drawing.Size(370, 23);
            this.BTGenerarAutomaticamente.TabIndex = 35;
            this.BTGenerarAutomaticamente.Text = "&Generar Automaticamente la Capa de Negocio";
            this.BTGenerarAutomaticamente.UseVisualStyleBackColor = true;
            this.BTGenerarAutomaticamente.Click += new System.EventHandler(this.BTGenerarAutomaticamente_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(420, 32);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(87, 23);
            this.btnBuscar.TabIndex = 35;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.dataGrid1);
            this.groupBox1.Controls.Add(this.BTGenerarAutomaticamente);
            this.groupBox1.Controls.Add(this.TXTUser);
            this.groupBox1.Controls.Add(this.LBBaseDatos);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.BTNConectarBaseDeDatos);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.TXTPass);
            this.groupBox1.Controls.Add(this.TXTSever);
            this.groupBox1.Controls.Add(this.BTNConectarServidor);
            this.groupBox1.Location = new System.Drawing.Point(29, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 244);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generar capa de Negocio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 431);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.CLBSeleccionCodigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TXTRutaArchivo);
            this.Controls.Add(this.Error2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TXTWebservices);
            this.Controls.Add(this.TPAcercaDeD4VYNCY);
            this.MaximumSize = new System.Drawing.Size(674, 489);
            this.MinimumSize = new System.Drawing.Size(674, 404);
            this.Name = "Form1";
            this.Text = "Generador de codigo estandas para la capa de negocio \"davidserrudo@gmail.com\"";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TPAcercaDeD4VYNCY.ResumeLayout(false);
            this.TPFicheros.ResumeLayout(false);
            this.TPTablas.ResumeLayout(false);
            this.TPGenerarCodigoPasos.ResumeLayout(false);
            this.TPGenerarCodigoPasos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private void NOTA()
    {
        Note[] Mary = new Note[] { new Note(Tone.B, Duration.QUARTER), new Note(Tone.A, Duration.QUARTER), new Note(Tone.GbelowC, Duration.QUARTER), new Note(Tone.A, Duration.QUARTER), new Note(Tone.B, Duration.QUARTER), new Note(Tone.B, Duration.QUARTER), new Note(Tone.B, Duration.HALF), new Note(Tone.A, Duration.QUARTER), new Note(Tone.A, Duration.QUARTER), new Note(Tone.A, Duration.HALF), new Note(Tone.B, Duration.QUARTER), new Note(Tone.D, Duration.QUARTER), new Note(Tone.D, Duration.HALF) };
        Play(Mary);
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
        this.TXTUsuario.Enabled = true;
        this.TXTContrasena.Enabled = true;
        this.BTNAutenticar.Enabled = true;
    }

    protected static void Play(Note[] tune)
    {
        foreach (Note n in tune)
        {
            if (n.NoteTone == Tone.REST)
            {
                Thread.Sleep((int) n.NoteDuration);
            }
            else
            {
                Console.Beep((int) n.NoteTone, (int) n.NoteDuration);
            }
        }
    }

    public string TipoDeDatoDataRow(string dato, string NombreCampo, string NombreTabla)
    {
        if (dato == "text")
        {
            dato = "item." + NombreCampo + " = Convert.ToString(dr[" + this.comi + NombreCampo + this.comi + "]);";
        }
        if (dato == "varchar")
        {
            dato = "item." + NombreCampo + " = Convert.ToString(dr[" + this.comi + NombreCampo + this.comi + "]);";
        }
        if (dato == "numeric")
        {
            dato = "item." + NombreCampo + " = Convert.ToDecimal(dr[" + this.comi + NombreCampo + this.comi + "]);";
        }
        if (dato == "Int32")
        {
            dato = "item." + NombreCampo + " = Convert.ToInt32(dr[" + this.comi + NombreCampo + this.comi + "]);";
        }
        if (dato == "Int16")
        {
            dato = "item." + NombreCampo + " = Convert.ToInt16(dr[" + this.comi + NombreCampo + this.comi + "]);";
        }
        if (dato == "Decimal")
        {
            dato = "item." + NombreCampo + " = Convert.ToDecimal(dr[" + this.comi + NombreCampo + this.comi + "]);";
        }
        if (dato == "Char")
        {
            dato = "item." + NombreCampo + " = Convert.ToString(dr[" + this.comi + NombreCampo + this.comi + "]);";
        }
        if (dato == "String")
        {
            dato = "item." + NombreCampo + " = Convert.ToString(dr[" + this.comi + NombreCampo + this.comi + "]);";
        }
        if (dato == "Text")
        {
            dato = "item." + NombreCampo + " = Convert.ToString(dr[" + this.comi + NombreCampo + this.comi + "]);";
        }
        if (dato == "DateTime")
        {
            dato = "item." + NombreCampo + " = Convert.ToDateTime(dr[" + this.comi + NombreCampo + this.comi + "]);";
        }
        if (dato == "Boolean")
        {
            dato = "item." + NombreCampo + " = Convert.ToBoolean(dr[" + this.comi + NombreCampo + this.comi + "]);";
        }
        if (dato == "Double")
        {
            dato = "item." + NombreCampo + " = Convert.ToDouble(dr[" + this.comi + NombreCampo + this.comi + "]);";
        }
        if (dato == "Byte[]")
        {
            dato = "item." + NombreCampo + " = (byte[])dr[" + this.comi + NombreCampo + this.comi + "];";
        }
        if (dato == "Byte")
        {
            dato = "item." + NombreCampo + " = Convert.ToByte(dr[" + this.comi + NombreCampo + this.comi + "]);";
        }
        if (dato == "Int64")
        {
            dato = "item." + NombreCampo + " = Convert.ToInt64(dr[" + this.comi + NombreCampo + this.comi + "]);";
        }
        return dato;
    }

    public string TipoDeDatoDataRowParaLaData(string dato, string NombreCampo, string NombreTabla)
    {
        if (dato == "text")
        {
            dato = "this." + NombreCampo + " = Convert.ToString(dr[" + this.comi + NombreCampo + this.comi + "]);";
        }
        if (dato == "varchar")
        {
            dato = "this." + NombreCampo + " = Convert.ToString(dr[" + this.comi + NombreCampo + this.comi + "]);";
        }
        if (dato == "numeric")
        {
            dato = "this." + NombreCampo + " = Convert.ToDecimal(dr[" + this.comi + NombreCampo + this.comi + "]);";
        }
        if (dato == "Int32")
        {
            dato = "this." + NombreCampo + " = Convert.ToInt32(dr[" + this.comi + NombreCampo + this.comi + "]);";
        }
        if (dato == "Int16")
        {
            dato = "this." + NombreCampo + " = Convert.ToInt16(dr[" + this.comi + NombreCampo + this.comi + "]);";
        }
        if (dato == "Decimal")
        {
            dato = "this." + NombreCampo + " = Convert.ToDecimal(dr[" + this.comi + NombreCampo + this.comi + "]);";
        }
        if (dato == "Char")
        {
            dato = "this." + NombreCampo + " = Convert.ToString(dr[" + this.comi + NombreCampo + this.comi + "]);";
        }
        if (dato == "String")
        {
            dato = "this." + NombreCampo + " = Convert.ToString(dr[" + this.comi + NombreCampo + this.comi + "]);";
        }
        if (dato == "Text")
        {
            dato = "this." + NombreCampo + " = Convert.ToString(dr[" + this.comi + NombreCampo + this.comi + "]);";
        }
        if (dato == "DateTime")
        {
            dato = "this." + NombreCampo + " = Convert.ToDateTime(dr[" + this.comi + NombreCampo + this.comi + "]);";
        }
        if (dato == "Boolean")
        {
            dato = "this." + NombreCampo + " = Convert.ToBoolean(dr[" + this.comi + NombreCampo + this.comi + "]);";
        }
        if (dato == "Double")
        {
            dato = "this." + NombreCampo + " = Convert.ToDouble(dr[" + this.comi + NombreCampo + this.comi + "]);";
        }
        if (dato == "Byte[]")
        {
            dato = "this." + NombreCampo + " = (byte[])dr[" + this.comi + NombreCampo + this.comi + "];";
        }
        if (dato == "Byte")
        {
            dato = "this." + NombreCampo + " = Convert.ToByte(dr[" + this.comi + NombreCampo + this.comi + "]);";
        }
        if (dato == "Int64")
        {
            dato = "this." + NombreCampo + " = Convert.ToInt64(dr[" + this.comi + NombreCampo + this.comi + "]);";
        }
        return dato;
    }

    public string validarDato(string dato)
    {
        if (dato == "text")
        {
            dato = "string";
        }
        if (dato == "varchar")
        {
            dato = "string";
        }
        if (dato == "numeric")
        {
            dato = "decimal";
        }
        if (dato == "Int32")
        {
            dato = "int";
        }
        if (dato == "Decimal")
        {
            dato = "decimal";
        }
        if (dato == "Char")
        {
            dato = "string";
        }
        if (dato == "String")
        {
            dato = "string";
        }
        if (dato == "Int16")
        {
            dato = "int";
        }
        if (dato == "Double")
        {
            dato = "double";
        }
        return dato;
    }

    public string valorInicialDato(string dato)
    {
        if (dato == "text")
        {
            dato = "string.Empty";
        }
        if (dato == "varchar")
        {
            dato = "string.Empty";
        }
        if (dato == "numeric")
        {
            dato = "0";
        }
        if (dato == "Int32")
        {
            dato = "0";
        }
        if (dato == "Decimal")
        {
            dato = "0";
        }
        if (dato == "Char")
        {
            dato = "string.Empty";
        }
        if (dato == "string")
        {
            dato = "string.Empty";
        }
        if (dato == "String")
        {
            dato = "string.Empty";
        }
        if (dato == "Boolean")
        {
            dato = "true";
        }
        if (dato == "DateTime")
        {
            dato = "DateTime.Now";
        }
        if (dato == "Int16")
        {
            dato = "0";
        }
        if (dato == "Int64")
        {
            dato = "0";
        }
        if (dato == "Double")
        {
            dato = "0";
        }
        return dato;
    }

    // Nested Types
    protected enum Duration
    {
        EIGHTH = 200,
        HALF = 800,
        QUARTER = 400,
        SIXTEENTH = 100,
        WHOLE = 0x640
    }

    
    protected struct Note
    {
        private Form1.Tone toneVal;
        private Form1.Duration durVal;
        public Note(Form1.Tone frequency, Form1.Duration time)
        {
            this.toneVal = frequency;
            this.durVal = time;
        }

        public Form1.Tone NoteTone
        {
            get
            {
                return this.toneVal;
            }
        }
        public Form1.Duration NoteDuration
        {
            get
            {
                return this.durVal;
            }
        }
    }

    protected enum Tone
    {
        A = 220,
        Asharp = 0xe9,
        B = 0xf7,
        C = 0x106,
        Csharp = 0x115,
        D = 0x126,
        Dsharp = 0x137,
        E = 330,
        F = 0x15d,
        Fsharp = 370,
        G = 0x188,
        GbelowC = 0xc4,
        Gsharp = 0x19f,
        REST = 0
    }
}

 

}