using SparkFur.Core.Interfaces;
using SparkFur.Infrastructure.Interfaces;
using SparkFur.Models.Entitys;
using SparkFur.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkFur.Core.Services
{
    public class SystemLogService:BaseService<SystemLog>,ISystemLogService
    {
        private readonly ISystemLogRepository _systemLogRepository;
        public SystemLogService(ISystemLogRepository  systemLogRepository, IUnitOfWork unitOfWork) : base(systemLogRepository, unitOfWork)
        {
            _systemLogRepository = systemLogRepository;
        }

        public async Task<IEnumerable<SystemLog>> GetLogsByDateRangeAsync(int pageNumber, int pageSize, DateTime startDate, DateTime endDate, LogType logType)
        {
          return await  _systemLogRepository.GetPagedAsync(pageNumber, pageSize, x => x.CreateTime >= startDate && x.CreateTime <= endDate && x.LogType == logType);
        }
    }
  
}
