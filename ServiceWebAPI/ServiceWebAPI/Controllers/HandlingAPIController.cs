using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//using System.Web.Http;
using ServiceWebAPI.Models;
using System.Data;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using System.Net.Security;
using System.Collections.Generic;

namespace ServiceWebAPI.Controllers
{
    [Route("api/Handling")]
    [ApiController]
    public class HandlingAPIController : ControllerBase
    {
        PointDataBase pointDataBase = new PointDataBase();

        public DataTable SampleRequest(string querySQL) // Выполнение SQL pfghjcf
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlCommand sqlCommand = new SqlCommand(querySQL, pointDataBase.GetConnection());
            adapter.SelectCommand = sqlCommand;
            adapter.Fill(dt);
            return dt;
        }
        public List<string> Swap(DataTable dt)  // Метод для формирования списка из строк таблицы
        {
            var dtList = new List<string>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    string columnstring = "";
                    foreach (DataColumn column in dt.Columns)
                    {
                        var item = row[column.ColumnName];
                        columnstring += $"({item})";
                    }
                    dtList.Add(columnstring);
                }
            }
            
            return dtList;
        }



        //https://localhost:5433/api/Handling/{login}
        [Route("{login}")]
        [ActionName("get"), HttpGet]
        public List<string> LoginCheck(string login)  // Метод для проверки логина и возврата id пользователя
        {
            string querySQL = $"SELECT ID FROM Users WHERE \"UserLogin\"='" + login + "';";
            DataTable dt = SampleRequest(querySQL);
            var dtList= Swap(dt);


            return dtList;
        }

        //https://localhost:5433/api/Handling/{idUser}/orders
        [Route("{idUser:int}/orders")]
        [ActionName("get"), HttpGet]
        public List<string> ListOfOrders(int idUser) // Метод для формирования списка заказов
        {
            string querySQL = $"SELECT ID,Convert(date,CreationDate),OrderPrice FROM Orders WHERE IDUser={idUser};";
            DataTable dt = SampleRequest(querySQL);
            var dtList = Swap(dt);

            return dtList;
        }

        //https://localhost:5433/api/Handling/{idOrder}/removeOrder
        [Route("{idOrder:int}/removeOrder")]
        [ActionName("get"), HttpGet]
        public void RemoveOrder(int idOrder)  // Удаление заказа
        {
            string querySQL = $"Declare @maxProduct INT;  " +
                $"Select @maxProduct=max(ID) from Products;  " +
                $"DECLARE @number INT SET @number = 1  while @number <= @maxProduct  " +
                $"BEGIN\r\nif (select ProductQuantity from OrderItem where OrderID={idOrder} and ProductID=@number) != 0  " +
                $"Update Products SET ProductQuantity=(ProductQuantity+(select ProductQuantity from OrderItem where OrderID={idOrder} and ProductID=@number)) " +
                $"where ID= @number;\r\n set @number = @number+1\r\nEND;\r\nDELETE OrderItem WHERE OrderID={idOrder};DELETE Orders WHERE ID={idOrder};";
            DataTable dt = SampleRequest(querySQL);
        }
        //https://localhost:5433/api/Handling/{idUser}/createOrder
        [Route("{idUser:int}/createOrder")]
        [ActionName("get"), HttpGet]
        public List<string> CreateOrder(int idUser)  // Создание заказа
        {
            string querySQL = $"INSERT INTO Orders (IDUser,CreationDate,OrderPrice) \r\nValues({idUser},(SELECT Convert(date, GetDate())as Today ),0); " +
                $"Select MAX(ID) From Orders";
            DataTable dt = SampleRequest(querySQL);
            var dtList = Swap(dt);

            return dtList;
        }

        //https://localhost:5433/api/Handling/{idOrder}/productsInOrder
        [Route("{idOrder:int}/productsInOrder")]
        [ActionName("get"), HttpGet]
        public List<string> ListOfProductsInTheOrder(int idOrder) // Метод для формирования списка позиций заказа
        {
            string querySQL = $"SELECT Products.ID, Products.ProductName, Products.Price, OrderItem.ProductQuantity " +
                $"FROM OrderItem INNER JOIN Products ON OrderItem.ProductID=Products.ID WHERE OrderItem.OrderID={idOrder};";
            DataTable dt = SampleRequest(querySQL);
            var dtList = Swap(dt);

            return dtList;
        }

        //https://localhost:5433/api/Handling/{idOrder}/increaseQuantit/{idProduct}
        [Route("{idOrder:int}/increaseQuantit/{idProduct:int}")]
        [ActionName("get"), HttpGet]
        public string IncreaseQuantity( int idOrder,int idProduct) // Увеличение количества товара в позиции заказа на 1
        {
            string querySQL = $"if ((Select ProductQuantity From Products where ID={idProduct} )>0) " +
                $"Begin UPDATE Products SET ProductQuantity = (ProductQuantity-1) where ID={idProduct} " +
                $"UPDATE OrderItem SET ProductQuantity = (ProductQuantity+1) where OrderID={idOrder} AND ProductID={idProduct} " +
                $"Select ProductQuantity From Products end; " +
                $"UPDATE Orders SET OrderPrice=(Select sum(Products.Price*OrderItem.ProductQuantity) From OrderItem Inner Join Products " +
                $"ON OrderItem.ProductID = Products.ID where OrderItem.OrderID = {idOrder}) where ID = {idOrder} ";
            DataTable dt = SampleRequest(querySQL);
            if(dt.Rows.Count > 0) { return "true"; }


            
            return "false";
        }

        //https://localhost:5433/api/Handling/{idOrder}/decreaseQuantity/{idProduct}
        [Route("{idOrder:int}/decreaseQuantity/{idProduct:int}")]
        [ActionName("get"), HttpGet]
        public void DecreaseQuantity(int idOrder, int idProduct) // Уменьшение количества товара в позиции заказа на 1
        {
            string querySQL = $"UPDATE Products SET ProductQuantity = (ProductQuantity+1) where ID={idProduct} " +
                $"UPDATE OrderItem SET ProductQuantity = (ProductQuantity-1) where OrderID={idOrder} AND ProductID={idProduct} " +
                $"UPDATE Orders SET OrderPrice=(Select sum(Products.Price*OrderItem.ProductQuantity) From OrderItem Inner Join Products " +
                $"ON OrderItem.ProductID = Products.ID where OrderItem.OrderID = {idOrder}) where ID = {idOrder} ";
            DataTable dt = SampleRequest(querySQL);
        }

        //https://localhost:5433/api/Handling/{idOrder}/removeProductOrder/{idProduct}
        [Route("{idOrder:int}/removeProductOrder/{idProduct:int}")]
        [ActionName("get"), HttpGet]
        public void RemoveProductOrder(int idOrder, int idProduct) // Удаление позиции заказа
        {
            string querySQL = $"UPDATE Products SET ProductQuantity = (ProductQuantity+ ( select ProductQuantity from OrderItem where ProductID={idProduct} AND OrderID={idOrder} ) ) where ID={idProduct} " +
                $"UPDATE OrderItem SET ProductQuantity = 0 where ProductID={idProduct} AND OrderID={idOrder} " +
                $"UPDATE Orders SET OrderPrice=(Select sum(Products.Price*OrderItem.ProductQuantity) From OrderItem Inner Join Products "+ 
                $"ON OrderItem.ProductID = Products.ID where OrderItem.OrderID = {idOrder}) where ID = {idOrder} " +
                $"DELETE OrderItem  where ProductID={idProduct} AND OrderID={idOrder}";
            DataTable dt = SampleRequest(querySQL);
        }

        //https://localhost:5433/api/Handling/listOfProducts
        [Route("{idUser}/listOfProducts")]
        [ActionName("get"), HttpGet]
        public List<string> ListOfProducts(int idUser) // метод для формирование списка товаров
        {
            string querySQL = $"SELECT ID, ProductName FROM  Products";
            DataTable dt = SampleRequest(querySQL);
            List<string> dtList = Swap(dt);

            return dtList;
        }

        //https://localhost:5433/api/Handling/{idOrder}/creatingAItem/{idProduct}
        [Route("{idOrder:int}/creatingAItem/{idProduct:int}")]
        [ActionName("get"), HttpGet]
        public void CreatingAnOrderItem(int idOrder, int idProduct) // Создание позиции заказа 
        {
            string querySQL = $"INSERT INTO OrderItem (OrderID,ProductID,ProductQuantity) Values({idOrder},{idProduct},0)";
            DataTable dt = SampleRequest(querySQL);
        }





    }
}
