using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspCore.Models;
using AspCore.DataLibrary;

namespace AspCore.Controllers
{
    /// <summary>
    /// 基础控制器
    /// </summary>
    public class BaseController : Controller
    {
        /// <summary>
        /// mysql数据库上下文
        /// </summary>
        public readonly MysqlContent dbContent;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="db"></param>
        public BaseController(MysqlContent db)
        {
            dbContent = db;
        }
    }
}
