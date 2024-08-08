namespace EntityGenerator
{
    public class MemberTask
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
        /// 赠送成长值
        /// </summary>
        public int? Growth { get; set; }
        /// <summary>
        /// 赠送积分
        /// </summary>
        public int? Intergration { get; set; }
        /// <summary>
        /// 任务类型：0->新手任务；1->日常任务
        /// </summary>
        public int? Type { get; set; }
    }
}
