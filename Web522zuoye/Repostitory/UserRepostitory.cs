using IRepostitory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repostitory
{
    public class UserRepostitory<T>: IUserRepostitory<T> where T : class
    {
        /// <summary>
        /// 增
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool UserAdd(T entity)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 删
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool UserDelete(T entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 改
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool UserAlter(T entity)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 查
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public IQueryable<T> GetUser()
        {
            throw new NotImplementedException();
        }
    }
}
