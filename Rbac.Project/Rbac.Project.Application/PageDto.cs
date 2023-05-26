using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rbac.Project.Application
{
    public class PageDto<T>: ResultDto<T>
    {
        public int TotalCount { get; set; }
    }
}
