namespace EntityGenerator
{
    public class Permission
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 父级权限id
        /// </summary>
        public long? Pid { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// 权限值
        /// </summary>
        public string? Value { get; set; }
        /// <summary>
        /// 图标
        /// </summary>
        public string? Icon { get; set; }
        /// <summary>
        /// 权限类型：0->目录；1->菜单；2->按钮（接口绑定权限）
        /// </summary>
        public int? Type { get; set; }
        /// <summary>
        /// 前端资源路径
        /// </summary>
        public string? Uri { get; set; }
        /// <summary>
        /// 启用状态；0->禁用；1->启用
        /// </summary>
        public int? Status { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int? Sort { get; set; }
    }
}
