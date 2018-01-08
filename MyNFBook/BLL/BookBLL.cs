using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BookBLL
    {
        /// <summary>
       /// 读取图书信息方法（）
       /// </summary>
       /// <returns>查询到图书信息数据集合</returns>
        public static List<Model.Book> GetBooksInfor()
        {
            return DAL.BookDAL.GetBooksInfor();
        }
    }
}
