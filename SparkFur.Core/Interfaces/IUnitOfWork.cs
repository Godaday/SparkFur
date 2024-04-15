using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkFur.Core.Interfaces
{

      /// <summary>
      /// 工作单元接口
      /// </summary>
        public interface IUnitOfWork : IDisposable
        {
            /// <summary>
            /// 异步保存所有更改到数据库
            /// </summary>
            /// <returns>受影响的行数</returns>
            Task<int> SaveChangesAsync();
        /// <summary>
        /// 保存所有更改到数据库
        /// </summary>
        /// <returns>受影响的行数</returns>
      int SaveChanges();

        /// <summary>
        /// 异步保存所有更改到数据库，并指定成功后是否立即接受所有更改
        /// </summary>
        /// <param name="acceptAllChangesOnSuccess">是否立即接受所有更改</param>
        /// <returns>受影响的行数</returns>
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess);

            /// <summary>
            /// 异步开始数据库事务
            /// </summary>
            Task BeginTransactionAsync();

            /// <summary>
            /// 异步提交事务
            /// </summary>
            Task CommitAsync();

            /// <summary>
            /// 异步回滚事务
            /// </summary>
            Task RollbackAsync();

            /// <summary>
            /// 异步确保事务的存在，如果事务不存在，则创建一个新事务
            /// </summary>
            /// <returns>如果事务存在或成功创建，则为 true；否则为 false</returns>
            Task<bool> EnsureTransactionAsync();
            /// <summary>
            /// 异步执行原始 SQL 查询，并返回实体列表
            /// </summary>
            /// <typeparam name="T">实体类型</typeparam>
            /// <param name="sql">原始 SQL 查询语句</param>
            /// <param name="parameters">参数</param>
            /// <returns>实体列表</returns>
            Task<List<T>> ExecuteSqlQueryAsync<T>(string sql, params object[] parameters) where T : class;
        }
    }
    



