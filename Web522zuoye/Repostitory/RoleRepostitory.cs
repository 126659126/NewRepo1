using IRepostitory;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserDb;

namespace Repostitory
{
    public class RoleRepostitory: IRoleRepostitory<Role_db>
    {
        private readonly UserDbContext db;
        public RoleRepostitory(UserDbContext _db)
        {
            db = _db;
        }

        /// <summary>
        /// 添加角色
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int AddRole(Role_db item)
        {
            try
            {
                db.Role_db.Add(item);
                return db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        public List<Role_db> QueryRole()
        {
            try
            {
                var list = db.Role_db.ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
