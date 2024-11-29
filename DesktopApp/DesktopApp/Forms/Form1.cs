using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            switch (flag)
            {
                case 0: { form1.Hide(); break; }
                case 1: { form1.Show(); break; }
                case -1: { Application.Exit(); ; break; }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1!=null)
            {
                string loginText= textBox1.Text;
                bool flag=sendingRequests.LoginCheck(loginText);
                if(!flag) { label3.Visible=true; }
                else
                {
                    textBox1.Text = null;
                    MainWindow mainWindow = new MainWindow();
                    Form1 form = new Form1(0);
                    mainWindow.Show();
                    //mainWindow.ShowDialog();
                    //this.Close();
                    //Application.Exit();
                    //ChangeVisible();
                }
            }
        }
        
    }
}
