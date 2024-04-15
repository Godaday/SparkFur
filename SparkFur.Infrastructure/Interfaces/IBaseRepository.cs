using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SparkFur.Infrastructure.Interfaces
{
 
    
            /// <summary>
            /// 通用数据仓库接口
            /// </summary>
            /// <typeparam name="TEntity">实体类型</typeparam>
            public interface IBaseRepository<TEntity> where TEntity : class
            {
                /// <summary>
                /// 根据ID异步获取实体
                /// </summary>
                Task<TEntity> GetByIdAsync(Guid id);

                /// <summary>
                /// 异步获取所有实体
                /// </summary>
                Task<IEnumerable<TEntity>> GetAllAsync();

                /// <summary>
                /// 异步分页获取实体
                /// </summary>
                Task<IEnumerable<TEntity>> GetPagedAsync(int pageNumber, int pageSize, Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null);

                /// <summary>
                /// 异步获取符合条件的实体
                /// </summary>
                Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> filter);

                /// <summary>
                /// 异步添加实体
                /// </summary>
                Task AddAsync(TEntity entity);

                /// <summary>
                /// 异步更新实体
                /// </summary>
                Task UpdateAsync(TEntity entity);

                /// <summary>
                /// 异步删除实体
                /// </summary>
                Task DeleteAsync(TEntity entity);
        /// <summary>
        /// 异步方式根据ID删除实体。
        /// </summary>
        /// <param name="id">实体ID</param>
        Task DeleteAsync(Guid id);


        /// <summary>
        /// 根据ID同步获取实体
        /// </summary>
        TEntity GetById(Guid id);


                /// <summary>
                /// 同步获取所有实体
                /// </summary>
                IEnumerable<TEntity> GetAll();

                /// <summary>
                /// 同步分页获取实体
                /// </summary>
                IEnumerable<TEntity> GetPaged(int pageNumber, int pageSize, Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null);

                /// <summary>
                /// 同步获取符合条件的实体
                /// </summary>
                IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter);

                /// <summary>
                /// 同步添加实体
                /// </summary>
                void Add(TEntity entity);

                /// <summary>
                /// 同步更新实体
                /// </summary>
                void Update(TEntity entity);

                /// <summary>
                /// 同步删除实体
                /// </summary>
                void Delete(TEntity entity);
            }
        }

    


