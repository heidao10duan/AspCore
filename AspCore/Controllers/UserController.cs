using AspCore.DataLibrary;
using AspCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;

namespace AspCore.Controllers
{
    public class UserController : BaseController
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="db"></param>
        public UserController(MysqlContent db) :
            base(db)
        {
        }

        /// <summary>
        /// index
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            var user = dbContent.User.FirstOrDefault();
            return View(user);
        }

        /// <summary>
        /// error
        /// </summary>
        /// <returns></returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
