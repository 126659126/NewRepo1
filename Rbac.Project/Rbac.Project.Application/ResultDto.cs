using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rbac.Project.Application
{
    public class ResultDto
    {
        public Result Result { get; set; }
        public string Message { get; set; }
    }

    public class ResultDto<T> : ResultDto
    {
        public T Data { get; set; }
    }

    public enum Result
    {
        Success = 200,
        Failure = 500
    }
}
