namespace EntityGenerator
{
    public class ProductLadder
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
        /// 满足的商品数量
        /// </summary>
        public int? Count { get; set; }
        /// <summary>
        /// 折扣
        /// </summary>
        public decimal? Discount { get; set; }
        /// <summary>
        /// 折后价格
        /// </summary>
        public decimal? Price { get; set; }
    }
}
