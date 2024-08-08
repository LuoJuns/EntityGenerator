namespace EntityGenerator
{
    public class FeightTemplate
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// 计费类型:0->按重量；1->按件数
        /// </summary>
        public int? ChargeType { get; set; }
        /// <summary>
        /// 首重kg
        /// </summary>
        public decimal? FirstWeight { get; set; }
        /// <summary>
        /// 首费（元）
        /// </summary>
        public decimal? FirstFee { get; set; }
        /// <summary>
        /// ContinueWeight
        /// </summary>
        public decimal? ContinueWeight { get; set; }
        /// <summary>
        /// ContinmeFee
        /// </summary>
        public decimal? ContinmeFee { get; set; }
        /// <summary>
        /// 目的地（省、市）
        /// </summary>
        public string? Dest { get; set; }
    }
}
