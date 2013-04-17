using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DataBase
{
    public class OrdersModel
    {
        public DataTable SelectAll()
        {
            DatabaseDataSetTableAdapters.ordersTableAdapter orders = new DatabaseDataSetTableAdapters.ordersTableAdapter();
            DataTable dt = orders.GetData();
            return dt;
        }
    }
}
