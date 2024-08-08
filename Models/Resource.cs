namespace EntityGenerator
{
    public class Resource
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
        /// 资源名称
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// 资源URL
        /// </summary>
        public string? Url { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string? Description { get; set; }
        /// <summary>
        /// 资源分类ID
        /// </summary>
        public long? CategoryId { get; set; }
    }
}
