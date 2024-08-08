namespace EntityGenerator
{
    public class Product
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// BrandId
        /// </summary>
        public long? BrandId { get; set; }
        /// <summary>
        /// ProductCategoryId
        /// </summary>
        public long? ProductCategoryId { get; set; }
        /// <summary>
        /// FeightTemplateId
        /// </summary>
        public long? FeightTemplateId { get; set; }
        /// <summary>
        /// ProductAttributeCategoryId
        /// </summary>
        public long? ProductAttributeCategoryId { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Pic
        /// </summary>
        public string? Pic { get; set; }
        /// <summary>
        /// 货号
        /// </summary>
        public string ProductSn { get; set; }
        /// <summary>
        /// 删除状态：0->未删除；1->已删除
        /// </summary>
        public int? DeleteStatus { get; set; }
        /// <summary>
        /// 上架状态：0->下架；1->上架
        /// </summary>
        public int? PublishStatus { get; set; }
        /// <summary>
        /// 新品状态:0->不是新品；1->新品
        /// </summary>
        public int? NewStatus { get; set; }
        /// <summary>
        /// 推荐状态；0->不推荐；1->推荐
        /// </summary>
        public int? RecommandStatus { get; set; }
        /// <summary>
        /// 审核状态：0->未审核；1->审核通过
        /// </summary>
        public int? VerifyStatus { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int? Sort { get; set; }
        /// <summary>
        /// 销量
        /// </summary>
        public int? Sale { get; set; }
        /// <summary>
        /// Price
        /// </summary>
        public decimal? Price { get; set; }
        /// <summary>
        /// 促销价格
        /// </summary>
        public decimal? PromotionPrice { get; set; }
        /// <summary>
        /// 赠送的成长值
        /// </summary>
        public int? GiftGrowth { get; set; }
        /// <summary>
        /// 赠送的积分
        /// </summary>
        public int? GiftPoint { get; set; }
        /// <summary>
        /// 限制使用的积分数
        /// </summary>
        public int? UsePointLimit { get; set; }
        /// <summary>
        /// 副标题
        /// </summary>
        public string? SubTitle { get; set; }
        /// <summary>
        /// 商品描述
        /// </summary>
        public string? Description { get; set; }
        /// <summary>
        /// 市场价
        /// </summary>
        public decimal? OriginalPrice { get; set; }
        /// <summary>
        /// 库存
        /// </summary>
        public int? Stock { get; set; }
        /// <summary>
        /// 库存预警值
        /// </summary>
        public int? LowStock { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string? Unit { get; set; }
        /// <summary>
        /// 商品重量，默认为克
        /// </summary>
        public decimal? Weight { get; set; }
        /// <summary>
        /// 是否为预告商品：0->不是；1->是
        /// </summary>
        public int? PreviewStatus { get; set; }
        /// <summary>
        /// 以逗号分割的产品服务：1->无忧退货；2->快速退款；3->免费包邮
        /// </summary>
        public string? ServiceIds { get; set; }
        /// <summary>
        /// Keywords
        /// </summary>
        public string? Keywords { get; set; }
        /// <summary>
        /// Note
        /// </summary>
        public string? Note { get; set; }
        /// <summary>
        /// 画册图片，连产品图片限制为5张，以逗号分割
        /// </summary>
        public string? AlbumPics { get; set; }
        /// <summary>
        /// DetailTitle
        /// </summary>
        public string? DetailTitle { get; set; }
        /// <summary>
        /// DetailDesc
        /// </summary>
        public string? DetailDesc { get; set; }
        /// <summary>
        /// 产品详情网页内容
        /// </summary>
        public string? DetailHtml { get; set; }
        /// <summary>
        /// 移动端网页详情
        /// </summary>
        public string? DetailMobileHtml { get; set; }
        /// <summary>
        /// 促销开始时间
        /// </summary>
        public DateTime? PromotionStartTime { get; set; }
        /// <summary>
        /// 促销结束时间
        /// </summary>
        public DateTime? PromotionEndTime { get; set; }
        /// <summary>
        /// 活动限购数量
        /// </summary>
        public int? PromotionPerLimit { get; set; }
        /// <summary>
        /// 促销类型：0->没有促销使用原价;1->使用促销价；2->使用会员价；3->使用阶梯价格；4->使用满减价格；5->限时购
        /// </summary>
        public int? PromotionType { get; set; }
        /// <summary>
        /// 品牌名称
        /// </summary>
        public string? BrandName { get; set; }
        /// <summary>
        /// 商品分类名称
        /// </summary>
        public string? ProductCategoryName { get; set; }
    }
}
