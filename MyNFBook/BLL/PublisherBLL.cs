using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PublisherBLL
    {
        /// <summary>
        /// 查询图书出版社信息方法（）
        /// </summary>
        /// <returns>查找到出版社信息数据集合</returns>
        public static List<Model.Publisher> GetPublisher()
        {
            return DAL.PublisherDAL.GetPublisher();
        }
    }
}
