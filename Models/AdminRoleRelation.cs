namespace EntityGenerator
{
    public class AdminRoleRelation
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
        /// RoleId
        /// </summary>
        public long? RoleId { get; set; }
    }
}
