using SparkFur.Infrastructure.DbContent;
using SparkFur.Infrastructure.Interfaces;
using SparkFur.Models.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkFur.Infrastructure.Repositorys
{
    /// <summary>
    /// 用户仓储服务实现类
    /// </summary>
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly SparkFurDbContext _dbContext;
        public UserRepository(SparkFurDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        
    }
}
