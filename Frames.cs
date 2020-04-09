using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Auth_Test
{
    class Frames
    {
        public static void RegWindow()
        {
            Register Register = new Register();
            Register.Show();

        }
        public static void TestWindow()
        {
            Test Test = new Test();
            Test.Show();
            

        }
        public static void Info()
        {
            Info Info = new Info();
            Info.Show();


        }
        public static void Login()
        {
            Form1 Form1 = new Form1();
            Form1.Show();


        }
    }
}
