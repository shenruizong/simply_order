using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DataBase
{
    public class DishModel
    {
        public DataTable SelectAll()
        {
            DatabaseDataSetTableAdapters.dishTableAdapter dish = new DatabaseDataSetTableAdapters.dishTableAdapter();
            DataTable dt = dish.GetData();
            return dt;
        }
    }
}
