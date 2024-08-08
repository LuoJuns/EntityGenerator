namespace EntityGenerator
{
    public class CouponProductCategoryRelation
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
        /// ProductCategoryId
        /// </summary>
        public long? ProductCategoryId { get; set; }
        /// <summary>
        /// 产品分类名称
        /// </summary>
        public string? ProductCategoryName { get; set; }
        /// <summary>
        /// 父分类名称
        /// </summary>
        public string? ParentCategoryName { get; set; }
    }
}
