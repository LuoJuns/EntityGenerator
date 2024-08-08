namespace EntityGenerator
{
    public class ProductOperateLog
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
        /// PriceOld
        /// </summary>
        public decimal? PriceOld { get; set; }
        /// <summary>
        /// PriceNew
        /// </summary>
        public decimal? PriceNew { get; set; }
        /// <summary>
        /// SalePriceOld
        /// </summary>
        public decimal? SalePriceOld { get; set; }
        /// <summary>
        /// SalePriceNew
        /// </summary>
        public decimal? SalePriceNew { get; set; }
        /// <summary>
        /// 赠送的积分
        /// </summary>
        public int? GiftPointOld { get; set; }
        /// <summary>
        /// GiftPointNew
        /// </summary>
        public int? GiftPointNew { get; set; }
        /// <summary>
        /// UsePointLimitOld
        /// </summary>
        public int? UsePointLimitOld { get; set; }
        /// <summary>
        /// UsePointLimitNew
        /// </summary>
        public int? UsePointLimitNew { get; set; }
        /// <summary>
        /// 操作人
        /// </summary>
        public string? OperateMan { get; set; }
        /// <summary>
        /// CreateTime
        /// </summary>
        public DateTime? CreateTime { get; set; }
    }
}
