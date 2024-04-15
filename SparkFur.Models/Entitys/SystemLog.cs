using SparkFur.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkFur.Models.Entitys
{
    /// <summary>
    /// 系统日志实体类
    /// </summary>
    public class SystemLog
    {
        public Guid Id { get; set; }
        public DateTimeOffset Timestamp { get; set; } // 时间戳
        public LogType LogType { get; set; } // 日志类型
        public string Message { get; set; } // 消息
        public string Exception { get; set; } // 异常信息

        public DateTime CreateTime { get; set; }

        // 其他元数据...

        public SystemLog()
        {
            Timestamp = DateTimeOffset.Now;
        }
    }

}
