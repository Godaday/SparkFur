using SparkFur.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkFur.Models.Entitys
{
    /// <summary>
    /// 用户实体类
    /// </summary>
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public UserType UserType { get; set; } // 用户类型

        public DateTime CreateTime { get; set; }

        // 其他属性...

        // 如果需要的话，你可以在这里添加与记录实体的关联导航属性
        // public ICollection<Record> Records { get; set; }
    }
}
