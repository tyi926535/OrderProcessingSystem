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
    public partial class AddingProduct : Form
    {
        static  int orderID;  //Инициализация происходит в только конструкторе
        SendingRequests sendingRequests = new SendingRequests(); 
        List<GroupBox> GB = new List<GroupBox>(); // Лист для хранения создаваемых groupBox
        public AddingProduct(int orderID) // В конструктор передается id запроса из формы  MainWindow
        {
            AddingProduct.orderID = orderID;
            InitializeComponent();

        }


        private void AddingProduct_Load(object sender, EventArgs e) // Заполнение формы списком позиций заказа, путем копирования шаблона 
        {
            if (orderID == 0) { label4.Visible = true; }  
            else
            {
                List<string[]> productsList = sendingRequests.ListOfProductsInTheOrder(orderID); //вызов метода для формирования списка позиций заказа
                if (productsList.Count == 0)
                {
                    label4.Visible = true;
                }
                else 
                {
                    groupBox1.Visible = true;
                    Control controlGB = groupBox1;
                    Control flowLP = flowLayoutPanel1;
                    
                    int tabIndexCurrent = 20;
                    foreach (string[] order in productsList)
                    {
                        GroupBox gB = Clone(groupBox1, 0);
                        gB.TabIndex = tabIndexCurrent;
                        tabIndexCurrent++;
                        GB.Add(gB);
                        flowLayoutPanel1.Controls.Add(gB);

                        foreach (Control ctrl in controlGB.Controls)
                        {
                            var newCtrl = Clone(ctrl, 1);
                            switch (newCtrl.Name) // Заполнение элементов данными о позиции в заказе и наложение событий на кнопки
                            {
                                case "ID": { newCtrl.Text = order[0]; break; }
                                case "ProductName": { newCtrl.Text = order[1]; break; }
                                case "Price": { newCtrl.Text = order[2]; break; }
                                case "ProductQuantity": { newCtrl.Text = order[3]; break; }
                                case "removeProductOrder": { newCtrl.Click += new System.EventHandler(this.removeProductOrder_Click); break; }
                                case "increaseQuantity": { newCtrl.Click += new System.EventHandler(this.increaseQuantity_Click); break; }
                                case "decreaseQuantity": { newCtrl.Click += new System.EventHandler(this.decreaseQuantity_Click); break; }
                            }
                            gB.Controls.Add(newCtrl);
                        }
                    }
                    groupBox1.Visible = false;
                }
            }

        }

        
        private void createOrder_Click(object sender, EventArgs e) //Открывает окно  для добавления товара 
        {
            var createOrder = new CreateOrder(orderID);
            createOrder.Show();
            orderID = 0;
            this.Dispose();

        }

        private void removeProductOrder_Click(object sender, EventArgs e) // Удаление позиции заказа
        {
            Control senderC = (Control)sender;
            Control parent = senderC.Parent; 
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl.Name == "ID")
                { sendingRequests.RemoveProductOrder(int.Parse(ctrl.Text),orderID); }
            }
            parent.Dispose();
        }

        private void increaseQuantity_Click(object sender, EventArgs e) // Увеличение количества товара в позиции заказа на 1
        {
            Control senderC = (Control)sender;
            if (senderC.ForeColor != Color.Black)
            {
                int idProduct = 0;
                Control productQuantityC = null;
                Control parent = senderC.Parent;
                foreach (Control ctrl in parent.Controls)
                {
                    if (ctrl.Name == "ID")
                    { idProduct = int.Parse(ctrl.Text); }
                    if (ctrl.Name == "ProductQuantity") { productQuantityC = ctrl; }
                    if (ctrl.Name == "decreaseQuantity") { ctrl.ForeColor = Color.White; }
                }
                bool flag = sendingRequests.IncreaseQuantity(idProduct, orderID);
                if (flag) { productQuantityC.Text = ((int.Parse(productQuantityC.Text)) + 1).ToString(); senderC.ForeColor = Color.White; }
                else { senderC.ForeColor = Color.Black; }
            }
        }

        private void decreaseQuantity_Click(object sender, EventArgs e) // Уменьшение количества товара в позиции заказа на 1
        {
            Control senderC = (Control)sender;
            if (senderC.ForeColor != Color.Black)
            {
                int idProduct = 0;
                Control parent = senderC.Parent;
                foreach (Control ctrl in parent.Controls)
                {
                    if (ctrl.Name == "ID")
                    { idProduct = int.Parse(ctrl.Text); }
                    if (ctrl.Name == "ProductQuantity")
                    {
                        if (int.Parse(ctrl.Text) == 0) { senderC.ForeColor = Color.Black; }
                        else { ctrl.Text = ((int.Parse(ctrl.Text)) - 1).ToString(); }
                    }
                    if (ctrl.Name == "increaseQuantity") { ctrl.ForeColor = Color.White; }
                }
                if (senderC.ForeColor != Color.Black)
                {
                    sendingRequests.DecreaseQuantity(idProduct, orderID);
                }
            }


        }

        private void AddingProduct_FormClosing(object sender, FormClosingEventArgs e) //Закрытие приложения
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e) // Возвращение в главное окно
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();
            orderID=0;
            this.Dispose();
        }

        private static T Clone<T>(T controlToClone, int flag) where T : Control // Для копирования свойств элемента
        {
            T instance = controlToClone;
            if (flag == 1) { instance = (T)Activator.CreateInstance(controlToClone.GetType()); } // Для элементов типа Control
            else { instance = Activator.CreateInstance<T>(); }
            PropertyInfo[] propertyInfo = controlToClone.GetType().GetProperties();

            foreach (PropertyInfo pi in propertyInfo)
            {
                if ((pi.CanWrite) && !(pi.Name == "WindowTarget") && !(pi.Name == "Capture"))
                {

                    pi.SetValue(instance, pi.GetValue(controlToClone, null), null);
                }
            }

            return instance;
        }
    }
}
