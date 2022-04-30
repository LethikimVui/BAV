using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.StoredProcedure
{
    public class SPBAV
    {
        //public static string Accessory_add = "usp_Accessory_add @p0,@p1,@p2,@p3,@p4";
        //public static string Accessory_get = "usp_Accessory_get";


        public static string Configuration_count = "usp_Configuration_count @p0,@p1,@p2,@p3 OUT";
        //public static string Configuration_get = "usp_Configuration_get @p0,@p1,@p2,@p3,@p4";
        public static string Configuration_get = "usp_Configuration_get @p0,@p1,@p2,@p3,@p4";
        public static string Configuration_getall = "usp_Configuration_getall @p0,@p1,@p2";
        public static string Configuration_add = "usp_Configuration_add @p0,@p1,@p2,@p3,@p4,@p5,@p6,@p7";
        public static string Configuration_delete = "usp_Configuration_delete @p0,@p1,@p2,@p3";
    }
}
