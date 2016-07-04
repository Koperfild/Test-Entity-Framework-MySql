using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;


namespace Entity_Framework_Test___MySql
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ping pingSender = new Ping();
            //PingReply reply = pingSender.Send("localhost");
            //if (reply.Status == IPStatus.Success && )

            using (var mc = new Model1Container())
            {
                try
                {
                    mc.Database.Connection.Open();//Не понял. Вроде как DbConnection - абстрактный класс. Как тут вызывается у него метод Open, Да и просто его экземпляр ставит в тупик
                    var coun = from c in mc.country
                               select c;

                    var newCountry = new country() { country1 = "Belarus" };
                    mc.country.Add(newCountry);
                    mc.SaveChanges();

                    foreach (var country in coun)
                    {
                        Console.WriteLine(country.country1);
                    }
                    mc.Database.Connection.Close();
                }
                catch(MySql.Data.MySqlClient.MySqlException ex)
                {
                    Console.WriteLine(ex.Message+'\n'+ex.ToString());
                }

            }
            Console.ReadKey();
        }
    }
}

////////////////////////////////////////////////////////////////////////////////
//Useful solutions

//try
//        {
//            MyContext.Database.Connection.Open();
//            MyContext.Database.Connection.Close();
//        }
//        catch(SqlException)