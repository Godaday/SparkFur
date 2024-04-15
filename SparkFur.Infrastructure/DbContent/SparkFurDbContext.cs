using Microsoft.EntityFrameworkCore;
using SparkFur.Models.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkFur.Infrastructure.DbContent
{
    /// <summary>
    /// 数据库上下文类
    /// </summary>
    public class SparkFurDbContext : DbContext
    {
        public SparkFurDbContext(DbContextOptions<SparkFurDbContext> options) : base(options)
        {
            Database.EnsureCreated(); // 确保数据库已创建，如果不存在则创建数据库和表
        }

        public DbSet<User> Users { get; set; }
        public DbSet<SystemLog> SystemLog { get; set; }
    }
}
