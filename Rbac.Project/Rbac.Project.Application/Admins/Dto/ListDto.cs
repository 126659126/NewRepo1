using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rbac.Project.Application.Admins.Dto
{
    public class ListDto
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int U_Id { get; set; }

        /// <summary>
        /// 账号
        /// </summary>
        public string U_UserName { get; set; }

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
        /// 创建人
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime AddTime { get; set; }
    }
}
