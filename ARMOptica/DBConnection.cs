using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace ARMOptica
{
    class DBConnection
    {
        static string connectionString = @"Database = armoptica; Data Source = localhost; UserID = root; Password = qwerty"; //строка подключения
        static MySqlConnection msConnect; //объект для установки соединения с БД
        static MySqlCommand msCommand; //объект для выполнения запросов
        static public MySqlDataAdapter msDataAdapter;
        //установка соединения с БД
        static public bool Connect()
        {
            try
            {

                //создание объекта соединения с заданной строкой подключения
                msConnect = new MySqlConnection(connectionString);
                msConnect.Open(); //открытие подключение
                                  //создание объекта-запрос
                msCommand = new MySqlCommand();
                msCommand.Connection = msConnect;
                msDataAdapter = new MySqlDataAdapter(msCommand);
                return true; //результ «истина»
            }

            catch (Exception ex) //при возникновении ошибки
            {
                //вывод сообщения
                System.Windows.Forms.MessageBox.Show(ex.ToString(), "Ошибка!");
                return false; //результат «ложь»
            }
        }
        //отключение соединения с БД
        static public void Close()
        {
            msConnect.Close();
        }
        static public string User;
        static public string idWorker;
        //логин авторизованного пользователя
        //авторизация пользователя, принимает параметры с формы авторизации
        static public void Authorization(string login, string password)
        {
            try
            {
                //формируем запрос: выбрать поле из таблицы значения,
                //где логин и пароль равны введенным пользователем значениям
                string sql = "SELECT Login FROM Users WHERE login = '" + login + "' AND password = '" + password + "';";
                //создаем запрос
                msCommand.CommandText = sql;
                //фиксируем результат запроса
                Object result = msCommand.ExecuteScalar();
                //если в результате выполнения запроса получено непустое значение
                if (result != null)
                {
                    //заполняем информацию об авторизованном пользователе
                    User = login;
                    sql = "SELECT WorkerID FROM Workers WHERE user = '" + login + "';";
                    msCommand.CommandText = sql;
                    result = msCommand.ExecuteScalar();
                    idWorker = Convert.ToString(result);
                }
            }
            catch (Exception ex) //при возникновении ошибки
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString(), "Ошибка!");
            }
        }

        //список всех покупателей
        static public DataTable dtCustomers = new DataTable();
        static public void GetCustomerList(string CustFIO = "", string CustTel = "", string CustAdr = "", string CustEmail = "")
        {
            //формируем запрос на выборку всех записей
            msCommand.CommandText = "SELECT CustID, CustFIO, CustTel, CustAdr, CustEmail FROM Customers WHERE CustFIO LIKE '%" + CustFIO + "%' AND CustTel LIKE '%" + CustTel + "%' AND CustAdr LIKE '%" + CustAdr + "%' AND CustEmail LIKE '%" + CustEmail + "%';";
            dtCustomers.Clear(); //очистка набора данных
            msDataAdapter.Fill(dtCustomers); //заполнение набора данных
        }

        //добавление покупателя в базу данных
        static public void AddCustomer(string name, string telephone, string adress, string email = null)
        {
            //формирование запроса
            msCommand.CommandText = @"INSERT INTO 
                                    `armoptica`.`customers` (`CustFIO`, `CustTel`, `CustAdr`, `CustEmail`) 
                                    VALUES ('" + name +"', '" + telephone +"', '" + adress +"', '" + email +"');";
            //выполение запроса
            msCommand.ExecuteNonQuery();
        }

        //редактирование покупателя в базе данных
        static public void redactCustomer(string id, string name, string telephone, string adress, string email = null)
        {
            //формирование запроса
            msCommand.CommandText = @"UPDATE `armoptica`.`customers` SET `CustFIO` = '" + name + "', `CustTel` = '" + telephone + "', `CustAdr` = '" + adress + "', `CustEmail` = '" + email + "' WHERE (`CustID` = '" + id + "');";
            //выполение запроса
            msCommand.ExecuteNonQuery();
        }

        //просмотр товара на складе
        static public DataTable dtStore = new DataTable();
        static public void GetStoreList()
        {
            //формируем запрос на выборку всех записей
            msCommand.CommandText = "SELECT assortiment.ProductID, assortiment.ProductName, Store.Count FROM armoptica.assortiment INNER JOIN Store USING(ProductID) GROUP BY ProductID;";
            dtStore.Clear(); //очистка набора данных
            msDataAdapter.Fill(dtStore); //заполнение набора данных
        }
        //просмотр товара на складе по условию
        static public void GetSortStoreList(string sortText, bool zeroTovar)
        {
            if (zeroTovar != true)
            {
                //формируем запрос на выборку всех записей
                msCommand.CommandText = "SELECT assortiment.ProductID, assortiment.ProductName, Store.Count FROM armoptica.assortiment INNER JOIN Store USING(ProductID) WHERE ProductName LIKE '%" + sortText + "%' GROUP BY ProductID;";
                dtStore.Clear(); //очистка набора данных
                msDataAdapter.Fill(dtStore); //заполнение набора данных
            }
            else
            {
                //формируем запрос на выборку всех записей
                msCommand.CommandText = "SELECT assortiment.ProductID, assortiment.ProductName, Store.Count FROM armoptica.assortiment INNER JOIN Store USING(ProductID) WHERE ProductName LIKE '%" + sortText + "%' AND Store.Count>0 GROUP BY ProductID;";
                dtStore.Clear(); //очистка набора данных
                msDataAdapter.Fill(dtStore); //заполнение набора данных
            }
        }

        //просмотр ассортимента в магазине
        static public DataTable dtAssortiment = new DataTable();
        static public void GetAssortimentList()
        {
            //формируем запрос на выборку всех записей
            msCommand.CommandText = @"SELECT assortiment.ProductID, assortiment.ProductName, productType.TypeName, assortiment.ProductPrice 
                                    FROM armoptica.assortiment, armoptica.producttype 
                                    WHERE assortiment.ProductTypeID = producttype.ProductTypeID;";
            dtAssortiment.Clear(); //очистка набора данных
            msDataAdapter.Fill(dtAssortiment); //заполнение набора данных
        }

        //просмотр ассортимента магазина по условию
        static public void GetSortAssortimentList(string sortName, string sortCategory, string sortPrice)
        {
            if (sortPrice != "")
            {
                //формируем запрос на выборку всех записей
                msCommand.CommandText = @"SELECT assortiment.ProductID, assortiment.ProductName, productType.TypeName, assortiment.ProductPrice 
                                    FROM armoptica.assortiment, armoptica.producttype 
                                    WHERE assortiment.ProductTypeID = producttype.ProductTypeID and assortiment.ProductName LIKE '%" + sortName + "%' and productType.TypeName LIKE '%" + sortCategory + "%' and assortiment.ProductPrice <= " + Convert.ToInt32(sortPrice) +";";
                dtAssortiment.Clear(); //очистка набора данных
                msDataAdapter.Fill(dtAssortiment); //заполнение набора данных
            }
            else
            {
                //формируем запрос на выборку всех записей
                msCommand.CommandText = @"SELECT assortiment.ProductID, assortiment.ProductName, productType.TypeName, assortiment.ProductPrice 
                                    FROM armoptica.assortiment, armoptica.producttype 
                                    WHERE assortiment.ProductTypeID = producttype.ProductTypeID and assortiment.ProductName LIKE '%" + sortName + "%' and productType.TypeName LIKE '%" + sortCategory + "%';";
                dtAssortiment.Clear(); //очистка набора данных
                msDataAdapter.Fill(dtAssortiment); //заполнение набора данных
            }
        }
        //список всех рабочих
        static public DataTable dtWorkers = new DataTable();
        static public void GetWorkersList(string UserLogin = "", string WorkerID = "", string WorkerFIO = "", string WorkerPost = "", string WorkerTel = "", string WorkerAdr = "")
        {
            //формируем запрос на выборку всех записей
            msCommand.CommandText = "SELECT * FROM Workers WHERE User LIKE '%" + UserLogin + "%' AND WorkerID LIKE '%" + WorkerID + "%' AND WorkerFIO LIKE '%" + WorkerFIO + "%' AND WorkerPost LIKE '%" + WorkerPost + "%' AND WorkerTel LIKE '%" + WorkerTel + "%' AND WorkerAdr LIKE '%" + WorkerAdr + "%' ORDER BY WorkerID;";
            dtWorkers.Clear(); //очистка набора данных
            msDataAdapter.Fill(dtWorkers); //заполнение набора данных
        }

        //формируем таблицу покупателей для окна составления цены
        static public DataTable dtCustomersForCheck = new DataTable();
        static public void GetCustomersForCheck(string sortText = "")
        {
            //формируем запрос на выборку всех записей
            msCommand.CommandText = "SELECT customers.CustID, customers.CustFIO, customers.CustTel, customers.CustAdr, customers.CustEmail FROM Customers WHERE customers.CustFIO LIKE '%" + sortText + "%';";
            dtCustomersForCheck.Clear(); //очистка набора данных
            msDataAdapter.Fill(dtCustomersForCheck); //заполнение набора данных
        }
        
        //формируем таблицу товара для окна составления цены
        static public DataTable dtTovarForCheck= new DataTable();
        static public void GetTovarForCheck(string sortText = "")
        {
            //формируем запрос на выборку всех записей
            msCommand.CommandText = "SELECT assortiment.ProductID, assortiment.ProductName, Store.Count, assortiment.ProductPrice FROM armoptica.assortiment INNER JOIN Store USING(ProductID) WHERE ProductName LIKE '%" + sortText + "%' AND Store.Count>0 GROUP BY ProductID;";
            dtTovarForCheck.Clear(); //очистка набора данных
            msDataAdapter.Fill(dtTovarForCheck); //заполнение набора данных
        }

        //таблица со скидками
        static public DataTable dtDiscounts = new DataTable();
        static public void GetDiscounts()
        {
            //формируем запрос на выборку всех записей
            msCommand.CommandText = "SELECT * FROM discounts;";
            dtDiscounts.Clear(); //очистка набора данных
            msDataAdapter.Fill(dtDiscounts); //заполнение набора данных
        }


        //добавление чека в базу данных
        static public void addCheck(string ProductID, string WorkerID, string CustomerID, string OrderAmount, string DiscountID, string OrderDate)
        {
            //формирование запроса
            msCommand.CommandText = @"INSERT INTO `armoptica`.`orders` (`ProductID`, `WorkerID`, `CustID`, `OrderAmount`, `DiscountID`, `OrderDate`) 
                                    VALUES ('" + ProductID + "', '" + WorkerID + "', '" + CustomerID + "', '" + OrderAmount + "', '" + DiscountID + "', '" + OrderDate + "');";
            //выполение запроса
            msCommand.ExecuteNonQuery();
        }

        //таблица со скидками
        static public DataTable dtChecks = new DataTable();
        static public void GetChecks(string ProductName = "", string WorkerFIO = "", string CustFIO = "", string OrderAmount = "")
        { //            orderIDTB.Text = productNameTB.Text = workerFIOTB.Text = custFIOTB.Text = countTB.Text = dicsountTB.Text = orderDateTB.Text = priceTB.Text = "";

            //формируем запрос на выборку всех записей
            msCommand.CommandText = @"SELECT orders.OrderID, assortiment.ProductName, workers.WorkerFIO, customers.CustFIO, 
                                    orders.OrderAmount, assortiment.ProductPrice, discounts.DiscountProcent, orders.OrderDate
                                    FROM armoptica.orders, armoptica.assortiment, armoptica.workers, armoptica.customers, armoptica.discounts
                                    WHERE assortiment.ProductID = orders.ProductID AND workers.WorkerID = orders.WorkerID AND
                                    customers.CustID = orders.CustID AND discounts.DiscountsID = orders.DiscountID AND ProductName LIKE '%" + ProductName + @"%' AND WorkerFIO LIKE '%" + WorkerFIO + @"%' AND CustFIO LIKE '%" + CustFIO + @"%' AND
                                    OrderAmount LIKE '%" + OrderAmount + @"%' ORDER BY OrderID;";
            dtChecks.Clear(); //очистка набора данных
            msDataAdapter.Fill(dtChecks); //заполнение набора данных
        }

    }
}
