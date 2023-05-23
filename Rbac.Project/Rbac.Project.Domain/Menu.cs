using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rbac.Project.Domain
{
    /// <summary>
    /// 菜单表
    /// </summary>
    [Table("Menu")]
    public class Menu: Timequantum
    {
        /// <summary>
        /// 菜单ID
        /// </summary>
        [Key]
        public int MenuID { get; set; }

        /// <summary>
        /// 菜单名称
        /// </summary>
        public string MenuName { get; set; }

        /// <summary>
        /// 父菜单ID
        /// </summary>
        public int ParentID { get; set; }

        /// <summary>
        /// 菜单类型
        /// </summary>
        public MenuType MenuType { get; set; }

        /// <summary>
        /// 菜单路由
        /// </summary>
        public string MenuRoute { get; set; }

        /// <summary>
        /// 菜单图标
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// 菜单接口
        /// </summary>
        public string MenuAPI { get; set; }
    }
}
