namespace EntityGenerator
{
    public class RoleResourceRelation
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
        /// 资源ID
        /// </summary>
        public long? ResourceId { get; set; }
    }
}
