using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.StoredProcedure
{
    public class SPLog
    {
        public static string Log_get = "usp_Log_get @p0,@p1,@p2,@p3,@p4";
        public static string Log_getall = "usp_Log_getall @p0,@p1,@p2";
        public static string Log_count = "usp_Log_count @p0,@p1,@p2,@p3 OUT";
    }
}
