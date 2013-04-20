using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DataBase
{
    public class OrderInfoModel
    {
        public DataTable GetByOrderid(Int64 order_id)
        {
            DatabaseDataSetTableAdapters.order_infoTableAdapter infoAp = new DatabaseDataSetTableAdapters.order_infoTableAdapter();
            DataTable dt = infoAp.GetDataByOrder_num(order_id);
            return dt;
        }
    }
}
