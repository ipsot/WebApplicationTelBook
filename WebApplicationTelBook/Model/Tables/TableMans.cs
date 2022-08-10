using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationTelBook.Model.Entities;
using MySql.Data.MySqlClient;
using WebApplicationTelBook.Model.Tools;

namespace WebApplicationTelBook.Model.Tables
{
    public class TableMans
    {
        public List<Man> GetAllMans()
        {
            List<Man> mans = new List<Man>();

            MySqlCommand mySqlCommand = DbConnector.GetInstance().GetMySqlCommand();

            mySqlCommand.CommandText = "SELECT * FROM `mans`";
            MySqlDataReader reader = mySqlCommand.ExecuteReader();

            while (reader.Read()==true)
            {
                mans.Add(new Man()
                {
                    Id = reader.GetInt32("id"),
                    Name = reader.GetString("name"),
                    Phone = reader.GetString("phone"),
                    Description = reader.GetString("description"),
                });
            }

            reader.Close();

            return mans;
        }
    }
}