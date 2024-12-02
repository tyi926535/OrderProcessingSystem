using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp.Forms
{
    public partial class AdminWindow : Form
    {
        List<string[]> listProduct;
        List<string[]> listUsers;
        SendingRequests sendingRequests = new SendingRequests();
        public AdminWindow()
        {
            InitializeComponent();
        }
        private void AddWindow_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView2.AllowUserToAddRows = false;
            listProduct=sendingRequests.GetListProducts();
            listUsers =sendingRequests.GetListUsers();
            dataGridView2.RowCount = listProduct.Count;
            if (listProduct.Count != 0)
            {
                for(int i = 0;i<listProduct.Count;i++)
                {
                    string[] line = listProduct[i];
                    for (int j = 0; j < line.Length; j++)
                    {
                        if ((line[j] != "")&& (line[j] != null))
                        {
                            dataGridView2[j,i].Value = line[j];
                        }
                    }
                }
            }
            dataGridView1.RowCount = listUsers.Count;
            if (listUsers.Count != 0)
            {
                for (int i = 0; i < listUsers.Count; i++)
                {
                    string[] line = listUsers[i];
                    for (int j = 0; j < line.Length; j++)
                    {
                        if ((line[j] != "") && (line[j] != null))
                        {
                            dataGridView1[j, i].Value = line[j];
                        }
                    }
                }
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1(1);
            this.Dispose();
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
        
        private void button4_Click_1(object sender, EventArgs e)
        {
            if (button4.Text == "Изменить логин")
            {
                button4.Text = "Сохранить";
                textBox1.Visible = true;
            }
            else
            {
                if (button4.Text == "Сохранить")
                {
                    button4.Text = "Изменить логин";
                    int index = 0;
                    foreach (char c in textBox1.Text)
                    {
                        bool b = CheckSymbol(c, 0);
                        if (!b) { index++; break; }
                    }
                    if (index > 0) { label3.Visible = true; label3.Text = "Логин может содержать только цифры и англ.буквы"; }
                    else
                    {
                        textBox1.Text = "";
                        textBox1.Visible= false; label3.Visible= false;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            int flag = 0;
            for(int i = 0; i < dataGridView1.RowCount; i++)
            {
                for(int j = 1; j < dataGridView1.ColumnCount; j++)
                {
                    string word = (string)dataGridView1[j, i].Value;

                    if((word == "")||(word==null)) {  flag = 1; break; }
                    foreach (char c in word)
                    {
                        bool b = CheckSymbol(c, 0);
                        if (!b) { flag = 2; break; }
                    }
                }

            }
            if (flag == 1) { label3.Visible = true; label3.Text = "Поля не должны быть пустыми"; }
            if (flag == 2) { label3.Visible = true; label3.Text = "Поля c именем и логином могут содержать только цифры и англ.буквы"; }
            if (flag == 0)
            {
                int index = 0;
                int i = 0;
                foreach (var user in listUsers)
                {
                    if (dataGridView1.RowCount <= i) { sendingRequests.DeleteUser(int.Parse(user[0])); index++; }
                    else
                    {
                        if ((string)dataGridView1[0, i].Value != user[0]) { sendingRequests.DeleteUser(int.Parse(user[0])); index++; }
                        else
                        {
                            if (((string)dataGridView1[1, i].Value != user[1]) || ((string)dataGridView1[2, i].Value != user[2]))
                            { sendingRequests.UpdateDBUsers((string)dataGridView1[1, i].Value, (string)dataGridView1[2, i].Value, int.Parse(user[0])); index++; }
                            i++;
                        }
                    }
                }
                if (index > 0) { AddWindow_Load(sender, e); }

            }

        }

        private void AddWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            int flag = -1;
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                for (int j = 1; j < dataGridView2.ColumnCount; j++)
                {
                    string word = (string)dataGridView2[j, i].Value;
                    int index = 1; if (j == 1) index = 2;
                    if ((word == "") || (word == null)) { flag = 1; break; }
                    foreach (char c in word)
                    {
                        bool b = CheckSymbol(c, index);
                        if (!b) { flag = index; break; }
                    }
                }

            }
            if (flag == 0) { label3.Visible = true; label3.Text = "Поля не должны быть пустыми"; }
            if (flag == 1) { label3.Visible = true; label3.Text = "Поля c ценой и кол-вом товаров могут содержать только цифры"; }
            if (flag == 2) { label3.Visible = true; label3.Text = "Поля c названием могут содержать только англ.буквы"; }
            if (flag == -1)
            {
                int index = 0;
                int i = 0;
                foreach (var product in listProduct)
                {
                    if (dataGridView2.RowCount<=i) { sendingRequests.DeleteProduct(int.Parse(product[0])); index++; }
                    else 
                    {
                        if ((string)dataGridView2[0, i].Value != product[0]) { sendingRequests.DeleteProduct(int.Parse(product[0])); index++; }
                        else
                        {
                            if (((string)dataGridView2[1, i].Value != product[1]) || ((string)dataGridView2[2, i].Value != product[2]) || ((string)dataGridView2[3, i].Value != product[3]))
                            { sendingRequests.UpdateDBProduct((string)dataGridView2[1, i].Value, int.Parse((string)dataGridView2[2, i].Value), int.Parse((string)dataGridView2[3, i].Value), int.Parse(product[0]));
                                index++; }
                            i++;
                        }
                    }
                }
                if (index > 0) { AddWindow_Load(sender, e); }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddProductUser addProductUser = new AddProductUser();
            addProductUser.Show();
            this.Dispose();
        }
    }
}
