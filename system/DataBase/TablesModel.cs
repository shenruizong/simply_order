using System;
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
            systemDataSetTableAdapters.tablesTableAdapter tables = new systemDataSetTableAdapters.tablesTableAdapter();
            DataTable dt = tables.GetData();
            return dt;
        }
        public void ChangeTableType(DataRowView rowView,int type)
        {
            systemDataSetTableAdapters.tablesTableAdapter tables = new systemDataSetTableAdapters.tablesTableAdapter();
            DataRow row = rowView.Row;
            row["type_id"] = type;
            tables.Update(row);
        }
        public void TurnTable(DataRowView firstTable, DataRowView secTable)
        {
            systemDataSetTableAdapters.tablesTableAdapter tables = new systemDataSetTableAdapters.tablesTableAdapter();
            firstTable["type_id"] = 1;
            secTable["type_id"] = 2;
            tables.Update(firstTable.Row);
            tables.Update(secTable.Row);

            systemDataSetTableAdapters.ordersTableAdapter orders = new systemDataSetTableAdapters.ordersTableAdapter();
            int FirTable_id = (int)firstTable["id"];
            int SecTable_id = (int)secTable["id"];
            systemDataSet.ordersDataTable ordersDt =  orders.GetDataByTable(FirTable_id);
            DataRow OrderRow = ordersDt.Select().First();
            OrderRow["table_id"] = SecTable_id;
            orders.Update(OrderRow);
        }
        public DataTable GetFreeTable()
        {
            systemDataSetTableAdapters.tablesTableAdapter tables = new systemDataSetTableAdapters.tablesTableAdapter();
            DataTable dt = tables.GetDataByFree();
            return dt;
        }
        public void AddTable(DataTable dt)
        {
            systemDataSetTableAdapters.tablesTableAdapter tableAp = new systemDataSetTableAdapters.tablesTableAdapter();
            tableAp.Update((systemDataSet.tablesDataTable)dt);
        }
        public void UpdateRow(DataRow row)
        {
            systemDataSetTableAdapters.tablesTableAdapter tableAp = new systemDataSetTableAdapters.tablesTableAdapter();
            tableAp.Update(row);
        }
        
    }
}
