using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Drawing;
namespace WebNFBook
{
    public partial class BookDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Model.Book book = (from B in BLL.BookBLL.GetBooksInfor() where B.ID == (Request.QueryString["ID"]) select B).First();
            lblAuthor.Text = book.Author;
            lblDesc.Text = book.ContentDesc;
            lblPrice.Text =  string.Format("{0:C}",book.Price) ;
            lblPublisherName.Text = book.PublisherName;
            lblTitle.Text = book.Title;
            imgCover.ImageUrl = "~/Image/BookCovers/" + book.ISBN + ".jpg";
            lblPublisherDate.Text = string.Format("{0:D}", book.PublishDate);
        }
    }
}