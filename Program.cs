using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace S11221003x0318DiyLab001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Form myForm = new Form();

            myForm.Size = new System.Drawing.Size(320, 240);

            myForm.Text = "DIY Form V1";

            //
            //
            System.Windows.Forms.Label lblMessage = new System.Windows.Forms.Label();

            lblMessage.Text = "帳號:";

            lblMessage.Location = new System.Drawing.Point(50, 50);

            myForm.Controls.Add(lblMessage);

            //帳號框

            TextBox tbUsername = new TextBox();

            tbUsername.Width = 150;

            tbUsername.Location = new System.Drawing.Point(80, 50);

            myForm.Controls.Add(tbUsername);

            //

            Button btnOK = new Button();

            btnOK.Text = "OK";

            btnOK.Width = 100;

            btnOK.Location = new System.Drawing.Point(50, 130);

            myForm.Controls.Add(btnOK);
            //
            System.Windows.Forms.Label blMessage = new System.Windows.Forms.Label();

            blMessage.Text = "密碼:";

            blMessage.Location = new System.Drawing.Point(50, 80);

            myForm.Controls.Add(blMessage);
            //

            TextBox tbUserq = new TextBox();

            tbUserq.Width = 150;

            tbUserq.Location = new System.Drawing.Point(80, 80);

            myForm.Controls.Add(tbUserq);





            btnOK.Click += BtnOK_Click;



            System.Windows.Forms.Application.Run(myForm);
        }

        private static void BtnOK_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Ok clicked!");
        }
    }
}
