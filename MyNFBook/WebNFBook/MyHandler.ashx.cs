using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Drawing;
namespace WebNFBook
{
    /// <summary>
    /// MyHandler 的摘要说明
    /// </summary>
    public class MyHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            //给图片添加水印效果
            string path = context.Server.MapPath("Image\\BookCovers\\" + context.Request.QueryString["ISBN"] + ".jpg");
            if(File.Exists(path))
            {
                Image img = Image.FromFile(path);
                Graphics g = Graphics.FromImage(img);
                SolidBrush Brush = new SolidBrush(Color.Red);
                g.DrawString("南方IT", new Font("宋体", 16f), Brush, 0, 0);
                context.Response.ContentType = "Image/jpeg";
                img.Save(context.Response.OutputStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                context.Response.End();
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