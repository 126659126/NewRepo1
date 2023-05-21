using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    /// <summary>
    /// 用户表
    /// </summary>
    [Table("UserTable")]
    public class UserTable
    {
        /// <summary>
        /// 用户名
        /// </summary>
        [Key]
        public string User_name { get; set; }

        /// <summary>
        /// 用户密码
        /// </summary>
        public string User_pwd { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        public string User_full_name { get; set; }
    }
}
