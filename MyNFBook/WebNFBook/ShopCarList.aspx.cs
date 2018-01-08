using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebNFBook
{
    public partial class ShopCarList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ShowBind();
            }
        }
        protected void ShowBind()
        {
            dgdShopCar.DataSource=(List<Model.ShopCar>)Session["ShopCar"];
            dgdShopCar.DataBind();          
        }
    }
}