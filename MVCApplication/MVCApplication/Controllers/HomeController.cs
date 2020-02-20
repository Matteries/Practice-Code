using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;
using MVCApplication.Models;

namespace MVCApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult About()
        {
            ViewBag.Message = "MVC About";

            return View();
        }

        public ActionResult Index()
        {
            ViewBag.Message = "MVC Index";
            List<UserInfo> users = FormattingUsers();

            return View(users);
        }

        private static List<UserInfo> FormattingUsers()
        {
            var reader = new StreamReader(System.IO.File.OpenRead(@"E:\MVCDATA.csv"));
            var users = new List<UserInfo>();

            bool notFirstLine = true;

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                if (notFirstLine)
                {
                    notFirstLine = false;
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        var values = line.Split(',');
                        if (values.Length >= 4)
                        {
                            users.Add(new UserInfo { ID = int.Parse(values[0]), Name = values[1], Email = values[2], Number = values[3] });
                        }
                    }
                }
            }
            return users;
        }
    }
}