using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

using System.Text;


namespace DVDExpressProject.DataLayer
{
    class MemberDL
    {
        // Members
        private static string connectionString = ConfigurationManager.ConnectionStrings["MIS220DB"].ConnectionString;
        // Properties
        public static string ConnectionString
        {
            get { return MemberDL.connectionString; }
            set { MemberDL.connectionString = value; }
        }
        
    }
}
