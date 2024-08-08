namespace EntityGenerator
{
    public class ResourceCategory
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 分类名称
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int? Sort { get; set; }
    }
}
