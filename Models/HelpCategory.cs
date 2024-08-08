namespace EntityGenerator
{
    public class HelpCategory
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// 分类图标
        /// </summary>
        public string? Icon { get; set; }
        /// <summary>
        /// 专题数量
        /// </summary>
        public int? HelpCount { get; set; }
        /// <summary>
        /// ShowStatus
        /// </summary>
        public int? ShowStatus { get; set; }
        /// <summary>
        /// Sort
        /// </summary>
        public int? Sort { get; set; }
    }
}
