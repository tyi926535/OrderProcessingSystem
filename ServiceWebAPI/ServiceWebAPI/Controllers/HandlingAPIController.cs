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

        public DataTable SampleRequest(string querySQL) // Выполнение SQL запросов
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
            string querySQL = $"SELECT ID FROM Users WHERE UserLogin='{login}' And ID>0;";
            DataTable dt = SampleRequest(querySQL);
            var dtList= Swap(dt);


            return dtList;
        }
        //https://localhost:5433/api/Handling/{login}/admin
        [Route("{login}/admin")]
        [ActionName("get"), HttpGet]
        public List<string> LoginCheckAdmin(string login)  // Метод для проверки логина и возврата id пользователя
        {
            string querySQL = $"SELECT ID FROM Users WHERE UserLogin='{login}' AND ID=0;";
            DataTable dt = SampleRequest(querySQL);
            var dtList = Swap(dt);


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
        public List<string> ListOfProducts(int idUser) // Получение ID и названия товаров у всех записей из таблицы Products
        {
            string querySQL = $"SELECT ID, ProductName FROM  Products";
            DataTable dt = SampleRequest(querySQL);
            List<string> dtList = Swap(dt);
            return dtList;
        }

        //https://localhost:5433/api/Handling/{idOrder}/creatingAItem/{idProduct}
        [Route("{idOrder:int}/creatingAItem/{idProduct:int}")]
        [ActionName("get"), HttpGet]
        public void CreatingAnOrderItem(int idOrder, int idProduct) // Создание записи в таблице с позициями заказа
        {
            string querySQL = $"INSERT INTO OrderItem (OrderID,ProductID,ProductQuantity) Values({idOrder},{idProduct},0)";
            DataTable dt = SampleRequest(querySQL);
        }
        //https://localhost:5433/api/Handling/{id}/listProducts
        [Route("{id:int}/listProducts")]
        [ActionName("get"), HttpGet]
        public List<string> GetListProducts(int id) // Получение всех записей из таблицы Products
        {
            string querySQL = $"Select * FROM Products";
            DataTable dt = SampleRequest(querySQL);
            List<string> dtList = Swap(dt);
            return dtList;
        }
        //https://localhost:5433/api/Handling/{id}/listUsers
        [Route("{id:int}/listUsers")]
        [ActionName("get"), HttpGet]
        public List<string> GetListUsers(int id) // Получение всех записей из таблицы Users, кроме админа
        {
            string querySQL = $"Select * FROM Users WHERE ID>0";
            DataTable dt = SampleRequest(querySQL);
            List<string> dtList = Swap(dt);
            return dtList;
        }

        [Route("{name}/addingUser/{login}")]
        [ActionName("get"), HttpGet]
        public void AddingDBUsers(string name, string login) // Создание записи в таблице Users
        {
            string querySQL = $"INSERT INTO Users (UserName,UserLogin) Values('{name}','{login}')";
            DataTable dt = SampleRequest(querySQL);
        }

        [Route("{name}/addingProduct/{price:int}/{quantity:int}")]
        [ActionName("get"), HttpGet]
        public void AddingDBProducts(string name, int price, int quantity) // Создание записи в таблице Products
        {
            string querySQL = $"INSERT INTO Products (ProductName,Price,ProductQuantity) Values('{name}',{price},{quantity})";
            DataTable dt = SampleRequest(querySQL);
        }

        [Route("{id:int}/updateProduct/{name}/{price:int}/{quantity:int}")]
        [ActionName("get"), HttpGet]
        public void UpdateDBProduct(int id,string name, int price, int quantity) // Создание записи в таблице Products
        {
            string querySQL = $"Update Products SET ProductName='{name}', Price={price}, ProductQuantity={quantity} where ID={id};";
            DataTable dt = SampleRequest(querySQL);
        }

        [Route("{id:int}/updateUser/{name}/{login}")]
        [ActionName("get"), HttpGet]
        public void UpdateDBUser(int id,string name, string login) // Создание записи в таблице Products
        {
            string querySQL = $"Update Users SET UserName='{name}' , UserLogin='{login}' where ID={id};";
            DataTable dt = SampleRequest(querySQL);
        }
        [Route("{id:int}/deleteUser")]
        [ActionName("get"), HttpGet]
        public void DeleteUser(int id) // Создание записи в таблице Products
        {
            string querySQL = $"Declare @countOrder INT SET @countOrder = 0 ;" +
                $"\r\nDeclare @maxID INT SET @countOrder = 0  ;" +
                $"\r\nSelect @countOrder=count(ID) From Orders where IDUser={id};" +
                $"\r\nDECLARE @number INT SET @number = 0  while @number <= @countOrder" +
                $"\r\nBEGIN\r\nSelect @maxID=max(ID)  From Orders where IDUser={id};\r\n" +
                $"Delete OrderItem where OrderID=@maxID;\r\n" +
                $"Delete Orders where ID=@maxID;\r\n" +
                $"SET @number=@number+1;\r\nEnd;\r\n" +
                $"Delete Users where ID={id};";
            DataTable dt = SampleRequest(querySQL);
        }
        [Route("{id:int}/deleteProduct")]
        [ActionName("get"), HttpGet]
        public void DeleteProduct(int id) // Создание записи в таблице Products
        {
            string querySQL = $"Delete OrderItem where ProductID={id};Delete Products where ID={id};";
            DataTable dt = SampleRequest(querySQL);
        }




    }
}
