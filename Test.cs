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
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double q1;
            double q2;
            double points;
            points = 0;
            q1 = 0;
            q2 = 0;
            if (checkBox1.Checked == true)
            {
                q1 = q1 + 0.5;
            }
            if (checkBox3.Checked == true)
            {
                q1 = q1 + 0.5;
            }
            if (radioButton3.Checked == true)
            {
                q2 = q2 + 1;
            }
            if (checkBox2.Checked == true)
            {
                q2 = 0;
            }
            if (checkBox4.Checked == true)
            {
                q2 = 0;
            }
            points = q1 + q2;

            if (points == 0 || points == 0.5)
            {
                label4.Text = "Оценка: 2";

            }
            if (points == 1)
            {
                label4.Text = "Оценка: 3";
            }
            if (points == 1.5)
            {
                label4.Text = "Оценка: 4";
            }
            if (points == 2)
            {
                label4.Text = "Оценка: 5";
            }
            label5.Text = "Баллы: "+points;
        }

        private void Test_Load(object sender, EventArgs e)
        {
            label6.Text += Methods.GlobalVars.arr[Methods.GlobalVars.auth_id].fio;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Frames.Login();

        }
    }
}
