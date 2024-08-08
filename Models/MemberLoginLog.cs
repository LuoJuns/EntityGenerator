namespace EntityGenerator
{
    public class MemberLoginLog
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
        /// CreateTime
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// Ip
        /// </summary>
        public string? Ip { get; set; }
        /// <summary>
        /// City
        /// </summary>
        public string? City { get; set; }
        /// <summary>
        /// 登录类型：0->PC；1->android;2->ios;3->小程序
        /// </summary>
        public int? LoginType { get; set; }
        /// <summary>
        /// Province
        /// </summary>
        public string? Province { get; set; }
    }
}
