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
            systemDataSetTableAdapters.dishTableAdapter dish = new systemDataSetTableAdapters.dishTableAdapter();
            DataTable dt = dish.GetData();
            return dt;
        }
        public void UpdateRow(DataRow row)
        {
            systemDataSetTableAdapters.dishTableAdapter dish = new systemDataSetTableAdapters.dishTableAdapter();
            dish.Update(row);
        }
        public void AddDish(DataTable dt)
        {
            systemDataSetTableAdapters.dishTableAdapter dishTA = new systemDataSetTableAdapters.dishTableAdapter();
            dishTA.Update((systemDataSet.dishDataTable)dt);
        }
    }
}
