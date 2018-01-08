using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization.Json;
using System.Collections;
using System.Web.Script.Serialization;
namespace WebNFBook
{
    /// <summary>
    /// Books 的摘要说明
    /// </summary>
    public class Books : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
           // context.Response.Write("Hello World");
            int pageCount=0;
            int pageNum = int.Parse(context.Request["pageNum"]);
            int pageindex = int.Parse(context.Request["pageindex"]);
            List<Model.Book> Books = DAL.BookDAL.GetBImage(pageNum, pageindex, out pageCount);
           
            Dictionary<object, object> Dic = new Dictionary<object, object>();
           // List<Model.Book> bookPage = DAL.BookDAL.GetBooksInfor();
            //if (bookPage.Count % pageNum == 0)
            //{
            //    pageCount = bookPage.Count / pageNum;
            //}
            //else
            //{
            //    pageCount = (bookPage.Count / pageNum) + 1;
            //}
            Dic.Add("pageCount", pageCount);
            Dic.Add("books", Books);           
            //DataContractJsonSerializer daJson = new DataContractJsonSerializer(typeof(IDictionary));
            //daJson.WriteObject(context.Response.OutputStream, Dic);
            string json=(new JavaScriptSerializer()).Serialize(Dic);
            context.Response.Write(json);
        }
        /// <summary>  
        /// 将Dictionary序列化为json数据  
        /// </summary>  
        /// <param name="jsonData">json数据</param>  
        /// <returns></returns>  
        private string DictionaryToJson(Dictionary<object, object> dic)
        {
            //实例化JavaScriptSerializer类的新实例  
            JavaScriptSerializer jss = new JavaScriptSerializer();
            try
            {
                //将指定的 JSON 字符串转换为 Dictionary<string, object> 类型的对象  
                return jss.Serialize(dic);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }  
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}