namespace EntityGenerator
{
    public class ProductVertifyRecord
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// ProductId
        /// </summary>
        public long? ProductId { get; set; }
        /// <summary>
        /// CreateTime
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 审核人
        /// </summary>
        public string? VertifyMan { get; set; }
        /// <summary>
        /// Status
        /// </summary>
        public int? Status { get; set; }
        /// <summary>
        /// 反馈详情
        /// </summary>
        public string? Detail { get; set; }
    }
}
