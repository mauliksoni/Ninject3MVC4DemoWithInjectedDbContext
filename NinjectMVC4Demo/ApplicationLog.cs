using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NinjectMVC4Demo
{
    public class ApplicationLog
    {
        public int ApplicationLogId { get; set; }
        public DateTime LogDate { get; set; }
        public string Message { get; set; }
        public string LogLevel { get; set; }
    }
}