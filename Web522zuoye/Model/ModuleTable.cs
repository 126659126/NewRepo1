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
    public class ModuleTable
    {
        /// <summary>
        /// 模块
        /// </summary>
        [Key]
        public string Module_code { get; set; }

        /// <summary>
        /// 模块名称
        /// </summary>
        public string Module_name { get; set; }
    }
}
