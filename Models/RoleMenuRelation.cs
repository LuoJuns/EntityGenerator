namespace EntityGenerator
{
    public class RoleMenuRelation
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 角色ID
        /// </summary>
        public long? RoleId { get; set; }
        /// <summary>
        /// 菜单ID
        /// </summary>
        public long? MenuId { get; set; }
    }
}
