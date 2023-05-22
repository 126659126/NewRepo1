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
    public class UserRepostitory: IUserRepostitory<UserTable>
    {
        private readonly UserDbContext db;
        public UserRepostitory(UserDbContext _db)
        {
            db = _db;
        }
        /// <summary>
        /// 增
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int UserAdd(UserTable entity)
        {
            db.Add(entity);
            return db.SaveChanges();
        }
        /// <summary>
        /// 删
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int UserDelete(UserTable entity)
        {
            db.UserTable.Remove(entity);
            return db.SaveChanges();
        }

        /// <summary>
        /// 改
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int UserAlter(UserTable entity)
        {
            db.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return db.SaveChanges();
        }
        /// <summary>
        /// 查
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public IEnumerable<UserTable> GetAll()
        {
            return db.UserTable.ToList();
        }
    }
}
