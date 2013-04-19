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
        public void UpdateRow(DataRow row)
        {
            DatabaseDataSetTableAdapters.dishTableAdapter dish = new DatabaseDataSetTableAdapters.dishTableAdapter();
            dish.Update(row);
        }
        public void AddDish(DataTable dt)
        {
            DatabaseDataSetTableAdapters.dishTableAdapter dishTA = new DatabaseDataSetTableAdapters.dishTableAdapter();
            dishTA.Update((DatabaseDataSet.dishDataTable)dt);
        }
    }
}
