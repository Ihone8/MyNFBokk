using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebNFBook
{
    public partial class NFBookMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowCategory();
            //判断当前用户是否存在
            if(Session["customer"]!=null)
            {
                //如果存在 则让登入按钮  变成 用户名称  并且点击会跳转到用户界面
                hyLogin.Text = ((Model.Customer)Session["customer"]).CustomerName;
                hyLogin.NavigateUrl = "~/Custormer/BasicInfo.aspx";
                hyRegist.Visible = false;
            }
            else
            {
                hyMyCar.NavigateUrl = "~/default.aspx";
            }
            //获取当前购物车  如果购物车不为空！ 则把购物车里面书籍数量显示出来
            if (Session["ShopCar"] != null)
                hyMyCar.Text = "购物车[" + ((List<Model.ShopCar>)Session["ShopCar"]).Count + "]|";
               
        }
        protected void ShowCategory()
        {
            tvCategory.Nodes.Clear();
            foreach (Model.Category item in BLL.CategoryBLL.GetCategory())
            {
                tvCategory.Nodes.Add(new TreeNode(item.CategoryName, item.ID.ToString(), "", "BookList.aspx?CategoryID=" + item.ID, "_self"));
            }
        }

        protected void lkClose_Click(object sender, EventArgs e)
        {
            //清空所有信息 返回到主界面原样
            Session["customer"] = null;
            Session["ShopCar"] = null;
            hyLogin.Text = "登入|";
            hyLogin.NavigateUrl = "~/Login.aspx";
            hyRegist.Visible = true;
            Response.Redirect("~/default.aspx");
        }
    }
}