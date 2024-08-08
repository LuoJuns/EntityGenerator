namespace EntityGenerator
{
    public class Role
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string? Description { get; set; }
        /// <summary>
        /// 后台用户数量
        /// </summary>
        public int? AdminCount { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 启用状态：0->禁用；1->启用
        /// </summary>
        public int? Status { get; set; }
        /// <summary>
        /// Sort
        /// </summary>
        public int? Sort { get; set; }
    }
}
