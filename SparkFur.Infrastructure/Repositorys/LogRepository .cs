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
    /// 日志仓储服务实现类
    /// </summary>
    public class SystemLogRepository : BaseRepository<SystemLog>, ISystemLogRepository
    {
    
        public SystemLogRepository(SparkFurDbContext dbContext) : base(dbContext)
        {
            
        }

        // 实现特定于日志的仓储操作方法
    }
}
