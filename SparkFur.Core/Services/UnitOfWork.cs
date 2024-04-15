using SparkFur.Core.Interfaces;
using SparkFur.Infrastructure.DbContent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkFur.Core.Services
{
    /// <summary>
    /// 工作单元实现类
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SparkFurDbContext _dbContext;

        public UnitOfWork(SparkFurDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// 异步保存所有更改到数据库
        /// </summary>
        /// <returns>受影响的行数</returns>
        public async Task<int> SaveChangesAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }

        /// <summary>
        /// 异步保存所有更改到数据库，并指定成功后是否立即接受所有更改
        /// </summary>
        /// <param name="acceptAllChangesOnSuccess">是否立即接受所有更改</param>
        /// <returns>受影响的行数</returns>
        public async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess)
        {
            return await _dbContext.SaveChangesAsync(acceptAllChangesOnSuccess);
        }

        /// <summary>
        /// 异步开始数据库事务
        /// </summary>
        public async Task BeginTransactionAsync()
        {
            await _dbContext.Database.BeginTransactionAsync();
        }

        /// <summary>
        /// 异步提交事务
        /// </summary>
        public async Task CommitAsync()
        {
            await _dbContext.Database.CurrentTransaction.CommitAsync();
        }

        /// <summary>
        /// 异步回滚事务
        /// </summary>
        public async Task RollbackAsync()
        {
            await _dbContext.Database.CurrentTransaction.RollbackAsync();
        }

        /// <summary>
        /// 异步确保事务的存在，如果事务不存在，则创建一个新事务
        /// </summary>
        /// <returns>如果事务存在或成功创建，则为 true；否则为 false</returns>
        public async Task<bool> EnsureTransactionAsync()
        {
            if (_dbContext.Database.CurrentTransaction == null)
            {
                await BeginTransactionAsync();
                return true;
            }
            return false;
        }

        /// <summary>
        /// 异步执行原始 SQL 查询，并返回实体列表
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <param name="sql">原始 SQL 查询语句</param>
        /// <param name="parameters">参数</param>
        /// <returns>实体列表</returns>
        public async Task<List<T>> ExecuteSqlQueryAsync<T>(string sql, params object[] parameters) where T : class
        {
            //return await _dbContext.Set<T>().FromSqlRaw(sql, parameters).ToListAsync();
            return null;
        }

        /// <summary>
        /// 释放资源
        /// </summary>
        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public int SaveChanges()
        {
            return  _dbContext.SaveChanges();
        }

      
    }
}
