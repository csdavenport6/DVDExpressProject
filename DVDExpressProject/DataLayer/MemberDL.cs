using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using DVDExpressProject.Classes;

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
        public static List<Member> GetMemberList()
        {
            string sqlText;

            sqlText = "SELECT *";

        }
    }
}
