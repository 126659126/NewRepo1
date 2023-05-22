using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    /// <summary>
    /// 用户表
    /// </summary>
    [Table("UserTable")]
    public class UserTable: TimeTable
    {
        /// <summary>
        /// 用户id
        /// </summary>
        [Key]
        public int User_Id { get; set; }

        /// <summary>
        /// 用户账号
        /// </summary>
        public string User_name { get; set; }

        /// <summary>
        /// 用户密码
        /// </summary>
        public string User_pwd { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        public string User_full_name { get; set; }

        /// <summary>
        /// 用户电话
        /// </summary>
        public string User_Phone { get; set; }
    }
}
