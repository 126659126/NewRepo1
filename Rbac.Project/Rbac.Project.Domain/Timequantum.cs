using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rbac.Project.Domain
{
    public class Timequantum
    {
        /// <summary>
        /// 创建人
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime AddTime { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        public string PutName { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? PutTime { get; set; }


        public bool IsDeleted { get; set; }
        public string DeleteName { get; set; }
        public DateTime? DeleteTime { get; set; }
    }
}
