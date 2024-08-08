namespace EntityGenerator
{
    public class MemberLevel
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
        /// GrowthPoint
        /// </summary>
        public int? GrowthPoint { get; set; }
        /// <summary>
        /// 是否为默认等级：0->不是；1->是
        /// </summary>
        public int? DefaultStatus { get; set; }
        /// <summary>
        /// 免运费标准
        /// </summary>
        public decimal? FreeFreightPoint { get; set; }
        /// <summary>
        /// 每次评价获取的成长值
        /// </summary>
        public int? CommentGrowthPoint { get; set; }
        /// <summary>
        /// 是否有免邮特权
        /// </summary>
        public int? PriviledgeFreeFreight { get; set; }
        /// <summary>
        /// 是否有签到特权
        /// </summary>
        public int? PriviledgeSignIn { get; set; }
        /// <summary>
        /// 是否有评论获奖励特权
        /// </summary>
        public int? PriviledgeComment { get; set; }
        /// <summary>
        /// 是否有专享活动特权
        /// </summary>
        public int? PriviledgePromotion { get; set; }
        /// <summary>
        /// 是否有会员价格特权
        /// </summary>
        public int? PriviledgeMemberPrice { get; set; }
        /// <summary>
        /// 是否有生日特权
        /// </summary>
        public int? PriviledgeBirthday { get; set; }
        /// <summary>
        /// Note
        /// </summary>
        public string? Note { get; set; }
    }
}
