using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace AspCore
{
    /// <summary>
    /// 入口
    /// </summary>
    public class Program
    {
        /// <summary>
        /// 入口
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            WebHost.CreateDefaultBuilder(args).UseStartup<Startup>().Build().Run();
        }
    }
}
