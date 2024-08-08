namespace EntityGenerator
{
    public class OrderItem
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 订单id
        /// </summary>
        public long? OrderId { get; set; }
        /// <summary>
        /// 订单编号
        /// </summary>
        public string? OrderSn { get; set; }
        /// <summary>
        /// ProductId
        /// </summary>
        public long? ProductId { get; set; }
        /// <summary>
        /// ProductPic
        /// </summary>
        public string? ProductPic { get; set; }
        /// <summary>
        /// ProductName
        /// </summary>
        public string? ProductName { get; set; }
        /// <summary>
        /// ProductBrand
        /// </summary>
        public string? ProductBrand { get; set; }
        /// <summary>
        /// ProductSn
        /// </summary>
        public string? ProductSn { get; set; }
        /// <summary>
        /// 销售价格
        /// </summary>
        public decimal? ProductPrice { get; set; }
        /// <summary>
        /// 购买数量
        /// </summary>
        public int? ProductQuantity { get; set; }
        /// <summary>
        /// 商品sku编号
        /// </summary>
        public long? ProductSkuId { get; set; }
        /// <summary>
        /// 商品sku条码
        /// </summary>
        public string? ProductSkuCode { get; set; }
        /// <summary>
        /// 商品分类id
        /// </summary>
        public long? ProductCategoryId { get; set; }
        /// <summary>
        /// 商品促销名称
        /// </summary>
        public string? PromotionName { get; set; }
        /// <summary>
        /// 商品促销分解金额
        /// </summary>
        public decimal? PromotionAmount { get; set; }
        /// <summary>
        /// 优惠券优惠分解金额
        /// </summary>
        public decimal? CouponAmount { get; set; }
        /// <summary>
        /// 积分优惠分解金额
        /// </summary>
        public decimal? IntegrationAmount { get; set; }
        /// <summary>
        /// 该商品经过优惠后的分解金额
        /// </summary>
        public decimal? RealAmount { get; set; }
        /// <summary>
        /// GiftIntegration
        /// </summary>
        public int? GiftIntegration { get; set; }
        /// <summary>
        /// GiftGrowth
        /// </summary>
        public int? GiftGrowth { get; set; }
        /// <summary>
        /// 商品销售属性:[{"key":"颜色","value":"颜色"},{"key":"容量","value":"4G"}]
        /// </summary>
        public string? ProductAttr { get; set; }
    }
}
