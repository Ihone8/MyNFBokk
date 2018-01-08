using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
namespace DAL
{
    public class CategoryDAL
    {
        /// <summary>
        /// 获取图书分类信息的方法
        /// </summary>
        /// <returns>得到图书分类信息的数据集合</returns>
        public static List<Model.Category> GetCategory()
        {
            List<Model.Category> category = new List<Model.Category>();
            string sql = "  select * from Category";
            SqlDataReader dr = DbHepler.ExecuteReader(sql,System.Data.CommandType.Text);
            while (dr.Read())
            {
                category.Add(new Model.Category() { ID = (int)dr["ID"], CategoryName = dr["CategoryName"] as string, ParentID = 0, ParentName = "", Remark = dr["Remark"] as string, State = (int)dr["State"] });
            }
            DbHepler.Close();
            return category;
        }
    }
}
