using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DataBase
{
    public class TableClass
    {
        /// <summary>
        /// 查询所有信息
        /// </summary>
        /// <returns></returns>
        public DataTable SelectAll()
        {
            DatabaseDataSetTableAdapters.tablesTableAdapter tableAp = new DatabaseDataSetTableAdapters.tablesTableAdapter();
            DataTable dt = tableAp.GetData();
            return dt;
        }
    }
}
