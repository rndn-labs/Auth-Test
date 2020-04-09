using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Auth_Test
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            Methods methods = new Methods();
            Frames frames = new Frames();
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            int uid = 0;
            Methods.GlobalVars.arr[Methods.GlobalVars.uid].login = reg_login.Text;
            Methods.GlobalVars.arr[Methods.GlobalVars.uid].pass = reg_pass.Text;
            Methods.GlobalVars.uid++;
            this.Visible = false;
            MessageBox.Show("Регистрация завершена", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

        }
    }
}
