using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NinjectMVC4Demo
{
    public class SQLDbTest:IdbTestService
    {
        private SqlDataContext _ctx;

        public SQLDbTest(SqlDataContext ctx)
        {
            _ctx = ctx;
        }

        public int dbTest()
        {
            return _ctx.ApplicationLog.Count();
        }
    }
}