namespace EntityGenerator
{
    public class Member
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// MemberLevelId
        /// </summary>
        public long? MemberLevelId { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string? Username { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string? Password { get; set; }
        /// <summary>
        /// 昵称
        /// </summary>
        public string? Nickname { get; set; }
        /// <summary>
        /// 手机号码
        /// </summary>
        public string? Phone { get; set; }
        /// <summary>
        /// 帐号启用状态:0->禁用；1->启用
        /// </summary>
        public int? Status { get; set; }
        /// <summary>
        /// 注册时间
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 头像
        /// </summary>
        public string? Icon { get; set; }
        /// <summary>
        /// 性别：0->未知；1->男；2->女
        /// </summary>
        public int? Gender { get; set; }
        /// <summary>
        /// 生日
        /// </summary>
        public object? Birthday { get; set; }
        /// <summary>
        /// 所做城市
        /// </summary>
        public string? City { get; set; }
        /// <summary>
        /// 职业
        /// </summary>
        public string? Job { get; set; }
        /// <summary>
        /// 个性签名
        /// </summary>
        public string? PersonalizedSignature { get; set; }
        /// <summary>
        /// 用户来源
        /// </summary>
        public int? SourceType { get; set; }
        /// <summary>
        /// 积分
        /// </summary>
        public int? Integration { get; set; }
        /// <summary>
        /// 成长值
        /// </summary>
        public int? Growth { get; set; }
        /// <summary>
        /// 剩余抽奖次数
        /// </summary>
        public int? LuckeyCount { get; set; }
        /// <summary>
        /// 历史积分数量
        /// </summary>
        public int? HistoryIntegration { get; set; }
    }
}
