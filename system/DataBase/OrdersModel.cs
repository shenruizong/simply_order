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
        public Boolean InsertOrder(DatabaseDataSet.ordersDataTable Orders,DataRow[] order_list)
        {

            try
            {
                DatabaseDataSetTableAdapters.ordersTableAdapter orders = new DatabaseDataSetTableAdapters.ordersTableAdapter();
                DataRow orders_Row = Orders.Select().First();
                DatabaseDataSetTableAdapters.order_infoTableAdapter orderInfo = new DatabaseDataSetTableAdapters.order_infoTableAdapter();
                DatabaseDataSet.order_infoDataTable infoDt = new DatabaseDataSet.order_infoDataTable();
                foreach (DataRow row in order_list)
                {
                    DataRow InfoRow = infoDt.NewRow();
                    InfoRow["order_id"] = (Int64)orders_Row["order_num"];
                    InfoRow["dish_id"] = (int)row["Dish_id"];
                    InfoRow["dish_num"] = (int)row["Dish_num"];
                    InfoRow["dish_price"] = (int)row["Dish_price"];
                    InfoRow["dish_name"] = (string)row["Dish_name"];
                    infoDt.Rows.Add(InfoRow);
                }
                orders.Update(Orders);
                orderInfo.Update(infoDt);
                return true;
            }
            catch (Exception ex)
            {
                
                return false;
            }
        }
        public string TableToOrder_num(int table_id)
        {
            DatabaseDataSetTableAdapters.ordersTableAdapter orders = new DatabaseDataSetTableAdapters.ordersTableAdapter();
            DataTable dt = orders.GetDataByTable(table_id);
            DataRow orderRow = dt.Select().First() ;
            string orderNum = (string)orderRow["order_num"];
            return orderNum;
        }
        public DataTable Order_numToOrder_info(string OrderNum)
        {
            DatabaseDataSetTableAdapters.order_infoTableAdapter order_info = new DatabaseDataSetTableAdapters.order_infoTableAdapter();
            DataTable dt = order_info.GetDataByOrder_num(OrderNum);
            return dt;
        }
    }
}
