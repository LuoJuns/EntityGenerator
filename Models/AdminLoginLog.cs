namespace EntityGenerator
{
    public class AdminLoginLog
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// AdminId
        /// </summary>
        public long? AdminId { get; set; }
        /// <summary>
        /// CreateTime
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// Ip
        /// </summary>
        public string? Ip { get; set; }
        /// <summary>
        /// Address
        /// </summary>
        public string? Address { get; set; }
        /// <summary>
        /// 浏览器登录类型
        /// </summary>
        public string? UserAgent { get; set; }
    }
}
