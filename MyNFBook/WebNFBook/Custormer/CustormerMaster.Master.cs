using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebNFBook.Custormer
{
    public partial class CustormerMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           TvShow();
           if (Session["Customer"] != null)
           {
               hyLogin.Text = ((Model.Customer)Session["Customer"]).CustomerName + "|";
               hyLogin.NavigateUrl = "~/Custormer/BasicInfo.aspx";
               hyRegist.Visible = false;
           }

           if (Session["ShopCar"] != null)
               hyMyCar.Text = "购物车[" + ((List<Model.ShopCar>)Session["ShopCar"]).Count + "]|";
        }
        protected void TvShow()
        {
            //清空数控键对象
            tvUserInfo.Nodes.Clear();
            //为树控件添加对象
            tvUserInfo.Nodes.Add(new TreeNode("基本信息", "", "", "BasicInfo.aspx", "_self"));
            tvUserInfo.Nodes.Add(new TreeNode("联系方式", "", "", "ContactInfo.aspx", "_self"));
            tvUserInfo.Nodes.Add(new TreeNode("密码保护", "", "", "SafetyInfo.aspx", "_self"));
            tvUserInfo.Nodes.Add(new TreeNode("修改密码", "", "", "ChangePassword.aspx", "_self"));
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