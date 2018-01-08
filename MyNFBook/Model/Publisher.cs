using System;

namespace Model
{
    /// <summary>
    /// 模型类：出版社
    /// </summary>

    public class Publisher
    {
        /// <summary>
        /// 构造：创建出版社对象
        /// </summary>
        public Publisher() { }

        /// <summary>
        /// 构造：根据指定数据创建出版社对象
        /// </summary>
        /// <param name="id">出版社编号</param>
        /// <param name="publisherName">出版社名称</param>
        /// <param name="imageURL">图标</param>
        /// <param name="webURL">网址</param>
        /// <param name="remark">说明</param>
        /// <param name="state">状态</param>
        public Publisher(int id,string publisherName,string imageUrl,string webUrl,string remark,int state)
        {
            ID = id;
            PublisherName = publisherName;
            ImageUrl = imageUrl;
            WebUrl = webUrl;
            Remark = remark;
            State = state;
        }

        /// <summary>
        /// 属性：出版社编号
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 属性：出版社名称
        /// </summary>
        public string PublisherName { get; set; }

        /// <summary>
        /// 属性：图标
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// 属性：网址
        /// </summary>
        public string WebUrl { get; set; }

        /// <summary>
        /// 属性：说明
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 属性：状态
        /// </summary>
        public int State { get; set; }
    }
}
