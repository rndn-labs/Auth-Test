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

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Frames frames = new Frames();
            Methods Methods = new Methods();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Frames.Info();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frames.RegWindow();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string log = auth_login.Text;
            string pass = auth_pass.Text;
            for (int i = 0; i <= Methods.GlobalVars.arr.Length-1; i++)
            {
                if (Methods.GlobalVars.arr[i].login == log)
                {
                    if (Methods.GlobalVars.arr[i].pass == pass)
                    {
                        Methods.GlobalVars.auth_id = Methods.GlobalVars.arr[i].u_id;
                        Frames.TestWindow();
                        this.Visible=false;
                    }else
                    {
                        MessageBox.Show("Авторизация не удалась", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
                
             

            }
            
        }


    }
}
