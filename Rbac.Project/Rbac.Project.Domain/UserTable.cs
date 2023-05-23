using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rbac.Project.Domain
{
    [Table("UserTable")]
    public class UserTable : Timequantum
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        [Key]
        public int U_Id { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string U_UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string U_Password { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string U_Name { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string U_Email { get; set; }

        /// <summary>
        /// 末次登录时间
        /// </summary>
        public DateTime U_LastloginTime { get; set; }

        /// <summary>
        /// 末次登录IP
        /// </summary>
        public string U_LastLonginIP { get; set; }
    }
}
