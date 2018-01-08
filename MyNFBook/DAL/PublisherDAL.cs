using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DAL
{
    public  class PublisherDAL
    {
        /// <summary>
        /// 查询图书出版社信息方法（）
        /// </summary>
        /// <returns>查找到出版社信息数据集合</returns>
        public static List<Model.Publisher> GetPublisher()
        {
            List<Model.Publisher> modelList = new List<Model.Publisher>();
            string sql = "  select * from Publisher";
            SqlDataReader dr = DbHepler.ExecuteReader(sql,System.Data.CommandType.Text);

            while (dr.Read())
            {
                modelList.Add(new Model.Publisher()
                {
                    ID = (int)dr["ID"],
                    ImageUrl = dr["ImageUrl"].ToString(),
                    PublisherName = dr["PublisherName"].ToString(),
                    Remark = dr["Remark"].ToString(),
                    State = (int)dr["State"],
                    WebUrl = dr["WebUrl"].ToString(),
                });
            }
            DbHepler.Close();               
            return modelList;
        }
    }
}
