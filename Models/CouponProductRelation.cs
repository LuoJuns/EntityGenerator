namespace EntityGenerator
{
    public class CouponProductRelation
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// CouponId
        /// </summary>
        public long? CouponId { get; set; }
        /// <summary>
        /// ProductId
        /// </summary>
        public long? ProductId { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string? ProductName { get; set; }
        /// <summary>
        /// 商品编码
        /// </summary>
        public string? ProductSn { get; set; }
    }
}
