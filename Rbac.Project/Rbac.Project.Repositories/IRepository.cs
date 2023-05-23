using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Rbac.Project.Repositories
{
    public interface IRepository<T> where T : class, new()
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        T Insert(T entity);

        /// <summary>
        /// 异步添加
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<T> InsertAsync(T entity);

        /// <summary>
        /// 异步批量添加
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<int> InsertManyAsync(List<T> entity);

        /// <summary>
        /// 根据主键删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Task<int> DeleteAsync(int Id);

        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        Task<int> DeleteAsync(List<T> entities);

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<T> UpdateAsync(T entity);

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Task<T> FindAsync(int Id);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IQueryable<T> Queryable();

        /// <summary>
        /// 按条件查询
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<T> QueryAsync(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// 是否存在记录
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<bool> ExistsAsync(Expression<Func<T, bool>> predicate);
    }
}
