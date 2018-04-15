using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//-----------------------

namespace WASystenInfor
{
    public partial class frmGetBoardMakerSeriNo : Form
    {
        VNTSecurity.System.SystemInfor objSystemInfor = new VNTSecurity.System.SystemInfor();
        VNTSecurity.VNTCrypt.Crypt1 objCrypt1 = new VNTSecurity.VNTCrypt.Crypt1();

        public frmGetBoardMakerSeriNo()
        {
            InitializeComponent();
        }

        private void frmGetBoardMakerSeriNo_Load(object sender, EventArgs e)
        {
            textBox1.Text = objCrypt1.Encrypt_Active(objSystemInfor.GetBoardMakerSerialNumber());
        }
    }
}