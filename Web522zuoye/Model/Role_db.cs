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
    /// 角色表
    /// </summary>
    [Table("Role_db")]
    public class Role_db
    {
        /// <summary>
        /// 角色id
        /// </summary>
        [Key]
        public int Rode_id { get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        public string Rode_name { get; set; }

        /// <summary>
        /// 角色状态
        /// </summary>
        public string Rode_status { get; set; }
    }
}
