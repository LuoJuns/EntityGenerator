namespace EntityGenerator
{
    public class MemberPrice
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
        /// MemberLevelId
        /// </summary>
        public long? MemberLevelId { get; set; }
        /// <summary>
        /// 会员价格
        /// </summary>
        public decimal? MemberPriceProperty { get; set; }
        /// <summary>
        /// MemberLevelName
        /// </summary>
        public string? MemberLevelName { get; set; }
    }
}
