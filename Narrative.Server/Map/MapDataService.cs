using System.Data.SqlClient;
using Narrative.Server.SqlHelper;

namespace Narrative.Server.Map
{
    public static class MapDataService
    {
        public static void WriteMap(Map map)
        {
            SqlHelper.SqlHelper.ExecuteNonQuery("INSERT INTO dbp.Map VALUES (1)");
        }

        public static Map LoadMap() 
        {
            return new Map();
        }
    }
}
