using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationTelBook.Model.Tables;

namespace WebApplicationTelBook.Model
{
    public class DbManager
    {
        public TableMans TableMans { get; }

        private static DbManager instance = null;

        private DbManager()
        {
            TableMans = new TableMans();
        }

        public static DbManager GetInstance()
        {
            if (instance == null)
            {
                instance = new DbManager();
            }

            return instance;
        }

    }
}