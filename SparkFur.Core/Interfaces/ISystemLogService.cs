using SparkFur.Models.Entitys;
using SparkFur.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkFur.Core.Interfaces
{

    public interface ISystemLogService : IBaseService<SystemLog>
    {
        /// <summary>
        /// 查询系统日志
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="logType">日志类型</param>
        /// <returns></returns>

        Task<IEnumerable<SystemLog>> GetLogsByDateRangeAsync(
            int pageIndex, int pageSize,
            DateTime startDate, DateTime endDate,LogType logType);
    }
}
