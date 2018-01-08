using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebNFBook
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //读取当前Cookie 保存的东西 如果存在数据 则让用户名显示在文本框中
            if (!IsPostBack)
            {
                try
                {
                            if ((Request.Cookies.Count > 0) && (Request.Cookies["Login"].Value != null))
                {
                    txtUserName.Text = Request.Cookies["Login"].Value;
                }
                }
                catch (Exception)
                {
                    
                  
                }
               
            }  
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Model.Customer customer = new Model.Customer();
            customer.LoginName = txtUserName.Text.ToLower();
            customer.Password = txtPassword.Text.Trim(); 
            if (BLL.CustomerBLL.SelectUserName(customer) > 0)
            {
                if (BLL.CustomerBLL.UserLogin(customer) > 0)
                {
                    //lblMes.Text = "登入成功！";
                    if (customer != null)
                    {
                        //保存当前用户登入信息
                        Model.Customer model = (from B in BLL.CustomerBLL.GetCustomerInfor() where B.LoginName == txtUserName.Text.ToLower() select B).First();
                        model.Password = null;//去掉密码 不能传密码 不安全
                        Session["customer"] = model;
                        //创建购物车
                        Session["ShopCar"] = new List<Model.ShopCar>();
                        //创建 Cookie 保存当前用户名
                        HttpCookie LoginNameCookie = new HttpCookie("Login", model.LoginName);
                        LoginNameCookie.Expires = DateTime.Now.AddYears(1);//设置Cookie 过期时间
                        Response.Cookies.Add(LoginNameCookie);                      //成功添加Cookie
                        Response.Redirect("~/default.aspx");
                        
                    }
                }
                else
                {
                    lblMes.Text = "密码输入有误！";
                }
            }
            else
            {
                lblMes.Text = "该账号不存在！";
            }
        }
    }
}