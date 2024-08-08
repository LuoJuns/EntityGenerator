namespace EntityGenerator
{
    public class OrderReturnReason
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 退货类型
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Sort
        /// </summary>
        public int? Sort { get; set; }
        /// <summary>
        /// 状态：0->不启用；1->启用
        /// </summary>
        public int? Status { get; set; }
        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime? CreateTime { get; set; }
    }
}
