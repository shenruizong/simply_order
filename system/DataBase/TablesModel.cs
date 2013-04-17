﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DataBase
{
    public class TablesModel
    {
        /// <summary>
        /// 查询所有桌台表信息
        /// </summary>
        /// <returns></returns>
        public DataTable SelectAll()
        {
            DatabaseDataSetTableAdapters.tablesTableAdapter tables = new DatabaseDataSetTableAdapters.tablesTableAdapter();
            DataTable dt = tables.GetData();
            return dt;
        }
        public void ChangeTableType(DataRowView rowView,int type)
        {
            DatabaseDataSetTableAdapters.tablesTableAdapter tables = new DatabaseDataSetTableAdapters.tablesTableAdapter();
            DataRow row = rowView.Row;
            row["type_id"] = type;
            tables.Update(row);
        }
    }
}
