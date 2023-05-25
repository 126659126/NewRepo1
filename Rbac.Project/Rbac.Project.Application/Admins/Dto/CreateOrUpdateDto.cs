using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rbac.Project.Application.Admins.Dto
{
    public class CreateOrUpdateDto
    {
        /// <summary>
        /// 用户ID
        /// </summary>
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
        /// 头像
        /// </summary>
        public string U_Avatar { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string U_Remark { get; set; }
    }
}
