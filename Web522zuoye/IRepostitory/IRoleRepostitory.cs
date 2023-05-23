using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepostitory
{
    public interface IRoleRepostitory<T>
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        int AddRole(T item);

        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        List<T> QueryRole()
    }
}
