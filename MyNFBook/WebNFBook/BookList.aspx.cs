using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebNFBook
{
    public partial class BookList : System.Web.UI.Page
    {
        //static int index = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["CategoryID"] != null)
                {
                    reBookInfo.DataSource = (from B in BLL.BookBLL.GetBooksInfor() where B.CategoryID == int.Parse((Request.QueryString["CategoryID"])) select B).ToList();                 
                }
                else
                {
                    reBookInfo.DataSource = BLL.BookBLL.GetBooksInfor();
                }
                reBookInfo.DataBind();
            }  
        }


        protected void reBookInfo_ItemCommand1(object source, RepeaterCommandEventArgs e)
        {
            //获取当前 Session  里面用户的对象 看看用户有没有登入  如果没有登入 ，则提示他登入
            Model.Customer customer = (Model.Customer)Session["customer"];
            if (customer == null)
            {
                Response.Write("<script>alert('请先登录后再购买图书！');</script>");
                return;
            }
            //获取当前用户点击购买图书的信息
            Model.Book book = (from B in BLL.BookBLL.GetBooksInfor() where B.ID == e.CommandName select B).First();
            //如果用户点击购买该图书俩次 则给他数量加+1 而不是添加购物车的数量
            for (int i = 0; i < ((List<Model.ShopCar>)Session["ShopCar"]).Count; i++)
            {
                if (e.CommandName == ((List<Model.ShopCar>)Session["ShopCar"])[i].BookID)
                {
                    ((List<Model.ShopCar>)Session["ShopCar"])[i].Count += 1;
                    return;
                }
            }
            //将用户当前购买的书籍 添加到购物车中
            if (book != null)
            {
                ((List<Model.ShopCar>)Session["ShopCar"]).Add(new Model.ShopCar() { BookID = book.ID, Title = book.Title, Count = 1, Price = book.Price });
                //改变当前 购物车的数量
                ((HyperLink)Master.FindControl("hyMyCar")).Text = "购物车[" + ((List<Model.ShopCar>)Session["ShopCar"]).Count + "]|";
            }
        }
    }
}