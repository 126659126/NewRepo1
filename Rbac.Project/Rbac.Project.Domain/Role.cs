using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rbac.Project.Domain
{
    [Table("Role")]
    public class Role : Timequantum
    {
        /// <summary>
        /// 角色ID
        /// </summary>
        [Key]
        public int RoleID { get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        public string RoleName { get; set; }

        /// <summary>
        /// 角色备注
        /// </summary>
        public string Remark { get; set; }
    }
}
