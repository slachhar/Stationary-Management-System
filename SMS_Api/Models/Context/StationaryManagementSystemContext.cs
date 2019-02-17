using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SMS_Api.Models.Context
{
    public class StationaryManagementSystemContext
    {
        private  SqlConnection smsDAL;

        public StationaryManagementSystemContext()
        {
            smsDAL = new SqlConnection("StationaryManagementSystemEntities");
        }
    }
}