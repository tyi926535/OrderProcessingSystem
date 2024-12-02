using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp.Forms
{
    public partial class AddProductUser : Form
    {

        SendingRequests sendingRequests = new SendingRequests();
        public AddProductUser()
        {
            InitializeComponent();
        }
        private void AddProductUser_Load(object sender, EventArgs e)
        {
            radioButton1.Checked=true;
            radioButton2.Checked=false;
            panel2.Visible = false;
            label6.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            radioButton2.Checked = false;
            panel2.Visible = false;
            panel1.Visible = true;
            label6.Visible = false;
            userTB1.Text = "";
            UserTB2.Text = "";


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            radioButton1.Checked = false;
            panel1.Visible = false;
            panel2.Visible = true;
            label6.Visible = false;
            productTB1.Text = "";
            productTB2.Text = "";
            productTB3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var adminWindow= new AdminWindow();
            adminWindow.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int flag = 0;
            if((userTB1.Text==null)||(userTB1.Text == "") || (UserTB2.Text == null) || (UserTB2.Text == "")) {  flag = 1; }
            foreach (char c in userTB1.Text)
            {
                bool b = CheckSymbol(c, 0);
                if (!b) { flag = 2; break; }
            }
            foreach (char c in UserTB2.Text)
            {
                bool b = CheckSymbol(c, 0);
                if (!b) { flag = 2; break; }
            }
            if (flag == 1) { label6.Visible = true; label6.Text = "Поля не должны быть пустыми"; }
            if (flag == 2) { label6.Visible = true; label6.Text = "Поля c именем и логином могут содержать только цифры и англ.буквы"; }
            if (flag == 0) { sendingRequests.AddingDBUsers(userTB1.Text, UserTB2.Text); button3_Click(sender, e);}
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int flag = -1;
            if ((productTB1.Text == "") || (productTB2.Text == "") ||  (productTB3.Text == "")) { flag = 0; }
            foreach (char c in productTB1.Text)
            {
                bool b = CheckSymbol(c, 2);
                if (!b) { flag = 2; break; }
            }
            foreach (char c in productTB2.Text)
            {
                bool b = CheckSymbol(c, 1);
                if (!b) { flag = 1; break; }
            }
            foreach (char c in productTB3.Text)
            {
                bool b = CheckSymbol(c, 1);
                if (!b) { flag = 1; break; }
            }
            if (flag == 0) { label6.Visible = true; label6.Text = "Поля не должны быть пустыми"; }
            if (flag == 1) { label6.Visible = true; label6.Text = "Поля c ценой и кол-вом товаров могут содержать только цифры"; }
            if (flag == 2) { label6.Visible = true; label6.Text = "Поля c названием могут содержать только англ.буквы"; }
            if (flag == -1)
            {
                sendingRequests.AddingDBProduct(productTB1.Text,int.Parse(productTB2.Text), int.Parse(productTB3.Text));
                button3_Click(sender,e);
            }
        }
    
        bool CheckSymbol(char x, int index)// Проверка символов, index=0 цифры и буквы, index=1 цифры, index=2 буквы
        {
            if ((index == 0) || (index == 1))
            {
                if (x >= '0' && x <= '9')
                    return true;
            }
            if ((index == 0) || (index == 2))
            {
                if (x >= 'a' && x <= 'z')
                    return true;
                if (x >= 'A' && x <= 'Z')
                    return true;
            }
            return false;
        }

    }
}
