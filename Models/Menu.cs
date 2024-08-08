namespace EntityGenerator
{
    public class Menu
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 父级ID
        /// </summary>
        public long? ParentId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 菜单名称
        /// </summary>
        public string? Title { get; set; }
        /// <summary>
        /// 菜单级数
        /// </summary>
        public int? Level { get; set; }
        /// <summary>
        /// 菜单排序
        /// </summary>
        public int? Sort { get; set; }
        /// <summary>
        /// 前端名称
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// 前端图标
        /// </summary>
        public string? Icon { get; set; }
        /// <summary>
        /// 前端隐藏
        /// </summary>
        public int? Hidden { get; set; }
    }
}
