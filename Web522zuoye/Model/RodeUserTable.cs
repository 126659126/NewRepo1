using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("RodeUserTable")]
    public class RodeUserTable
    {
        /// <summary>
        /// 用户角色表
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        public int User_Id { get; set; }

        /// <summary>
        /// 角色id
        /// </summary>
        public int Rode_id { get; set; }
    }
}
