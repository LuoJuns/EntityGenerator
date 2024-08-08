namespace EntityGenerator
{
    public class ProductCategory
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 上机分类的编号：0表示一级分类
        /// </summary>
        public long? ParentId { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// 分类级别：0->1级；1->2级
        /// </summary>
        public int? Level { get; set; }
        /// <summary>
        /// ProductCount
        /// </summary>
        public int? ProductCount { get; set; }
        /// <summary>
        /// ProductUnit
        /// </summary>
        public string? ProductUnit { get; set; }
        /// <summary>
        /// 是否显示在导航栏：0->不显示；1->显示
        /// </summary>
        public int? NavStatus { get; set; }
        /// <summary>
        /// 显示状态：0->不显示；1->显示
        /// </summary>
        public int? ShowStatus { get; set; }
        /// <summary>
        /// Sort
        /// </summary>
        public int? Sort { get; set; }
        /// <summary>
        /// 图标
        /// </summary>
        public string? Icon { get; set; }
        /// <summary>
        /// Keywords
        /// </summary>
        public string? Keywords { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string? Description { get; set; }
    }
}
