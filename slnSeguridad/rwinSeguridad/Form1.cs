using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Resources;
using System.Globalization;
using System.Web.Security;



namespace rwinSeguridad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreaPasswordHash("Clave123456", "XcPpLiI=");
        }

        //public string CreaPasswordHash1(string pPassword, string pSalt)
        //{
        //    return FormsAuthentication.HashPasswordForStoringInConfigFile(pHostname + pIp, "SHA1");

        //    //return HashPasswordForStoringInConfigFile(pPassword + pSalt, "SHA1");

        //}

        public string CreaPasswordHash(string pPassword, string pSalt)
        {
            string cUnion, cPassHashSalt;
            cUnion = string.Concat(pPassword, pSalt);
            cPassHashSalt = FormsAuthentication.HashPasswordForStoringInConfigFile(cUnion, "SHA1");
            return cPassHashSalt;
        }
    }
}
