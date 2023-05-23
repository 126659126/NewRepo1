using System;
using System.Collections.Generic;
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
        int UserAdd(T entity);

        /// <summary>
        /// 删
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        int UserDelete(T entity);

        /// <summary>
        /// 改
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        int UserAlter(T entity);

        /// <summary>
        /// 查
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        //IQueryable<T> GetUser();


        IEnumerable<T> GetAll();


        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        int LogIn(string name, string pwd);
    }
}
