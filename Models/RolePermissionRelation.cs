namespace EntityGenerator
{
    public class RolePermissionRelation
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// RoleId
        /// </summary>
        public long? RoleId { get; set; }
        /// <summary>
        /// PermissionId
        /// </summary>
        public long? PermissionId { get; set; }
    }
}
