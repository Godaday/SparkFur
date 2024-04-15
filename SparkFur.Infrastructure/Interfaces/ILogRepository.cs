using SparkFur.Models.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkFur.Infrastructure.Interfaces
{
    /// <summary>
    /// 日志仓储服务接口
    /// </summary>
    public interface ISystemLogRepository : IBaseRepository<SystemLog>
    {
       
    }
}
