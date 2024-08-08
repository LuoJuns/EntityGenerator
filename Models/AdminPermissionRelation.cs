namespace EntityGenerator
{
    public class AdminPermissionRelation
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
        /// PermissionId
        /// </summary>
        public long? PermissionId { get; set; }
        /// <summary>
        /// Type
        /// </summary>
        public int? Type { get; set; }
    }
}
