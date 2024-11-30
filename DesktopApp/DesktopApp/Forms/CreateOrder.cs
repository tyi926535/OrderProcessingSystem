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
    public partial class CreateOrder : Form
    {
        SendingRequests sendingRequests = new SendingRequests();
        static int orderID;
        static List<int> idList=new List<int>();
        public CreateOrder(int orderID)
        {
            CreateOrder.orderID = orderID;
            InitializeComponent();

        }
        private void CreateOrder_Load(object sender, EventArgs e)
        {
            List<string[]> listProducts= sendingRequests.ListOfProducts();
            List<string> nameList=new List<string>();
            foreach (string[] order in listProducts)
            {
                idList.Add(int.Parse(order[0]));
                nameList.Add(order[1]);
            }
            string[] nameArray=new string[nameList.Count];
            nameList.CopyTo(nameArray);
            comboBox1.Items.AddRange(nameArray);
            

        }


        private void button1_Click(object sender, EventArgs e) //Создание позиции заказа
        {
            int index= comboBox1.SelectedIndex;
            if (index >= 0)
            {
                sendingRequests.CreatingAnOrderItem(idList[index], orderID);
                var addingProduct = new AddingProduct(orderID);
                addingProduct.Show();
                this.Dispose();
            }
        }

        private void button3_Click(object sender, EventArgs e)//Закрытие формы
        {
            var addingProduct = new AddingProduct(orderID);
            addingProduct.Show();
            this.Dispose();
        }
    }

        
}
