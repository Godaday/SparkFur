using SparkFur.Models.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkFur.Core.Interfaces
{
    public interface IUserService : IBaseService<User>
    {
        /// <summary>
        /// 根据用户名获取用户信息
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        Task<User> GetByUsernameAsync(string username);
    }
}
