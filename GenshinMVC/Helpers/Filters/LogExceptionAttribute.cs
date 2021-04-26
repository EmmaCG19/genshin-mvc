using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Text;
using System.Web.Mvc;
using System.Security.Permissions;

namespace GenshinMVC.Helpers.Filters
{
    public class LogExceptionAttribute : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            LogException(filterContext.Exception);
        }

        private void LogException(Exception exception)
        {
            string path = HttpContext.Current.Server.MapPath("~/Logs/log_test.txt");

            FileInfo fi = new FileInfo(path);

            using (StreamWriter sw = fi.AppendText())
            {
                sw.WriteLine(ExceptionMessage(exception.Message));
            }
        }

        private string ExceptionMessage(string message)
        {
            StringBuilder sb = new StringBuilder();
            DateTime actualDate = DateTime.Now;

            sb.Append($"[{actualDate.Day}-{actualDate.Month}-{actualDate.Year}");
            sb.Append(" - ");
            sb.Append($"{actualDate.Hour}:{actualDate.Minute}:{actualDate.Second}]");
            sb.Append(" - ");
            sb.Append($"Exception: {message}");

            return sb.ToString();
        }
    }
}