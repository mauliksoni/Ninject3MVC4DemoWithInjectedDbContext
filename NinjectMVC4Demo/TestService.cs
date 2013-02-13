using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NinjectMVC4Demo
{
    public class TestService:ITestService
    {
        public string HelloWorld()
        {
            return "Hello: " + DateTime.Now.ToString();
        }
    }
}