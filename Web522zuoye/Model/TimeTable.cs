using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    /// <summary>
    /// 时间表
    /// </summary>
    public class TimeTable
    {
        /// <summary>
        /// 添加人姓名
        /// </summary>
        public string AddName { get; set; }

        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime AddTime { get; set; }

        /// <summary>
        /// 修改人姓名
        /// </summary>
        public string ChangeName { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime ChangeTime { get; set; }
    }
}
