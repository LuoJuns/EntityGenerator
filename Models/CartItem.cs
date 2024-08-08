namespace EntityGenerator
{
    public class CartItem
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
        /// ProductSkuId
        /// </summary>
        public long? ProductSkuId { get; set; }
        /// <summary>
        /// MemberId
        /// </summary>
        public long? MemberId { get; set; }
        /// <summary>
        /// 购买数量
        /// </summary>
        public int? Quantity { get; set; }
        /// <summary>
        /// 添加到购物车的价格
        /// </summary>
        public decimal? Price { get; set; }
        /// <summary>
        /// 商品主图
        /// </summary>
        public string? ProductPic { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string? ProductName { get; set; }
        /// <summary>
        /// 商品副标题（卖点）
        /// </summary>
        public string? ProductSubTitle { get; set; }
        /// <summary>
        /// 商品sku条码
        /// </summary>
        public string? ProductSkuCode { get; set; }
        /// <summary>
        /// 会员昵称
        /// </summary>
        public string? MemberNickname { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateDate { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? ModifyDate { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        public int? DeleteStatus { get; set; }
        /// <summary>
        /// 商品分类
        /// </summary>
        public long? ProductCategoryId { get; set; }
        /// <summary>
        /// ProductBrand
        /// </summary>
        public string? ProductBrand { get; set; }
        /// <summary>
        /// ProductSn
        /// </summary>
        public string? ProductSn { get; set; }
        /// <summary>
        /// 商品销售属性:[{"key":"颜色","value":"颜色"},{"key":"容量","value":"4G"}]
        /// </summary>
        public string? ProductAttr { get; set; }
    }
}
