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
            systemDataSetTableAdapters.ordersTableAdapter orders = new systemDataSetTableAdapters.ordersTableAdapter();
            DataTable dt = orders.GetData();
            return dt;
        }
        public Boolean InsertOrder(systemDataSet.ordersDataTable Orders,DataRow[] order_list)
        {

            try
            {
                systemDataSetTableAdapters.ordersTableAdapter orders = new systemDataSetTableAdapters.ordersTableAdapter();
                DataRow orders_Row = Orders.Select().First();
                systemDataSetTableAdapters.order_infoTableAdapter orderInfo = new systemDataSetTableAdapters.order_infoTableAdapter();
                systemDataSet.order_infoDataTable infoDt = new systemDataSet.order_infoDataTable();
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
        public Int64 TableToOrder_num(int table_id)
        {
            systemDataSetTableAdapters.ordersTableAdapter orders = new systemDataSetTableAdapters.ordersTableAdapter();
            DataTable dt = orders.GetDataByTable(table_id);
            DataRow orderRow = dt.Select().First() ;
            Int64 orderNum = (Int64)orderRow["order_num"];
            return orderNum;
        }
        public DataTable Order_numToOrder_info(Int64 OrderNum)
        {
            systemDataSetTableAdapters.order_infoTableAdapter order_info = new systemDataSetTableAdapters.order_infoTableAdapter();
            DataTable dt = order_info.GetDataByOrder_num(OrderNum);
            return dt;
        }
    }
}
