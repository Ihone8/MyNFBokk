using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DAL
{
   public  class BookDAL
   {
       /// <summary>
       /// 读取图书信息方法（）
       /// </summary>
       /// <returns>查询到图书信息数据集合</returns>
       public static List<Model.Book> GetBooksInfor()
       {
           List<Model.Book> modelList = new List<Model.Book>();
           string sql = " select * from book";
           SqlDataReader dr = DbHepler.ExecuteReader(sql,System.Data.CommandType.Text);
           while (dr.Read())
           {
               modelList.Add(new Model.Book()
               {
                   Author = dr["Author"].ToString(),
                   AuthorDesc = dr["AuthorDesc"].ToString(),
                   CategoryID = (int)dr["CategoryID"],
                //  CategoryName = dr["CategoryName"].ToString(),
                   Clicks = (int)dr["Clicks"],
                   ContentDesc = dr["ContentDesc"].ToString(),
                   EditorComment = dr["EditorComment"].ToString(),
                   ID = dr["ID"].ToString(),
                   ISBN = dr["ISBN"].ToString(),
                   Price = (decimal)dr["Price"],
                   PublishDate = (DateTime)dr["PublishDate"],
                   PublisherID = (int)dr["PublisherID"],
                  // PublisherName = dr["PublisherName"].ToString(),
                   State = (int)dr["State"],
                   Title = dr["Title"].ToString(),
                   TOC = dr["TOC"].ToString(),
                   WordsCount = (int)dr["WordsCount"],
               });
           }
           DbHepler.Close();
           return modelList;
       }
       /// <summary>
       /// 读取图书信息方法（）
       /// </summary>
       /// <param name="pagenum">显示的条数</param>
       /// <param name="pageindex">当前页码</param>
       /// <returns>查询到图书信息数据集合</returns>
       public static List<Model.Book> BOOK(int pagenum,int pageindex,out int pagesCount)
       {
           List<Model.Book> modelList = new List<Model.Book>();
           SqlParameter [] P={
                                 new SqlParameter("@pageIndex",pageindex),
                                 new SqlParameter("@pageCount",pagenum),
                                 new SqlParameter("@pageTotalCount",SqlDbType.Int),
                             };
           P[2].Direction = ParameterDirection.Output;
            
           SqlDataReader dr = DbHepler.ExecuteReader("WY", System.Data.CommandType.StoredProcedure, P);
               pagesCount = Convert.ToInt32(P[2].Value); 
           while (dr.Read())
           {
              
               modelList.Add(new Model.Book()
               {
                   Author = dr["Author"].ToString(),
                   AuthorDesc = dr["AuthorDesc"].ToString(),
                   CategoryID = (int)dr["CategoryID"],
                   //  CategoryName = dr["CategoryName"].ToString(),
                   Clicks = (int)dr["Clicks"],
                   ContentDesc = dr["ContentDesc"].ToString(),
                   EditorComment = dr["EditorComment"].ToString(),
                   ID = dr["ID"].ToString(),
                   ISBN = dr["ISBN"].ToString(),
                   Price = (decimal)dr["Price"],
                   PublishDate = (DateTime)dr["PublishDate"],
                   PublisherID = (int)dr["PublisherID"],
                   // PublisherName = dr["PublisherName"].ToString(),
                   State = (int)dr["State"],
                   Title = dr["Title"].ToString(),
                   TOC = dr["TOC"].ToString(),
                   WordsCount = (int)dr["WordsCount"],
               });
           }
 
           DbHepler.Close();
           return modelList;
       }
       public static List<Model.Book> GetBImage(int pagenum, int pageindex, out int pageCount)
       {
           List<Model.Book> books = new List<Model.Book>();
           SqlParameter[] P ={
                                 new SqlParameter("@pageIndex",pageindex),
                                 new SqlParameter("@pageCount",pagenum),
                                 new SqlParameter("@pageTotalCount",SqlDbType.Int),
                             };
           P[2].Direction = ParameterDirection.Output;
           DataSet ds = DbHepler.GetDataSet("WY", System.Data.CommandType.StoredProcedure, P);
           pageCount = Convert.ToInt32(P[2].Value);
           foreach (DataRow dr in ds.Tables[0].Rows)
           {
                   Model.Book book = new Model.Book();
                   book.Author = dr["Author"].ToString();
                   book.AuthorDesc = dr["AuthorDesc"].ToString();
                   book.CategoryID = (int)dr["CategoryID"];
                   book.Clicks = (int)dr["Clicks"];
                   book.ContentDesc = dr["ContentDesc"].ToString();
                   book.EditorComment = dr["EditorComment"].ToString();
                   book.ID = dr["ID"].ToString();
                   book.ISBN = dr["ISBN"].ToString();
                   book.Price = (decimal)dr["Price"];
                   book.PublishDate = (DateTime)dr["PublishDate"];
                   book.PublisherID = (int)dr["PublisherID"];
                   book.State = (int)dr["State"];
                   book.Title = dr["Title"].ToString();
                   book.TOC = dr["TOC"].ToString();
                   book.WordsCount = (int)dr["WordsCount"];
                   books.Add(book);
           }
           return books;
       }
    }
}
