using System;

namespace Model
{
    /// <summary>
    /// 模型类：图书
    /// </summary>
    public class Book
    {
        /// <summary>
        /// 构造：创建图书对象
        /// </summary>
        public Book() { }

        /// <summary>
        /// 构造：根据指定数据创建图书对象
        /// </summary>
        /// <param name="id">图书编号</param>
        /// <param name="title">书名</param>
        /// <param name="author">作者</param>
        /// <param name="publisherID">出版社编号</param>
        /// <param name="publisherName">出版社名称</param>
        /// <param name="categoryID">分类编号</param>
        /// <param name="categoryName">分类名称</param>
        /// <param name="publishDate">出版日期</param>
        /// <param name="isbn">书号</param>
        /// <param name="wordsCount">总字数</param>
        /// <param name="price">价格</param>
        /// <param name="contentDesc">图书简介</param>
        /// <param name="authorDesc">作者简介</param>
        /// <param name="editorComment">编辑推介</param>
        /// <param name="toc">目录</param>
        /// <param name="clicks">点击次数</param>
        /// <param name="state">状态</param>
        public Book(string id,string title,string author,int publisherID,string publisherName,int categoryID,string categoryName,DateTime publishDate,string isbn,int wordsCount,decimal price,string contentDesc,string authorDesc,string editorComment,string toc,int clicks,int state)
        {
            ID = id;
            Title = title;
            Author = author;
            PublisherID = publisherID;
            PublisherName = publisherName;
            CategoryID = categoryID;
            CategoryName = categoryName;
            PublishDate = publishDate;
            ISBN = isbn;
            WordsCount = wordsCount;
            Price = price;
            ContentDesc = contentDesc;
            AuthorDesc = authorDesc;
            EditorComment = editorComment;
            TOC = toc;
            Clicks = clicks;
            State = state;
        }

        /// <summary>
        /// 属性：图书编号
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// 属性：书名
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 属性：作者
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// 属性：出版社编号
        /// </summary>
        public int PublisherID { get; set; }

        /// <summary>
        /// 属性：出版社名称
        /// </summary>
        public string PublisherName { get; set; }

        /// <summary>
        /// 属性：分类编号
        /// </summary>
        public int CategoryID { get; set; }

        /// <summary>
        /// 属性：分类名称
        /// </summary>
        public string CategoryName { get; set; }

        /// <summary>
        /// 属性：出版日期
        /// </summary>
        public DateTime PublishDate { get; set; }

        /// <summary>
        /// 属性：书号
        /// </summary>
        public string ISBN { get; set; }

        /// <summary>
        /// 属性：总字数
        /// </summary>
        public int WordsCount { get; set; }

        /// <summary>
        /// 属性：价格
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// 属性：图书简介
        /// </summary>
        public string ContentDesc { get; set; }

        /// <summary>
        /// 属性：作者简介
        /// </summary>
        public string AuthorDesc { get; set; }

        /// <summary>
        /// 属性：编辑推介
        /// </summary>
        public string EditorComment { get; set; }

        /// <summary>
        /// 属性：目录
        /// </summary>
        public string TOC { get; set; }

        /// <summary>
        /// 属性：点击次数
        /// </summary>
        public int Clicks { get; set; }

        /// <summary>
        /// 属性：状态
        /// </summary>
        public int State { get; set; }
    }
}
