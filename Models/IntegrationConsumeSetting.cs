namespace EntityGenerator
{
    public class IntegrationConsumeSetting
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 每一元需要抵扣的积分数量
        /// </summary>
        public int? DeductionPerAmount { get; set; }
        /// <summary>
        /// 每笔订单最高抵用百分比
        /// </summary>
        public int? MaxPercentPerOrder { get; set; }
        /// <summary>
        /// 每次使用积分最小单位100
        /// </summary>
        public int? UseUnit { get; set; }
        /// <summary>
        /// 是否可以和优惠券同用；0->不可以；1->可以
        /// </summary>
        public int? CouponStatus { get; set; }
    }
}
