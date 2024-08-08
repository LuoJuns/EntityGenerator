namespace EntityGenerator
{
    public class FlashPromotionProductRelation
    {
        /// <summary>
        /// 编号
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// FlashPromotionId
        /// </summary>
        public long? FlashPromotionId { get; set; }
        /// <summary>
        /// 编号
        /// </summary>
        public long? FlashPromotionSessionId { get; set; }
        /// <summary>
        /// ProductId
        /// </summary>
        public long? ProductId { get; set; }
        /// <summary>
        /// 限时购价格
        /// </summary>
        public decimal? FlashPromotionPrice { get; set; }
        /// <summary>
        /// 限时购数量
        /// </summary>
        public int? FlashPromotionCount { get; set; }
        /// <summary>
        /// 每人限购数量
        /// </summary>
        public int? FlashPromotionLimit { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int? Sort { get; set; }
    }
}
