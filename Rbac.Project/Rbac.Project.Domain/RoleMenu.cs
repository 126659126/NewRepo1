using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rbac.Project.Domain
{
    [Table("RoleMenu")]
    public class RoleMenu
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// 角色ID
        /// </summary>
        [ForeignKey("FKRole")]
        public int RoleID { get; set; }
        public Role FKRole { get; set; }

        /// <summary>
        /// 菜单ID
        /// </summary>
        [ForeignKey("FKMenu")]
        public int MenuID { get; set; }
        public Menu FKMenu { get; set; }
    }
}
