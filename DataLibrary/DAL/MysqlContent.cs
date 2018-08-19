using Microsoft.EntityFrameworkCore;
using System;

namespace AspCore.DataLibrary
{
    /// <summary>
    /// mysql数据库上下文
    /// </summary>
    public class MysqlContent : DbContext
    {
        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="options"></param>
        public MysqlContent(DbContextOptions<MysqlContent> options)
            : base(options)
        {
        }

        /// <summary>
        /// 用户数据
        /// </summary>
        public DbSet<User> User { set; get; }
    }
}
