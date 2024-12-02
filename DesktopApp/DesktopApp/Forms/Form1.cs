using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.LinkLabel;

namespace DesktopApp.Forms
{
    public partial class Form1 : Form
    {
        SendingRequests sendingRequests = new SendingRequests();
        public static Form1 form1;
        public Form1()
        {
            InitializeComponent();
            form1=this;

        }
        public Form1(int flag)
        {
            textBox1.Text = "";
            label1.Visible = true;

            switch (flag)
            {
                case 0: { form1.Hide(); break; }
                case 1: { form1.Show(); break; }
                case -1: { Application.Exit(); ; break; }
            }
        }

        private void button1_Click(object sender, EventArgs e) //Кнопка для открытия форм MainWindow и AddProductUser
        {
            string loginText = textBox1.Text;

            if(loginText != "")
            {
                if (label1.Visible == true) 
                {
                    bool flag = sendingRequests.LoginCheck(loginText);
                    if (!flag) { label3.Visible = true; }
                    else
                    {
                        MainWindow mainWindow = new MainWindow();
                        Form1 form = new Form1(0);
                        mainWindow.Show();

                    }
                }
                else
                {
                    bool flag = sendingRequests.LoginCheckAdmin(loginText);
                    if (!flag) { label3.Visible = true; }
                    else
                    {
                        AdminWindow adminWindow = new AdminWindow();
                        Form1 form = new Form1(0);
                        adminWindow.Show();

                    }
                }
            }
            else { label3.Visible=true; }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        
    }
}
