using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Z.EntityFramework;
using Z.EntityFramework.Extensions;
using Z.EntityFramework.Plus;

namespace Rbac.Project.Repositories
{
    public class Repository<T>: IRepository<T> where T : class, new()
    {
        private readonly RbacDbContext db;
        public Repository(RbacDbContext _db)
        {
            db = _db;
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public T Insert(T entity)
        {
            db.Set<T>().Add(entity);
            db.SaveChanges();
            return entity;
        }

        /// <summary>
        /// 异步添加
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<T> InsertAsync(T entity)
        {
            db.Set<T>().Add(entity);
            await db.SaveChangesAsync();
            return entity;
        }

        /// <summary>
        /// 异步批量添加
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<int> InsertManyAsync(List<T> entity)
        {
            await db.Set<T>().AddRangeAsync(entity);
            return await db.SaveChangesAsync();
        }

        /// <summary>
        /// 根据主键删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<int> DeleteAsync(int Id)
        {
            var Rntity = await db.Set<T>().FindAsync(Id);
            db.Set<T>().Remove(Rntity);
            return await db.SaveChangesAsync();
        }

        /// <summary>
        /// 按条件删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<int> DeleteAsync(Expression<Func<T, bool>> predicate)
        {
            return await db.Set<T>().Where(predicate).DeleteAsync();
        }

        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public async Task<int> DeleteAsync(List<T> entities)
        {
            db.Set<T>().RemoveRange(entities);
            return await db.SaveChangesAsync();
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<T> UpdateAsync(T entity)
        {
            db.Set<T>().Update(entity);
            await db.SaveChangesAsync();
            return entity;
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<T> FindAsync(int Id)
        {
            return await db.Set<T>().FindAsync(Id);
        }


        public IQueryable<T> Queryable()
        {
            return  db.Set<T>().AsQueryable();
        }

        /// <summary>
        /// 按条件查询
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public async Task<T> QueryAsync(Expression<Func<T,bool>> predicate)
        {
            return await db.Set<T>().FindAsync(predicate);
        }
        /// <summary>
        /// 是否存在记录
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public async Task<bool> ExistsAsync(Expression<Func<T, bool>> predicate)
        {
            return await db.Set<T>().AnyAsync(predicate);
        }

        /// <summary>
        /// 按条件查单条
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<T> FindAsync(Expression<Func<T, bool>> predicate)
        {
            return await db.Set<T>().FirstOrDefaultAsync(predicate);
        }
    }
}
