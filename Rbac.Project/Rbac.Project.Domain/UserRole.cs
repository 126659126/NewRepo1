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
    /// 用户角色表
    /// </summary>
    [Table("UserRole")]
    public class UserRole
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [ForeignKey("FKUserTable")]
        public int U_Id { get; set; }
        public UserTable FKUserTable { get; set; }

        /// <summary>
        /// 角色ID
        /// </summary>
        [ForeignKey("FKRole")]
        public int RoleID { get; set; }
        public Role FKRole { get; set; }
    }
}
