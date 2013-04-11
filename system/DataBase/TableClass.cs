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
        /// <returns>返回一个带数据的虚拟表</returns>
        public DataTable SelectAll()
        {
            DatabaseDataSetTableAdapters.tablesTableAdapter tableAp = new DatabaseDataSetTableAdapters.tablesTableAdapter();
            DataTable dt = tableAp.GetData();
            return dt;
        }
        /// <summary>
        /// 添加桌台
        /// </summary>
        /// <param name="table_name">桌台名</param>
        public void AddTable(string table_name)
        {
            try
            {
                DatabaseDataSetTableAdapters.tablesTableAdapter tableAp = new DatabaseDataSetTableAdapters.tablesTableAdapter();
                DatabaseDataSet.tablesDataTable tablesDt = new DatabaseDataSet.tablesDataTable();
                DataRow row = tablesDt.NewRow();
                row["name"] = table_name;
                tablesDt.Rows.Add(row);
                tableAp.Update(tablesDt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
