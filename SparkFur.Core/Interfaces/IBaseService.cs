using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SparkFur.Core.Interfaces
{ 


        /// <summary>
        /// 提供了通用的业务逻辑和操作。
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        public interface IBaseService<T> where T : class
        {
            /// <summary>
            /// 异步方式获取所有实体。
            /// </summary>
            /// <returns>实体集合</returns>
            Task<IEnumerable<T>> GetAllAsync();

            /// <summary>
            /// 异步方式根据ID获取实体。
            /// </summary>
            /// <param name="id">实体ID</param>
            /// <returns>实体</returns>
            Task<T> GetByIdAsync(Guid id);

            /// <summary>
            /// 异步方式添加实体。
            /// </summary>
            /// <param name="entity">要添加的实体</param>
            Task AddAsync(T entity);

            /// <summary>
            /// 异步方式更新实体。
            /// </summary>
            /// <param name="entity">要更新的实体</param>
            Task UpdateAsync(T entity);

            /// <summary>
            /// 异步方式根据ID删除实体。
            /// </summary>
            /// <param name="id">实体ID</param>
            Task DeleteAsync(Guid id);

            // 同步方法

            /// <summary>
            /// 获取所有实体。
            /// </summary>
            /// <returns>实体集合</returns>
            IEnumerable<T> GetAll();

            /// <summary>
            /// 根据ID获取实体。
            /// </summary>
            /// <param name="id">实体ID</param>
            /// <returns>实体</returns>
            T GetById(Guid id);

            /// <summary>
            /// 添加实体。
            /// </summary>
            /// <param name="entity">要添加的实体</param>
            void Add(T entity);

            /// <summary>
            /// 更新实体。
            /// </summary>
            /// <param name="entity">要更新的实体</param>
            void Update(T entity);

            /// <summary>
            /// 根据ID删除实体。
            /// </summary>
            /// <param name="id">实体ID</param>
            void Delete(Guid id);
        }
    

}
