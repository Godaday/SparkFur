

using SparkFur.Core.Interfaces;
using SparkFur.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkFur.Core.Services
{
    /// <summary>
    /// BaseService 提供了通用的业务逻辑和操作。
    /// </summary>
    /// <typeparam name="T">实体类型</typeparam>
    public class BaseService<T> : IBaseService<T> where T : class
    {
        protected readonly IBaseRepository<T> _repository;
        protected readonly IUnitOfWork _unitOfWork;

        public BaseService(IBaseRepository<T> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        /// <inheritdoc />
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            /*
            获取所有实体的异步方法。
            */
            return await _repository.GetAllAsync();
        }

        /// <inheritdoc />
        public async Task<T> GetByIdAsync(Guid id)
        {
            /*
            根据ID获取实体的异步方法。
            */
            return await _repository.GetByIdAsync(id);
        }

        /// <inheritdoc />
        public async Task AddAsync(T entity)
        {
            /*
            添加实体的异步方法。
            */
            await _repository.AddAsync(entity);
            await _unitOfWork.SaveChangesAsync();
        }

        /// <inheritdoc />
        public async Task UpdateAsync(T entity)
        {
            /*
            更新实体的异步方法。
            */
            _repository.Update(entity);
            await _unitOfWork.SaveChangesAsync();
        }

        /// <inheritdoc />
        public async Task DeleteAsync(T t)
        {
            /*
            根据ID删除实体的异步方法。
            */
            await _repository.DeleteAsync(t);
            await _unitOfWork.SaveChangesAsync();
        }

        // 同步方法

        /// <inheritdoc />
        public IEnumerable<T> GetAll()
        {
            /*
            获取所有实体的同步方法。
            */
            return _repository.GetAll();
        }

        /// <inheritdoc />
        public T GetById(Guid id)
        {
            /*
            根据ID获取实体的同步方法。
            */
            return _repository.GetById(id);
        }

        /// <inheritdoc />
        public void Add(T entity)
        {
            /*
            添加实体的同步方法。
            */
            _repository.Add(entity);
            _unitOfWork.SaveChanges();
        }

        /// <inheritdoc />
        public void Update(T entity)
        {
            /*
            更新实体的同步方法。
            */
            _repository.Update(entity);
            _unitOfWork.SaveChanges();
        }

        /*
          根据ID删除实体的同步方法。
          */
        public void Delete(T t)
        {
         
            _repository.Delete(t);
            _unitOfWork.SaveChanges();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
