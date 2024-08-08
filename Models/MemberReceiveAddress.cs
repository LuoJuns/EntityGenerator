namespace EntityGenerator
{
    public class MemberReceiveAddress
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// MemberId
        /// </summary>
        public long? MemberId { get; set; }
        /// <summary>
        /// 收货人名称
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// PhoneNumber
        /// </summary>
        public string? PhoneNumber { get; set; }
        /// <summary>
        /// 是否为默认
        /// </summary>
        public int? DefaultStatus { get; set; }
        /// <summary>
        /// 邮政编码
        /// </summary>
        public string? PostCode { get; set; }
        /// <summary>
        /// 省份/直辖市
        /// </summary>
        public string? Province { get; set; }
        /// <summary>
        /// 城市
        /// </summary>
        public string? City { get; set; }
        /// <summary>
        /// 区
        /// </summary>
        public string? Region { get; set; }
        /// <summary>
        /// 详细地址(街道)
        /// </summary>
        public string? DetailAddress { get; set; }
    }
}
