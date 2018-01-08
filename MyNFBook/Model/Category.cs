using System;

namespace Model
{
    /// <summary>
    /// 模型类：图书分类
    /// </summary>

    public class Category
    {
        /// <summary>
        /// 构造：创建图书分类对象
        /// </summary>
        public Category() { }

        /// <summary>
        /// 构造：根据指定的数据创建图书分类对象
        /// </summary>
        /// <param name="id">图书分类编号</param>
        /// <param name="name">图书分类名称</param>
        /// <param name="parentID">父类型编号</param>
        /// <param name="parentName">父类型名称</param>
        /// <param name="imageUrl">类型图标</param>
        /// <param name="remark">说明</param>
        /// <param name="state">状态</param>
        public Category(int id, string name, int parentID, string parentName,string imageUrl, string remark, int state)
        {
            ID = id;
            CategoryName = name;
            ParentID = parentID;
            ParentName = parentName;
            ImageUrl = imageUrl;
            Remark = remark;
            State = state;
        }

        /// <summary>
        /// 属性：图书类型编号
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 属性：图书类型名称
        /// </summary>
        public string CategoryName { get; set; }

        /// <summary>
        /// 属性：父类型编号
        /// </summary>
        public int ParentID { get; set; }

        /// <summary>
        /// 属性：父类型名称
        /// </summary>
        public string ParentName { get; set; }

        /// <summary>
        /// 属性：类型图标
        /// </summary>
        public string ImageUrl { get; set; }

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