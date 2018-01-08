using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class CategoryBLL
    {
         /// <summary>
        /// 获取图书分类信息的方法
        /// </summary>
        /// <returns>得到图书分类信息的数据集合</returns>
        public static List<Model.Category> GetCategory()
        {
            return DAL.CategoryDAL.GetCategory();
        }
    }
}
