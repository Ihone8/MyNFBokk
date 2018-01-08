<%@ WebHandler Language="C#" Class="NFbooks" %>

using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Runtime.Serialization.Json;
public class NFbooks : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        //context.Response.Write("Hello");
        List<Model.Book> bookList = BLL.BookBLL.GetBooksInfor();
        DataContractJsonSerializer daJson = new DataContractJsonSerializer(typeof(List<Model.Book>));
        daJson.WriteObject(context.Response.OutputStream, bookList);
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}