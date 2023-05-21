using System;
using System.Linq;

namespace IRepostitory
{
    public interface IUserRepostitory<T>
    {
        /// <summary>
        /// 增
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool UserAdd(T entity);

        /// <summary>
        /// 删
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool UserDelete(T entity);

        /// <summary>
        /// 改
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool UserAlter(T entity);

        /// <summary>
        /// 查
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public IQueryable<T> GetUser();

    }
}
