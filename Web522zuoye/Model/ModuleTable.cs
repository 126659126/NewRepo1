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
    /// 模块表
    /// </summary>
    [Table("ModuleTable")]
    public class ModuleTable: TimeTable
    {
        /// <summary>
        /// 模块id
        /// </summary>
        [Key]
        public int Module_Id { get; set; }

        /// <summary>
        /// 模块名称
        /// </summary>
        public string Module_name { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        public int Parent_code { get; set; }

        /// <summary>
        /// 模块级
        /// </summary>
        public int Module_level { get; set; }
    }
}
