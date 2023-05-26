using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rbac.Project.Application.Admins.Dto
{
    /// <summary>
    /// 查询条件
    /// </summary>
    public class QueryDto: BaseQueryDto
    {
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
    }
}
