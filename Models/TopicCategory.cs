namespace EntityGenerator
{
    public class TopicCategory
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
        public int? SubjectCount { get; set; }
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
