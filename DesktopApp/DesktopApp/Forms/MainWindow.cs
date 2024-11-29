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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace DesktopApp.Forms
{
    public partial class MainWindow : Form
    {
        SendingRequests sendingRequests = new SendingRequests();
        List<GroupBox> GB = new List<GroupBox>();
        
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            List <string[]> ordersList=sendingRequests.ListOfOrders();
            if (ordersList.Count == 0)
            {
                label4.Visible = true;
            }
            else
            {
                groupBox1.Visible = true;
                Control controlGB = groupBox1;
                Control flowLP = flowLayoutPanel1;
                var tabIndexMin = groupBox1.TabIndex;
                var tabIndexMax = groupBox1.TabIndex + 9;
                int tabIndexCurrent = 20;
                foreach (string[] order in ordersList)
                {
                    GroupBox gB = Clone(groupBox1,0);
                    gB.TabIndex = tabIndexCurrent;
                    tabIndexCurrent++;
                    GB.Add(gB);
                    flowLayoutPanel1.Controls.Add(gB);

                    foreach (Control ctrl in controlGB.Controls)
                    {
                        var newCtrl=Clone(ctrl,1);
                        switch (newCtrl.Name)
                        {
                            case "OrderID":{ newCtrl.Text = order[0];break; }
                            case "OrderCreationDate": { newCtrl.Text = order[1]; break; }
                            case "OrderCost": { newCtrl.Text = order[2]; break; }
                            case "viewProductList": { newCtrl.Click += new System.EventHandler(this.viewProductList_Click); break; }
                            case "removeOrder": { newCtrl.Click += new System.EventHandler(this.removeOrder_Click); break; }
                        }
                        gB.Controls.Add(newCtrl);
                    }
                }
                groupBox1.Visible = false;
            }
        }

        private void createOrder_Click(object sender, EventArgs e)
        {
            string[] contentArray = sendingRequests.CreateOrder();
            if (contentArray.Length > 0)
            {
                int orderID = 0;
                foreach (string id in contentArray)
                {
                    orderID = int.Parse(id);
                }

                var addingProduct = new AddingProduct(orderID);
                addingProduct.Show();
                this.Dispose();
            }
                
        }

        private void viewProductList_Click(object sender, EventArgs e)
        {
            int orderID = 0;
            Control senderC = (Control)sender;
            Control parent = senderC.Parent;
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl.Name == "OrderID")
                { orderID = int.Parse(ctrl.Text); }
            }
            var addingProduct = new AddingProduct(orderID);
            addingProduct.Show();
            this.Dispose();
        }

        private void removeOrder_Click(object sender, EventArgs e)
        {
            Control senderC = (Control)sender;
            Control parent = senderC.Parent;
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl.Name == "OrderID")
                { sendingRequests.RemoveOrder(int.Parse(ctrl.Text)); }
            }
            parent.Dispose();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1(1);
            this.Dispose();
        }

        private static T Clone<T>(T controlToClone, int flag) where T : Control
        {
            T instance = controlToClone;
            if (flag == 1) { instance = (T)Activator.CreateInstance(controlToClone.GetType()); }
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
