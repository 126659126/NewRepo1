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
    /// 模块角色表
    /// </summary>
    [Table("ModulerodeTable")]
    public class ModulerodeTable
    {
        /// <summary>
        /// id
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// 模块id
        /// </summary>
        public int Module_Id { get; set; }

        /// <summary>
        /// 角色id
        /// </summary>
        public int Rode_id { get; set; }
    }
}
