using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DesktopApp
{
    internal class SendingRequests
    {
        private const string url = "https://localhost:5433/api/Handling";  //Адрес сервера
        private static int idUser; 

        public bool LoginCheck(string login) 
        {
            string urlRequests = url+'/' +login;
            string content = CreatingRequests(urlRequests);
            if (content != "")
            {
                string jsonStrShort = "";
                int flag = 0;
                foreach (char i in content)
                {
                    if (i == ')') {  flag--; }
                    if (flag > 0) { jsonStrShort += i; }
                    if (i == '(') { flag++; }
                }
                idUser= int.Parse(jsonStrShort);
                return true;
            }
            return false;
        }

        public List<string[]> ListOfOrders()
        {
            List<string[]> contentList = new List<string[]>();
            string urlRequests = url + '/' + idUser + "/orders";
            string content = CreatingRequests(urlRequests);
            if (content != "")
            {
                List<string[]> contentStringTrim = ContentStringTrim(content);
                return contentStringTrim;

            }
            return contentList;
        }

        public void RemoveOrder(int orderID)
        {
            string urlRequests = url + '/' + orderID + "/removeOrder";
            string content = CreatingRequests(urlRequests);
        }
        public string[] CreateOrder()
        {
            string[] contentArray2 = new string[1];
            string urlRequests = url + '/' + idUser + "/createOrder";
            string content = CreatingRequests(urlRequests);
            if (content != "")
            {
                string[] contentArray = content.Split(new char[] { '"', ',', '[', ']',')','(' });
                contentArray2 = (from x in contentArray where ((x != "") && (x != " ")) select x).ToArray();
            }
            return contentArray2;
        }
        


        public List<string[]> ListOfProductsInTheOrder(int orderID)
        {
            List<string[]> contentList = new List<string[]>();
            string urlRequests = url + '/' + orderID + "/productsInOrder";
            string content = CreatingRequests(urlRequests);
            if (content != "")
            {
                List<string[]> contentStringTrim= ContentStringTrim(content);
                return contentStringTrim;
            }
            return contentList;
        }

        public bool IncreaseQuantity(int idProduct,int orderID)
        {
            string urlRequests = url + '/' + orderID + "/increaseQuantit/" + idProduct;
            string content = CreatingRequests(urlRequests);
            if (content != "")
            {
                List<string[]> contentStringTrim = ContentStringTrim(content);
                if (contentStringTrim[0][0] == "true") { return true; }
            }
            return false;

        }
        public void DecreaseQuantity(int idProduct,int orderID)
        {
            string urlRequests = url + '/' + orderID + "/decreaseQuantity/" + idProduct;
            string content = CreatingRequests(urlRequests);

        }
       
        public void RemoveProductOrder(int idProduct, int orderID) 
        {
            string urlRequests = url + '/' + orderID + "/removeProductOrder/" + idProduct;
            string content = CreatingRequests(urlRequests);
        }
        public List<string[]> ListOfProducts() //Возвращает список товаров
        {
            List<string[]> contentList = new List<string[]>();
            string urlRequests = url + "/1/listOfProducts";
            string content = CreatingRequests(urlRequests);
            if (content != "")
            {
                List<string[]> contentStringTrim = ContentStringTrim(content);
                return contentStringTrim;
            }
            return contentList;
        }

        public void CreatingAnOrderItem(int idProduct, int orderID)
        {
            string urlRequests = url + '/' + orderID + "/creatingAItem/" + idProduct;
            string content = CreatingRequests(urlRequests);

        }

        private string CreatingRequests(string urlRequests) //Создание запроса 
        {
            string content = "";
            WebRequest request = WebRequest.Create(urlRequests);
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            if (response.StatusDescription == "OK")
            {
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                content = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
                response.Close();
                
            }
            return content;
        }
        private List<string[]> ContentStringTrim(string content)  //Обработчик данных полученных из потока
        {
            List<string[]> contentList = new List<string[]>();
            string[] contentArray = content.Split(new char[] { '"', ',', '[', ']' });
            contentArray = (from x in contentArray where ((x != "") && (x != " ")) select x).ToArray();
            Console.WriteLine(contentArray);
            foreach (string str in contentArray)
            {
                string[] strArray = str.Split(new char[] { '(', ')' });
                strArray = (from x in strArray where ((x != "") && (x != " ")) select x).ToArray();
                contentList.Add(strArray);
            }
            return contentList;

        }
    }
}
