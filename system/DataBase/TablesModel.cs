using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DataBase
{
    public class TablesModel
    {
        public DataTable SelectAll()
        {
            DatabaseDataSetTableAdapters.tablesTableAdapter tables = new DatabaseDataSetTableAdapters.tablesTableAdapter();
            DataTable dt = tables.GetData();
            return dt;
        }
    }
}
